using System.Runtime.CompilerServices;

namespace Controllo_Qualita_Acqua_Form
{
    public partial class CQAForm : Form
    {
        const double PumpOutflowMlPerS = 50.0;
        const double MlPerSToLPerS = 1.0 / 1000.0;

        string onText = "ATTIVO";
        string offText = "SPENTO";

        string turnOnText = "ACCENDI";
        string turnOffText = "SPEGNI";

        Color coloreAcquaPulita = Color.FromArgb(0, 170, 255);

        int delta;
        double startingTemperature = 25.0;
        double currentTemperature;
        double temperatureChangeSpeed = 0.3;
        double maxTemperature = 50.0;
        double minTemperature = 0.0;
        double highTemperatureAlarmThreshold = 30.0;
        double lowTemperatureAlarmThreshold = 20.0;

        double mercurySingleDegreeGUIHeight;

        int purity;
        double purityDecreaseSpeed = 0.7;
        double uvLightPurifyingSpeed = 3;

        double currentWaterVolume = 50;
        double waterFlushSpeed = 0.3;
        double waterIncomingFlowSpeed;
        double waterOutgoingFlowSpeed;

        double capienzaSerbatoio = 80;
        double waterLevelSingleLitreGUIHeight;

        double currentElectricityW;
        double maxElectricityUsage = 6000;
        double minElectricityUsage = 0;

        double uvLightW = 2500;
        double sinkW = 1000;
        double outPumpW = 1000;
        double thermostatW = 3500;

        double electricitySingleWGUIHeight;

        int pumpSpeed;

        public CQAForm()
        {
            InitializeComponent();
        }

        private void CQAForm_Load(object sender, EventArgs e)
        {
            //inizializzazione variabili di stato
            currentTemperature = startingTemperature;
            purity = 100;
            capienzaSerbatoioTextBox.Text = Convert.ToString(capienzaSerbatoio);
            setCapienzaSerbatoio(capienzaSerbatoio);
            setIncomingFlowSpeed(0.05);
            // La pompa deve controllare lo scarico: a pompa spenta, nessun flusso in uscita.
            setOutgoingFlowSpeed(0.0);
            pumpSpeed = 0;
            pompaButton.Text = turnOnText;
            pompaTextBox.Text = offText;
            guiPompa.BackColor = Color.LightPink;
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



            //aggiorno grafica
            setPanelHeightFromBottom(guiMercurio, (int)(mercurySingleDegreeGUIHeight * currentTemperature));
            updateTemperatureAlarms();
            updateTemperature();
            updateWaterPurityGUI(purity);
            updateWaterVolumeGUI(currentWaterVolume);
            updateElectricityGUI();
        }

        private bool isThermostatActive()
        {
            return termostatoTextBox.Text != null && termostatoTextBox.Text != "";
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
            termostatoButton.Text = turnOffText;
        }

        private void turnOffThermostat()
        {
            if (!decreaseElectricityKW(thermostatW))
            {
                return;
            }
            termostatoTextBox.Text = null;
            termostatoButton.Text = turnOnText; termostatoButton.Text = turnOnText;
        }

        private void updateTemperatureAlarms()
        {
            if (currentTemperature > highTemperatureAlarmThreshold)
            {
                turnOnAlarm(guiAllarmeTemperaturaAlta, allarmeTemperaturaAltaTextBox);
            }
            else if (currentTemperature < highTemperatureAlarmThreshold)
            {
                turnOffAlarm(guiAllarmeTemperaturaAlta, allarmeTemperaturaAltaTextBox);
            }


            if (currentTemperature < lowTemperatureAlarmThreshold)
            {
                turnOnAlarm(guiAllarmeTemperaturaBassa, allarmeTemperaturaBassaTextBox);
            }
            else if (currentTemperature > lowTemperatureAlarmThreshold)
            {
                turnOffAlarm(guiAllarmeTemperaturaBassa, allarmeTemperaturaBassaTextBox);
            }
        }

