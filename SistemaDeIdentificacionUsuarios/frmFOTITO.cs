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
        #region Variables
        public static Image foto;
        private bool deviceExist = false;
        private FilterInfoCollection filter;
        private VideoCaptureDevice video = null;
        
       
        #endregion variables

        #region Singletón
        //Variable utilizada en el método del Singleton(frmFOTITO).
        public static frmFOTITO _instance;

        //Permite no abrir la ventana mas de una vez.
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
        #endregion Singletón

        #region Métodos de ejecucíón del programa
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
        // Cerrar el video después de haber capturado la imagen al cerrar la ventana.
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
        //Iniciar la cámara seleccionada en el comboBox.
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
        //Método el cuál permite la captura de la foto y valida si el campo de la imagen está en blanco.
        private void CapturarFoto()
        {
            if (pcbFOTO == null)
            {
                MessageBox.Show("No hay una imagen","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                   // frmAdministrador.pic = new PictureBox();
                    frmAdministrador.pic.Image = pcbFOTO.BackgroundImage;
                    this.Close();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.ToString());
                }
            }
        }
#endregion fin de los métodos

        private void CargarVideo(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pcbFOTO.BackgroundImage = img;
        }
        private void frmFOTITO_Load(object sender, EventArgs e)
        {
           ListarCamaras();
           // // Cargamos los dispositivos de video
           // filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);

           // //// Y por cada dispositivo detectado, lo agregamos a un combobox (ahora ya no es visible para el usuario)
           // foreach (FilterInfo Dispositivo in filter)
           // {
           //     cmbCAMARA.Items.Add(Dispositivo.Name);
           // }
           // //// Seleccionamos el primer dispositivo
           // cmbCAMARA.SelectedIndex = 0;
           // //// Inicializamos el dispositivo
           // video = new VideoCaptureDevice();

           // //// Y creamos el handler para comenzar a hacer el stream de video
           // try
           // {
           //     video = new VideoCaptureDevice(filter[cmbCAMARA.SelectedIndex].MonikerString);
           //     video.NewFrame += FrameFinal_NewFrame;

           //     video.Start();
           // }
           // catch (Exception ex)
           // {
           //     MessageBox.Show(ex.Message);
           // }
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
