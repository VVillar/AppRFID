using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFIDMEDevKit;
using RFID_App;
using Impinj.OctaneSdk;
using System.Threading;
using Flurl.Http;
using System.Net;
using System.Text.RegularExpressions;

namespace RFID_App
{
    public partial class Form1 : Form
    {
        //Instanciamos el RFID ME
        public RFIDMEDevKit.reader myReader = new RFIDMEDevKit.reader();

        //Indicamos el localhost del dispositivo Speedway
        public const string ReaderHostname = "speedwayr-11-22-9E.local";
        //Instanciamos el Speedway
        static ImpinjReader reader = new ImpinjReader();
        const ushort EPC_OP_ID = 123;
        const ushort PC_BITS_OP_ID = 321;
        static bool _stopLoop = true;
        static string idEvento;
        static string idDestino;




        public Form1()
        {
            InitializeComponent();
            //Activamos el RFID como demo
            bool myResult = myReader.Activation("Demo");
            //Conectamos el RFID ME
            myReader.Connect("RFIDME");
            this.cbDispositivo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.KeyPreview = true;
            this.lboxLog.SelectionMode = SelectionMode.None;


            try
            {
                //Conectamos el Speedway
                reader.Connect(ReaderHostname);
                //Se aplican los valores por defecto al speedway
                reader.ApplyDefaultSettings();
                //Se inicia el speedway
                //reader.Start();
                //Instanciamos settings y le asignamos los settings actuales
                Settings settings = reader.QuerySettings();
                //Se agrega el número de puerto de antena al reporte
                settings.Report.IncludeAntennaPortNumber = true;
                //Se ajusta el modo de lectura al mas óptimo
                settings.ReaderMode = ReaderMode.AutoSetDenseReader;
                //Se captura el hostname en la caja de texto tbIPSpeedway
                tbIPSpeedway.Text = reader.Address;
            }
            catch
            {
                //En caso el speedway no esté conectado se muestra un mensaje
                MessageBox.Show("El speedway no está conectado");
            }
        }

