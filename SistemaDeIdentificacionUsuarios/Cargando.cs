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
    public partial class Cargando : Form
    {
        public Cargando(string title, DoWorkEventHandler callback, bool reportsProgress, object args, EventHandler cancelHandler)
        {
            InitializeComponent();
            if (!reportsProgress)
                pgBCARGANDO.Style = ProgressBarStyle.Marquee;

            SetExecutionText(title);
            this.callback = callback;
            argument = args;
            _worker.WorkerReportsProgress = reportsProgress;
            _worker.DoWork += Cargando_DoWork;
            _worker.RunWorkerCompleted += Cargando_RunWorkerCompleted;
            _worker.ProgressChanged += Cargando_ProgressChanged;
            if (cancelHandler != null)
            {
                _worker.WorkerSupportsCancellation = true;
                btnCANCELAR.Click += cancelHandler;
                btnCANCELAR.Click += new EventHandler(PostOnCancelClick);
                btnCANCELAR.Enabled = true;
                btnCANCELAR.Visible = true;
            }
        }
        private DoWorkEventHandler callback;
        private object argument;
        private RunWorkerCompletedEventArgs results;
        private Exception error;
        protected BackgroundWorker _worker = new BackgroundWorker();
        private void Cargando_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (callback != null)
                {
                    callback(sender, e);
                }
            }
            catch (Exception ex)
            {
                error = ex;
            }
        }
        private void Cargando_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string text = e.UserState as string;
            if (text != null)
            {
                SetExecutionText(text);
            }

            SetExecutionValue(e.ProgressPercentage);
        }
        private void Cargando_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            results = e;
            Close();
        }
        public void SetExecutionText(string text)
        {
            try
            {
                if (lblCARGANDO.InvokeRequired)
                {
                    lblCARGANDO.Invoke((MethodInvoker)delegate ()
                    {
                        lblCARGANDO.Text = text;
                    });
                }
                else
                {
                    lblCARGANDO.Text = text;
                }
            }
            finally
            {
            }
        }
        public void SetExecutionValue(int value)
        {
            try
            {
                if (pgBCARGANDO.InvokeRequired)
                {
                    pgBCARGANDO.Invoke((MethodInvoker)delegate ()
                    {
                        pgBCARGANDO.Value = value;
                    });
                }
                else
                {
                    pgBCARGANDO.Value = value;
                }
            }
            finally
            {
            }
        }

        void PostOnCancelClick(object sender, EventArgs e)
        {
            btnCANCELAR.Enabled = false;
            btnCANCELAR.Refresh();
        }
        public static RunWorkerCompletedEventArgs RunLongTask(string title, DoWorkEventHandler callback)
        {
            return RunLongTask(title, callback, false);
        }
        public static RunWorkerCompletedEventArgs RunLongTask(string title, DoWorkEventHandler callback, bool reportsProgress)
        {
            using (Cargando frmLongTask = new Cargando(title, callback, reportsProgress))
            {
                frmLongTask.ShowDialog();
                if (frmLongTask.error != null)
                {
                    throw frmLongTask.error;
                }
                return frmLongTask.results;
            }
        }
        public static RunWorkerCompletedEventArgs RunLongTask(string title, DoWorkEventHandler callback, bool reportsProgress, object args, EventHandler cancelHandler)
        {
            using (Cargando frmLongTask = new Cargando(title, callback, reportsProgress, args, cancelHandler))
            {
                frmLongTask.ShowDialog();
                if (frmLongTask.error != null)
                {
                    throw frmLongTask.error;
                }
                return frmLongTask.results;
            }
        }
        private void Cargando_Shown(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync(argument);
        }
        private Cargando(string title, DoWorkEventHandler callback)
			: this(title, callback, false, null, null)
		{
        }
        private Cargando(string title, DoWorkEventHandler callback, object args)
            : this(title, callback, false, args, null)
		{
        }
    }
}
