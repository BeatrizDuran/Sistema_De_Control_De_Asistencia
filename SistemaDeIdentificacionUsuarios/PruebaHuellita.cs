using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neurotec.Biometrics;
using DPFP;
using System.IO;
using MySql.Data.MySqlClient;


namespace SistemaDeIdentificacionUsuarios
{
    public partial class PruebaHuellita : Form
    {
        public PruebaHuellita()
        {
            InitializeComponent();
        }
       
        
        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            // Me quede en lo del guardado de la huella dactilar... en la base de datos
            MySqlConnection con = new MySqlConnection("server=localhost;password=siqueirosuth19;database=Prueba;user=root");
            con.Open();
            MySqlCommand comd = new MySqlCommand("INSERT INTO DatosHuella(Nombre, Huella) VALUES (?,?)");
            comd.Parameters.AddWithValue("Nombre",txtNOMBRE.Text.ToString());
            
            comd.ExecuteNonQuery();
            comd.Dispose();
            con.Close();
        }

        private void PruebaHuellita_Load(object sender, EventArgs e)
        {
            //Init();
            //Start();
        }
    }
}
