using RFIDMEDevKit;
using RFID_App;
namespace RFID_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Config = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDTxPower = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIPSpeedway = new System.Windows.Forms.TextBox();
            this.btnConfSpeedway = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbAnt4Rx = new System.Windows.Forms.TextBox();
            this.cbSearchMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAnt1Rx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAnt3Rx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAnt2Rx = new System.Windows.Forms.TextBox();
            this.tbAnt2Tx = new System.Windows.Forms.TextBox();
            this.tbAnt1Tx = new System.Windows.Forms.TextBox();
            this.tbAnt3Tx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnt4Tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDispositivo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Conectar = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnIniDetLectSpeedway = new System.Windows.Forms.Button();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIniciarPararLectura = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pBotonesRFIDME = new System.Windows.Forms.Panel();
            this.b2IniciarLectura = new System.Windows.Forms.Button();
            this.btnGrabarEPC = new System.Windows.Forms.Button();
            this.pBotonesSpeedway = new System.Windows.Forms.Panel();
            this.btnLecSpeedway = new System.Windows.Forms.Button();
            this.btnGrabarSpeedway = new System.Windows.Forms.Button();
            this.cbBotonesLeerGrabar = new System.Windows.Forms.ComboBox();
            this.btnEnvWS = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbIDDestino = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIDEvento = new System.Windows.Forms.TextBox();
            this.nudEPC = new System.Windows.Forms.NumericUpDown();
            this.cbIncremento = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbNuevoEPC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCodEPC = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Config.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Conectar.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pBotonesRFIDME.SuspendLayout();
            this.pBotonesSpeedway.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEPC)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Config);
            this.tabControl1.Controls.Add(this.Conectar);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 424);
            this.tabControl1.TabIndex = 0;
            // 
            // Config
            // 
            this.Config.Controls.Add(this.panel2);
            this.Config.Controls.Add(this.panel1);
            this.Config.Controls.Add(this.cbDispositivo);
            this.Config.Controls.Add(this.label10);
            this.Config.Location = new System.Drawing.Point(4, 22);
            this.Config.Name = "Config";
            this.Config.Padding = new System.Windows.Forms.Padding(3);
            this.Config.Size = new System.Drawing.Size(602, 398);
            this.Config.TabIndex = 0;
            this.Config.Text = "Config";
            this.Config.UseVisualStyleBackColor = true;
            this.Config.Click += new System.EventHandler(this.Config_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.tbDTxPower);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(50, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 324);
            this.panel2.TabIndex = 25;
            this.panel2.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(98, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Tx Power:";
            // 
            // tbDTxPower
            // 
            this.tbDTxPower.Location = new System.Drawing.Point(161, 58);
            this.tbDTxPower.Name = "tbDTxPower";
            this.tbDTxPower.Size = new System.Drawing.Size(118, 20);
            this.tbDTxPower.TabIndex = 27;
            this.tbDTxPower.TextChanged += new System.EventHandler(this.tbDTxPower_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbIPSpeedway);
            this.panel1.Controls.Add(this.btnConfSpeedway);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.tbAnt4Rx);
            this.panel1.Controls.Add(this.cbSearchMode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbAnt1Rx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbAnt3Rx);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbAnt2Rx);
            this.panel1.Controls.Add(this.tbAnt2Tx);
            this.panel1.Controls.Add(this.tbAnt1Tx);
            this.panel1.Controls.Add(this.tbAnt3Tx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbAnt4Tx);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(50, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 325);
            this.panel1.TabIndex = 25;
            // 
            // tbIPSpeedway
            // 
            this.tbIPSpeedway.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbIPSpeedway.Enabled = false;
            this.tbIPSpeedway.Location = new System.Drawing.Point(48, 13);
            this.tbIPSpeedway.Name = "tbIPSpeedway";
            this.tbIPSpeedway.Size = new System.Drawing.Size(195, 20);
            this.tbIPSpeedway.TabIndex = 1;
            this.tbIPSpeedway.TextChanged += new System.EventHandler(this.tbIPSpeedway_TextChanged);
            // 
            // btnConfSpeedway
            // 
            this.btnConfSpeedway.Location = new System.Drawing.Point(453, 297);
            this.btnConfSpeedway.Name = "btnConfSpeedway";
            this.btnConfSpeedway.Size = new System.Drawing.Size(75, 23);
            this.btnConfSpeedway.TabIndex = 24;
            this.btnConfSpeedway.Text = "Guardar";
            this.btnConfSpeedway.UseVisualStyleBackColor = true;
            this.btnConfSpeedway.Click += new System.EventHandler(this.btnConfSpeedway_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rx Sensitivity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tx Power ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 299);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 10;
            // 
            // tbAnt4Rx
            // 
            this.tbAnt4Rx.Location = new System.Drawing.Point(283, 190);
            this.tbAnt4Rx.Name = "tbAnt4Rx";
            this.tbAnt4Rx.Size = new System.Drawing.Size(62, 20);
            this.tbAnt4Rx.TabIndex = 21;
            // 
            // cbSearchMode
            // 
            this.cbSearchMode.FormattingEnabled = true;
            this.cbSearchMode.Items.AddRange(new object[] {
            "Dual Target",
            "Single Target",
            "Single target with suppression"});
            this.cbSearchMode.Location = new System.Drawing.Point(122, 233);
            this.cbSearchMode.Name = "cbSearchMode";
            this.cbSearchMode.Size = new System.Drawing.Size(143, 21);
            this.cbSearchMode.TabIndex = 9;
            this.cbSearchMode.Text = "Dual Target";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Search Mode:";
            // 
            // tbAnt1Rx
            // 
            this.tbAnt1Rx.Location = new System.Drawing.Point(283, 82);
            this.tbAnt1Rx.Name = "tbAnt1Rx";
            this.tbAnt1Rx.Size = new System.Drawing.Size(62, 20);
            this.tbAnt1Rx.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Session 1:";
            // 
            // tbAnt3Rx
            // 
            this.tbAnt3Rx.Location = new System.Drawing.Point(283, 157);
            this.tbAnt3Rx.Name = "tbAnt3Rx";
            this.tbAnt3Rx.Size = new System.Drawing.Size(62, 20);
            this.tbAnt3Rx.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ant 1:";
            // 
            // tbAnt2Rx
            // 
            this.tbAnt2Rx.Location = new System.Drawing.Point(283, 120);
            this.tbAnt2Rx.Name = "tbAnt2Rx";
            this.tbAnt2Rx.Size = new System.Drawing.Size(62, 20);
            this.tbAnt2Rx.TabIndex = 19;
            // 
            // tbAnt2Tx
            // 
            this.tbAnt2Tx.Location = new System.Drawing.Point(131, 120);
            this.tbAnt2Tx.Name = "tbAnt2Tx";
            this.tbAnt2Tx.Size = new System.Drawing.Size(62, 20);
            this.tbAnt2Tx.TabIndex = 17;
            // 
            // tbAnt1Tx
            // 
            this.tbAnt1Tx.Location = new System.Drawing.Point(131, 82);
            this.tbAnt1Tx.Name = "tbAnt1Tx";
            this.tbAnt1Tx.Size = new System.Drawing.Size(62, 20);
            this.tbAnt1Tx.TabIndex = 14;
            // 
            // tbAnt3Tx
            // 
            this.tbAnt3Tx.Location = new System.Drawing.Point(131, 157);
            this.tbAnt3Tx.Name = "tbAnt3Tx";
            this.tbAnt3Tx.Size = new System.Drawing.Size(62, 20);
            this.tbAnt3Tx.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ant 4:";
            // 
            // tbAnt4Tx
            // 
            this.tbAnt4Tx.Location = new System.Drawing.Point(131, 190);
            this.tbAnt4Tx.Name = "tbAnt4Tx";
            this.tbAnt4Tx.Size = new System.Drawing.Size(62, 20);
            this.tbAnt4Tx.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ant 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ant 2:";
            // 
            // cbDispositivo
            // 
            this.cbDispositivo.FormattingEnabled = true;
            this.cbDispositivo.Items.AddRange(new object[] {
            "Speedway",
            "RFID ME"});
            this.cbDispositivo.Location = new System.Drawing.Point(122, 26);
            this.cbDispositivo.Name = "cbDispositivo";
            this.cbDispositivo.Size = new System.Drawing.Size(121, 21);
            this.cbDispositivo.TabIndex = 23;
            this.cbDispositivo.Text = "Speedway";
            this.cbDispositivo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Dispositivo:";
            // 
            // Conectar
            // 
            this.Conectar.Controls.Add(this.btnLimpiar);
            this.Conectar.Controls.Add(this.btnIniDetLectSpeedway);
            this.Conectar.Controls.Add(this.lboxLog);
            this.Conectar.Controls.Add(this.label12);
            this.Conectar.Controls.Add(this.btnIniciarPararLectura);
            this.Conectar.Location = new System.Drawing.Point(4, 22);
            this.Conectar.Name = "Conectar";
            this.Conectar.Padding = new System.Windows.Forms.Padding(3);
            this.Conectar.Size = new System.Drawing.Size(602, 398);
            this.Conectar.TabIndex = 1;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnLimpiar.Location = new System.Drawing.Point(508, 137);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(76, 23);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnIniDetLectSpeedway
            // 
            this.btnIniDetLectSpeedway.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnIniDetLectSpeedway.Location = new System.Drawing.Point(356, 80);
            this.btnIniDetLectSpeedway.Name = "btnIniDetLectSpeedway";
            this.btnIniDetLectSpeedway.Size = new System.Drawing.Size(149, 23);
            this.btnIniDetLectSpeedway.TabIndex = 30;
            this.btnIniDetLectSpeedway.Text = "Iniciar Lectura Speedway";
            this.btnIniDetLectSpeedway.UseVisualStyleBackColor = true;
            this.btnIniDetLectSpeedway.Click += new System.EventHandler(this.button1_Click);
            // 
            // lboxLog
            // 
            this.lboxLog.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lboxLog.Enabled = false;
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.HorizontalScrollbar = true;
            this.lboxLog.Location = new System.Drawing.Point(135, 137);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(356, 225);
            this.lboxLog.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Código EPC:";
            // 
            // btnIniciarPararLectura
            // 
            this.btnIniciarPararLectura.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnIniciarPararLectura.Location = new System.Drawing.Point(356, 51);
            this.btnIniciarPararLectura.Name = "btnIniciarPararLectura";
            this.btnIniciarPararLectura.Size = new System.Drawing.Size(149, 23);
            this.btnIniciarPararLectura.TabIndex = 25;
            this.btnIniciarPararLectura.Text = "Realizar Lectura RFID ME";
            this.btnIniciarPararLectura.UseVisualStyleBackColor = true;
            this.btnIniciarPararLectura.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pBotonesRFIDME);
            this.tabPage3.Controls.Add(this.pBotonesSpeedway);
            this.tabPage3.Controls.Add(this.cbBotonesLeerGrabar);
            this.tabPage3.Controls.Add(this.btnEnvWS);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.tbIDDestino);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tbIDEvento);
            this.tabPage3.Controls.Add(this.nudEPC);
            this.tabPage3.Controls.Add(this.cbIncremento);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.tbNuevoEPC);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.tbCodEPC);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(602, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Read/Write";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pBotonesRFIDME
            // 
            this.pBotonesRFIDME.Controls.Add(this.b2IniciarLectura);
            this.pBotonesRFIDME.Controls.Add(this.btnGrabarEPC);
            this.pBotonesRFIDME.Location = new System.Drawing.Point(27, 273);
            this.pBotonesRFIDME.Name = "pBotonesRFIDME";
            this.pBotonesRFIDME.Size = new System.Drawing.Size(359, 29);
            this.pBotonesRFIDME.TabIndex = 44;
            this.pBotonesRFIDME.Visible = false;
            // 
            // b2IniciarLectura
            // 
            this.b2IniciarLectura.Location = new System.Drawing.Point(3, 3);
            this.b2IniciarLectura.Name = "b2IniciarLectura";
            this.b2IniciarLectura.Size = new System.Drawing.Size(158, 23);
            this.b2IniciarLectura.TabIndex = 26;
            this.b2IniciarLectura.Text = "Iniciar Lectura RFID ME (O)";
            this.b2IniciarLectura.UseVisualStyleBackColor = true;
            this.b2IniciarLectura.Click += new System.EventHandler(this.b2IniciarLectura_Click);
            // 
            // btnGrabarEPC
            // 
            this.btnGrabarEPC.Location = new System.Drawing.Point(179, 3);
            this.btnGrabarEPC.Name = "btnGrabarEPC";
            this.btnGrabarEPC.Size = new System.Drawing.Size(146, 23);
            this.btnGrabarEPC.TabIndex = 33;
            this.btnGrabarEPC.Text = "Grabar EPC RFID ME (P)";
            this.btnGrabarEPC.UseVisualStyleBackColor = true;
            this.btnGrabarEPC.Click += new System.EventHandler(this.button5_Click);
            // 
            // pBotonesSpeedway
            // 
            this.pBotonesSpeedway.Controls.Add(this.btnLecSpeedway);
            this.pBotonesSpeedway.Controls.Add(this.btnGrabarSpeedway);
            this.pBotonesSpeedway.Location = new System.Drawing.Point(27, 239);
            this.pBotonesSpeedway.Name = "pBotonesSpeedway";
            this.pBotonesSpeedway.Size = new System.Drawing.Size(359, 32);
            this.pBotonesSpeedway.TabIndex = 43;
            // 
            // btnLecSpeedway
            // 
            this.btnLecSpeedway.Location = new System.Drawing.Point(3, 3);
            this.btnLecSpeedway.Name = "btnLecSpeedway";
            this.btnLecSpeedway.Size = new System.Drawing.Size(158, 23);
            this.btnLecSpeedway.TabIndex = 35;
            this.btnLecSpeedway.Text = "Iniciar Lectura Speedway (N)";
            this.btnLecSpeedway.UseVisualStyleBackColor = true;
            this.btnLecSpeedway.Click += new System.EventHandler(this.btnLecSpeedway_Click);
            // 
            // btnGrabarSpeedway
            // 
            this.btnGrabarSpeedway.Location = new System.Drawing.Point(179, 3);
            this.btnGrabarSpeedway.Name = "btnGrabarSpeedway";
            this.btnGrabarSpeedway.Size = new System.Drawing.Size(146, 23);
            this.btnGrabarSpeedway.TabIndex = 36;
            this.btnGrabarSpeedway.Text = "Grabar EPC Speedway (M)";
            this.btnGrabarSpeedway.UseVisualStyleBackColor = true;
            this.btnGrabarSpeedway.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // cbBotonesLeerGrabar
            // 
            this.cbBotonesLeerGrabar.FormattingEnabled = true;
            this.cbBotonesLeerGrabar.Items.AddRange(new object[] {
            "Speedway",
            "RFID ME"});
            this.cbBotonesLeerGrabar.Location = new System.Drawing.Point(35, 193);
            this.cbBotonesLeerGrabar.Name = "cbBotonesLeerGrabar";
            this.cbBotonesLeerGrabar.Size = new System.Drawing.Size(121, 21);
            this.cbBotonesLeerGrabar.TabIndex = 42;
            this.cbBotonesLeerGrabar.Text = "Speedway";
            this.cbBotonesLeerGrabar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnEnvWS
            // 
            this.btnEnvWS.Location = new System.Drawing.Point(442, 316);
            this.btnEnvWS.Name = "btnEnvWS";
            this.btnEnvWS.Size = new System.Drawing.Size(146, 23);
            this.btnEnvWS.TabIndex = 41;
            this.btnEnvWS.Text = "Enviar a Base de Datos";
            this.btnEnvWS.UseVisualStyleBackColor = true;
            this.btnEnvWS.Click += new System.EventHandler(this.btnEnvWS_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(387, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "ID Destino:";
            // 
            // tbIDDestino
            // 
            this.tbIDDestino.Location = new System.Drawing.Point(466, 273);
            this.tbIDDestino.Name = "tbIDDestino";
            this.tbIDDestino.Size = new System.Drawing.Size(122, 20);
            this.tbIDDestino.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "ID Evento:";
            // 
            // tbIDEvento
            // 
            this.tbIDEvento.Location = new System.Drawing.Point(466, 242);
            this.tbIDEvento.Name = "tbIDEvento";
            this.tbIDEvento.Size = new System.Drawing.Size(122, 20);
            this.tbIDEvento.TabIndex = 37;
            // 
            // nudEPC
            // 
            this.nudEPC.Location = new System.Drawing.Point(522, 195);
            this.nudEPC.Name = "nudEPC";
            this.nudEPC.Size = new System.Drawing.Size(55, 20);
            this.nudEPC.TabIndex = 32;
            this.nudEPC.Visible = false;
            this.nudEPC.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cbIncremento
            // 
            this.cbIncremento.AutoSize = true;
            this.cbIncremento.Location = new System.Drawing.Point(428, 197);
            this.cbIncremento.Name = "cbIncremento";
            this.cbIncremento.Size = new System.Drawing.Size(79, 17);
            this.cbIncremento.TabIndex = 31;
            this.cbIncremento.Text = "Incremento";
            this.cbIncremento.UseVisualStyleBackColor = true;
            this.cbIncremento.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(62, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Nuevo EPC:";
            // 
            // tbNuevoEPC
            // 
            this.tbNuevoEPC.Location = new System.Drawing.Point(141, 110);
            this.tbNuevoEPC.Name = "tbNuevoEPC";
            this.tbNuevoEPC.Size = new System.Drawing.Size(406, 20);
            this.tbNuevoEPC.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Código EPC:";
            // 
            // tbCodEPC
            // 
            this.tbCodEPC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCodEPC.Enabled = false;
            this.tbCodEPC.Location = new System.Drawing.Point(141, 66);
            this.tbCodEPC.Name = "tbCodEPC";
            this.tbCodEPC.Size = new System.Drawing.Size(406, 20);
            this.tbCodEPC.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Middleware";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Config.ResumeLayout(false);
            this.Config.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Conectar.ResumeLayout(false);
            this.Conectar.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pBotonesRFIDME.ResumeLayout(false);
            this.pBotonesSpeedway.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Config;
        private System.Windows.Forms.TabPage Conectar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIPSpeedway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAnt2Tx;
        private System.Windows.Forms.TextBox tbAnt3Tx;
        private System.Windows.Forms.TextBox tbAnt4Tx;
        private System.Windows.Forms.TextBox tbAnt1Tx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbSearchMode;
        private System.Windows.Forms.Button btnConfSpeedway;
        private System.Windows.Forms.ComboBox cbDispositivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAnt4Rx;
        private System.Windows.Forms.TextBox tbAnt3Rx;
        private System.Windows.Forms.TextBox tbAnt2Rx;
        private System.Windows.Forms.TextBox tbAnt1Rx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnIniciarPararLectura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDTxPower;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGrabarEPC;
        private System.Windows.Forms.NumericUpDown nudEPC;
        private System.Windows.Forms.CheckBox cbIncremento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbNuevoEPC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCodEPC;
        private System.Windows.Forms.Button b2IniciarLectura;
        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.Button btnIniDetLectSpeedway;
        private System.Windows.Forms.Button btnLecSpeedway;
        private System.Windows.Forms.Button btnGrabarSpeedway;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIDEvento;
        private System.Windows.Forms.Button btnEnvWS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbIDDestino;
        private System.Windows.Forms.ComboBox cbBotonesLeerGrabar;
        private System.Windows.Forms.Panel pBotonesSpeedway;
        private System.Windows.Forms.Panel pBotonesRFIDME;
    }
}

