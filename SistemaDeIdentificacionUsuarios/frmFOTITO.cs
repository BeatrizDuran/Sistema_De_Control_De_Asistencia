using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace SistemaDeIdentificacionUsuarios
{
    public partial class frmFOTITO : Form
    {
        public frmFOTITO()
        {
            InitializeComponent();
        }
        public static Image foto;
        private bool deviceExist = false;
        private FilterInfoCollection filter;
        private VideoCaptureDevice video = null;
        public static frmFOTITO _instance;
        public frmFOTITO instance
        {
            get
            {
                if (frmFOTITO._instance == null)
                {
                    frmFOTITO._instance = new frmFOTITO();
                }
                return frmFOTITO._instance;
            }
        }
        string ruta= @"C:\Users\BeatrizDuran\Bibliotecas\Documentos\ImagenRostro\Rostro.jpeg";
        string rutita;
        //Listar las cámaras que reconoce el programa
        private void ListarCamaras()
        {
            try
            {
                filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cmbCAMARA.Items.Clear();
                if (filter.Count == 0)
                {
                    throw new ApplicationException();
                }
                deviceExist = true;
                foreach (FilterInfo camaras in filter)
                {
                    cmbCAMARA.Items.Add(camaras.Name);
                }
                cmbCAMARA.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                deviceExist = false;
                cmbCAMARA.Items.Add("Error no hay dispositivos");
            }
            cmbCAMARA.SelectedIndex = 0;
        }
        /// <summary>
        /// Cerrar el video después de haber capturado la imagen al cerrar la ventana
        /// </summary>
        private void CerrarVideo()
        {
            if (!(video == null))
            {
                if (video.IsRunning)
                {
                    video.SignalToStop();
                    video = null;
                }
            }
        }
        private void btnINICIARmet()
        {
            btnINICIAR.Enabled = false;
            if (btnINICIAR.Text == "Iniciar")
            {
                video = new VideoCaptureDevice(filter[cmbCAMARA.SelectedIndex].MonikerString);
                video.NewFrame += new NewFrameEventHandler(CargarVideo);
                //codigo para ajustar las dimensiones de  la cámara.....
                // capabilities.FrameSize = (800,600);

                CerrarVideo();
                video.Start();
                btnINICIAR.Text = "Iniciado";
                btnCAPTURAR.Enabled = true;
            }
            else
            {
                if (video.IsRunning)
                {
                    CerrarVideo();
                    btnINICIAR.Text = "Iniciar";
                }
            }
        }
        private void CapturarFoto()
        {
            try
            {
                if (File.Exists(ruta))
                    File.Delete(ruta);
                else
                //error con el path con las diagonales.
              pcbFOTO.BackgroundImage.Save(ruta, ImageFormat.Jpeg);
                //ruta = ruta.Replace(@"\\", @"\");
                new frmAdministrador(foto).ShowDialog();
            }
            catch (Exception error)
            {
                CerrarVideo();
                MessageBox.Show(error.ToString());
            }
        }

        private void CargarVideo(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pcbFOTO.BackgroundImage = img;
        }
        private void frmFOTITO_Load(object sender, EventArgs e)
        {
           // ListarCamaras();
            // Cargamos los dispositivos de video
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //// Y por cada dispositivo detectado, lo agregamos a un combobox (ahora ya no es visible para el usuario)
            foreach (FilterInfo Dispositivo in filter)
            {
                cmbCAMARA.Items.Add(Dispositivo.Name);
            }
            //// Seleccionamos el primer dispositivo
            cmbCAMARA.SelectedIndex = 0;
            //// Inicializamos el dispositivo
            video = new VideoCaptureDevice();

            //// Y creamos el handler para comenzar a hacer el stream de video
            try
            {
                video = new VideoCaptureDevice(filter[cmbCAMARA.SelectedIndex].MonikerString);
                video.NewFrame += FrameFinal_NewFrame;

                video.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmFOTITO_FormClosed(object sender, FormClosedEventArgs e) => CerrarVideo();
        private void btnINICIAR_Click(object sender, EventArgs e)
        {
            //btnINICIARmet();
            try
            {
                video = new VideoCaptureDevice(filter[cmbCAMARA.SelectedIndex].MonikerString);
                video.NewFrame += FrameFinal_NewFrame;
                video.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FrameFinal_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs) => pcbFOTO.Image = (Bitmap)eventArgs.Frame.Clone();
        private void btnCAPTURAR_Click(object sender, EventArgs e) => CapturarFoto();
        private void btnSALIR_Click(object sender, EventArgs e) => this.Close();
        private void btnMINI_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
    }
}
