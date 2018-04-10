namespace SistemaDeIdentificacionUsuarios
{
    partial class frmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.lblNAME = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.lblPRIMERAPELLIDO = new System.Windows.Forms.Label();
            this.lblSEGUNDOAPELLIDO = new System.Windows.Forms.Label();
            this.txtAPELLIDO1 = new System.Windows.Forms.TextBox();
            this.txtAPELLIDO2 = new System.Windows.Forms.TextBox();
            this.lblCORREO = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.lblPASSORIGINAL = new System.Windows.Forms.Label();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.lblTIPOUSUARIO = new System.Windows.Forms.Label();
            this.cmbTIPOUSUARIO = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAGREGAR = new System.Windows.Forms.ToolStripButton();
            this.tsbMODIFICAR = new System.Windows.Forms.ToolStripButton();
            this.tsbELIMINAR = new System.Windows.Forms.ToolStripButton();
            this.tsbCONSULTAR = new System.Windows.Forms.ToolStripButton();
            this.tsbLIMPIAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbACERCADE = new System.Windows.Forms.ToolStripButton();
            this.tsbSALIR = new System.Windows.Forms.ToolStripButton();
            this.lblCONFIRMARPASS = new System.Windows.Forms.Label();
            this.txtCONPASSWORD = new System.Windows.Forms.TextBox();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.lblPASSWORD = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tmrCRONOMETRO = new System.Windows.Forms.Timer(this.components);
            this.pcbIMAGEFINGER = new System.Windows.Forms.PictureBox();
            this.pcbIMAGEFACE = new System.Windows.Forms.PictureBox();
            this.tsbIDIOMA = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmESPANISH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmINGLES = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIMAGEFINGER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIMAGEFACE)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNAME
            // 
            this.lblNAME.AutoSize = true;
            this.lblNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNAME.Location = new System.Drawing.Point(26, 278);
            this.lblNAME.Name = "lblNAME";
            this.lblNAME.Size = new System.Drawing.Size(69, 20);
            this.lblNAME.TabIndex = 0;
            this.lblNAME.Text = "Nombre:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOMBRE.Location = new System.Drawing.Point(29, 301);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(152, 26);
            this.txtNOMBRE.TabIndex = 1;
            // 
            // lblPRIMERAPELLIDO
            // 
            this.lblPRIMERAPELLIDO.AutoSize = true;
            this.lblPRIMERAPELLIDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRIMERAPELLIDO.Location = new System.Drawing.Point(26, 330);
            this.lblPRIMERAPELLIDO.Name = "lblPRIMERAPELLIDO";
            this.lblPRIMERAPELLIDO.Size = new System.Drawing.Size(118, 20);
            this.lblPRIMERAPELLIDO.TabIndex = 2;
            this.lblPRIMERAPELLIDO.Text = "Primer Apellido:";
            // 
            // lblSEGUNDOAPELLIDO
            // 
            this.lblSEGUNDOAPELLIDO.AutoSize = true;
            this.lblSEGUNDOAPELLIDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEGUNDOAPELLIDO.Location = new System.Drawing.Point(25, 381);
            this.lblSEGUNDOAPELLIDO.Name = "lblSEGUNDOAPELLIDO";
            this.lblSEGUNDOAPELLIDO.Size = new System.Drawing.Size(138, 20);
            this.lblSEGUNDOAPELLIDO.TabIndex = 3;
            this.lblSEGUNDOAPELLIDO.Text = "Segundo Apellido:";
            // 
            // txtAPELLIDO1
            // 
            this.txtAPELLIDO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAPELLIDO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPELLIDO1.Location = new System.Drawing.Point(29, 352);
            this.txtAPELLIDO1.Name = "txtAPELLIDO1";
            this.txtAPELLIDO1.Size = new System.Drawing.Size(152, 26);
            this.txtAPELLIDO1.TabIndex = 4;
            // 
            // txtAPELLIDO2
            // 
            this.txtAPELLIDO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAPELLIDO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPELLIDO2.Location = new System.Drawing.Point(29, 402);
            this.txtAPELLIDO2.Name = "txtAPELLIDO2";
            this.txtAPELLIDO2.Size = new System.Drawing.Size(152, 26);
            this.txtAPELLIDO2.TabIndex = 5;
            // 
            // lblCORREO
            // 
            this.lblCORREO.AutoSize = true;
            this.lblCORREO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCORREO.Location = new System.Drawing.Point(191, 278);
            this.lblCORREO.Name = "lblCORREO";
            this.lblCORREO.Size = new System.Drawing.Size(142, 20);
            this.lblCORREO.TabIndex = 6;
            this.lblCORREO.Text = "Correo electrónico:";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMAIL.Location = new System.Drawing.Point(194, 301);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(239, 26);
            this.txtEMAIL.TabIndex = 7;
            // 
            // lblPASSORIGINAL
            // 
            this.lblPASSORIGINAL.AutoSize = true;
            this.lblPASSORIGINAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPASSORIGINAL.Location = new System.Drawing.Point(450, 278);
            this.lblPASSORIGINAL.Name = "lblPASSORIGINAL";
            this.lblPASSORIGINAL.Size = new System.Drawing.Size(96, 20);
            this.lblPASSORIGINAL.TabIndex = 8;
            this.lblPASSORIGINAL.Text = "Contraseña:";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASSWORD.Location = new System.Drawing.Point(454, 301);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(152, 26);
            this.txtPASSWORD.TabIndex = 9;
            this.txtPASSWORD.UseSystemPasswordChar = true;
            // 
            // lblTIPOUSUARIO
            // 
            this.lblTIPOUSUARIO.AutoSize = true;
            this.lblTIPOUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIPOUSUARIO.Location = new System.Drawing.Point(191, 329);
            this.lblTIPOUSUARIO.Name = "lblTIPOUSUARIO";
            this.lblTIPOUSUARIO.Size = new System.Drawing.Size(121, 20);
            this.lblTIPOUSUARIO.TabIndex = 10;
            this.lblTIPOUSUARIO.Text = "Tipo de usuario:";
            // 
            // cmbTIPOUSUARIO
            // 
            this.cmbTIPOUSUARIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTIPOUSUARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTIPOUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTIPOUSUARIO.FormattingEnabled = true;
            this.cmbTIPOUSUARIO.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbTIPOUSUARIO.Location = new System.Drawing.Point(194, 378);
            this.cmbTIPOUSUARIO.Name = "cmbTIPOUSUARIO";
            this.cmbTIPOUSUARIO.Size = new System.Drawing.Size(183, 28);
            this.cmbTIPOUSUARIO.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAGREGAR,
            this.tsbMODIFICAR,
            this.tsbELIMINAR,
            this.tsbCONSULTAR,
            this.tsbLIMPIAR,
            this.toolStripSeparator1,
            this.tsbIDIOMA,
            this.tsbACERCADE,
            this.tsbSALIR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(885, 28);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAGREGAR
            // 
            this.tsbAGREGAR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAGREGAR.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources._07_plus_161;
            this.tsbAGREGAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAGREGAR.Name = "tsbAGREGAR";
            this.tsbAGREGAR.Size = new System.Drawing.Size(86, 25);
            this.tsbAGREGAR.Text = "Agregar";
            this.tsbAGREGAR.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbMODIFICAR
            // 
            this.tsbMODIFICAR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbMODIFICAR.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources._012_restart_16;
            this.tsbMODIFICAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMODIFICAR.Name = "tsbMODIFICAR";
            this.tsbMODIFICAR.Size = new System.Drawing.Size(96, 25);
            this.tsbMODIFICAR.Text = "Modificar";
            this.tsbMODIFICAR.Click += new System.EventHandler(this.tsbMODIFICAR_Click);
            // 
            // tsbELIMINAR
            // 
            this.tsbELIMINAR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbELIMINAR.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.trash_01_16;
            this.tsbELIMINAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbELIMINAR.Name = "tsbELIMINAR";
            this.tsbELIMINAR.Size = new System.Drawing.Size(87, 25);
            this.tsbELIMINAR.Text = "Eliminar";
            this.tsbELIMINAR.Click += new System.EventHandler(this.tsbELIMINAR_Click);
            // 
            // tsbCONSULTAR
            // 
            this.tsbCONSULTAR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCONSULTAR.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources._09_search_16;
            this.tsbCONSULTAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCONSULTAR.Name = "tsbCONSULTAR";
            this.tsbCONSULTAR.Size = new System.Drawing.Size(97, 25);
            this.tsbCONSULTAR.Text = "Consultar";
            this.tsbCONSULTAR.Click += new System.EventHandler(this.tsbCONSULTAR_Click);
            // 
            // tsbLIMPIAR
            // 
            this.tsbLIMPIAR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLIMPIAR.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.broom_stick_3_20;
            this.tsbLIMPIAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLIMPIAR.Name = "tsbLIMPIAR";
            this.tsbLIMPIAR.Size = new System.Drawing.Size(83, 25);
            this.tsbLIMPIAR.Text = "Limpiar";
            this.tsbLIMPIAR.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbACERCADE
            // 
            this.tsbACERCADE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbACERCADE.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.acerca_de;
            this.tsbACERCADE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbACERCADE.Name = "tsbACERCADE";
            this.tsbACERCADE.Size = new System.Drawing.Size(97, 25);
            this.tsbACERCADE.Text = "Acerca de";
            // 
            // tsbSALIR
            // 
            this.tsbSALIR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSALIR.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.thin_1570_exit_login_import_16;
            this.tsbSALIR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSALIR.Name = "tsbSALIR";
            this.tsbSALIR.Size = new System.Drawing.Size(61, 25);
            this.tsbSALIR.Text = "Salir";
            this.tsbSALIR.Click += new System.EventHandler(this.tsbSALIR_Click);
            // 
            // lblCONFIRMARPASS
            // 
            this.lblCONFIRMARPASS.AutoSize = true;
            this.lblCONFIRMARPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONFIRMARPASS.Location = new System.Drawing.Point(451, 330);
            this.lblCONFIRMARPASS.Name = "lblCONFIRMARPASS";
            this.lblCONFIRMARPASS.Size = new System.Drawing.Size(166, 20);
            this.lblCONFIRMARPASS.TabIndex = 16;
            this.lblCONFIRMARPASS.Text = "Confirmar contraseña:";
            // 
            // txtCONPASSWORD
            // 
            this.txtCONPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCONPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCONPASSWORD.Location = new System.Drawing.Point(454, 352);
            this.txtCONPASSWORD.Name = "txtCONPASSWORD";
            this.txtCONPASSWORD.Size = new System.Drawing.Size(152, 26);
            this.txtCONPASSWORD.TabIndex = 17;
            this.txtCONPASSWORD.UseSystemPasswordChar = true;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvAdmin.Location = new System.Drawing.Point(12, 45);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(861, 230);
            this.dgvAdmin.TabIndex = 18;
            this.dgvAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Primer Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Segundo Apellido";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Correo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Contraseña";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tipo de Usuario";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Imagen del rostro";
            this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Imagen dactilar";
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSUARIO.Location = new System.Drawing.Point(191, 354);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(222, 20);
            this.lblUSUARIO.TabIndex = 19;
            this.lblUSUARIO.Text = "(1.Administrador, 2. Operador)";
            // 
            // lblPASSWORD
            // 
            this.lblPASSWORD.AutoSize = true;
            this.lblPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPASSWORD.ForeColor = System.Drawing.Color.Red;
            this.lblPASSWORD.Location = new System.Drawing.Point(450, 386);
            this.lblPASSWORD.Name = "lblPASSWORD";
            this.lblPASSWORD.Size = new System.Drawing.Size(13, 20);
            this.lblPASSWORD.TabIndex = 20;
            this.lblPASSWORD.Text = ".";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(816, 424);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 20);
            this.lblID.TabIndex = 21;
            this.lblID.Text = ".";
            this.lblID.Visible = false;
            // 
            // tmrCRONOMETRO
            // 
            this.tmrCRONOMETRO.Enabled = true;
            this.tmrCRONOMETRO.Interval = 1000;
            // 
            // pcbIMAGEFINGER
            // 
            this.pcbIMAGEFINGER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbIMAGEFINGER.ErrorImage = global::SistemaDeIdentificacionUsuarios.Properties.Resources.huellita;
            this.pcbIMAGEFINGER.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.huellita;
            this.pcbIMAGEFINGER.Location = new System.Drawing.Point(751, 286);
            this.pcbIMAGEFINGER.Name = "pcbIMAGEFINGER";
            this.pcbIMAGEFINGER.Size = new System.Drawing.Size(122, 124);
            this.pcbIMAGEFINGER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIMAGEFINGER.TabIndex = 14;
            this.pcbIMAGEFINGER.TabStop = false;
            this.pcbIMAGEFINGER.Click += new System.EventHandler(this.pcbIMAGEFINGER_Click);
            // 
            // pcbIMAGEFACE
            // 
            this.pcbIMAGEFACE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbIMAGEFACE.ErrorImage = global::SistemaDeIdentificacionUsuarios.Properties.Resources.user;
            this.pcbIMAGEFACE.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.user1;
            this.pcbIMAGEFACE.Location = new System.Drawing.Point(623, 286);
            this.pcbIMAGEFACE.Name = "pcbIMAGEFACE";
            this.pcbIMAGEFACE.Size = new System.Drawing.Size(122, 124);
            this.pcbIMAGEFACE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIMAGEFACE.TabIndex = 13;
            this.pcbIMAGEFACE.TabStop = false;
            this.pcbIMAGEFACE.Click += new System.EventHandler(this.pcbIMAGEFACE_Click);
            // 
            // tsbIDIOMA
            // 
            this.tsbIDIOMA.BackColor = System.Drawing.SystemColors.Control;
            this.tsbIDIOMA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmESPANISH,
            this.tsmINGLES});
            this.tsbIDIOMA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbIDIOMA.Name = "tsbIDIOMA";
            this.tsbIDIOMA.Size = new System.Drawing.Size(71, 25);
            this.tsbIDIOMA.Text = "Idioma";
            this.tsbIDIOMA.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsbIDIOMA_DropDownItemClicked);
            // 
            // tsmESPANISH
            // 
            this.tsmESPANISH.Checked = true;
            this.tsmESPANISH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmESPANISH.Name = "tsmESPANISH";
            this.tsmESPANISH.Size = new System.Drawing.Size(180, 26);
            this.tsmESPANISH.Text = "Español";
            this.tsmESPANISH.Click += new System.EventHandler(this.tsmESPANISH_Click);
            // 
            // tsmINGLES
            // 
            this.tsmINGLES.Checked = true;
            this.tsmINGLES.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmINGLES.Name = "tsmINGLES";
            this.tsmINGLES.Size = new System.Drawing.Size(180, 26);
            this.tsmINGLES.Text = "Ingles";
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 453);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPASSWORD);
            this.Controls.Add(this.lblUSUARIO);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.txtCONPASSWORD);
            this.Controls.Add(this.lblCONFIRMARPASS);
            this.Controls.Add(this.pcbIMAGEFINGER);
            this.Controls.Add(this.pcbIMAGEFACE);
            this.Controls.Add(this.cmbTIPOUSUARIO);
            this.Controls.Add(this.lblTIPOUSUARIO);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.lblPASSORIGINAL);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.lblCORREO);
            this.Controls.Add(this.txtAPELLIDO2);
            this.Controls.Add(this.txtAPELLIDO1);
            this.Controls.Add(this.lblSEGUNDOAPELLIDO);
            this.Controls.Add(this.lblPRIMERAPELLIDO);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.lblNAME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIMAGEFINGER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIMAGEFACE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNAME;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label lblPRIMERAPELLIDO;
        private System.Windows.Forms.Label lblSEGUNDOAPELLIDO;
        private System.Windows.Forms.TextBox txtAPELLIDO1;
        private System.Windows.Forms.TextBox txtAPELLIDO2;
        private System.Windows.Forms.Label lblCORREO;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Label lblPASSORIGINAL;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Label lblTIPOUSUARIO;
        private System.Windows.Forms.ComboBox cmbTIPOUSUARIO;
        private System.Windows.Forms.PictureBox pcbIMAGEFACE;
        private System.Windows.Forms.PictureBox pcbIMAGEFINGER;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAGREGAR;
        private System.Windows.Forms.ToolStripButton tsbMODIFICAR;
        private System.Windows.Forms.ToolStripButton tsbELIMINAR;
        private System.Windows.Forms.ToolStripButton tsbCONSULTAR;
        private System.Windows.Forms.ToolStripButton tsbSALIR;
        private System.Windows.Forms.ToolStripButton tsbACERCADE;
        private System.Windows.Forms.Label lblCONFIRMARPASS;
        private System.Windows.Forms.TextBox txtCONPASSWORD;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Label lblUSUARIO;
        private System.Windows.Forms.Label lblPASSWORD;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Timer tmrCRONOMETRO;
        private System.Windows.Forms.ToolStripButton tsbLIMPIAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.ToolStripDropDownButton tsbIDIOMA;
        private System.Windows.Forms.ToolStripMenuItem tsmESPANISH;
        private System.Windows.Forms.ToolStripMenuItem tsmINGLES;
    }
}