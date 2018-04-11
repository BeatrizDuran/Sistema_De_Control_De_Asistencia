using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neurotec.Biometrics;
using DPFP;
using System.IO;
using MySql.Data.MySqlClient;
using SistemaDeIdentificacionUsuarios.RecursosReutilizables;


namespace SistemaDeIdentificacionUsuarios
{
    public partial class Registro_de_huella : Form, DPFP.Capture.EventHandler {
        public Registro_de_huella()
        {
            InitializeComponent();
        }
        // Variables Globales, requeridas por el SDK
        MySqlConnection con = new MySqlConnection("server=localhost;password=siqueirosuth19;database=prueba");
        public delegate void OnTemplateEventHandler(DPFP.Template template);
        public static Image foto;
        public event OnTemplateEventHandler OnTemplate;
        private DPFP.Processing.Enrollment Enroller;
        public static Registro_de_huella _instance;
        public Registro_de_huella instance
        {
            get
            {
                if (Registro_de_huella._instance == null)
                {
                    Registro_de_huella._instance = new Registro_de_huella();
                }
                return Registro_de_huella._instance;
            }
        }

        // Variable Global donde se almacena la huella escaneada. "Template" es una clase del SDK
        public Template plantilla;

        // Permitir arrastrar la ventana desde cualquier parte del formulario donde se haga Click.
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void CambioIdioma()
        {
            btnREGISTRAR.Text = Idioma.btnREGISTRAR;
            btnVERIFICAR.Text = Idioma.btnVERIFICAR;
            lblTITULODACTILAR.Text = Idioma.lblTITULODACTILAR;
        }