        private void Config_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //Lógica para mostrar y ocultar paneles para la primera pestaña según el dispositivo
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDispositivo.Text.Equals("Speedway"))
            {
                panel2.Visible = false;
                panel1.Visible = true;
            }
            else if (cbDispositivo.Text.Equals("RFID ME"))
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        //Boton para setear el poder del RFID ME
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                myReader.setPower(int.Parse(tbDTxPower.Text));
                MessageBox.Show("Se gurado el cambio en la antena");
            }
            catch
            {
                MessageBox.Show("Introduzca el número en el formato correcto");
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        //Boton para leer el EPC del RFID ME
        private void button2_Click(object sender, EventArgs e)
        {
            if (myReader.ReadEPC(true, ",") != "SDK Demo has expired")
            {
                //while (btnIniciarPararLectura.Text == "Detener Lectura") { 
                Cursor.Current = Cursors.WaitCursor;
                string myTags = "";
                myTags = myReader.ReadEPC(true, ",");
                string[] myTagList = myTags.Split(',');
                foreach (string tag in myTagList)
                    lboxLog.Items.Add(tag);
                Cursor.Current = Cursors.Default;
                //Thread.Sleep(10000);
                //}
            }
            else
            {
                MessageBox.Show("Dispositivo no conectado");
            }

        }


        public void OnTagsReported2(ImpinjReader sender, TagReport report)
        {
            // This event handler is called asynchronously 
            // when tag reports are available.
            // Loop through each tag in the report 
            // and print the data.
            foreach (Tag tag in report)
            {
                TextBox.CheckForIllegalCrossThreadCalls = false;
                tbCodEPC.Text = tag.Epc.ToString();
            }
        }

        private void Conectar_Click(object sender, EventArgs e)
        {

        }

        private void cbIniciarPararLectura_CheckedChanged(object sender, EventArgs e)
        {


        }

        //Boton para realizar lectura del RFID ME en la pestaña Read/Write
        private void b2IniciarLectura_Click(object sender, EventArgs e)
        {
            b2IniciarLectura.FlatStyle = FlatStyle.Flat;
            tbCodEPC.Text = myReader.ReadEPC(false, ",");
            tbNuevoEPC.Text = tbCodEPC.Text;
            b2IniciarLectura.FlatStyle = FlatStyle.Standard;
            if (cbIncremento.Checked)
            {
                tbNuevoEPC.Text = (Int64.Parse(tbCodEPC.Text) + Int64.Parse(nudEPC.Value.ToString())).ToString().PadLeft(24, '0');
            }
        }

        //Checkbox incremento para mostrar o esconder 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbIncremento.Checked == true)
                {
                    tbNuevoEPC.Text = (Int64.Parse(tbCodEPC.Text) + Int64.Parse(nudEPC.Value.ToString())).ToString().PadLeft(24, '0');
                    nudEPC.Visible = true;
                }
                else
                {
                    tbNuevoEPC.Text = tbCodEPC.Text;
                    nudEPC.Visible = false;
                }
            }
            catch
            {
                if (cbIncremento.Checked == true)
                {
                    tbNuevoEPC.Text = "0";
                    nudEPC.Visible = true;
                }
                else
                {
                    tbNuevoEPC.Text = tbCodEPC.Text;
                    nudEPC.Visible = false;
                }

            }
        }
        // Cuando cambia un valor del Numeric Up Down
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 valNEPC = Int64.Parse(tbCodEPC.Text) + Int64.Parse(nudEPC.Value.ToString());
                tbNuevoEPC.Text = valNEPC.ToString().PadLeft(24, '0');
            }
            catch
            {
                MessageBox.Show("Número del EPC en un formato no aceptado");
            }
        }

        // Boton para validación de la longitud del nuevo EPC y grabar el EPC
        private void button5_Click(object sender, EventArgs e)
        {
            btnGrabarEPC.FlatStyle = FlatStyle.Flat;
            btnGrabarEPC.FlatStyle = FlatStyle.Standard;
            if ((tbNuevoEPC.TextLength % 4) != 0)
            {
                MessageBox.Show("La longitud del tag tiene que ser divisible entre 4");
                return;
            }
            try
            {
                //Int64 nEPC = Int64.Parse(tbCodEPC.Text, System.Globalization.NumberStyles.HexNumber) + Int64.Parse(nudEPC.Value.ToString());
                //tbNuevoEPC.Text = nEPC.ToString("X").PadLeft(24, '0');

                if (cbIncremento.Checked)
                {
                    if (myReader.ReadEPC(false, ",").Equals("No tags found"))
                    {
                        MessageBox.Show("EPC no guardado, etiqueta no encontrada");
                        return;
                    }
                    else
                    {
                        Int64 sigEPC = Int64.Parse(tbNuevoEPC.Text) + Int64.Parse(nudEPC.Value.ToString());
                        myReader.writeEPC(myReader.ReadEPC(false, ","), "00000000", tbNuevoEPC.Text.PadLeft(24, '0'));
                        MessageBox.Show("EPC guardado");
                        tbNuevoEPC.Text = sigEPC.ToString().PadLeft(24, '0');
                        tbCodEPC.Text = myReader.ReadEPC(false, ",");

                    }
                }
                else
                {
                    if (myReader.ReadEPC(false, ",").Equals("No tags found"))
                    {
                        MessageBox.Show("EPC no guardado, etiqueta no encontrada");
                        return;
                    }
                    else
                    {
                        myReader.writeEPC(tbCodEPC.Text, "00000000", tbNuevoEPC.Text.PadLeft(24, '0'));
                        tbCodEPC.Text = myReader.ReadEPC(false, ",");
                        MessageBox.Show("EPC guardado");
                    }

                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                return;
            }
            tbCodEPC.Text = myReader.ReadEPC(false, ",");
        }

        //Boton aplicar incremento
        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        //Boton para aplicar las configuraciones del speedway
        private void btnConfSpeedway_Click(object sender, EventArgs e)
        {
            Settings settings = reader.QuerySettings();
            try
            {
                if (tbAnt1Tx.Text != "")
                    settings.Antennas.GetAntenna(1).TxPowerInDbm = double.Parse(tbAnt1Tx.Text);
                if (tbAnt2Tx.Text != "")
                    settings.Antennas.GetAntenna(2).TxPowerInDbm = double.Parse(tbAnt2Tx.Text);
                if (tbAnt3Tx.Text != "")
                    settings.Antennas.GetAntenna(3).TxPowerInDbm = double.Parse(tbAnt3Tx.Text);
                if (tbAnt4Tx.Text != "")
                    settings.Antennas.GetAntenna(4).TxPowerInDbm = double.Parse(tbAnt4Tx.Text);

                if (tbAnt1Rx.Text != "")
                    settings.Antennas.GetAntenna(1).RxSensitivityInDbm = double.Parse(tbAnt1Rx.Text);
                if (tbAnt2Rx.Text != "")
                    settings.Antennas.GetAntenna(2).RxSensitivityInDbm = double.Parse(tbAnt2Rx.Text);
                if (tbAnt3Rx.Text != "")
                    settings.Antennas.GetAntenna(3).RxSensitivityInDbm = double.Parse(tbAnt3Rx.Text);
                if (tbAnt4Rx.Text != "")
                    settings.Antennas.GetAntenna(4).RxSensitivityInDbm = double.Parse(tbAnt4Rx.Text);

                MessageBox.Show("Se guardaron los cambios en las antenas");
            }
            catch
            {
                MessageBox.Show("Introduzca los números en el formato correcto");
            }
            if (cbSearchMode.SelectedText == "Dual Target")
            {
                settings.SearchMode = SearchMode.DualTarget;
                settings.Session = 2;
            }
            else if (cbSearchMode.SelectedText == "Single Target")
            {
                settings.SearchMode = SearchMode.SingleTarget;
                settings.Session = 2;
            }
            else
            {
                settings.SearchMode = SearchMode.TagFocus;
                settings.Session = 1;
            }
            reader.ApplySettings(settings);
        }

        private void tbIPSpeedway_TextChanged(object sender, EventArgs e)
        {

        }

        //Boton para iniciar lectura del speedway
        private void button1_Click(object sender, EventArgs e)
        {

            switch (btnIniDetLectSpeedway.Text)
            {

                case "Iniciar Lectura Speedway":

                    #region Speedway
                    try
                    {


                        reader.ApplyDefaultSettings();
                        Settings settings = reader.QuerySettings();
                        settings.Antennas.DisableAll();
                        settings.Antennas.GetAntenna(1).IsEnabled = true;
                        settings.Report.Mode = ReportMode.BatchAfterStop;
                        settings.Report.Mode = ReportMode.BatchAfterStop;
                        settings.AutoStart.Mode = AutoStartMode.Periodic;
                        settings.AutoStart.PeriodInMs = 3000;
                        settings.AutoStop.Mode = AutoStopMode.Duration;
                        settings.AutoStop.DurationInMs = 1500;
                        reader.ApplySettings(settings);
                        btnIniDetLectSpeedway.Text = "Detener Lectura Speedway";
                        reader.TagsReported += OnTagsReported;
                        reader.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Speedway no conectado");
                    }
                    #endregion
                    break;
                case "Detener Lectura Speedway":
                    //reader.Stop();
                    btnIniDetLectSpeedway.Text = "Iniciar Lectura Speedway";
                    reader.TagsReported -= OnTagsReported;
                    break;
            }
        }
        //Método de apoyo para leer y añadir EPC del Speedway al Listbox lboxlog
        public void OnTagsReported(ImpinjReader sender, TagReport report)
        {
            // This event handler is called asynchronously 
            // when tag reports are available.
            // Loop through each tag in the report 
            // and print the data.
            foreach (Tag tag in report)
            {
                ListBox.CheckForIllegalCrossThreadCalls = false;
                lboxLog.Items.Add(tag.Epc.ToString());
            }
        }

        // This event handler will be called when tag 
        // operations have been executed by the reader.
        static void OnTagOpComplete(ImpinjReader reader, TagOpReport report)
        {
            // Loop through all the completed tag operations.
            foreach (TagOpResult result in report)
            {
                // Was this completed operation a tag write operation?
                if (result is TagWriteOpResult)
                {
                    // Cast it to the correct type.
                    TagWriteOpResult writeResult = result as TagWriteOpResult;
                    if (writeResult.OpId == EPC_OP_ID)
                        MessageBox.Show("Write to EPC complete : {0}" + writeResult.Result);
                    else if (writeResult.OpId == PC_BITS_OP_ID)
                        MessageBox.Show("Write to PC bits complete : {0}" + writeResult.Result);

                    // Print out the number of words written
                    MessageBox.Show("Number of words written : {0}" + writeResult.NumWordsWritten);
                }
            }
        }



        private void tbDTxPower_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lboxLog.Items.Clear();
        }

        private void btnLecSpeedway_Click(object sender, EventArgs e)
        {
            btnLecSpeedway.FlatStyle = FlatStyle.Flat;
            try
            {
                //reader.Start();
                Settings settings = reader.QueryDefaultSettings();
                reader.TagsReported += OnTagsReported4;
            }
            catch
            {
                MessageBox.Show("Speedway no encontrado");
            }
            btnLecSpeedway.FlatStyle = FlatStyle.Standard;
        }
        public void OnTagsReported4(ImpinjReader sender, TagReport report)
        {
            reader.TagsReported -= OnTagsReported4;

            Tag tag = report.Tags[0];
            TextBox.CheckForIllegalCrossThreadCalls = false;
            string codEPC = tag.Epc.ToHexString();
            TextBox.CheckForIllegalCrossThreadCalls = false;
            tbCodEPC.Text = codEPC;
            tbNuevoEPC.Text = tag.Epc.ToHexString();
            //ProgramEpc(tag.Epc.ToString(), tag.PcBits, tbNuevoEPC.Text);
        }
        private void btnEnvWS_Click(object sender, EventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            reader.Stop();
            reader.Disconnect();
            MessageBox.Show("Speedway Desconectado");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.O))
            {
                b2IniciarLectura.PerformClick();
            }
            else if (keyData == (Keys.P))
            {
                btnGrabarEPC.PerformClick();
            }
            else if (keyData == (Keys.N))
            {
                btnLecSpeedway.PerformClick();
            }
            else if (keyData == (Keys.M))
            {
                btnLecSpeedway.PerformClick();
            }
            else if (keyData == (Keys.Z))
            {
                button4.PerformClick();
            }
            else if (keyData == (Keys.X))
            {
                button2.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        string Method2(string aString)
        {
            return aString;
        }

        //Activar lectura y grabar en base de datos
        private void button1_Click_1(object sender, EventArgs e)
        {
            int cont = 0;
            if (tbIDEvento.Text.Equals(""))
            {
                MessageBox.Show("Llenar el campo ID Evento");
                return;
            }

            if (tbIDDestino.Text.Equals(""))
            {
                MessageBox.Show("Llenar el  campo ID Destino");
                return;
            }

            do
            {
                tbAyudaCodEPC.Text = myReader.ReadEPC(false, ",");
                if (tbAyudaCodEPC.Text != "No tags found")
                    cont = cont + 1;
            } while (cont != 1);
            try
            {
                string url = "http://52.43.37.169:8080/eventos/rest/dongle/leer/" + tbAyudaCodEPC.Text + "/" + tbIDEvento.Text + "/" + tbIDDestino.Text;
                lblURL.Text = url;
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    string HtmlResult = wc.UploadString(url, "");
                    if (HtmlResult.Equals("{\"estado\":1}"))
                    {
                        MessageBox.Show("Lectura guardada en base de datos");
                    }
                    else
                    {
                        MessageBox.Show("Lectura no guardada en base de datos");
                    }
                }
                tbAyudaCodEPC.Text = "";
            }
            catch
            {
                MessageBox.Show("Error de conexión con el web service o de tipo de datos ingresados");
            }
        }
        //con Timer
        private async void button1_Click_3(object sender, EventArgs e)
        {
            if (tbIDEvento.Text.Equals(""))
            {
                MessageBox.Show("Llenar el campo ID Evento");
                return;
            }

            if (tbIDDestino.Text.Equals(""))
            {
                MessageBox.Show("Llenar el  campo ID Destino");
                return;
            }
            if (tbDormirLectura.Text.Equals(""))
            {
                MessageBox.Show("Llenar el  campo Dormir Lectura");
                return;
            }
            lblTimer.Text = "Timer activado";
            await Task.Run(() => loop());

        }

        private void loop()
        {
            switch (lblTimer.Text)
            {
                case "Timer activado":
                    Button.CheckForIllegalCrossThreadCalls = false;
                    do
                    {
                        tbAyudaCodEPC.Text = myReader.ReadEPC(false, ",");
                        idEvento = tbIDEvento.Text;
                        idDestino = tbIDDestino.Text;
                        if (lblTimer.Text == "Timer desactivado")
                            return;
                        if (tbAyudaCodEPC.Text != "No tags found")
                        {
                            AutoClosingMessageBox.Show("EPC leido", "Mensaje", 1000);
                        }
                        else
                        {
                            AutoClosingMessageBox.Show("EPC no leido volviendo a leer", "Mensaje", 1000);
                        }
                        string textolbl = lblTimer.Text;
                    } while (tbAyudaCodEPC.Text == "No tags found");

                    try
                    {
                        string url = "http://52.43.37.169:8080/eventos/rest/dongle/leer/" + tbAyudaCodEPC.Text + "/" + idEvento + "/" + idDestino;
                        Label.CheckForIllegalCrossThreadCalls = false;
                        lblURL.Text = url;
                        using (WebClient wc = new WebClient())
                        {
                            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                            string HtmlResult = wc.UploadString(url, "");
                            if (HtmlResult.Equals("{\"estado\":1}"))
                            {
                                AutoClosingMessageBox.Show("Lectura guardada en base de datos", "Mensaje", 1000);
                                try
                                {
                                    Thread.Sleep(int.Parse(tbDormirLectura.Text) * 1000);
                                }
                                catch
                                {
                                    MessageBox.Show("Ingresar un valor valido en dormir lectura");
                                }
                                loop();
                            }
                            else
                            {
                                AutoClosingMessageBox.Show("Lectura  no guardada en base de datos", "Mensaje", 1000);
                                loop();
                            }
                        }
                        tbAyudaCodEPC.Text = "";
                    }
                    catch (Exception ex)
                    {
                        Button.CheckForIllegalCrossThreadCalls = false;
                        AutoClosingMessageBox.Show("Error de conexión con el web service o de tipo de datos ingresados" + ex, "Mensaje", 2000);
                        loop();
                    }
                    break;
                case "Timer desactivado":
                    break;
            }
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            lblTimer.Text = "Timer desactivado";
        }

        #region Leer Speedway y mandar a base de datos
        private void btnLecSpeedway_Click_1(object sender, EventArgs e)
        {

            Settings settings;
            if (tbEventoSW.Text == "")
            {
                MessageBox.Show("Agregar el ID del evento");
                return;
            }
            // reader.Start();
            try
            {
                
                settings = reader.QuerySettings();
                settings.Antennas.GetAntenna(1).IsEnabled = true;
                settings.Antennas.GetAntenna(2).IsEnabled = true;
                settings.Antennas.GetAntenna(3).IsEnabled = true;
                settings.Antennas.GetAntenna(4).IsEnabled = true;
            }
            catch
            {
                reader.ApplyDefaultSettings();
                settings = reader.QuerySettings();
            }
            settings.Report.Mode = ReportMode.BatchAfterStop;

            settings.AutoStart.Mode = AutoStartMode.Periodic;
            settings.AutoStart.PeriodInMs = 3000;
            settings.AutoStop.Mode = AutoStopMode.Duration;
            settings.AutoStop.DurationInMs = 1500;
            settings.Report.IncludeAntennaPortNumber = true;
            
            //settings.Antennas[1].RxSensitivityInDbm=10;
            reader.ApplySettings(settings);

            reader.TagsReported += OnTagsReported10;
            //reader.ResumeEventsAndReports();
            reader.Start();
            //reader.Stop();
            // mostrarElementos();


        }
        public void OnTagsReported10(ImpinjReader sender, TagReport report)
        {
            // This event handler is called asynchronously 
            // when tag reports are available.
            // Loop through each tag in the report 
            // and print the data.
            //reader.TagsReported -= OnTagsReported10;

            foreach (Tag tag in report)
            {
                ListBox.CheckForIllegalCrossThreadCalls = false;
                lbSpeedway.Items.Add("Antena: " + tag.AntennaPortNumber + " Tag: " + tag.Epc.ToString());
                try
                {
                    WebRequest req = WebRequest.Create(@"http://52.43.37.169:8080/eventos/rest/r420/leer/" + Regex.Replace(tag.Epc.ToString(), @"\s+", "") + "/" + tbEventoSW.Text);
                    req.Method = "POST";
                    req.Timeout = 5000;
                    HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
                    req.Abort();
                }
                catch
                {
                    AutoClosingMessageBox.Show("Tag : " + tag.Epc + " no enviado", "Mensaje", 1000);
                    // System.Diagnostics.Debug.WriteLine("Tag : " + tag.Epc + " no enviado");
                }
            }
        }



        private void btnGrabarSpeedway_Click(object sender, EventArgs e)
        {
            reader.TagsReported -= OnTagsReported10;
        }
        #endregion

        private void sdf(object sender, EventArgs e)
        {

        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            lbSpeedway.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings settings;
            // reader.Start();
            try
            {
                settings = reader.QuerySettings();
            }
            catch
            {
                reader.ApplyDefaultSettings();
                settings = reader.QuerySettings();
            }
            //settings.Report.Mode = ReportMode.BatchAfterStop;
            //settings.AutoStart.Mode = AutoStartMode.Periodic;
            //settings.AutoStart.PeriodInMs = 3000;
            //settings.AutoStop.Mode = AutoStopMode.Duration;
            //settings.AutoStop.DurationInMs = 1500;
            //settings.Report.IncludeAntennaPortNumber = true;
            //settings.Antennas[1].RxSensitivityInDbm=10;
            reader.ApplySettings(settings);

            reader.TagsReported += OnTagsReported7;
            //reader.ResumeEventsAndReports();
            reader.Start();
        }
        #region Grabar EPC Speedway



        private void button2_Click_2(object sender, EventArgs e)
        {
            Settings settings;
            try
            {
                settings = reader.QuerySettings();
            }
            catch
            {
                reader.ApplyDefaultSettings();
                settings = reader.QuerySettings();
            }
            try
            {
                // Assign the TagsReported event handler.
                // This specifies which method to call
                // when tags reports are available.
                reader.TagsReported += OnTagsReported8;
                // Assign the TagOpComplete event handler.
                // This specifies which method to call
                // when tag operations are complete.
                reader.TagOpComplete += OnTagOpComplete8;

                // Get the default settings
                // We'll use these as a starting point
                // and then modify the settings we're 
                // interested in.
                settings = reader.QuerySettings();

                // Tell the reader to include the Protocol Control 
                // bits in all tag reports. We will need to modify 
                // the PC bits if we change the length of the EPC. 
                settings.Report.IncludePcBits = true;

                // Enable antenna #1. Disable all others.
                settings.Antennas.DisableAll();
                settings.Antennas.GetAntenna(1).IsEnabled = true;

                // Apply the newly modified settings.
                reader.ApplySettings(settings);
                reader.Start();

            }
            catch (Exception eexc)
            {
                // Handle Octane SDK errors.
                MessageBox.Show("Error con la escritura" + eexc);
            }
        }
        public void OnTagsReported8(ImpinjReader sender, TagReport report)
        {
            // We've read the tag we want write to, so
            // we're not interested in tag reports any more.
            // Unsubscribe from the event.
            reader.TagsReported -= OnTagsReported8;

            // Change the EPC of the first tag we read to a random value.
            Tag tag = report.Tags[0];
            TextBox.CheckForIllegalCrossThreadCalls = false;
            string nuevoEPC = tbNEPCSpeedway.Text;
            ProgramEpc(tag.Epc.ToHexString(), tag.PcBits, nuevoEPC);
            button4.PerformClick();

        }
        public void OnTagsReported7(ImpinjReader sender, TagReport report)
        {
            // We've read the tag we want write to, so
            // we're not interested in tag reports any more.
            // Unsubscribe from the event.
            reader.TagsReported -= OnTagsReported7;

            // Change the EPC of the first tag we read to a random value.
            Tag tag = report.Tags[0];
            TextBox.CheckForIllegalCrossThreadCalls = false;
            //string nuevoEPC = tbNEPCSpeedway.Text;
            tbEPCSpeedway.Text = tag.Epc.ToHexString();
            //ProgramEpc(tag.Epc.ToHexString(), tag.PcBits, nuevoEPC);
            //MessageBox.Show("El nuevo tag es:" + tag.Epc.ToHexString());
            try
            {
                if (cbIncSpeedway.Checked == true)
                {
                    tbNEPCSpeedway.Text = (Int64.Parse(tbEPCSpeedway.Text) + Int64.Parse(nuSpeedway.Value.ToString())).ToString().PadLeft(24, '0');
                }
                else {
                    tbNEPCSpeedway.Text = tag.Epc.ToHexString();
                }
            }
            catch
            {

            }
        }
        static void ProgramEpc(string currentEpc, ushort currentPcBits, string newEpc)
        {
            try
            {
                // Check that the specified EPCs are a valid length
                if (newEpc.Length % 4 != 0)
                {
                    MessageBox.Show("El nuevo EPC debe ser multiplo de 4");
                    return;
                }

                // Create a tag operation sequence.
                // You can add multiple read, write, lock, kill and QT
                // operations to this sequence.
                TagOpSequence seq = new TagOpSequence();

                // Specify a target tag based on the EPC.
                seq.TargetTag.MemoryBank = MemoryBank.Epc;
                seq.TargetTag.BitPointer = BitPointers.Epc;
                seq.TargetTag.Data = currentEpc;

                // If you are using Monza 4, Monza 5 or Monza X tag chips,
                // uncomment these two lines. This enables 32-bit block writes
                // which significantly improves write performance.
                //seq.BlockWriteEnabled = true;
                //seq.BlockWriteWordCount = 2;

                // Create a tag write operation to change the EPC.
                TagWriteOp writeEpc = new TagWriteOp();
                // Set an ID so we can tell when this operation has executed.
                writeEpc.Id = EPC_OP_ID;
                // Write to EPC memory
                writeEpc.MemoryBank = MemoryBank.Epc;
                // Specify the new EPC data
                writeEpc.Data = TagData.FromHexString(newEpc);
                // Starting writing at word 2 (word 0 = CRC, word 1 = PC bits)
                writeEpc.WordPointer = WordPointers.Epc;

                // Add this tag write op to the tag operation sequence.
                seq.Ops.Add(writeEpc);

                // Is the new EPC a different length than the current EPC?
                if (currentEpc.Length != newEpc.Length)
                {
                    // We need adjust the PC bits and write them back to the 
                    // tag because the length of the EPC has changed.

                    // Adjust the PC bits (4 hex characters per word).
                    ushort newEpcLenWords = (ushort)(newEpc.Length / 4);
                    ushort newPcBits = PcBits.AdjustPcBits(currentPcBits, newEpcLenWords);

                    TagWriteOp writePc = new TagWriteOp();
                    writePc.Id = PC_BITS_OP_ID;
                    // The PC bits are in the EPC memory bank.
                    writePc.MemoryBank = MemoryBank.Epc;
                    // Specify the data to write (the modified PC bits).
                    writePc.Data = TagData.FromWord(newPcBits);
                    // Start writing at the start of the PC bits.
                    writePc.WordPointer = WordPointers.PcBits;

                    // Add this tag write op to the tag operation sequence.
                    seq.Ops.Add(writePc);
                }

                // Add the tag operation sequence to the reader.
                // The reader supports multiple sequences.
                reader.AddOpSequence(seq);
                MessageBox.Show("EPC escrito");
            }
            catch
            {
                MessageBox.Show("Error al grabar");
                return;
            }
        }
        static void OnTagOpComplete8(ImpinjReader reader, TagOpReport report)
        {
            //// Loop through all the completed tag operations.
            //foreach (TagOpResult result in report)
            //{
            //    // Was this completed operation a tag write operation?
            //    if (result is TagWriteOpResult)
            //    {
            //        // Cast it to the correct type.
            //        TagWriteOpResult writeResult = result as TagWriteOpResult;
            //        if (writeResult.OpId == EPC_OP_ID)
            //            Console.WriteLine("Write to EPC complete : {0}", writeResult.Result);
            //        else if (writeResult.OpId == PC_BITS_OP_ID)
            //            Console.WriteLine("Write to PC bits complete : {0}", writeResult.Result);

            //        // Print out the number of words written
            //        Console.WriteLine("Number of words written : {0}", writeResult.NumWordsWritten);
            //    }
            //}
        }


        #endregion

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void nudEPCSpeedway_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cbIncSpeedway_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbIncSpeedway.Checked == true)
                {
                    tbNEPCSpeedway.Text = (Int64.Parse(tbEPCSpeedway.Text) + Int64.Parse(nuSpeedway.Value.ToString())).ToString().PadLeft(24, '0');
                    nuSpeedway.Visible = true;
                }
                else
                {
                    tbNEPCSpeedway.Text = tbEPCSpeedway.Text;
                    nuSpeedway.Visible = false;
                }
            }
            catch
            {
                if (cbIncSpeedway.Checked == true)
                {
                    tbNEPCSpeedway.Text = "0";
                    nuSpeedway.Visible = true;
                }
                else
                {
                    tbNEPCSpeedway.Text = tbEPCSpeedway.Text;
                    nuSpeedway.Visible = false;
                }

            }
        }

        private void nuSpeedway_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 valNEPC = Int64.Parse(tbEPCSpeedway.Text) + Int64.Parse(nuSpeedway.Value.ToString());
                tbNEPCSpeedway.Text = valNEPC.ToString().PadLeft(24, '0');
            }
            catch
            {
                MessageBox.Show("Número del EPC en un formato no aceptado");
            }
        }
    }
}
