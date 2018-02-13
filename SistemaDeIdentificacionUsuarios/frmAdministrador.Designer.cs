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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPELLIDO1 = new System.Windows.Forms.TextBox();
            this.txtAPELLIDO2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTIPOUSUARIO = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbMODIFICAR = new System.Windows.Forms.ToolStripButton();
            this.tsbELIMINAR = new System.Windows.Forms.ToolStripButton();
            this.tsbCONSULTAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.idiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbACERCADE = new System.Windows.Forms.ToolStripButton();
            this.tsbSALIR = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.lblPASSWORD = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tmrCRONOMETRO = new System.Windows.Forms.Timer(this.components);
            this.pcbIMAGEFINGER = new System.Windows.Forms.PictureBox();
            this.pcbIMAGEFACE = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIMAGEFINGER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIMAGEFACE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Segundo Apellido:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de usuario:";
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
            this.toolStripButton1,
            this.tsbMODIFICAR,
            this.tsbELIMINAR,
            this.tsbCONSULTAR,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.tsbACERCADE,
            this.tsbSALIR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(885, 28);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources._07_plus_161;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(86, 25);
            this.toolStripButton1.Text = "Agregar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.broom_stick_3_20;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(83, 25);
            this.toolStripButton2.Text = "Limpiar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomasToolStripMenuItem,
            this.españolToolStripMenuItem});
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(71, 25);
            this.toolStripButton3.Text = "Idioma";
            // 
            // idiomasToolStripMenuItem
            // 
            this.idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            this.idiomasToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.idiomasToolStripMenuItem.Text = "Español";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.españolToolStripMenuItem.Text = "Ingles";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(451, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Confirmar contraseña:";
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
            this.Column4.HeaderText = "Email";
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
            this.Column7.HeaderText = "Imagen face";
            this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Imagen huella";
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "(1.Administrador, 2. Operador)";
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
            this.pcbIMAGEFACE.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.user1;
            this.pcbIMAGEFACE.Location = new System.Drawing.Point(623, 286);
            this.pcbIMAGEFACE.Name = "pcbIMAGEFACE";
            this.pcbIMAGEFACE.Size = new System.Drawing.Size(122, 124);
            this.pcbIMAGEFACE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIMAGEFACE.TabIndex = 13;
            this.pcbIMAGEFACE.TabStop = false;
            this.pcbIMAGEFACE.Click += new System.EventHandler(this.pcbIMAGEFACE_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 453);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPASSWORD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.txtCONPASSWORD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pcbIMAGEFINGER);
            this.Controls.Add(this.pcbIMAGEFACE);
            this.Controls.Add(this.cmbTIPOUSUARIO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAPELLIDO2);
            this.Controls.Add(this.txtAPELLIDO1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPELLIDO1;
        private System.Windows.Forms.TextBox txtAPELLIDO2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTIPOUSUARIO;
        private System.Windows.Forms.PictureBox pcbIMAGEFACE;
        private System.Windows.Forms.PictureBox pcbIMAGEFINGER;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbMODIFICAR;
        private System.Windows.Forms.ToolStripButton tsbELIMINAR;
        private System.Windows.Forms.ToolStripButton tsbCONSULTAR;
        private System.Windows.Forms.ToolStripButton tsbSALIR;
        private System.Windows.Forms.ToolStripButton tsbACERCADE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCONPASSWORD;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPASSWORD;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Timer tmrCRONOMETRO;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}