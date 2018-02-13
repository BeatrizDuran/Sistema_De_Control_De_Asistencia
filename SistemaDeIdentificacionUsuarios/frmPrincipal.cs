using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeIdentificacionUsuarios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public static frmPrincipal _instance;
        public frmPrincipal instance
        {
            get
            {
                if (frmPrincipal._instance == null)
                {
                    frmPrincipal._instance = new frmPrincipal();
                }
                return frmPrincipal._instance;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e) => new frmLogin().ShowDialog();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHORA.Text = DateTime.Now.ToLongTimeString();
            lblFECHA.Text = DateTime.Now.ToLongDateString();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblHORA.Text = DateTime.Now.ToLongTimeString();
            lblFECHA.Text = DateTime.Now.ToLongDateString();
        }
    }
}