        private void turnOnAlarm(Panel panel, TextBox alarmTextBox)
        {
            panel.BackColor = Color.Red;
            alarmTextBox.Text = onText;
        }

        private void turnOffAlarm(Panel panel, TextBox alarmTextBox)
        {
            panel.BackColor = Color.Green;
            alarmTextBox.Text = offText;
        }

        private void updateTemperature()
        {
            temperaturaTextBox.Text = string.Format("{0:F2}", currentTemperature);
        }

        private bool isUVLightOn()
        {
            return luceUVTextBox.Text == onText;
        }

        private void turnOffUVLight()
        {
            decreaseElectricityKW(uvLightW);
            luceUVTextBox.Text = offText;
            luceUVButton.Text = turnOnText;
            guiUV_Lamp.BackColor = Color.LightPink;
        }

        private void turnOnUVLight()
        {
            if (!increaseElectricityKW(uvLightW))
            {
                return;
            }
            luceUVTextBox.Text = onText;
            luceUVButton.Text = turnOffText;
            guiUV_Lamp.BackColor = Color.LightGreen;

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
            purity = Math.Max(0, Math.Min(100, purity));

            // Normalizzazione (0 = sporca, 1 = pulita)
            double t = purity / 100.0;


            Color acquaSporca = Color.FromArgb(90, 60, 30);    // Marrone scuro

            int r = (int)(acquaSporca.R + t * (coloreAcquaPulita.R - acquaSporca.R));
            int g = (int)(acquaSporca.G + t * (coloreAcquaPulita.G - acquaSporca.G));
            int b = (int)(acquaSporca.B + t * (coloreAcquaPulita.B - acquaSporca.B));

            Color waterColor = Color.FromArgb(r, g, b);

            guiAcqua.BackColor = waterColor;

            //aggiorno testo
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

            return Math.Min(capienzaSerbatoio, Math.Max(0, newWaterVolume));
        }

        private bool isFlushOpen()
        {
            return scaricoAcquaTextBox.Text == onText;
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
                guiFlussoIngresso.BackColor = coloreAcquaPulita;
            }
            else
            {
                guiFlussoIngresso.BackColor = Color.LightGray;
            }

            if (isFlushOpen())
            {
                guiScarico.BackColor = coloreAcquaPulita;
            }
            else
            {
                guiScarico.BackColor = Color.LightGray;
            }

            if (isOutgoingFlowOn())
            {
                guiTuboUscita.BackColor = coloreAcquaPulita;
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
            scaricoButton.Text = turnOffText;
            scaricoAcquaTextBox.Text = onText;
        }

        private void turnOffSink()
        {
            decreaseElectricityKW(sinkW);
            scaricoButton.Text = turnOnText;
            scaricoAcquaTextBox.Text = offText;
        }

        private void capienzaSerbatoioTextBox_TextChanged(object sender, EventArgs e)
        {
            double nuovaCapienzaSerbatoio = Convert.ToDouble(capienzaSerbatoioTextBox.Text);
            setCapienzaSerbatoio(nuovaCapienzaSerbatoio);
        }

        // ritorna false se non e' stato possibile aumentare l'elittricita' (se  sta gia' al massimo)
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
            if(pumpSpeed>0)
            {
                turnOffPump();
            } else
            {
                turnOnPump();
            }
        }

        private void turnOnPump()
        {
            if(!increaseElectricityKW(outPumpW))
            {
                return;
            }
            pumpSpeed = 1;
            pompaButton.Text = turnOffText;
            pompaTextBox.Text = onText;
            guiPompa.BackColor = Color.LightGreen;
            setOutgoingFlowSpeed(PumpOutflowMlPerS * MlPerSToLPerS);
        }

        private void turnOffPump()
        {
            decreaseElectricityKW(outPumpW);
            pumpSpeed = 0;
            pompaButton.Text = turnOnText;
            pompaTextBox.Text = offText;
            guiPompa.BackColor = Color.LightPink;
            setOutgoingFlowSpeed(0.0);
        }
    }
}
