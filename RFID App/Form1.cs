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
       

        public Form1()
        {
            InitializeComponent();
            //Activamos el RFID como demo
            bool myResult = myReader.Activation("Demo");
            //Conectamos el RFID ME
            myReader.Connect("RFIDME");
            this.cbDispositivo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbBotonesLeerGrabar.DropDownStyle = ComboBoxStyle.DropDownList;
            this.KeyPreview = true;
            try
            {
                //Conectamos el Speedway
                reader.Connect(ReaderHostname);
                //Se aplican los valores por defecto al speedway
                reader.ApplyDefaultSettings();
                //Se inicia el speedway
                reader.Start();
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
            tbCodEPC.Text = "";
            tbCodEPC.Text = myReader.ReadEPC(false, ",");
            tbNuevoEPC.Text = "";
            tbNuevoEPC.Text = tbCodEPC.Text;
            b2IniciarLectura.FlatStyle = FlatStyle.Standard;
        }

        //Checkbox incremento para mostrar o esconder 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIncremento.Checked == true)
            {
                //tbNuevoEPC.Text = tbCodEPC.Text;
                nudEPC.Visible = true;
            }
            else
            {
                //tbNuevoEPC.Text = tbCodEPC.Text;
                nudEPC.Visible = false;
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
                        myReader.writeEPC(tbCodEPC.Text, "00000000", tbNuevoEPC.Text.PadLeft(24, '0'));
                        tbNuevoEPC.Text = sigEPC.ToString().PadLeft(24, '0');
                        MessageBox.Show("EPC guardado");
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
                        
                        // reader.Start();
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
                    }
                    catch
                    {
                        MessageBox.Show("Speedway no conectado");
                    }
                    #endregion
                    break;
                case "Detener Lectura Speedway":
                    reader.Stop();
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
            report.Tags.Clear();
        }



        #region Grabar EPC Speedway
        //Grabar EPC Speedway
        private void button1_Click_2(object sender, EventArgs e)
        {
            btnGrabarSpeedway.FlatStyle = FlatStyle.Flat;
            try
            {
                // Assign the TagsReported event handler.
                // This specifies which method to call
                // when tags reports are available.
                reader.TagsReported += OnTagsReported3;
                // Get the default settings
                // We'll use these as a starting point
                // and then modify the settings we're 
                // interested in.
                Settings settings = reader.QuerySettings();

                // Tell the reader to include the Protocol Control 
                // bits in all tag reports. We will need to modify 
                // the PC bits if we change the length of the EPC. 
                settings.Report.IncludePcBits = true;

                // Enable antenna #1. Disable all others.
                settings.Antennas.DisableAll();
                settings.Antennas.GetAntenna(1).IsEnabled = true;

                // Apply the newly modified settings.
                reader.ApplySettings(settings);

            }
            catch
            {
                // Handle Octane SDK errors.
                MessageBox.Show("Error con la escritura");
            }
            btnGrabarSpeedway.FlatStyle = FlatStyle.Standard;
        }
        public void OnTagsReported3(ImpinjReader sender, TagReport report)
        {
            // We've read the tag we want write to, so
            // we're not interested in tag reports any more.
            // Unsubscribe from the event.
            reader.TagsReported -= OnTagsReported3;

            // Change the EPC of the first tag we read to a random value.
            Tag tag = report.Tags[0];
            TextBox.CheckForIllegalCrossThreadCalls = false;
            string nuevoEPC = tbNuevoEPC.Text;
            ProgramEpc(tag.Epc.ToHexString(), tag.PcBits, nuevoEPC);
            MessageBox.Show("El nuevo tag es:" + tag.Epc.ToHexString());
        }


        static void ProgramEpc(string currentEpc, ushort currentPcBits, string newEpc)
        {
            try { 
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
        }
            catch {
                MessageBox.Show("Error al grabar");
                    return;
            }
        }
        #endregion


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
                reader.Start();
                Settings settings = reader.QueryDefaultSettings();
                reader.TagsReported += OnTagsReported4;
            }
            catch { }
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
            tbNuevoEPC.Text= tag.Epc.ToHexString();
            //ProgramEpc(tag.Epc.ToString(), tag.PcBits, tbNuevoEPC.Text);
        }
        private void btnEnvWS_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "http://52.43.37.169:8080/eventos/rest/dongle/leer/" + tbCodEPC.Text +"/"+ tbIDEvento.Text +"/"+ tbIDDestino.Text;
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    string HtmlResult = wc.UploadString(url, "");
                    if (HtmlResult.Equals("{\"estado\":1}"))
                    {
                        MessageBox.Show("Leectura guardada en base de datos");
                    }
                    else
                    {
                        MessageBox.Show("Lectura no guardada en base de datos");
                    }

                }
            }
            catch{
                MessageBox.Show("Error de conexión con el web service o de tipo de datos ingresados");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBotonesLeerGrabar.SelectedItem.Equals("Speedway"))
            {
                pBotonesRFIDME.Visible = false;
                pBotonesSpeedway.Visible = true;
            }
            else if (cbBotonesLeerGrabar.SelectedItem.Equals("RFID ME"))
            {
                pBotonesRFIDME.Visible = true;
                pBotonesSpeedway.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Desconectando el Speedway");
            reader.Stop();
            reader.Disconnect();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.O))
            {
                b2IniciarLectura.PerformClick();
            }
            else if (keyData == (Keys.P)){
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
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}