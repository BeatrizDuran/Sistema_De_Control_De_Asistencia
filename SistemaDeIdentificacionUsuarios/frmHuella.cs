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

namespace SistemaDeIdentificacionUsuarios
{
    public partial class Registro_de_huella : Form
    {
        Nffv _engine;
            public Registro_de_huella()
        {
           // _engine = engine;
           
            InitializeComponent();
        }
        internal class EnrollmentResult
        {
            public NffvStatus engineStatus;
            public NffvUser engineUser;
        };
        private void doEnroll(object sender, DoWorkEventArgs args)
        {
            EnrollmentResult enrollmentResults = new EnrollmentResult();
            enrollmentResults.engineUser = _engine.Enroll(20000, out enrollmentResults.engineStatus);
            args.Result = enrollmentResults;
        }

        private void btnVERIFICAR_Click(object sender, EventArgs e)
        {
            RunWorkerCompletedEventArgs taskResult = Cargando.RunLongTask("Esperando la huella ...", new DoWorkEventHandler(doEnroll),
                        false, null, new EventHandler(CancelScanningHandler));
            EnrollmentResult enrollmentResult = (EnrollmentResult)taskResult.Result;
        }
        private void CancelScanningHandler(object sender, EventArgs e)
        {
            _engine.Cancel();
        }
    }
}
