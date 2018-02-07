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
        MySqlDataAdapter ad;
        public static string user, password;
        private void btnACCEDER_Click(object sender, EventArgs e)
        {
           con= new MySqlConnection( "server=127.0.0.1;database=integradora2;user=root;password=siqueirosuth19");
            con.Open();
            string query = "SELECT * FROM users WHERE email_users='"+txtUSUARIO.Text+"' AND password_users=md5('"+txtPASSWORD.Text+"'); ";
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
                        this.Hide();
                        new frmAdministrador().ShowDialog();
                        this.Show();
                    }
                }
            }           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
