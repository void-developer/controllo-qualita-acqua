namespace Controllo_Qualita_Acqua_Form
{
    partial class CQAForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CQAForm));
            volumeAcquaLabel = new Label();
            volumeAcquaTextBox = new TextBox();
            capienzaSerbatoioTextBox = new TextBox();
            capienzaSerbatorioLabel = new Label();
            riempimentoLabel = new Label();
            riempimentoTextBox = new TextBox();
            purityPercLabel = new Label();
            purityPercTextBox = new TextBox();
            temperaturaLabel = new Label();
            temperaturaTextBox = new TextBox();
            celciusLabel = new Label();
            scaricoAcquaLabel = new Label();
            scaricoAcquaTextBox = new TextBox();
            percLablel1 = new Label();
            percLabel2 = new Label();
            pompaLabel = new Label();
            pompaTextBox = new TextBox();
            allarmePuritaLabel = new Label();
            allarmePuritaTextBox = new TextBox();
            allarmeVolumBassoLabel = new Label();
            allarmeVolumeBassoTextBox = new TextBox();
            allarmeVolumeAltoTextBox = new TextBox();
            allarmeVolumeAltoLabel = new Label();
            flussoIngressoLabel = new Label();
            flussoIngressoTextBox = new TextBox();
            flussoUscitaLabel = new Label();
            flussoMisuraIngressoLabel = new Label();
            flussoUscitaTextBox = new TextBox();
            flussoMisuraUscitaLabel = new Label();
            allarmeTemperaturaBassaLabel = new Label();
            allarmeTemperaturaBassaTextBox = new TextBox();
            allarmeTemperaturaAltaLabel = new Label();
            allarmeTemperaturaAltaTextBox = new TextBox();
            allarmiGroupBox = new GroupBox();
            sensoriGroupBox = new GroupBox();
            litriMisuraLabel2 = new Label();
            litriMisuraLabel1 = new Label();
            termostatoMisuraLabel = new Label();
            termostatoTextBox = new TextBox();
            termostatoLabel = new Label();
            luceUVTextBox = new TextBox();
            luceUVLabel = new Label();
            luceUVButton = new Button();
            actionsPanel = new Panel();
            correnteMisuraLabel = new Label();
            correnteTextBox = new TextBox();
            correnteLabel = new Label();
            label1 = new Label();
            scaricoButton = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            scaricoButtonLabel = new Label();
            termostatoButton = new Button();
            termostatoButtonLabel = new Label();
            pompaButton = new Button();
            label2 = new Label();
            luceUVButtonLabel = new Label();
            guiTermometerContainer = new Panel();
            maxTemperaturaLabel = new Label();
            label3 = new Label();
            guiAllarmeTemperaturaBassa = new Panel();
            allarmeTemperaturaBassaMisuraLabel = new Label();
            simulationGroupBox = new GroupBox();
            guiElettricitaMisuraContainer = new Panel();
            guiElettricitaPanel = new Panel();
            utilizzoCorrenteLabel = new Label();
            maxKwLabel = new Label();
            minKwLabel = new Label();
            guiTuboUscita = new Panel();
            guiFlussoIngresso = new Panel();
            guiScaricoLabel = new Label();
            guiScarico = new Panel();
            guiSerbatoio = new Panel();
            guiUV_Lamp = new PictureBox();
            guiAcqua = new Panel();
            guiMercurio = new Panel();
            guiAllarmeTemperaturaAlta = new Panel();
            allarmeTemperaturaAltaMisuraLabel = new Label();
            midTemperaturaLabel = new Label();
            masterTimer = new System.Windows.Forms.Timer(components);
            startTimer = new System.Windows.Forms.Timer(components);
            controlPanel = new Panel();
            resetButton = new Button();
            startButton = new Button();
            guiPompa = new PictureBox();
            allarmiGroupBox.SuspendLayout();
            sensoriGroupBox.SuspendLayout();
            actionsPanel.SuspendLayout();
            guiAllarmeTemperaturaBassa.SuspendLayout();
            simulationGroupBox.SuspendLayout();
            guiElettricitaMisuraContainer.SuspendLayout();
            guiSerbatoio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guiUV_Lamp).BeginInit();
            guiAcqua.SuspendLayout();
            guiAllarmeTemperaturaAlta.SuspendLayout();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guiPompa).BeginInit();
            SuspendLayout();
            // 
            // volumeAcquaLabel
            // 
            volumeAcquaLabel.AutoSize = true;
            volumeAcquaLabel.Location = new Point(11, 22);
            volumeAcquaLabel.Margin = new Padding(2, 0, 2, 0);
            volumeAcquaLabel.Name = "volumeAcquaLabel";
            volumeAcquaLabel.Size = new Size(84, 15);
            volumeAcquaLabel.TabIndex = 0;
            volumeAcquaLabel.Text = "Volume Acqua";
            // 
            // volumeAcquaTextBox
            // 
            volumeAcquaTextBox.Location = new Point(174, 22);
            volumeAcquaTextBox.Margin = new Padding(2, 1, 2, 1);
            volumeAcquaTextBox.Name = "volumeAcquaTextBox";
            volumeAcquaTextBox.Size = new Size(105, 23);
            volumeAcquaTextBox.TabIndex = 1;
            // 
            // capienzaSerbatoioTextBox
            // 
            capienzaSerbatoioTextBox.Location = new Point(174, 56);
            capienzaSerbatoioTextBox.Margin = new Padding(2, 1, 2, 1);
            capienzaSerbatoioTextBox.Name = "capienzaSerbatoioTextBox";
            capienzaSerbatoioTextBox.Size = new Size(105, 23);
            capienzaSerbatoioTextBox.TabIndex = 3;
            capienzaSerbatoioTextBox.TextChanged += capienzaSerbatoioTextBox_TextChanged;
            // 
            // capienzaSerbatorioLabel
            // 
            capienzaSerbatorioLabel.AutoSize = true;
            capienzaSerbatorioLabel.Location = new Point(11, 56);
            capienzaSerbatorioLabel.Margin = new Padding(2, 0, 2, 0);
            capienzaSerbatorioLabel.Name = "capienzaSerbatorioLabel";
            capienzaSerbatorioLabel.Size = new Size(108, 15);
            capienzaSerbatorioLabel.TabIndex = 2;
            capienzaSerbatorioLabel.Text = "Capienza Serbatoio";
            // 
            // riempimentoLabel
            // 
            riempimentoLabel.AutoSize = true;
            riempimentoLabel.Location = new Point(11, 91);
            riempimentoLabel.Margin = new Padding(2, 0, 2, 0);
            riempimentoLabel.Name = "riempimentoLabel";
            riempimentoLabel.Size = new Size(79, 15);
            riempimentoLabel.TabIndex = 4;
            riempimentoLabel.Text = "Riempimento";
            // 
            // riempimentoTextBox
            // 
            riempimentoTextBox.Location = new Point(174, 90);
            riempimentoTextBox.Margin = new Padding(2, 1, 2, 1);
            riempimentoTextBox.Name = "riempimentoTextBox";
            riempimentoTextBox.Size = new Size(105, 23);
            riempimentoTextBox.TabIndex = 5;
            // 
            // purityPercLabel
            // 
            purityPercLabel.AutoSize = true;
            purityPercLabel.Location = new Point(11, 127);
            purityPercLabel.Margin = new Padding(2, 0, 2, 0);
            purityPercLabel.Name = "purityPercLabel";
            purityPercLabel.Size = new Size(38, 15);
            purityPercLabel.TabIndex = 6;
            purityPercLabel.Text = "Purità";
            // 
            // purityPercTextBox
            // 
            purityPercTextBox.Location = new Point(174, 127);
            purityPercTextBox.Margin = new Padding(2, 1, 2, 1);
            purityPercTextBox.Name = "purityPercTextBox";
            purityPercTextBox.Size = new Size(105, 23);
            purityPercTextBox.TabIndex = 7;
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Location = new Point(11, 165);
            temperaturaLabel.Margin = new Padding(2, 0, 2, 0);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new Size(73, 15);
            temperaturaLabel.TabIndex = 8;
            temperaturaLabel.Text = "Temperatura";
            // 
            // temperaturaTextBox
            // 
            temperaturaTextBox.Location = new Point(174, 165);
            temperaturaTextBox.Margin = new Padding(2, 1, 2, 1);
            temperaturaTextBox.Name = "temperaturaTextBox";
            temperaturaTextBox.Size = new Size(105, 23);
            temperaturaTextBox.TabIndex = 9;
            // 
            // celciusLabel
            // 
            celciusLabel.AutoSize = true;
            celciusLabel.Location = new Point(282, 165);
            celciusLabel.Margin = new Padding(2, 0, 2, 0);
            celciusLabel.Name = "celciusLabel";
            celciusLabel.Size = new Size(20, 15);
            celciusLabel.TabIndex = 10;
            celciusLabel.Text = "°C";
            // 
            // scaricoAcquaLabel
            // 
            scaricoAcquaLabel.AutoSize = true;
            scaricoAcquaLabel.Location = new Point(11, 201);
            scaricoAcquaLabel.Margin = new Padding(2, 0, 2, 0);
            scaricoAcquaLabel.Name = "scaricoAcquaLabel";
            scaricoAcquaLabel.Size = new Size(82, 15);
            scaricoAcquaLabel.TabIndex = 11;
            scaricoAcquaLabel.Text = "Scarico Acqua";
            // 
            // scaricoAcquaTextBox
            // 
            scaricoAcquaTextBox.Location = new Point(174, 199);
            scaricoAcquaTextBox.Margin = new Padding(2, 1, 2, 1);
            scaricoAcquaTextBox.Name = "scaricoAcquaTextBox";
            scaricoAcquaTextBox.Size = new Size(130, 23);
            scaricoAcquaTextBox.TabIndex = 12;
            // 
            // percLablel1
            // 
            percLablel1.AutoSize = true;
            percLablel1.Location = new Point(284, 90);
            percLablel1.Margin = new Padding(2, 0, 2, 0);
            percLablel1.Name = "percLablel1";
            percLablel1.Size = new Size(17, 15);
            percLablel1.TabIndex = 13;
            percLablel1.Text = "%";
            // 
            // percLabel2
            // 
            percLabel2.AutoSize = true;
            percLabel2.Location = new Point(284, 128);
            percLabel2.Margin = new Padding(2, 0, 2, 0);
            percLabel2.Name = "percLabel2";
            percLabel2.Size = new Size(17, 15);
            percLabel2.TabIndex = 14;
            percLabel2.Text = "%";
            // 
            // pompaLabel
            // 
            pompaLabel.AutoSize = true;
            pompaLabel.Location = new Point(11, 234);
            pompaLabel.Margin = new Padding(2, 0, 2, 0);
            pompaLabel.Name = "pompaLabel";
            pompaLabel.Size = new Size(45, 15);
            pompaLabel.TabIndex = 15;
            pompaLabel.Text = "Pompa";
            // 
            // pompaTextBox
            // 
            pompaTextBox.Location = new Point(174, 234);
            pompaTextBox.Margin = new Padding(2, 1, 2, 1);
            pompaTextBox.Name = "pompaTextBox";
            pompaTextBox.Size = new Size(130, 23);
            pompaTextBox.TabIndex = 16;
            // 
            // allarmePuritaLabel
            // 
            allarmePuritaLabel.AutoSize = true;
            allarmePuritaLabel.Location = new Point(12, 19);
            allarmePuritaLabel.Margin = new Padding(2, 0, 2, 0);
            allarmePuritaLabel.Name = "allarmePuritaLabel";
            allarmePuritaLabel.Size = new Size(82, 15);
            allarmePuritaLabel.TabIndex = 17;
            allarmePuritaLabel.Text = "Allarme Purità";
            // 
            // allarmePuritaTextBox
            // 
            allarmePuritaTextBox.Location = new Point(207, 17);
            allarmePuritaTextBox.Margin = new Padding(2, 1, 2, 1);
            allarmePuritaTextBox.Name = "allarmePuritaTextBox";
            allarmePuritaTextBox.Size = new Size(130, 23);
            allarmePuritaTextBox.TabIndex = 18;
            // 
            // allarmeVolumBassoLabel
            // 
            allarmeVolumBassoLabel.AutoSize = true;
            allarmeVolumBassoLabel.Location = new Point(12, 54);
            allarmeVolumBassoLabel.Margin = new Padding(2, 0, 2, 0);
            allarmeVolumBassoLabel.Name = "allarmeVolumBassoLabel";
            allarmeVolumBassoLabel.Size = new Size(124, 15);
            allarmeVolumBassoLabel.TabIndex = 19;
            allarmeVolumBassoLabel.Text = "Allarme Volume Basso";
            // 
            // allarmeVolumeBassoTextBox
            // 
            allarmeVolumeBassoTextBox.Location = new Point(207, 54);
            allarmeVolumeBassoTextBox.Margin = new Padding(2, 1, 2, 1);
            allarmeVolumeBassoTextBox.Name = "allarmeVolumeBassoTextBox";
            allarmeVolumeBassoTextBox.Size = new Size(130, 23);
            allarmeVolumeBassoTextBox.TabIndex = 20;
            // 
            // allarmeVolumeAltoTextBox
            // 
            allarmeVolumeAltoTextBox.Location = new Point(207, 87);
            allarmeVolumeAltoTextBox.Margin = new Padding(2, 1, 2, 1);
            allarmeVolumeAltoTextBox.Name = "allarmeVolumeAltoTextBox";
            allarmeVolumeAltoTextBox.Size = new Size(130, 23);
            allarmeVolumeAltoTextBox.TabIndex = 21;
            // 
            // allarmeVolumeAltoLabel
            // 
            allarmeVolumeAltoLabel.AutoSize = true;
            allarmeVolumeAltoLabel.Location = new Point(12, 87);
            allarmeVolumeAltoLabel.Margin = new Padding(2, 0, 2, 0);
            allarmeVolumeAltoLabel.Name = "allarmeVolumeAltoLabel";
            allarmeVolumeAltoLabel.Size = new Size(116, 15);
            allarmeVolumeAltoLabel.TabIndex = 22;
            allarmeVolumeAltoLabel.Text = "Allarme Volume Alto";
            // 
            // flussoIngressoLabel
            // 
            flussoIngressoLabel.AutoSize = true;
            flussoIngressoLabel.Location = new Point(11, 267);
            flussoIngressoLabel.Margin = new Padding(2, 0, 2, 0);
            flussoIngressoLabel.Name = "flussoIngressoLabel";
            flussoIngressoLabel.Size = new Size(87, 15);
            flussoIngressoLabel.TabIndex = 23;
            flussoIngressoLabel.Text = "Flusso Ingresso";
            // 
            // flussoIngressoTextBox
            // 
            flussoIngressoTextBox.Location = new Point(174, 267);
            flussoIngressoTextBox.Margin = new Padding(2, 1, 2, 1);
            flussoIngressoTextBox.Name = "flussoIngressoTextBox";
            flussoIngressoTextBox.Size = new Size(88, 23);
            flussoIngressoTextBox.TabIndex = 24;
            flussoIngressoTextBox.TextChanged += flussoIngressoTextBox_TextChanged;
            // 
            // flussoUscitaLabel
            // 
            flussoUscitaLabel.AutoSize = true;
            flussoUscitaLabel.Location = new Point(11, 300);
            flussoUscitaLabel.Margin = new Padding(2, 0, 2, 0);
            flussoUscitaLabel.Name = "flussoUscitaLabel";
            flussoUscitaLabel.Size = new Size(75, 15);
            flussoUscitaLabel.TabIndex = 25;
            flussoUscitaLabel.Text = "Flusso Uscita";
            // 
            // flussoMisuraIngressoLabel
            // 
            flussoMisuraIngressoLabel.AutoSize = true;
            flussoMisuraIngressoLabel.Location = new Point(270, 268);
            flussoMisuraIngressoLabel.Margin = new Padding(2, 0, 2, 0);
            flussoMisuraIngressoLabel.Name = "flussoMisuraIngressoLabel";
            flussoMisuraIngressoLabel.Size = new Size(31, 15);
            flussoMisuraIngressoLabel.TabIndex = 26;
            flussoMisuraIngressoLabel.Text = "ml/s";
            // 
            // flussoUscitaTextBox
            // 
            flussoUscitaTextBox.Location = new Point(174, 300);
            flussoUscitaTextBox.Margin = new Padding(2, 1, 2, 1);
            flussoUscitaTextBox.Name = "flussoUscitaTextBox";
            flussoUscitaTextBox.Size = new Size(88, 23);
            flussoUscitaTextBox.TabIndex = 27;
            flussoUscitaTextBox.TextChanged += flussoUscitaTextBox_TextChanged;
            // 
            // flussoMisuraUscitaLabel
            // 
            flussoMisuraUscitaLabel.AutoSize = true;
            flussoMisuraUscitaLabel.Location = new Point(270, 301);
            flussoMisuraUscitaLabel.Margin = new Padding(2, 0, 2, 0);
            flussoMisuraUscitaLabel.Name = "flussoMisuraUscitaLabel";
            flussoMisuraUscitaLabel.Size = new Size(31, 15);
            flussoMisuraUscitaLabel.TabIndex = 28;
            flussoMisuraUscitaLabel.Text = "ml/s";
            // 
            // allarmeTemperaturaBassaLabel
            // 
            allarmeTemperaturaBassaLabel.AutoSize = true;
            allarmeTemperaturaBassaLabel.Location = new Point(12, 123);
            allarmeTemperaturaBassaLabel.Margin = new Padding(2, 0, 2, 0);
            allarmeTemperaturaBassaLabel.Name = "allarmeTemperaturaBassaLabel";
            allarmeTemperaturaBassaLabel.Size = new Size(149, 15);
            allarmeTemperaturaBassaLabel.TabIndex = 29;
            allarmeTemperaturaBassaLabel.Text = "Allarme Temperatura Bassa";
            // 
            // allarmeTemperaturaBassaTextBox
            // 
            allarmeTemperaturaBassaTextBox.Location = new Point(207, 123);
            allarmeTemperaturaBassaTextBox.Margin = new Padding(2, 1, 2, 1);
            allarmeTemperaturaBassaTextBox.Name = "allarmeTemperaturaBassaTextBox";
            allarmeTemperaturaBassaTextBox.Size = new Size(130, 23);
            allarmeTemperaturaBassaTextBox.TabIndex = 30;
            // 
            // allarmeTemperaturaAltaLabel
            // 
            allarmeTemperaturaAltaLabel.AutoSize = true;
            allarmeTemperaturaAltaLabel.Location = new Point(12, 157);
            allarmeTemperaturaAltaLabel.Margin = new Padding(2, 0, 2, 0);
            allarmeTemperaturaAltaLabel.Name = "allarmeTemperaturaAltaLabel";
            allarmeTemperaturaAltaLabel.Size = new Size(141, 15);
            allarmeTemperaturaAltaLabel.TabIndex = 31;
            allarmeTemperaturaAltaLabel.Text = "Allarme Temperatura Alta";
            // 
            // allarmeTemperaturaAltaTextBox
            // 
            allarmeTemperaturaAltaTextBox.Location = new Point(207, 157);
            allarmeTemperaturaAltaTextBox.Margin = new Padding(2, 1, 2, 1);
            allarmeTemperaturaAltaTextBox.Name = "allarmeTemperaturaAltaTextBox";
            allarmeTemperaturaAltaTextBox.Size = new Size(130, 23);
            allarmeTemperaturaAltaTextBox.TabIndex = 32;
            // 
            // allarmiGroupBox
            // 
            allarmiGroupBox.Controls.Add(allarmeTemperaturaAltaTextBox);
            allarmiGroupBox.Controls.Add(allarmeTemperaturaAltaLabel);
            allarmiGroupBox.Controls.Add(allarmeTemperaturaBassaTextBox);
            allarmiGroupBox.Controls.Add(allarmeTemperaturaBassaLabel);
            allarmiGroupBox.Controls.Add(allarmeVolumeAltoLabel);
            allarmiGroupBox.Controls.Add(allarmeVolumeAltoTextBox);
            allarmiGroupBox.Controls.Add(allarmeVolumeBassoTextBox);
            allarmiGroupBox.Controls.Add(allarmeVolumBassoLabel);
            allarmiGroupBox.Controls.Add(allarmePuritaTextBox);
            allarmiGroupBox.Controls.Add(allarmePuritaLabel);
            allarmiGroupBox.Location = new Point(394, 42);
            allarmiGroupBox.Margin = new Padding(2, 1, 2, 1);
            allarmiGroupBox.Name = "allarmiGroupBox";
            allarmiGroupBox.Padding = new Padding(2, 1, 2, 1);
            allarmiGroupBox.Size = new Size(358, 203);
            allarmiGroupBox.TabIndex = 33;
            allarmiGroupBox.TabStop = false;
            allarmiGroupBox.Text = "Allarmi";
            // 
            // sensoriGroupBox
            // 
            sensoriGroupBox.Controls.Add(litriMisuraLabel2);
            sensoriGroupBox.Controls.Add(litriMisuraLabel1);
            sensoriGroupBox.Controls.Add(termostatoMisuraLabel);
            sensoriGroupBox.Controls.Add(termostatoTextBox);
            sensoriGroupBox.Controls.Add(termostatoLabel);
            sensoriGroupBox.Controls.Add(luceUVTextBox);
            sensoriGroupBox.Controls.Add(luceUVLabel);
            sensoriGroupBox.Controls.Add(flussoMisuraUscitaLabel);
            sensoriGroupBox.Controls.Add(flussoUscitaTextBox);
            sensoriGroupBox.Controls.Add(flussoMisuraIngressoLabel);
            sensoriGroupBox.Controls.Add(flussoUscitaLabel);
            sensoriGroupBox.Controls.Add(flussoIngressoTextBox);
            sensoriGroupBox.Controls.Add(flussoIngressoLabel);
            sensoriGroupBox.Controls.Add(pompaTextBox);
            sensoriGroupBox.Controls.Add(pompaLabel);
            sensoriGroupBox.Controls.Add(percLabel2);
            sensoriGroupBox.Controls.Add(percLablel1);
            sensoriGroupBox.Controls.Add(scaricoAcquaTextBox);
            sensoriGroupBox.Controls.Add(scaricoAcquaLabel);
            sensoriGroupBox.Controls.Add(celciusLabel);
            sensoriGroupBox.Controls.Add(temperaturaTextBox);
            sensoriGroupBox.Controls.Add(temperaturaLabel);
            sensoriGroupBox.Controls.Add(purityPercTextBox);
            sensoriGroupBox.Controls.Add(purityPercLabel);
            sensoriGroupBox.Controls.Add(riempimentoTextBox);
            sensoriGroupBox.Controls.Add(riempimentoLabel);
            sensoriGroupBox.Controls.Add(capienzaSerbatoioTextBox);
            sensoriGroupBox.Controls.Add(capienzaSerbatorioLabel);
            sensoriGroupBox.Controls.Add(volumeAcquaTextBox);
            sensoriGroupBox.Controls.Add(volumeAcquaLabel);
            sensoriGroupBox.Location = new Point(29, 38);
            sensoriGroupBox.Margin = new Padding(2, 1, 2, 1);
            sensoriGroupBox.Name = "sensoriGroupBox";
            sensoriGroupBox.Padding = new Padding(2, 1, 2, 1);
            sensoriGroupBox.Size = new Size(318, 390);
            sensoriGroupBox.TabIndex = 34;
            sensoriGroupBox.TabStop = false;
            sensoriGroupBox.Text = "Sensori";
            // 
            // litriMisuraLabel2
            // 
            litriMisuraLabel2.AutoSize = true;
            litriMisuraLabel2.Location = new Point(284, 24);
            litriMisuraLabel2.Margin = new Padding(2, 0, 2, 0);
            litriMisuraLabel2.Name = "litriMisuraLabel2";
            litriMisuraLabel2.Size = new Size(13, 15);
            litriMisuraLabel2.TabIndex = 35;
            litriMisuraLabel2.Text = "L";
            // 
            // litriMisuraLabel1
            // 
            litriMisuraLabel1.AutoSize = true;
            litriMisuraLabel1.Location = new Point(284, 58);
            litriMisuraLabel1.Margin = new Padding(2, 0, 2, 0);
            litriMisuraLabel1.Name = "litriMisuraLabel1";
            litriMisuraLabel1.Size = new Size(13, 15);
            litriMisuraLabel1.TabIndex = 34;
            litriMisuraLabel1.Text = "L";
            // 
            // termostatoMisuraLabel
            // 
            termostatoMisuraLabel.AutoSize = true;
            termostatoMisuraLabel.Location = new Point(282, 365);
            termostatoMisuraLabel.Margin = new Padding(2, 0, 2, 0);
            termostatoMisuraLabel.Name = "termostatoMisuraLabel";
            termostatoMisuraLabel.Size = new Size(20, 15);
            termostatoMisuraLabel.TabIndex = 33;
            termostatoMisuraLabel.Text = "°C";
            // 
            // termostatoTextBox
            // 
            termostatoTextBox.Location = new Point(174, 363);
            termostatoTextBox.Margin = new Padding(2, 1, 2, 1);
            termostatoTextBox.Name = "termostatoTextBox";
            termostatoTextBox.Size = new Size(88, 23);
            termostatoTextBox.TabIndex = 32;
            // 
            // termostatoLabel
            // 
            termostatoLabel.AutoSize = true;
            termostatoLabel.Location = new Point(11, 363);
            termostatoLabel.Margin = new Padding(2, 0, 2, 0);
            termostatoLabel.Name = "termostatoLabel";
            termostatoLabel.Size = new Size(66, 15);
            termostatoLabel.TabIndex = 31;
            termostatoLabel.Text = "Termostato";
            // 
            // luceUVTextBox
            // 
            luceUVTextBox.Location = new Point(174, 332);
            luceUVTextBox.Margin = new Padding(2, 1, 2, 1);
            luceUVTextBox.Name = "luceUVTextBox";
            luceUVTextBox.Size = new Size(130, 23);
            luceUVTextBox.TabIndex = 30;
            // 
            // luceUVLabel
            // 
            luceUVLabel.AutoSize = true;
            luceUVLabel.Location = new Point(11, 332);
            luceUVLabel.Margin = new Padding(2, 0, 2, 0);
            luceUVLabel.Name = "luceUVLabel";
            luceUVLabel.Size = new Size(50, 15);
            luceUVLabel.TabIndex = 29;
            luceUVLabel.Text = "Luce UV";
            // 
            // luceUVButton
            // 
            luceUVButton.Location = new Point(166, 15);
            luceUVButton.Margin = new Padding(2, 1, 2, 1);
            luceUVButton.Name = "luceUVButton";
            luceUVButton.Size = new Size(136, 26);
            luceUVButton.TabIndex = 35;
            luceUVButton.Text = "ACCENDI";
            luceUVButton.UseVisualStyleBackColor = true;
            luceUVButton.Click += luceUVButton_Click;
            // 
            // actionsPanel
            // 
            actionsPanel.Controls.Add(correnteMisuraLabel);
            actionsPanel.Controls.Add(correnteTextBox);
            actionsPanel.Controls.Add(correnteLabel);
            actionsPanel.Controls.Add(label1);
            actionsPanel.Controls.Add(scaricoButton);
            actionsPanel.Controls.Add(textBox1);
            actionsPanel.Controls.Add(label4);
            actionsPanel.Controls.Add(scaricoButtonLabel);
            actionsPanel.Controls.Add(termostatoButton);
            actionsPanel.Controls.Add(termostatoButtonLabel);
            actionsPanel.Controls.Add(pompaButton);
            actionsPanel.Controls.Add(label2);
            actionsPanel.Controls.Add(luceUVButtonLabel);
            actionsPanel.Controls.Add(luceUVButton);
            actionsPanel.Location = new Point(779, 45);
            actionsPanel.Margin = new Padding(2, 1, 2, 1);
            actionsPanel.Name = "actionsPanel";
            actionsPanel.Size = new Size(312, 360);
            actionsPanel.TabIndex = 36;
            // 
            // correnteMisuraLabel
            // 
            correnteMisuraLabel.AutoSize = true;
            correnteMisuraLabel.Location = new Point(271, 302);
            correnteMisuraLabel.Margin = new Padding(2, 0, 2, 0);
            correnteMisuraLabel.Name = "correnteMisuraLabel";
            correnteMisuraLabel.Size = new Size(24, 15);
            correnteMisuraLabel.TabIndex = 44;
            correnteMisuraLabel.Text = "kW";
            // 
            // correnteTextBox
            // 
            correnteTextBox.Location = new Point(174, 299);
            correnteTextBox.Margin = new Padding(2, 1, 2, 1);
            correnteTextBox.Name = "correnteTextBox";
            correnteTextBox.Size = new Size(88, 23);
            correnteTextBox.TabIndex = 43;
            // 
            // correnteLabel
            // 
            correnteLabel.AutoSize = true;
            correnteLabel.Location = new Point(11, 301);
            correnteLabel.Margin = new Padding(2, 0, 2, 0);
            correnteLabel.Name = "correnteLabel";
            correnteLabel.Size = new Size(53, 15);
            correnteLabel.TabIndex = 42;
            correnteLabel.Text = "Corrente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 334);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 38;
            label1.Text = "ml/s";
            // 
            // scaricoButton
            // 
            scaricoButton.Location = new Point(166, 119);
            scaricoButton.Margin = new Padding(2, 1, 2, 1);
            scaricoButton.Name = "scaricoButton";
            scaricoButton.Size = new Size(136, 26);
            scaricoButton.TabIndex = 41;
            scaricoButton.Text = "ACCENDI";
            scaricoButton.UseVisualStyleBackColor = true;
            scaricoButton.Click += scaricoButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 330);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 23);
            textBox1.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 330);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 36;
            label4.Text = "Pompa";
            // 
            // scaricoButtonLabel
            // 
            scaricoButtonLabel.AutoSize = true;
            scaricoButtonLabel.Location = new Point(22, 119);
            scaricoButtonLabel.Margin = new Padding(2, 0, 2, 0);
            scaricoButtonLabel.Name = "scaricoButtonLabel";
            scaricoButtonLabel.Size = new Size(45, 15);
            scaricoButtonLabel.TabIndex = 40;
            scaricoButtonLabel.Text = "Scarico";
            // 
            // termostatoButton
            // 
            termostatoButton.Location = new Point(166, 83);
            termostatoButton.Margin = new Padding(2, 1, 2, 1);
            termostatoButton.Name = "termostatoButton";
            termostatoButton.Size = new Size(136, 26);
            termostatoButton.TabIndex = 39;
            termostatoButton.Text = "ACCENDI";
            termostatoButton.UseVisualStyleBackColor = true;
            termostatoButton.Click += termostatoButton_Click;
            // 
            // termostatoButtonLabel
            // 
            termostatoButtonLabel.AutoSize = true;
            termostatoButtonLabel.Location = new Point(22, 87);
            termostatoButtonLabel.Margin = new Padding(2, 0, 2, 0);
            termostatoButtonLabel.Name = "termostatoButtonLabel";
            termostatoButtonLabel.Size = new Size(66, 15);
            termostatoButtonLabel.TabIndex = 38;
            termostatoButtonLabel.Text = "Termostato";
            // 
            // pompaButton
            // 
            pompaButton.Location = new Point(166, 49);
            pompaButton.Margin = new Padding(2, 1, 2, 1);
            pompaButton.Name = "pompaButton";
            pompaButton.Size = new Size(136, 26);
            pompaButton.TabIndex = 37;
            pompaButton.Text = "ACCENDI";
            pompaButton.UseVisualStyleBackColor = true;
            pompaButton.Click += pompaButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 53);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 36;
            label2.Text = "Pompa";
            // 
            // luceUVButtonLabel
            // 
            luceUVButtonLabel.AutoSize = true;
            luceUVButtonLabel.Location = new Point(22, 21);
            luceUVButtonLabel.Margin = new Padding(2, 0, 2, 0);
            luceUVButtonLabel.Name = "luceUVButtonLabel";
            luceUVButtonLabel.Size = new Size(50, 15);
            luceUVButtonLabel.TabIndex = 31;
            luceUVButtonLabel.Text = "Luce UV";
            // 
            // guiTermometerContainer
            // 
            guiTermometerContainer.BorderStyle = BorderStyle.FixedSingle;
            guiTermometerContainer.Location = new Point(81, 32);
            guiTermometerContainer.Margin = new Padding(2, 1, 2, 1);
            guiTermometerContainer.Name = "guiTermometerContainer";
            guiTermometerContainer.Size = new Size(11, 252);
            guiTermometerContainer.TabIndex = 38;
            // 
            // maxTemperaturaLabel
            // 
            maxTemperaturaLabel.AutoSize = true;
            maxTemperaturaLabel.Location = new Point(39, 32);
            maxTemperaturaLabel.Margin = new Padding(2, 0, 2, 0);
            maxTemperaturaLabel.Name = "maxTemperaturaLabel";
            maxTemperaturaLabel.Size = new Size(32, 15);
            maxTemperaturaLabel.TabIndex = 39;
            maxTemperaturaLabel.Text = "50°C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 269);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 40;
            label3.Text = "0°C";
            // 
            // guiAllarmeTemperaturaBassa
            // 
            guiAllarmeTemperaturaBassa.BackColor = Color.Green;
            guiAllarmeTemperaturaBassa.Controls.Add(allarmeTemperaturaBassaMisuraLabel);
            guiAllarmeTemperaturaBassa.Location = new Point(94, 177);
            guiAllarmeTemperaturaBassa.Margin = new Padding(2, 1, 2, 1);
            guiAllarmeTemperaturaBassa.Name = "guiAllarmeTemperaturaBassa";
            guiAllarmeTemperaturaBassa.Size = new Size(41, 27);
            guiAllarmeTemperaturaBassa.TabIndex = 38;
            // 
            // allarmeTemperaturaBassaMisuraLabel
            // 
            allarmeTemperaturaBassaMisuraLabel.AutoSize = true;
            allarmeTemperaturaBassaMisuraLabel.Location = new Point(3, 7);
            allarmeTemperaturaBassaMisuraLabel.Margin = new Padding(2, 0, 2, 0);
            allarmeTemperaturaBassaMisuraLabel.Name = "allarmeTemperaturaBassaMisuraLabel";
            allarmeTemperaturaBassaMisuraLabel.Size = new Size(32, 15);
            allarmeTemperaturaBassaMisuraLabel.TabIndex = 42;
            allarmeTemperaturaBassaMisuraLabel.Text = "20°C";
            // 
            // simulationGroupBox
            // 
            simulationGroupBox.BackgroundImageLayout = ImageLayout.None;
            simulationGroupBox.Controls.Add(guiElettricitaMisuraContainer);
            simulationGroupBox.Controls.Add(utilizzoCorrenteLabel);
            simulationGroupBox.Controls.Add(maxKwLabel);
            simulationGroupBox.Controls.Add(minKwLabel);
            simulationGroupBox.Controls.Add(guiTuboUscita);
            simulationGroupBox.Controls.Add(guiFlussoIngresso);
            simulationGroupBox.Controls.Add(guiScaricoLabel);
            simulationGroupBox.Controls.Add(guiScarico);
            simulationGroupBox.Controls.Add(guiSerbatoio);
            simulationGroupBox.Controls.Add(guiMercurio);
            simulationGroupBox.Controls.Add(guiAllarmeTemperaturaAlta);
            simulationGroupBox.Controls.Add(midTemperaturaLabel);
            simulationGroupBox.Controls.Add(guiAllarmeTemperaturaBassa);
            simulationGroupBox.Controls.Add(label3);
            simulationGroupBox.Controls.Add(maxTemperaturaLabel);
            simulationGroupBox.Controls.Add(guiTermometerContainer);
            simulationGroupBox.Location = new Point(29, 450);
            simulationGroupBox.Margin = new Padding(2, 1, 2, 1);
            simulationGroupBox.Name = "simulationGroupBox";
            simulationGroupBox.Padding = new Padding(2, 1, 2, 1);
            simulationGroupBox.Size = new Size(1062, 311);
            simulationGroupBox.TabIndex = 41;
            simulationGroupBox.TabStop = false;
            simulationGroupBox.Text = "Simulazione";
            // 
            // guiElettricitaMisuraContainer
            // 
            guiElettricitaMisuraContainer.BackColor = Color.FromArgb(224, 224, 224);
            guiElettricitaMisuraContainer.BorderStyle = BorderStyle.FixedSingle;
            guiElettricitaMisuraContainer.Controls.Add(guiElettricitaPanel);
            guiElettricitaMisuraContainer.Location = new Point(972, 37);
            guiElettricitaMisuraContainer.Name = "guiElettricitaMisuraContainer";
            guiElettricitaMisuraContainer.Size = new Size(40, 250);
            guiElettricitaMisuraContainer.TabIndex = 47;
            // 
            // guiElettricitaPanel
            // 
            guiElettricitaPanel.BackColor = Color.Khaki;
            guiElettricitaPanel.Location = new Point(-1, 116);
            guiElettricitaPanel.Name = "guiElettricitaPanel";
            guiElettricitaPanel.Size = new Size(40, 133);
            guiElettricitaPanel.TabIndex = 46;
            // 
            // utilizzoCorrenteLabel
            // 
            utilizzoCorrenteLabel.AutoSize = true;
            utilizzoCorrenteLabel.Location = new Point(946, 17);
            utilizzoCorrenteLabel.Name = "utilizzoCorrenteLabel";
            utilizzoCorrenteLabel.Size = new Size(92, 15);
            utilizzoCorrenteLabel.TabIndex = 49;
            utilizzoCorrenteLabel.Text = "Utilizzo corrente";
            // 
            // maxKwLabel
            // 
            maxKwLabel.AutoSize = true;
            maxKwLabel.Location = new Point(936, 37);
            maxKwLabel.Name = "maxKwLabel";
            maxKwLabel.Size = new Size(30, 15);
            maxKwLabel.TabIndex = 48;
            maxKwLabel.Text = "6kW";
            // 
            // minKwLabel
            // 
            minKwLabel.AutoSize = true;
            minKwLabel.Location = new Point(936, 272);
            minKwLabel.Name = "minKwLabel";
            minKwLabel.Size = new Size(30, 15);
            minKwLabel.TabIndex = 47;
            minKwLabel.Text = "0kW";
            // 
            // guiTuboUscita
            // 
            guiTuboUscita.BackColor = Color.FromArgb(0, 170, 255);
            guiTuboUscita.BorderStyle = BorderStyle.FixedSingle;
            guiTuboUscita.Location = new Point(458, 240);
            guiTuboUscita.Margin = new Padding(2, 1, 2, 1);
            guiTuboUscita.Name = "guiTuboUscita";
            guiTuboUscita.Size = new Size(160, 10);
            guiTuboUscita.TabIndex = 45;
            // 
            // guiFlussoIngresso
            // 
            guiFlussoIngresso.BackColor = Color.FromArgb(0, 170, 255);
            guiFlussoIngresso.BorderStyle = BorderStyle.FixedSingle;
            guiFlussoIngresso.Location = new Point(219, 74);
            guiFlussoIngresso.Margin = new Padding(2, 1, 2, 1);
            guiFlussoIngresso.Name = "guiFlussoIngresso";
            guiFlussoIngresso.Size = new Size(67, 9);
            guiFlussoIngresso.TabIndex = 44;
            // 
            // guiScaricoLabel
            // 
            guiScaricoLabel.AutoSize = true;
            guiScaricoLabel.Location = new Point(383, 272);
            guiScaricoLabel.Margin = new Padding(2, 0, 2, 0);
            guiScaricoLabel.Name = "guiScaricoLabel";
            guiScaricoLabel.Size = new Size(45, 15);
            guiScaricoLabel.TabIndex = 44;
            guiScaricoLabel.Text = "Scarico";
            // 
            // guiScarico
            // 
            guiScarico.BackColor = Color.FromArgb(0, 170, 255);
            guiScarico.BorderStyle = BorderStyle.FixedSingle;
            guiScarico.Location = new Point(434, 265);
            guiScarico.Margin = new Padding(2, 1, 2, 1);
            guiScarico.Name = "guiScarico";
            guiScarico.Size = new Size(20, 36);
            guiScarico.TabIndex = 43;
            // 
            // guiSerbatoio
            // 
            guiSerbatoio.BackColor = Color.FromArgb(224, 224, 224);
            guiSerbatoio.BorderStyle = BorderStyle.FixedSingle;
            guiSerbatoio.Controls.Add(guiUV_Lamp);
            guiSerbatoio.Controls.Add(guiAcqua);
            guiSerbatoio.Location = new Point(284, 32);
            guiSerbatoio.Margin = new Padding(2, 1, 2, 1);
            guiSerbatoio.Name = "guiSerbatoio";
            guiSerbatoio.Size = new Size(170, 232);
            guiSerbatoio.TabIndex = 42;
            // 
            // guiUV_Lamp
            // 
            guiUV_Lamp.BackColor = Color.FromArgb(255, 192, 192);
            guiUV_Lamp.Image = (Image)resources.GetObject("guiUV_Lamp.Image");
            guiUV_Lamp.InitialImage = (Image)resources.GetObject("guiUV_Lamp.InitialImage");
            guiUV_Lamp.Location = new Point(61, 1);
            guiUV_Lamp.Margin = new Padding(2, 1, 2, 1);
            guiUV_Lamp.Name = "guiUV_Lamp";
            guiUV_Lamp.Size = new Size(47, 37);
            guiUV_Lamp.SizeMode = PictureBoxSizeMode.StretchImage;
            guiUV_Lamp.TabIndex = 44;
            guiUV_Lamp.TabStop = false;
            // 
            // guiAcqua
            // 
            guiAcqua.BackColor = Color.FromArgb(0, 170, 255);
            guiAcqua.Controls.Add(guiPompa);
            guiAcqua.Location = new Point(0, 110);
            guiAcqua.Margin = new Padding(2, 1, 2, 1);
            guiAcqua.Name = "guiAcqua";
            guiAcqua.Size = new Size(169, 121);
            guiAcqua.TabIndex = 43;
            // 
            // guiMercurio
            // 
            guiMercurio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guiMercurio.BackColor = Color.FromArgb(64, 64, 64);
            guiMercurio.ForeColor = SystemColors.ActiveCaptionText;
            guiMercurio.Location = new Point(81, 155);
            guiMercurio.Margin = new Padding(2, 1, 2, 1);
            guiMercurio.Name = "guiMercurio";
            guiMercurio.Size = new Size(10, 128);
            guiMercurio.TabIndex = 39;
            // 
            // guiAllarmeTemperaturaAlta
            // 
            guiAllarmeTemperaturaAlta.BackColor = Color.Green;
            guiAllarmeTemperaturaAlta.Controls.Add(allarmeTemperaturaAltaMisuraLabel);
            guiAllarmeTemperaturaAlta.Location = new Point(94, 98);
            guiAllarmeTemperaturaAlta.Margin = new Padding(2, 1, 2, 1);
            guiAllarmeTemperaturaAlta.Name = "guiAllarmeTemperaturaAlta";
            guiAllarmeTemperaturaAlta.Size = new Size(41, 24);
            guiAllarmeTemperaturaAlta.TabIndex = 39;
            // 
            // allarmeTemperaturaAltaMisuraLabel
            // 
            allarmeTemperaturaAltaMisuraLabel.AutoSize = true;
            allarmeTemperaturaAltaMisuraLabel.Location = new Point(3, 4);
            allarmeTemperaturaAltaMisuraLabel.Margin = new Padding(2, 0, 2, 0);
            allarmeTemperaturaAltaMisuraLabel.Name = "allarmeTemperaturaAltaMisuraLabel";
            allarmeTemperaturaAltaMisuraLabel.Size = new Size(32, 15);
            allarmeTemperaturaAltaMisuraLabel.TabIndex = 43;
            allarmeTemperaturaAltaMisuraLabel.Text = "30°C";
            // 
            // midTemperaturaLabel
            // 
            midTemperaturaLabel.AutoSize = true;
            midTemperaturaLabel.Location = new Point(39, 148);
            midTemperaturaLabel.Margin = new Padding(2, 0, 2, 0);
            midTemperaturaLabel.Name = "midTemperaturaLabel";
            midTemperaturaLabel.Size = new Size(32, 15);
            midTemperaturaLabel.TabIndex = 41;
            midTemperaturaLabel.Text = "25°C";
            // 
            // masterTimer
            // 
            masterTimer.Tick += masterTimer_Tick;
            // 
            // startTimer
            // 
            startTimer.Tick += startTimer_Tick;
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(resetButton);
            controlPanel.Controls.Add(startButton);
            controlPanel.Location = new Point(394, 266);
            controlPanel.Margin = new Padding(2, 1, 2, 1);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(358, 140);
            controlPanel.TabIndex = 42;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            resetButton.Location = new Point(24, 78);
            resetButton.Margin = new Padding(2, 1, 2, 1);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(306, 50);
            resetButton.TabIndex = 1;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            startButton.Location = new Point(24, 13);
            startButton.Margin = new Padding(2, 1, 2, 1);
            startButton.Name = "startButton";
            startButton.Size = new Size(306, 50);
            startButton.TabIndex = 0;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // guiPompa
            // 
            guiPompa.BackColor = Color.FromArgb(255, 192, 192);
            guiPompa.BackgroundImageLayout = ImageLayout.None;
            guiPompa.Image = (Image)resources.GetObject("guiPompa.Image");
            guiPompa.Location = new Point(123, 79);
            guiPompa.Name = "guiPompa";
            guiPompa.Size = new Size(43, 38);
            guiPompa.SizeMode = PictureBoxSizeMode.StretchImage;
            guiPompa.TabIndex = 50;
            guiPompa.TabStop = false;
            // 
            // CQAForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 800);
            Controls.Add(controlPanel);
            Controls.Add(simulationGroupBox);
            Controls.Add(actionsPanel);
            Controls.Add(sensoriGroupBox);
            Controls.Add(allarmiGroupBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CQAForm";
            Text = "CQAForm";
            Load += CQAForm_Load;
            allarmiGroupBox.ResumeLayout(false);
            allarmiGroupBox.PerformLayout();
            sensoriGroupBox.ResumeLayout(false);
            sensoriGroupBox.PerformLayout();
            actionsPanel.ResumeLayout(false);
            actionsPanel.PerformLayout();
            guiAllarmeTemperaturaBassa.ResumeLayout(false);
            guiAllarmeTemperaturaBassa.PerformLayout();
            simulationGroupBox.ResumeLayout(false);
            simulationGroupBox.PerformLayout();
            guiElettricitaMisuraContainer.ResumeLayout(false);
            guiSerbatoio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guiUV_Lamp).EndInit();
            guiAcqua.ResumeLayout(false);
            guiAllarmeTemperaturaAlta.ResumeLayout(false);
            guiAllarmeTemperaturaAlta.PerformLayout();
            controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guiPompa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label volumeAcquaLabel;
        private TextBox volumeAcquaTextBox;
        private TextBox capienzaSerbatoioTextBox;
        private Label capienzaSerbatorioLabel;
        private Label riempimentoLabel;
        private TextBox riempimentoTextBox;
        private Label purityPercLabel;
        private TextBox purityPercTextBox;
        private Label temperaturaLabel;
        private TextBox temperaturaTextBox;
        private Label celciusLabel;
        private Label scaricoAcquaLabel;
        private TextBox scaricoAcquaTextBox;
        private Label percLablel1;
        private Label percLabel2;
        private Label pompaLabel;
        private TextBox pompaTextBox;
        private Label allarmePuritaLabel;
        private TextBox allarmePuritaTextBox;
        private Label allarmeVolumBassoLabel;
        private TextBox allarmeVolumeBassoTextBox;
        private TextBox allarmeVolumeAltoTextBox;
        private Label allarmeVolumeAltoLabel;
        private Label flussoIngressoLabel;
        private TextBox flussoIngressoTextBox;
        private Label flussoUscitaLabel;
        private Label flussoMisuraIngressoLabel;
        private TextBox flussoUscitaTextBox;
        private Label flussoMisuraUscitaLabel;
        private Label allarmeTemperaturaBassaLabel;
        private TextBox allarmeTemperaturaBassaTextBox;
        private Label allarmeTemperaturaAltaLabel;
        private TextBox allarmeTemperaturaAltaTextBox;
        private GroupBox allarmiGroupBox;
        private GroupBox sensoriGroupBox;
        private Label luceUVLabel;
        private TextBox luceUVTextBox;
        private Button luceUVButton;
        private Panel actionsPanel;
        private Label luceUVButtonLabel;
        private Button scaricoButton;
        private Label scaricoButtonLabel;
        private Button termostatoButton;
        private Label termostatoButtonLabel;
        private Button pompaButton;
        private Label label2;
        private Panel guiTermometerContainer;
        private Label maxTemperaturaLabel;
        private Label label3;
        private Panel guiAllarmeTemperaturaBassa;
        private GroupBox simulationGroupBox;
        private Label midTemperaturaLabel;
        private Panel guiAllarmeTemperaturaAlta;
        private Panel guiMercurio;
        private System.Windows.Forms.Timer masterTimer;
        private System.Windows.Forms.Timer startTimer;
        private Panel controlPanel;
        private Button resetButton;
        private Button startButton;
        private TextBox termostatoTextBox;
        private Label termostatoLabel;
        private Label termostatoMisuraLabel;
        private Label allarmeTemperaturaBassaMisuraLabel;
        private Label allarmeTemperaturaAltaMisuraLabel;
        private Label litriMisuraLabel2;
        private Label litriMisuraLabel1;
        private Panel guiSerbatoio;
        private Panel guiAcqua;
        private PictureBox guiUV_Lamp;
        private Label guiScaricoLabel;
        private Panel guiScarico;
        private Panel guiFlussoIngresso;
        private Panel guiTuboUscita;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Panel guiElettricitaPanel;
        private Label maxKwLabel;
        private Label minKwLabel;
        private Label correnteMisuraLabel;
        private TextBox correnteTextBox;
        private Label correnteLabel;
        private Label utilizzoCorrenteLabel;
        private Panel guiElettricitaMisuraContainer;
        private PictureBox guiPompa;
    }
}