        // Inicializar proceso de captura
        private void InicializarCaptura()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Crea la operacion de captura
                this.OnTemplate += CaptureForm_OnTemplate;

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Suscribe los eventos de captura.
                else
                    SetPrompt("Can't initiate capture operation!");
                
            }
            catch
            {
                //MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected virtual void Init()
        {
            InicializarCaptura();
            Enroller = new DPFP.Processing.Enrollment();			// Crea un registro
            UpdateStatus();
        }
        //Donde se convierte la huella y luego la muestra en el pictureBox.
        void CaptureForm_OnTemplate(DPFP.Template template)
        {
            // Este evento es llamado automaticamente por el SDK una vez que se escanea la huella 4 veces.
            // Y nos envia la "template" por parametro, que usamos para convertir a binario y subir al a base de datos.

            // Invoke es necesario siempre que queramos hacer cambios a objetos/elementos de nuestro formulario
            // esto se debe a que el proceso de Captura del escaner se realiza en un proceso por separado.

            if (success == true)
            {
                //MessageBox.Show("Huella escaneada satisfactoriamente!", "Escanéo satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //btnRegistrarVisitante.Invoke(new MethodInvoker(delegate { btnRegistrarVisitante.Enabled = true; }));
                btnREGISTRAR.Invoke(new MethodInvoker(delegate { btnREGISTRAR.Enabled = true; }));
                lblEstatus.Invoke(new MethodInvoker(delegate { lblEstatus.Text = "Escaneo Satisfactorio"; }));
              
            }

            this.Invoke(new MethodInvoker(delegate {
                // Si todo sale bien, la variable global "plantilla" se coloca como la plantilla generada por el escaner
                try
                {
                    plantilla = template;
                }
                catch (Exception ex) { }
            }));
         
        }
        protected virtual void ProcesarMuestra(DPFP.Sample Sample)
        {
            // Este evento es llamado automaticamente por el SDK cada que se pase el dedo por el escaner
            // En total, se manda a llamar 4 veces, las 4 veces requeridas por el SDK para generar el template.

            // Convierte la muestra "Sample" a imagen, y la muestra en el picturebox. (Esta es la imagen de la huella como tal)
            DrawPicture(ConvertSampleToBitmap(Sample));
        }
        protected void Start()
        {
            // Inicia la captura de la huella digital
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    SetPrompt("Can't initiate capture!");
                }
            }
        }
        protected void Stop()
        {
            // Detiene la captura de la huella digital
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Can't terminate capture!");
                }
            }
        }
        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("The fingerprint sample was captured.");
            SetPrompt("Scan the same fingerprint again.");
            Process(Sample);
        }
        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }
        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
           // MessageBox.Show("El dispositivo fue tocado.");
        }
        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");
        }
        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
        }

        // Convierte el Sample a imagen y la devuelve.
        // Esto permite mostrarla en el Picturebox
        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();	// Create a sample convertor.
            Bitmap bitmap = null;					                                        							            // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                                       // TODO: return bitmap as a result
            return bitmap;
        }

        // Este método es propia del SDK, obtiene ciertos puntos clave de la huella digital que la convierte en unica
        // y genera algo llamado "Features" o "Caracteristicas", con ellas se hace la comparativa con otras huellas.
        protected FeatureSet ExtractFeatures(Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();	// Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            FeatureSet features = new FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);			// TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        // Todos estos métodos venian incluidos en el SDK, los deje por si requieren ejemplos
        // de como acceder a elementos de nuestro formulario, desde el proceso externo de captura.
        protected void SetStatus(string status)
        {
            StatusLine.Invoke(new MethodInvoker(delegate { StatusLine.Text = status; }));
        }
        protected void SetPrompt(string prompt)
        {
            lblEstatus.Invoke(new MethodInvoker(delegate { lblEstatus.Text = prompt; }));
        }
        protected void MakeReport(string message)
        {
            StatusText.Invoke(new MethodInvoker(delegate { StatusText.Text=(message + "\r\n"); }));
        }
        private void DrawPicture(Bitmap bitmap)
        {
           pcbHUELLA.Invoke(new MethodInvoker(delegate { pcbHUELLA.Image = new Bitmap(bitmap, pcbHUELLA.Size); }));
        }
        private DPFP.Capture.Capture Capturer;
        private void UpdateStatus()
        {
            // Show number of samples needed.
            SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
        }
        bool success = false;
        protected void Process(DPFP.Sample Sample)
        {
            ProcesarMuestra(Sample);

            // Este método es usado por el SDK para ir generando una plantilla completa, a partir de las 4 muestras que
            // pide, y va obteniendo sus "features"
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);         
            // Se verifica que la calidad de la muestra sea buena
            if (features != null) try
                {
                    MakeReport("The fingerprint feature set was created.");
                    Enroller.AddFeatures(features);		// Add feature set to template.
                    pbMuestras.Invoke(new MethodInvoker(delegate { pbMuestras.Value += 25; }));
                    success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado, por favor vuelva a intentarlo.", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // lblEstatus.Invoke(new MethodInvoker(delegate { lblEstatus.Text = "Error, vuelva a escanear"; }));
                    success = false;
                    pbMuestras.Invoke(new MethodInvoker(delegate { pbMuestras.Value = 0; }));
                    return;
                }
                finally
                {
                    UpdateStatus();

                    // Verificar que la plantilla haya sido creada con exito
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:	// report success and stop capturing
                            OnTemplate(Enroller.Template);
                            //SetPrompt("Click Close, and then click Fingerprint Verification.");
                            Stop();
                            success = true;
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed:	// report failure and restart capturing
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            OnTemplate(null);
                            Start();
                            success = false;
                            break;
                    }
                }
        }

        private void btnVERIFICAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aun no funciona");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdministrador admin = new frmAdministrador();
            admin.ShowDialog();
        }

        private void Registro_de_huella_Load(object sender, EventArgs e)
        {
            Init();
            Start();
            CambioIdioma();
        }
        private void btnREGISTRAR_Click(object sender, EventArgs e)
        {
            MemoryStream fingerprintData = new MemoryStream();
            Enroller.Template.Serialize(fingerprintData);
            fingerprintData.Position = 0;
            // Leemos todos sus bytes
            BinaryReader br = new BinaryReader(fingerprintData);
            Byte[] bytes = br.ReadBytes((Int32)fingerprintData.Length);
            //Desplegamos en pantalla por medio de un mensaje todo lo que representa la huella dactilar(hash)
            //En una serie de bytes.
            StreamWriter fs = File.CreateText(@"C:\Escritorio\codigoHuella.txt");
                fs.WriteLine(string.Join(" ", bytes));
           // MessageBox.Show(string.Join(" ", bytes));
        }
    }
}
