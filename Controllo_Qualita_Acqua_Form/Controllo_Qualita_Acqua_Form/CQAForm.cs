namespace Controllo_Qualita_Acqua_Form
{
    public partial class CQAForm : Form
    {

        string onText = "Attivo";
        string offText = "Spento";

        int delta;
        double startingTemperature = 25.0;
        double currentTemperature;
        double temperatureChangeSpeed = 0.3;
        double maxTemperature = 50.0;
        double minTemperature = 0.0;
        double highTemperatureAlarmThreshold = 30.0;
        double lowTemperatureAlarmThreshold = 20.0;

        double mercurySingleDegreeGUIHeight;



        public CQAForm()
        {
            InitializeComponent();
        }

        private void CQAForm_Load(object sender, EventArgs e)
        {
            //inizializzazione variabili di stato
            currentTemperature = startingTemperature;

            mercurySingleDegreeGUIHeight = guiTermometerContainer.Height / (maxTemperature - minTemperature);
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
                currentTemperature = Math.Max(maxTemperature, currentTemperature + temperatureVariation);
            }
            else
            {
                // assum che la temperatura fuori sia 0 gradi quindi a termostato spento scende
                currentTemperature = Math.Min(maxTemperature, currentTemperature - temperatureVariation);
            }


            //aggiorno grafica
            setPanelHeightFromBottom(guiMercurio, (int)(mercurySingleDegreeGUIHeight * currentTemperature));
        }

        private bool isThermostatActive()
        {
            return termostatoTextBox.Text != null && termostatoTextBox.Text != "";
        }

        private double getThermostatTemperature()
        {
            if (isThermostatActive())
            {
                return Convert.ToDouble(termostatoTextBox);
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
    }
}
