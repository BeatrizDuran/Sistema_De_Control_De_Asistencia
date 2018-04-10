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
using libConnection;
using MySql.Data.MySqlClient;
using SistemaDeIdentificacionUsuarios.RecursosReutilizables;
using System.Threading;
using System.Globalization;

namespace SistemaDeIdentificacionUsuarios
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }
        #region Declaración de variables
        //Conexión a Mysql
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=integradora2;user=root;password=siqueirosuth19");
        MySqlDataReader lector;
        MySqlCommand com;
        string rutaFace;
        string rutaFinger;
        public static Image huellita;
        public static PictureBox pic;

        #endregion

        Registro_de_huella huella = new Registro_de_huella();

        #region Método singleton
        // Variable la cual se utiliza en el método de frmAdministrador instance.
        public static frmAdministrador _instance;
        
        //Este método permite no abrir más de una vez la ventana.
        public frmAdministrador instance
        {
            get
            {
                if (frmAdministrador._instance == null)
                {
                    frmAdministrador._instance = new frmAdministrador();
                }
                return frmAdministrador._instance;
            }
        }
        #endregion

        //Métodos que realizan las operaciones básicas para registrar a los usuarios, realizar modificaciones
        //como eliminaciones y consultas.
        private void limpiar()
        {
            txtAPELLIDO1.Clear();
            txtAPELLIDO2.Clear();
            txtCONPASSWORD.Clear();
            txtEMAIL.Clear();
            txtNOMBRE.Clear();
            txtPASSWORD.Clear();
            cmbTIPOUSUARIO.Items.Clear();
            pcbIMAGEFACE.Image = Image.FromFile("C:/Users/BeatrizDuran/Pictures/user.png");
            pcbIMAGEFINGER.Image = Image.FromFile("C:/Users/BeatrizDuran/Pictures/huellita.png");
        }
        private void eliminar()
        {
            con.Open();
            string query = "DELETE FROM users WHERE id_users='" + lblID.Text + "';";
            com = new MySqlCommand(query, con);
            lector = com.ExecuteReader();
            con.Close();
        }
        private void modificar()
        {
            con.Open();
            rutaFace = rutaFace.Replace(@"\", @"\\");
            rutaFinger = rutaFinger.Replace(@"\", @"\\");
            string query = "UPDATE users SET name_users='" + txtNOMBRE.Text + "'" +
                "OR lastname1_users='" + txtAPELLIDO1.Text + "'" +
                "OR lastname2_users='" + txtAPELLIDO2.Text + "'" +
                "OR email_users='" + txtEMAIL.Text + "'" +
                "OR password_users='" + txtPASSWORD.Text + "'" +
                "OR type_users='" + cmbTIPOUSUARIO.Text + "'" +
                "OR image_face_users='" + rutaFace + "'" +
                "OR image_finger_users='" + rutaFinger + "';";
            com = new MySqlCommand(query, con);
            lector = com.ExecuteReader();
            con.Close();
        }
        private void cargar()
        {
            try
            {
                //huella.plantilla = pcbIMAGEFINGER.Image;
                //pcbIMAGEFACE.Image = pic;
                dgvAdmin.Rows.Clear();
                con.Open();
                string query = "SELECT * FROM users";
                com = new MySqlCommand(query, con);
                lector = com.ExecuteReader();
                while (lector.Read())
                {
                    dgvAdmin.Rows.Add(lector.GetString(0), lector.GetString(1), lector.GetString(2),
                       lector.GetString(3), lector.GetString(4),
                       lector.GetString(5), lector.GetString(6),
                       Image.FromFile(lector.GetString(7)),Image.FromFile(lector.GetString(8)));
                }
                    con.Close();
                // pcbIMAGEFACE.Image = frmFOTITO.foto = Image.FromFile(@"C:\Users\BeatrizDuran\Bibliotecas\Documentos\ImagenRostro\Rostro.jpeg");         
                CambioIdioma();
            }
            catch (MySqlException errorcito)
            {
                MessageBox.Show(errorcito.ToString());
            }
           }
        private void consultar()
        {
            con.Open();
            rutaFace = rutaFace.Replace(@"\", @"\\");
            rutaFinger = rutaFinger.Replace(@"\", @"\\");
            string query = "SELECT FROM users WHERE name_users='" + txtNOMBRE.Text + "'" +
                "OR lastname1_users='" + txtAPELLIDO1.Text + "'" +
                "OR lastname2_users='" + txtAPELLIDO2.Text + "'" +
                "OR email_users='" + txtEMAIL.Text + "'" +
                "OR password_users='" + txtPASSWORD.Text + "'" +
                "OR type_users='" + cmbTIPOUSUARIO.Text + "'" +
                "OR image_face_users='" + rutaFace + "'" +
                "OR image_finger_users='" + rutaFinger + "';";
            com = new MySqlCommand(query, con);
            lector = com.ExecuteReader();
            con.Close();
        }

        private void CambioIdioma()
        {
            tsbAGREGAR.Text = Idioma.tsbAGREGAR;
            tsbMODIFICAR.Text = Idioma.tsbMODIFICAR;
            tsbELIMINAR.Text = Idioma.tsbELIMINAR;
            tsbCONSULTAR.Text = Idioma.tsbCONSULTAR;
            tsbLIMPIAR.Text = Idioma.tsbLIMPIAR;
            tsbIDIOMA.Text = Idioma.tsbIDIOMA;
            tsmESPANISH.Text = Idioma.tsmESPANISH;
            tsmINGLES.Text = Idioma.tsmINGLES;
            tsbACERCADE.Text = Idioma.tsbACERCADE;
            tsbSALIR.Text = Idioma.tsbSALIR;
            lblNAME.Text = Idioma.lblNAME;
            lblPRIMERAPELLIDO.Text = Idioma.lblPRIMERAPELLIDO;
            lblSEGUNDOAPELLIDO.Text = Idioma.lblSEGUNDOAPELLIDO;
            lblCORREO.Text = Idioma.lblCORREO;
            lblTIPOUSUARIO.Text = Idioma.lblTIPOUSUARIO;
            lblUSUARIO.Text = Idioma.lblUSUARIO;
            lblPASSORIGINAL.Text = Idioma.lblPASSORIGINAL;
            lblCONFIRMARPASS.Text = Idioma.lblCONFIRMARPASS;
            lblPASSWORD.Text = Idioma.lblPASSWORD;    
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {                
           
                if (txtNOMBRE.Text.Trim() == " " || txtAPELLIDO1.Text.Trim() == " " ||
                    txtAPELLIDO2.Text.Trim() == " " || txtEMAIL.Text.Trim() == " " ||
                    txtPASSWORD.Text.Trim() == " " || txtCONPASSWORD.Text.Trim() == " " ||
                    cmbTIPOUSUARIO.Text.Trim()=="")
                {
                    MessageBox.Show("Algún campo se encuentra vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNOMBRE.Focus();
                }
                else
                {
                    if (txtPASSWORD.Text == txtCONPASSWORD.Text)
                    {
                        con.Open();
                        rutaFace = rutaFace.Replace(@"\", @"\\");
                        rutaFinger = rutaFinger.Replace(@"\", @"\\");
                        string query = "INSERT INTO users (name_users,lastname1_users,lastname2_users," +
                            "email_users,password_users,type_users,image_face_users,image_finger_users" +
                            ") VALUES ('" + txtNOMBRE.Text + "','" + txtAPELLIDO1.Text + "','" + txtAPELLIDO2.Text + "','" + txtEMAIL.Text + "'" +
                            ",md5('" + txtPASSWORD.Text + "'),'" + cmbTIPOUSUARIO.Text + "','" + rutaFace + "','" + rutaFinger + "'); ";
                        com = new MySqlCommand(query, con);
                        lector = com.ExecuteReader();
                        con.Close();
                        frmAdministrador_Load(sender, e);
                        limpiar();
                    }
                    else
                    {
                        lblPASSWORD.Text = "Contraseña incorrecta";
                       System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
                        t.Interval = 1000;
                        t.Tick += (s, a) => {
                            ((System.Windows.Forms.Timer)s).Stop();
                            lblPASSWORD.Text = "";

                        };

                        t.Start();
                    }
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void pcbIMAGEFACE_Click(object sender, EventArgs e)
        {
            new frmFOTITO().ShowDialog(); //A tomar foto
                pcbIMAGEFACE.Image = pic.Image; //si viene fotografia se pone
           // catch (NullReferenceException) //en caso de cancelada la captura recargo la imagen
           // {
             //   pic.Image = Image.FromFile(@"C:\Users\BeatrizDuran\Bibliotecas\Imagenes\user.png");
           // }
            //frmFOTITO a = new frmFOTITO();
            //a.instance.Show();
            //this.Hide();
        }
        private void pcbIMAGEFINGER_Click(object sender, EventArgs e)
        {
          Registro_de_huella r =  new Registro_de_huella();
            r.instance.Show();
            this.Hide();
        }
        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                lblID.Text = dgvAdmin[0, e.RowIndex].Value.ToString();
                txtNOMBRE.Text = dgvAdmin[1, e.RowIndex].Value.ToString();
                txtAPELLIDO1.Text = dgvAdmin[2, e.RowIndex].Value.ToString();
                txtAPELLIDO2.Text = dgvAdmin[3, e.RowIndex].Value.ToString();
                txtEMAIL.Text = dgvAdmin[4, e.RowIndex].Value.ToString();
                cmbTIPOUSUARIO.Text = dgvAdmin[6, e.RowIndex].Value.ToString();
                try { 
                    pcbIMAGEFACE.Image =Image.FromFile(dgvAdmin[7, e.RowIndex].Value.ToString());
                    pcbIMAGEFINGER.Image = Image.FromFile(dgvAdmin[8, e.RowIndex].Value.ToString());
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
            }
        }
        private void frmAdministrador_Load(object sender, EventArgs e) => cargar();
        private void tsbSALIR_Click(object sender, EventArgs e) => this.Close();
        private void tsbMODIFICAR_Click(object sender, EventArgs e)
        {
            modificar();
            frmAdministrador_Load(sender, e);
        }
        private void tsbELIMINAR_Click(object sender, EventArgs e)
        {
             eliminar();
            frmAdministrador_Load(sender, e);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            limpiar();
            frmAdministrador_Load(sender, e);
        }
        private void tsbCONSULTAR_Click(object sender, EventArgs e) => consultar();

        private void tsbIDIOMA_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Thread.CurrentThread.CurrentUICulture = new
            //CultureInfo((string)tsmESPANISH.Checked.ToString());
           // CambioIdioma();
        }

        private void tsmESPANISH_Click(object sender, EventArgs e)
        {
            CambioIdioma();
        }
    }
}
