namespace Controllo_Qualita_Acqua_Form
{
    public partial class CQAForm : Form
    {
        private const double PumpOutflowMlPerS = 50.0;
        private const double MlPerSToLPerS = 1.0 / 1000.0;

        private const string StatusOnText = "ATTIVO";
        private const string StatusOffText = "SPENTO";

        private const string TurnOnText = "ACCENDI";
        private const string TurnOffText = "SPEGNI";

        private static readonly Color ColoreAcquaPulita = Color.FromArgb(0, 170, 255);
        private static readonly Color DeviceOnColor = Color.LightGreen;
        private static readonly Color DeviceOffColor = Color.LightPink;

        private int delta;
        private readonly double startingTemperature = 25.0;
        private double currentTemperature;
        private readonly double temperatureChangeSpeed = 0.3;
        private readonly double maxTemperature = 50.0;
        private readonly double minTemperature = 0.0;
        private readonly double highTemperatureAlarmThreshold = 30.0;
        private readonly double lowTemperatureAlarmThreshold = 20.0;

        private double mercurySingleDegreeGUIHeight;

        private int purity;
        private readonly double purityDecreaseSpeed = 0.7;
        private readonly double uvLightPurifyingSpeed = 3;

        private double currentWaterVolume = 50;
        private readonly double waterFlushSpeed = 0.3;
        private double waterIncomingFlowSpeed;
        private double waterOutgoingFlowSpeed;

        private double capienzaSerbatoio = 80;
        private double waterLevelSingleLitreGUIHeight;

        private double currentElectricityW;
        private readonly double maxElectricityUsage = 6000;
        private readonly double minElectricityUsage = 0;

        private readonly double uvLightW = 2500;
        private readonly double sinkW = 1000;
        private readonly double outPumpW = 1000;
        private readonly double thermostatW = 3500;

        private double electricitySingleWGUIHeight;

        private int pumpSpeed;

        public CQAForm()
        {
            InitializeComponent();
        }

        private void CQAForm_Load(object sender, EventArgs e)
        {
            // Inizializzazione variabili di stato
            currentTemperature = startingTemperature;
            purity = 100;
            capienzaSerbatoioTextBox.Text = Convert.ToString(capienzaSerbatoio);
            setCapienzaSerbatoio(capienzaSerbatoio);
            setIncomingFlowSpeed(0.05);
            // La pompa deve controllare lo scarico: a pompa spenta, nessun flusso in uscita.
            setOutgoingFlowSpeed(0.0);
            setPumpUi(isOn: false);
            // Evita confusione: il flusso uscita è controllato dalla pompa.
            flussoUscitaTextBox.ReadOnly = true;
            volumeAcquaTextBox.Text = "0";
            mercurySingleDegreeGUIHeight = guiTermometerContainer.Height / (maxTemperature - minTemperature);
            electricitySingleWGUIHeight = guiElettricitaMisuraContainer.Height / (maxElectricityUsage - minElectricityUsage);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            masterTimer.Start();
            startTimer.Start();
            startButton.Enabled = false;
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            startTimer.Stop();
            startButton.Enabled = true;
        }

        private void masterTimer_Tick(object sender, EventArgs e)
        {
            delta = masterTimer.Interval / 100;
            // gestione temperatura
            double temperatureVariation = (double)delta * temperatureChangeSpeed;

            if (isThermostatActive() && getThermostatTemperature() > currentTemperature)
            {
                currentTemperature = Math.Min(maxTemperature, currentTemperature + temperatureVariation);
            }
            else
            {
                // assum che la temperatura fuori sia 0 gradi quindi a termostato spento scende
                currentTemperature = Math.Max(minTemperature, currentTemperature - temperatureVariation);
            }

            purity = getUpdatedPurity(delta);
            currentWaterVolume = calculateWaterVolume(delta);



            // Aggiorno grafica
            setPanelHeightFromBottom(guiMercurio, (int)(mercurySingleDegreeGUIHeight * currentTemperature));
            updateTemperatureAlarms();
            updateTemperature();
            updateWaterPurityGUI(purity);
            updateWaterVolumeGUI(currentWaterVolume);
            updateElectricityGUI();
        }

        private bool isThermostatActive()
        {
            return !string.IsNullOrWhiteSpace(termostatoTextBox.Text);
        }

        private double getThermostatTemperature()
        {
            if (isThermostatActive())
            {
                return Convert.ToDouble(termostatoTextBox.Text);
            }
            return 0;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            masterTimer.Stop();
        }

        private void setPanelHeightFromBottom(Panel panel, int newHeight)
        {
            int bottom = panel.Bottom;
            panel.Height = newHeight;
            panel.Top = bottom - newHeight;
        }

        private void termostatoButton_Click(object sender, EventArgs e)
        {
            if (isThermostatActive())
            {
                turnOffThermostat();
            }
            else
            {
                turnOnThermostat();
            }
        }

