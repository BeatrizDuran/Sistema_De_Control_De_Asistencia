using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace SistemaDeIdentificacionUsuarios
{
    public partial class frmFOTITO : Form
    {
        public frmFOTITO()
        {
            InitializeComponent();
        }
        private bool deviceExist = false;
        private FilterInfoCollection filter;
        private VideoCaptureDevice video = null;
        private VideoCapabilities capabilities;
      
        //Listar las cámaras que reconoce el programa
        private void ListarCamaras()
        {
            try
            {
                filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cmbCAMARA.Items.Clear();
                if (filter.Count==0)
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
            if (!(video==null))
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
                pcbFOTO.BackgroundImage.Save(@"C:\Users\BeatrizDuran\Desktop\prueba.jpeg", ImageFormat.Jpeg);
            }
            catch (Exception)
            {
                throw;
            }
        }
       
       

        private void CargarVideo(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap) eventArgs.Frame.Clone();
            pcbFOTO.BackgroundImage = img;
        }
        private void frmFOTITO_Load(object sender, EventArgs e) => ListarCamaras();
        private void frmFOTITO_FormClosed(object sender, FormClosedEventArgs e) => CerrarVideo();
        private void btnINICIAR_Click(object sender, EventArgs e) => btnINICIARmet();
        private void btnCAPTURAR_Click(object sender, EventArgs e) => CapturarFoto();
        private void btnSALIR_Click(object sender, EventArgs e) => this.Close();
    }
}
