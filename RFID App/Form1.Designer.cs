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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbIPSpeedway = new System.Windows.Forms.TextBox();
            this.btnConfSpeedway = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAnt4Rx = new System.Windows.Forms.TextBox();
            this.cbSearchMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAnt1Rx = new System.Windows.Forms.TextBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDTxPower = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Conectar = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnIniDetLectSpeedway = new System.Windows.Forms.Button();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIniciarPararLectura = new System.Windows.Forms.Button();
            this.Read_Write_RFIDME = new System.Windows.Forms.TabPage();
            this.btnGrabarEPC = new System.Windows.Forms.Button();
            this.b2IniciarLectura = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDormirLectura = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.tbAyudaCodEPC = new System.Windows.Forms.TextBox();
            this.btnActLecBagBaseDat = new System.Windows.Forms.Button();
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
            this.Read_Write_Speedway = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNEPCSpeedway = new System.Windows.Forms.TextBox();
            this.tbEPCSpeedway = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.tbEventoSW = new System.Windows.Forms.TextBox();
            this.btnGrabarSpeedway = new System.Windows.Forms.Button();
            this.btnLecSpeedway = new System.Windows.Forms.Button();
            this.lbSpeedway = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.nuSpeedway = new System.Windows.Forms.NumericUpDown();
            this.cbIncSpeedway = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.Config.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Conectar.SuspendLayout();
            this.Read_Write_RFIDME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEPC)).BeginInit();
            this.Read_Write_Speedway.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSpeedway)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.Config);
            this.tabControl1.Controls.Add(this.Conectar);
            this.tabControl1.Controls.Add(this.Read_Write_RFIDME);
            this.tabControl1.Controls.Add(this.Read_Write_Speedway);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 424);
            this.tabControl1.TabIndex = 0;
            // 
            // Config
            // 
            this.Config.Controls.Add(this.panel1);
            this.Config.Controls.Add(this.cbDispositivo);
            this.Config.Controls.Add(this.label10);
            this.Config.Controls.Add(this.panel2);
            this.Config.Location = new System.Drawing.Point(4, 22);
            this.Config.Name = "Config";
            this.Config.Padding = new System.Windows.Forms.Padding(3);
            this.Config.Size = new System.Drawing.Size(602, 398);
            this.Config.TabIndex = 0;
            this.Config.Text = "Config";
            this.Config.UseVisualStyleBackColor = true;
            this.Config.Click += new System.EventHandler(this.Config_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.tbIPSpeedway);
            this.panel1.Controls.Add(this.btnConfSpeedway);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbAnt4Rx);
            this.panel1.Controls.Add(this.cbSearchMode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbAnt1Rx);
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
            this.panel1.Location = new System.Drawing.Point(50, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 325);
            this.panel1.TabIndex = 25;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(351, 193);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 13);
            this.label29.TabIndex = 33;
            this.label29.Text = "(Max -80)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(351, 160);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 13);
            this.label28.TabIndex = 32;
            this.label28.Text = "(Max -80)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(351, 123);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 13);
            this.label27.TabIndex = 31;
            this.label27.Text = "(Max -80)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(202, 193);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 13);
            this.label26.TabIndex = 30;
            this.label26.Text = "(Max 30)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(202, 160);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "(Max 30)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(202, 123);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 28;
            this.label24.Text = "(Max 30)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(351, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "(Max -80)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(202, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "(Max 30)";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.tbDTxPower);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(50, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 324);
            this.panel2.TabIndex = 25;
            this.panel2.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(161, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "(Rangos de 5 a 18 DBm)";
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
            // Read_Write_RFIDME
            // 
            this.Read_Write_RFIDME.Controls.Add(this.btnGrabarEPC);
            this.Read_Write_RFIDME.Controls.Add(this.b2IniciarLectura);
            this.Read_Write_RFIDME.Controls.Add(this.lblTimer);
            this.Read_Write_RFIDME.Controls.Add(this.button1);
            this.Read_Write_RFIDME.Controls.Add(this.btnTimer);
            this.Read_Write_RFIDME.Controls.Add(this.label18);
            this.Read_Write_RFIDME.Controls.Add(this.label15);
            this.Read_Write_RFIDME.Controls.Add(this.tbDormirLectura);
            this.Read_Write_RFIDME.Controls.Add(this.lblURL);
            this.Read_Write_RFIDME.Controls.Add(this.tbAyudaCodEPC);
            this.Read_Write_RFIDME.Controls.Add(this.btnActLecBagBaseDat);
            this.Read_Write_RFIDME.Controls.Add(this.label13);
            this.Read_Write_RFIDME.Controls.Add(this.tbIDDestino);
            this.Read_Write_RFIDME.Controls.Add(this.label11);
            this.Read_Write_RFIDME.Controls.Add(this.tbIDEvento);
            this.Read_Write_RFIDME.Controls.Add(this.nudEPC);
            this.Read_Write_RFIDME.Controls.Add(this.cbIncremento);
            this.Read_Write_RFIDME.Controls.Add(this.label17);
            this.Read_Write_RFIDME.Controls.Add(this.tbNuevoEPC);
            this.Read_Write_RFIDME.Controls.Add(this.label16);
            this.Read_Write_RFIDME.Controls.Add(this.tbCodEPC);
            this.Read_Write_RFIDME.Location = new System.Drawing.Point(4, 22);
            this.Read_Write_RFIDME.Name = "Read_Write_RFIDME";
            this.Read_Write_RFIDME.Size = new System.Drawing.Size(602, 398);
            this.Read_Write_RFIDME.TabIndex = 2;
            this.Read_Write_RFIDME.Text = "Read/Write RFID ME";
            this.Read_Write_RFIDME.UseVisualStyleBackColor = true;
            // 
            // btnGrabarEPC
            // 
            this.btnGrabarEPC.Location = new System.Drawing.Point(209, 245);
            this.btnGrabarEPC.Name = "btnGrabarEPC";
            this.btnGrabarEPC.Size = new System.Drawing.Size(146, 23);
            this.btnGrabarEPC.TabIndex = 33;
            this.btnGrabarEPC.Text = "Grabar EPC RFID ME (P)";
            this.btnGrabarEPC.UseVisualStyleBackColor = true;
            this.btnGrabarEPC.Click += new System.EventHandler(this.button5_Click);
            // 
            // b2IniciarLectura
            // 
            this.b2IniciarLectura.Location = new System.Drawing.Point(30, 245);
            this.b2IniciarLectura.Name = "b2IniciarLectura";
            this.b2IniciarLectura.Size = new System.Drawing.Size(158, 23);
            this.b2IniciarLectura.TabIndex = 26;
            this.b2IniciarLectura.Text = "Iniciar Lectura RFID ME (O)";
            this.b2IniciarLectura.UseVisualStyleBackColor = true;
            this.b2IniciarLectura.Click += new System.EventHandler(this.b2IniciarLectura_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(206, 381);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(96, 13);
            this.lblTimer.TabIndex = 53;
            this.lblTimer.Text = "Timer Desactivado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Detener Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(317, 346);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(271, 23);
            this.btnTimer.TabIndex = 51;
            this.btnTimer.Text = "Activar Lectura y Grabar en Base de Datos con timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(194, 352);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 50;
            this.label18.Text = "segundos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 352);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Dormir lectura por:";
            // 
            // tbDormirLectura
            // 
            this.tbDormirLectura.Location = new System.Drawing.Point(119, 349);
            this.tbDormirLectura.Name = "tbDormirLectura";
            this.tbDormirLectura.Size = new System.Drawing.Size(69, 20);
            this.tbDormirLectura.TabIndex = 48;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(32, 158);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(0, 13);
            this.lblURL.TabIndex = 47;
            // 
            // tbAyudaCodEPC
            // 
            this.tbAyudaCodEPC.Location = new System.Drawing.Point(27, 375);
            this.tbAyudaCodEPC.Name = "tbAyudaCodEPC";
            this.tbAyudaCodEPC.Size = new System.Drawing.Size(122, 20);
            this.tbAyudaCodEPC.TabIndex = 46;
            this.tbAyudaCodEPC.Visible = false;
            // 
            // btnActLecBagBaseDat
            // 
            this.btnActLecBagBaseDat.Location = new System.Drawing.Point(317, 320);
            this.btnActLecBagBaseDat.Name = "btnActLecBagBaseDat";
            this.btnActLecBagBaseDat.Size = new System.Drawing.Size(271, 23);
            this.btnActLecBagBaseDat.TabIndex = 45;
            this.btnActLecBagBaseDat.Text = "Activar Lectura y Grabar en Base de Datos";
            this.btnActLecBagBaseDat.UseVisualStyleBackColor = true;
            this.btnActLecBagBaseDat.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(387, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "ID Dispositivo:";
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
            // Read_Write_Speedway
            // 
            this.Read_Write_Speedway.AccessibleName = "";
            this.Read_Write_Speedway.Controls.Add(this.nuSpeedway);
            this.Read_Write_Speedway.Controls.Add(this.cbIncSpeedway);
            this.Read_Write_Speedway.Controls.Add(this.label30);
            this.Read_Write_Speedway.Controls.Add(this.label5);
            this.Read_Write_Speedway.Controls.Add(this.tbNEPCSpeedway);
            this.Read_Write_Speedway.Controls.Add(this.tbEPCSpeedway);
            this.Read_Write_Speedway.Controls.Add(this.button4);
            this.Read_Write_Speedway.Controls.Add(this.button2);
            this.Read_Write_Speedway.Controls.Add(this.btnLimpiar2);
            this.Read_Write_Speedway.Controls.Add(this.label23);
            this.Read_Write_Speedway.Controls.Add(this.tbEventoSW);
            this.Read_Write_Speedway.Controls.Add(this.btnGrabarSpeedway);
            this.Read_Write_Speedway.Controls.Add(this.btnLecSpeedway);
            this.Read_Write_Speedway.Controls.Add(this.lbSpeedway);
            this.Read_Write_Speedway.Controls.Add(this.label19);
            this.Read_Write_Speedway.Location = new System.Drawing.Point(4, 22);
            this.Read_Write_Speedway.Name = "Read_Write_Speedway";
            this.Read_Write_Speedway.Size = new System.Drawing.Size(602, 398);
            this.Read_Write_Speedway.TabIndex = 3;
            this.Read_Write_Speedway.Text = "Read/Write Speedway";
            this.Read_Write_Speedway.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 283);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 13);
            this.label30.TabIndex = 63;
            this.label30.Text = "Código EPC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Nuevo EPC:";
            // 
            // tbNEPCSpeedway
            // 
            this.tbNEPCSpeedway.Location = new System.Drawing.Point(88, 306);
            this.tbNEPCSpeedway.Name = "tbNEPCSpeedway";
            this.tbNEPCSpeedway.Size = new System.Drawing.Size(406, 20);
            this.tbNEPCSpeedway.TabIndex = 61;
            // 
            // tbEPCSpeedway
            // 
            this.tbEPCSpeedway.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEPCSpeedway.Enabled = false;
            this.tbEPCSpeedway.Location = new System.Drawing.Point(88, 280);
            this.tbEPCSpeedway.Name = "tbEPCSpeedway";
            this.tbEPCSpeedway.Size = new System.Drawing.Size(406, 20);
            this.tbEPCSpeedway.TabIndex = 60;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(88, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 36);
            this.button4.TabIndex = 57;
            this.button4.Text = "Iniciar Lectura única de Speedway (Z)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 36);
            this.button2.TabIndex = 56;
            this.button2.Text = "Grabar EPC Speedway (X)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(405, 87);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(164, 23);
            this.btnLimpiar2.TabIndex = 55;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(402, 142);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 13);
            this.label23.TabIndex = 54;
            this.label23.Text = "ID Evento:";
            // 
            // tbEventoSW
            // 
            this.tbEventoSW.Location = new System.Drawing.Point(466, 139);
            this.tbEventoSW.Name = "tbEventoSW";
            this.tbEventoSW.Size = new System.Drawing.Size(101, 20);
            this.tbEventoSW.TabIndex = 53;
            // 
            // btnGrabarSpeedway
            // 
            this.btnGrabarSpeedway.Location = new System.Drawing.Point(268, 17);
            this.btnGrabarSpeedway.Name = "btnGrabarSpeedway";
            this.btnGrabarSpeedway.Size = new System.Drawing.Size(164, 38);
            this.btnGrabarSpeedway.TabIndex = 36;
            this.btnGrabarSpeedway.Text = "Detener Lectura Speedway (M)";
            this.btnGrabarSpeedway.UseVisualStyleBackColor = true;
            this.btnGrabarSpeedway.Click += new System.EventHandler(this.btnGrabarSpeedway_Click);
            // 
            // btnLecSpeedway
            // 
            this.btnLecSpeedway.Location = new System.Drawing.Point(85, 17);
            this.btnLecSpeedway.Name = "btnLecSpeedway";
            this.btnLecSpeedway.Size = new System.Drawing.Size(158, 38);
            this.btnLecSpeedway.TabIndex = 35;
            this.btnLecSpeedway.Text = "Iniciar Lectura Speedway y enviar a base de datos (N)";
            this.btnLecSpeedway.UseVisualStyleBackColor = true;
            this.btnLecSpeedway.Click += new System.EventHandler(this.btnLecSpeedway_Click_1);
            // 
            // lbSpeedway
            // 
            this.lbSpeedway.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbSpeedway.FormattingEnabled = true;
            this.lbSpeedway.HorizontalScrollbar = true;
            this.lbSpeedway.Location = new System.Drawing.Point(85, 87);
            this.lbSpeedway.Name = "lbSpeedway";
            this.lbSpeedway.Size = new System.Drawing.Size(298, 173);
            this.lbSpeedway.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Código EPC:";
            // 
            // nuSpeedway
            // 
            this.nuSpeedway.Location = new System.Drawing.Point(532, 352);
            this.nuSpeedway.Name = "nuSpeedway";
            this.nuSpeedway.Size = new System.Drawing.Size(55, 20);
            this.nuSpeedway.TabIndex = 65;
            this.nuSpeedway.Visible = false;
            this.nuSpeedway.ValueChanged += new System.EventHandler(this.nuSpeedway_ValueChanged);
            // 
            // cbIncSpeedway
            // 
            this.cbIncSpeedway.AutoSize = true;
            this.cbIncSpeedway.Location = new System.Drawing.Point(438, 354);
            this.cbIncSpeedway.Name = "cbIncSpeedway";
            this.cbIncSpeedway.Size = new System.Drawing.Size(79, 17);
            this.cbIncSpeedway.TabIndex = 64;
            this.cbIncSpeedway.Text = "Incremento";
            this.cbIncSpeedway.UseVisualStyleBackColor = true;
            this.cbIncSpeedway.CheckedChanged += new System.EventHandler(this.cbIncSpeedway_CheckedChanged);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Conectar.ResumeLayout(false);
            this.Conectar.PerformLayout();
            this.Read_Write_RFIDME.ResumeLayout(false);
            this.Read_Write_RFIDME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEPC)).EndInit();
            this.Read_Write_Speedway.ResumeLayout(false);
            this.Read_Write_Speedway.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSpeedway)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Config;
        private System.Windows.Forms.TabPage Conectar;
        private System.Windows.Forms.TabPage Read_Write_RFIDME;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIDEvento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbIDDestino;
        private System.Windows.Forms.Button btnActLecBagBaseDat;
        private System.Windows.Forms.TextBox tbAyudaCodEPC;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbDormirLectura;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TabPage Read_Write_Speedway;
        private System.Windows.Forms.Button btnLecSpeedway;
        private System.Windows.Forms.Button btnGrabarSpeedway;
        private System.Windows.Forms.ListBox lbSpeedway;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbEventoSW;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNEPCSpeedway;
        private System.Windows.Forms.TextBox tbEPCSpeedway;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nuSpeedway;
        private System.Windows.Forms.CheckBox cbIncSpeedway;
    }
}