        private void turnOnThermostat()
        {
            if (!increaseElectricityKW(thermostatW))
            {
                return;
            }
            termostatoTextBox.Text = Convert.ToString(startingTemperature);
            termostatoButton.Text = TurnOffText;
        }

        private void turnOffThermostat()
        {
            if (!decreaseElectricityKW(thermostatW))
            {
                return;
            }
            termostatoTextBox.Text = string.Empty;
            termostatoButton.Text = TurnOnText;
        }

        private void updateTemperatureAlarms()
        {
            if (currentTemperature > highTemperatureAlarmThreshold)
            {
                turnOnAlarm(guiAllarmeTemperaturaAlta, allarmeTemperaturaAltaTextBox);
            }
            else
            {
                turnOffAlarm(guiAllarmeTemperaturaAlta, allarmeTemperaturaAltaTextBox);
            }

            if (currentTemperature < lowTemperatureAlarmThreshold)
            {
                turnOnAlarm(guiAllarmeTemperaturaBassa, allarmeTemperaturaBassaTextBox);
            }
            else
            {
                turnOffAlarm(guiAllarmeTemperaturaBassa, allarmeTemperaturaBassaTextBox);
            }
        }

        private void turnOnAlarm(Panel panel, TextBox alarmTextBox)
        {
            panel.BackColor = Color.Red;
            alarmTextBox.Text = StatusOnText;
        }

        private void turnOffAlarm(Panel panel, TextBox alarmTextBox)
        {
            panel.BackColor = Color.Green;
            alarmTextBox.Text = StatusOffText;
        }

        private void updateTemperature()
        {
            temperaturaTextBox.Text = string.Format("{0:F2}", currentTemperature);
        }

        private bool isUVLightOn()
        {
            return luceUVTextBox.Text == StatusOnText;
        }

        private void turnOffUVLight()
        {
            decreaseElectricityKW(uvLightW);
            setUvUi(isOn: false);
        }

        private void turnOnUVLight()
        {
            if (!increaseElectricityKW(uvLightW))
            {
                return;
            }
            setUvUi(isOn: true);
        }

        private void luceUVButton_Click(object sender, EventArgs e)
        {
            if (isUVLightOn())
            {
                turnOffUVLight();
            }
            else
            {
                turnOnUVLight();
            }
        }

        private void updateWaterPurityGUI(double purity)
        {
            // Clamp sicurezza
            purity = Math.Clamp(purity, 0, 100);

            // Normalizzazione (0 = sporca, 1 = pulita)
            double t = purity / 100.0;


            Color acquaSporca = Color.FromArgb(90, 60, 30); // Marrone scuro

            int r = (int)(acquaSporca.R + t * (ColoreAcquaPulita.R - acquaSporca.R));
            int g = (int)(acquaSporca.G + t * (ColoreAcquaPulita.G - acquaSporca.G));
            int b = (int)(acquaSporca.B + t * (ColoreAcquaPulita.B - acquaSporca.B));

            Color waterColor = Color.FromArgb(r, g, b);

            guiAcqua.BackColor = waterColor;

            // Aggiorno testo
            purityPercTextBox.Text = Convert.ToString(purity);
        }

        private int getUpdatedPurity(int timeDelta)
        {
            if (isUVLightOn())
            {
                return Convert.ToInt16(Math.Min(100, purity + timeDelta * uvLightPurifyingSpeed));
            }
            else
            {
                return Convert.ToInt16(Math.Max(0, purity - timeDelta * purityDecreaseSpeed));
            }
        }

        private double calculateWaterVolume(int timeDelta)
        {
            double newWaterVolume = currentWaterVolume;
            if (isFlushOpen())
            {
                newWaterVolume -= timeDelta * waterFlushSpeed;
            }

            newWaterVolume += timeDelta * waterIncomingFlowSpeed;
            newWaterVolume -= timeDelta * waterOutgoingFlowSpeed;

            return Math.Clamp(newWaterVolume, 0, capienzaSerbatoio);
        }

        private bool isFlushOpen()
        {
            return scaricoAcquaTextBox.Text == StatusOnText;
        }

        private bool isIncomingFlowOn()
        {
            return waterIncomingFlowSpeed > 0;
        }

        private bool isOutgoingFlowOn()
        {
            return waterOutgoingFlowSpeed > 0;
        }


        private void setCapienzaSerbatoio(double capienzaSerbatoio)
        {
            this.capienzaSerbatoio = capienzaSerbatoio;
            waterLevelSingleLitreGUIHeight = guiSerbatoio.Height / capienzaSerbatoio;
        }

        private void setIncomingFlowSpeed(double speedLs)
        {
            waterIncomingFlowSpeed = speedLs;
            flussoIngressoTextBox.Text = string.Format("{0:F2}", speedLs * 1000);
        }

