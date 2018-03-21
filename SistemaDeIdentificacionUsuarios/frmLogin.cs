using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaDeIdentificacionUsuarios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        MySqlCommand com;
        MySqlConnection con;
        public static string user, password;
        public static Image foto;
        public static frmLogin _instance;
        public frmLogin instance
        {
            get
            {
                if (frmLogin._instance == null)
                {
                    frmLogin._instance = new frmLogin();
                }
                return frmLogin._instance;
            }
        }
        private void ACCEDER()
        {
            con = new MySqlConnection("server=127.0.0.1;database=integradora2;user=root;password=siqueirosuth19");
            con.Open();
            string query = "SELECT * FROM users WHERE email_users='" + txtUSUARIO.Text + "' AND password_users=md5('" + txtPASSWORD.Text + "'); ";
            com = new MySqlCommand(query, con);
            MySqlDataReader lector = com.ExecuteReader();
            if (!lector.HasRows)
                MessageBox.Show("Usuario o contraseña incorrectos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                while (lector.Read())
                {
                    user = lector.GetString(4);
                    password = lector.GetString(5);
                    if (lector.GetString(6) == "1")
                    {
                       frmAdministrador a= new frmAdministrador();
                        a.instance.Show();
                        this.Hide();
                    }
                }
            }

        }
        private void btnACCEDER_Click(object sender, EventArgs e) => ACCEDER();
        private void button1_Click(object sender, EventArgs e) => this.Close();
    }
}