        private void setOutgoingFlowSpeed(double speedLs)
        {
            waterOutgoingFlowSpeed = speedLs;
            flussoUscitaTextBox.Text = string.Format("{0:F2}", speedLs * 1000);
        }

        private void flussoIngressoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(flussoIngressoTextBox.Text, out double value))
            {
                waterIncomingFlowSpeed = value / 1000.0;
            }
            else
            {
                waterIncomingFlowSpeed = 0.0;
                flussoIngressoTextBox.Text = "0";
            }
        }

        private void flussoUscitaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(flussoUscitaTextBox.Text, out double value))
            {
                waterOutgoingFlowSpeed = value / 1000.0;
            }
            else
            {
                waterOutgoingFlowSpeed = 0.0;
                flussoUscitaTextBox.Text = "0";
            }
        }

        private void updateWaterVolumeGUI(double waterVolume)
        {
            if (isIncomingFlowOn())
            {
                guiFlussoIngresso.BackColor = ColoreAcquaPulita;
            }
            else
            {
                guiFlussoIngresso.BackColor = Color.LightGray;
            }

            if (isFlushOpen())
            {
                guiScarico.BackColor = ColoreAcquaPulita;
            }
            else
            {
                guiScarico.BackColor = Color.LightGray;
            }

            if (isOutgoingFlowOn())
            {
                guiTuboUscita.BackColor = ColoreAcquaPulita;
            }
            else
            {
                guiTuboUscita.BackColor = Color.LightGray;
            }

            setPanelHeightFromBottom(guiAcqua, Convert.ToInt32(waterLevelSingleLitreGUIHeight * waterVolume));
            volumeAcquaTextBox.Text = string.Format("{0:F2}", waterVolume);
            riempimentoTextBox.Text = string.Format("{0:F2}", 100 / capienzaSerbatoio * waterVolume);
        }

        private void scaricoButton_Click(object sender, EventArgs e)
        {
            if (isFlushOpen())
            {
                turnOffSink();
            }
            else
            {
                turnOnSink();
            }
        }

        private void turnOnSink()
        {
            if (!increaseElectricityKW(sinkW))
            {
                return;
            }
            scaricoButton.Text = TurnOffText;
            scaricoAcquaTextBox.Text = StatusOnText;
        }

        private void turnOffSink()
        {
            decreaseElectricityKW(sinkW);
            scaricoButton.Text = TurnOnText;
            scaricoAcquaTextBox.Text = StatusOffText;
        }

        private void capienzaSerbatoioTextBox_TextChanged(object sender, EventArgs e)
        {
            double nuovaCapienzaSerbatoio = Convert.ToDouble(capienzaSerbatoioTextBox.Text);
            setCapienzaSerbatoio(nuovaCapienzaSerbatoio);
        }

        // Ritorna false se non è stato possibile aumentare l'elettricità (se sta già al massimo)
        private bool increaseElectricityKW(double kW)
        {
            double newKw = currentElectricityW + kW;

            if (newKw > maxElectricityUsage)
            {
                return false;
            }

            currentElectricityW = newKw;
            return true;
        }

        private bool decreaseElectricityKW(double kW)
        {
            double newKw = currentElectricityW - kW;
            if (newKw < minElectricityUsage)
            {
                return false;
            }

            currentElectricityW = newKw;
            return true;
        }

        private void updateElectricityGUI()
        {
            setPanelHeightFromBottom(guiElettricitaPanel, Convert.ToInt32(electricitySingleWGUIHeight * currentElectricityW));
            correnteTextBox.Text = string.Format("{0:F2}", currentElectricityW / 1000);
        }

        private void pompaButton_Click(object sender, EventArgs e)
        {
            if (pumpSpeed > 0)
            {
                turnOffPump();
            }
            else
            {
                turnOnPump();
            }
        }

        private void turnOnPump()
        {
            if (!increaseElectricityKW(outPumpW))
            {
                return;
            }
            setPumpUi(isOn: true);
            setOutgoingFlowSpeed(PumpOutflowMlPerS * MlPerSToLPerS);
        }

        private void turnOffPump()
        {
            decreaseElectricityKW(outPumpW);
            setPumpUi(isOn: false);
            setOutgoingFlowSpeed(0.0);
        }

        private void setPumpUi(bool isOn)
        {
            pumpSpeed = isOn ? 1 : 0;
            pompaButton.Text = isOn ? TurnOffText : TurnOnText;
            pompaTextBox.Text = isOn ? StatusOnText : StatusOffText;
            guiPompa.BackColor = isOn ? DeviceOnColor : DeviceOffColor;
        }

        private void setUvUi(bool isOn)
        {
            luceUVTextBox.Text = isOn ? StatusOnText : StatusOffText;
            luceUVButton.Text = isOn ? TurnOffText : TurnOnText;
            guiUV_Lamp.BackColor = isOn ? DeviceOnColor : DeviceOffColor;
        }
    }
}
