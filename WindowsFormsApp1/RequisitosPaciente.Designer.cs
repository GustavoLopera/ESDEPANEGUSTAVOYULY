namespace WindowsFormsApp1
{
    partial class RequisitosPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequisitosPaciente));
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEstadoCiv = new System.Windows.Forms.ComboBox();
            this.cbxNivelEsco = new System.Windows.Forms.ComboBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.cbxRegimen = new System.Windows.Forms.ComboBox();
            this.cbxTipoID = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblContEmerg = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblEPS = new System.Windows.Forms.Label();
            this.lblNivelEsc = new System.Windows.Forms.Label();
            this.lblOcup = new System.Windows.Forms.Label();
            this.lblTelRes = new System.Windows.Forms.Label();
            this.lblCiudadRes = new System.Windows.Forms.Label();
            this.lblDirecRes = new System.Windows.Forms.Label();
            this.lblEstCivil = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNumID = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtContEmerg = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelCont = new System.Windows.Forms.TextBox();
            this.txtDirecRes = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNumID = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxOcupacion = new System.Windows.Forms.ComboBox();
            this.cbxEPS = new System.Windows.Forms.ComboBox();
            this.cbxCiudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(656, 558);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(109, 51);
            this.btnSiguiente.TabIndex = 71;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(501, 558);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 51);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "DATOS PERSONALES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 59;
            this.label1.Text = "DATOS DE CONTACTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxEstadoCiv
            // 
            this.cbxEstadoCiv.BackColor = System.Drawing.Color.Thistle;
            this.cbxEstadoCiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoCiv.FormattingEnabled = true;
            this.cbxEstadoCiv.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Divorciado/a",
            "Viudo/a",
            "Union libre",
            ""});
            this.cbxEstadoCiv.Location = new System.Drawing.Point(77, 449);
            this.cbxEstadoCiv.Name = "cbxEstadoCiv";
            this.cbxEstadoCiv.Size = new System.Drawing.Size(227, 24);
            this.cbxEstadoCiv.TabIndex = 50;
            // 
            // cbxNivelEsco
            // 
            this.cbxNivelEsco.BackColor = System.Drawing.Color.Thistle;
            this.cbxNivelEsco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivelEsco.FormattingEnabled = true;
            this.cbxNivelEsco.Location = new System.Drawing.Point(77, 572);
            this.cbxNivelEsco.Name = "cbxNivelEsco";
            this.cbxNivelEsco.Size = new System.Drawing.Size(227, 24);
            this.cbxNivelEsco.TabIndex = 54;
            // 
            // cbxGenero
            // 
            this.cbxGenero.BackColor = System.Drawing.Color.Thistle;
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(199, 381);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(105, 24);
            this.cbxGenero.TabIndex = 48;
            // 
            // cbxRegimen
            // 
            this.cbxRegimen.BackColor = System.Drawing.Color.Thistle;
            this.cbxRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegimen.FormattingEnabled = true;
            this.cbxRegimen.Location = new System.Drawing.Point(211, 630);
            this.cbxRegimen.Name = "cbxRegimen";
            this.cbxRegimen.Size = new System.Drawing.Size(93, 24);
            this.cbxRegimen.TabIndex = 58;
            // 
            // cbxTipoID
            // 
            this.cbxTipoID.BackColor = System.Drawing.Color.Thistle;
            this.cbxTipoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxTipoID.FormattingEnabled = true;
            this.cbxTipoID.Location = new System.Drawing.Point(77, 184);
            this.cbxTipoID.Name = "cbxTipoID";
            this.cbxTipoID.Size = new System.Drawing.Size(227, 24);
            this.cbxTipoID.TabIndex = 40;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "DD/MM/AAA";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(77, 312);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(227, 22);
            this.dtpFechaNacimiento.TabIndex = 44;
            this.dtpFechaNacimiento.Value = new System.DateTime(2022, 3, 17, 0, 0, 0, 0);
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // lblContEmerg
            // 
            this.lblContEmerg.AutoSize = true;
            this.lblContEmerg.BackColor = System.Drawing.Color.Transparent;
            this.lblContEmerg.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContEmerg.Location = new System.Drawing.Point(519, 290);
            this.lblContEmerg.Name = "lblContEmerg";
            this.lblContEmerg.Size = new System.Drawing.Size(196, 18);
            this.lblContEmerg.TabIndex = 66;
            this.lblContEmerg.Text = "Contacto en caso de emergencia";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(519, 358);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 18);
            this.lblEmail.TabIndex = 68;
            this.lblEmail.Text = "Email";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.Transparent;
            this.lblReg.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.Location = new System.Drawing.Point(208, 611);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(60, 18);
            this.lblReg.TabIndex = 57;
            this.lblReg.Text = "Régimen";
            // 
            // lblEPS
            // 
            this.lblEPS.AutoSize = true;
            this.lblEPS.BackColor = System.Drawing.Color.Transparent;
            this.lblEPS.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEPS.Location = new System.Drawing.Point(74, 611);
            this.lblEPS.Name = "lblEPS";
            this.lblEPS.Size = new System.Drawing.Size(30, 18);
            this.lblEPS.TabIndex = 55;
            this.lblEPS.Text = "EPS";
            // 
            // lblNivelEsc
            // 
            this.lblNivelEsc.AutoSize = true;
            this.lblNivelEsc.BackColor = System.Drawing.Color.Transparent;
            this.lblNivelEsc.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelEsc.Location = new System.Drawing.Point(74, 553);
            this.lblNivelEsc.Name = "lblNivelEsc";
            this.lblNivelEsc.Size = new System.Drawing.Size(113, 18);
            this.lblNivelEsc.TabIndex = 53;
            this.lblNivelEsc.Text = "Nivel escolaridad";
            // 
            // lblOcup
            // 
            this.lblOcup.AutoSize = true;
            this.lblOcup.BackColor = System.Drawing.Color.Transparent;
            this.lblOcup.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcup.Location = new System.Drawing.Point(74, 491);
            this.lblOcup.Name = "lblOcup";
            this.lblOcup.Size = new System.Drawing.Size(72, 18);
            this.lblOcup.TabIndex = 51;
            this.lblOcup.Text = "Ocupación";
            // 
            // lblTelRes
            // 
            this.lblTelRes.AutoSize = true;
            this.lblTelRes.BackColor = System.Drawing.Color.Transparent;
            this.lblTelRes.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelRes.Location = new System.Drawing.Point(519, 228);
            this.lblTelRes.Name = "lblTelRes";
            this.lblTelRes.Size = new System.Drawing.Size(128, 18);
            this.lblTelRes.TabIndex = 64;
            this.lblTelRes.Text = "Teléfono de contacto";
            // 
            // lblCiudadRes
            // 
            this.lblCiudadRes.AutoSize = true;
            this.lblCiudadRes.BackColor = System.Drawing.Color.Transparent;
            this.lblCiudadRes.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadRes.Location = new System.Drawing.Point(519, 163);
            this.lblCiudadRes.Name = "lblCiudadRes";
            this.lblCiudadRes.Size = new System.Drawing.Size(133, 18);
            this.lblCiudadRes.TabIndex = 62;
            this.lblCiudadRes.Text = "Ciudad de residencia";
            // 
            // lblDirecRes
            // 
            this.lblDirecRes.AutoSize = true;
            this.lblDirecRes.BackColor = System.Drawing.Color.Transparent;
            this.lblDirecRes.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecRes.Location = new System.Drawing.Point(519, 101);
            this.lblDirecRes.Name = "lblDirecRes";
            this.lblDirecRes.Size = new System.Drawing.Size(132, 18);
            this.lblDirecRes.TabIndex = 60;
            this.lblDirecRes.Text = "Dirección residencial";
            // 
            // lblEstCivil
            // 
            this.lblEstCivil.AutoSize = true;
            this.lblEstCivil.BackColor = System.Drawing.Color.Transparent;
            this.lblEstCivil.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstCivil.Location = new System.Drawing.Point(74, 424);
            this.lblEstCivil.Name = "lblEstCivil";
            this.lblEstCivil.Size = new System.Drawing.Size(77, 18);
            this.lblEstCivil.TabIndex = 49;
            this.lblEstCivil.Text = "Estado civil";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(77, 358);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 18);
            this.lblEdad.TabIndex = 45;
            this.lblEdad.Text = "Edad";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNac.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(74, 290);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(129, 18);
            this.lblFechaNac.TabIndex = 43;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(196, 358);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(51, 18);
            this.lblGenero.TabIndex = 47;
            this.lblGenero.Text = "Género";
            // 
            // lblNumID
            // 
            this.lblNumID.AutoSize = true;
            this.lblNumID.BackColor = System.Drawing.Color.Transparent;
            this.lblNumID.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumID.Location = new System.Drawing.Point(74, 228);
            this.lblNumID.Name = "lblNumID";
            this.lblNumID.Size = new System.Drawing.Size(159, 18);
            this.lblNumID.TabIndex = 41;
            this.lblNumID.Text = "Número de identificación";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoDoc.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(74, 163);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(136, 18);
            this.lblTipoDoc.TabIndex = 39;
            this.lblTipoDoc.Text = "Tipo de identificación";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombres.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(74, 101);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(128, 18);
            this.lblNombres.TabIndex = 37;
            this.lblNombres.Text = "Nombres completos";
            // 
            // txtContEmerg
            // 
            this.txtContEmerg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtContEmerg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContEmerg.Location = new System.Drawing.Point(522, 312);
            this.txtContEmerg.MaxLength = 10;
            this.txtContEmerg.Name = "txtContEmerg";
            this.txtContEmerg.Size = new System.Drawing.Size(229, 22);
            this.txtContEmerg.TabIndex = 67;
            this.txtContEmerg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContEmerg_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(522, 381);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 22);
            this.txtEmail.TabIndex = 69;
            // 
            // txtTelCont
            // 
            this.txtTelCont.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTelCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelCont.Location = new System.Drawing.Point(522, 247);
            this.txtTelCont.MaxLength = 10;
            this.txtTelCont.Name = "txtTelCont";
            this.txtTelCont.Size = new System.Drawing.Size(229, 22);
            this.txtTelCont.TabIndex = 65;
            this.txtTelCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelCont_KeyPress);
            // 
            // txtDirecRes
            // 
            this.txtDirecRes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDirecRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirecRes.Location = new System.Drawing.Point(522, 120);
            this.txtDirecRes.MaxLength = 100;
            this.txtDirecRes.Name = "txtDirecRes";
            this.txtDirecRes.Size = new System.Drawing.Size(229, 22);
            this.txtDirecRes.TabIndex = 61;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(77, 380);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(105, 22);
            this.txtEdad.TabIndex = 46;
            // 
            // txtNumID
            // 
            this.txtNumID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNumID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumID.Location = new System.Drawing.Point(77, 247);
            this.txtNumID.MaxLength = 10;
            this.txtNumID.Name = "txtNumID";
            this.txtNumID.Size = new System.Drawing.Size(227, 22);
            this.txtNumID.TabIndex = 42;
            this.txtNumID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumID_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombres.Location = new System.Drawing.Point(77, 120);
            this.txtNombres.MaxLength = 60;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(227, 22);
            this.txtNombres.TabIndex = 38;
            this.txtNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombres_KeyDown);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // cbxOcupacion
            // 
            this.cbxOcupacion.BackColor = System.Drawing.Color.Thistle;
            this.cbxOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOcupacion.FormattingEnabled = true;
            this.cbxOcupacion.Location = new System.Drawing.Point(77, 512);
            this.cbxOcupacion.Name = "cbxOcupacion";
            this.cbxOcupacion.Size = new System.Drawing.Size(227, 24);
            this.cbxOcupacion.TabIndex = 72;
            // 
            // cbxEPS
            // 
            this.cbxEPS.BackColor = System.Drawing.Color.Thistle;
            this.cbxEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEPS.FormattingEnabled = true;
            this.cbxEPS.Items.AddRange(new object[] {
            "Subsidiado",
            "Contributivo",
            "Especial"});
            this.cbxEPS.Location = new System.Drawing.Point(77, 630);
            this.cbxEPS.Name = "cbxEPS";
            this.cbxEPS.Size = new System.Drawing.Size(128, 24);
            this.cbxEPS.TabIndex = 73;
            // 
            // cbxCiudad
            // 
            this.cbxCiudad.BackColor = System.Drawing.Color.SkyBlue;
            this.cbxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCiudad.FormattingEnabled = true;
            this.cbxCiudad.Location = new System.Drawing.Point(522, 184);
            this.cbxCiudad.Name = "cbxCiudad";
            this.cbxCiudad.Size = new System.Drawing.Size(229, 24);
            this.cbxCiudad.TabIndex = 74;
            // 
            // RequisitosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.purple_and_blue_gradient_background_free_photo4;
            this.ClientSize = new System.Drawing.Size(889, 683);
            this.Controls.Add(this.cbxCiudad);
            this.Controls.Add(this.cbxEPS);
            this.Controls.Add(this.cbxOcupacion);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEstadoCiv);
            this.Controls.Add(this.cbxNivelEsco);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.cbxRegimen);
            this.Controls.Add(this.cbxTipoID);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblContEmerg);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblEPS);
            this.Controls.Add(this.lblNivelEsc);
            this.Controls.Add(this.lblOcup);
            this.Controls.Add(this.lblTelRes);
            this.Controls.Add(this.lblCiudadRes);
            this.Controls.Add(this.lblDirecRes);
            this.Controls.Add(this.lblEstCivil);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNumID);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtContEmerg);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelCont);
            this.Controls.Add(this.txtDirecRes);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNumID);
            this.Controls.Add(this.txtNombres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RequisitosPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATOS DEL PACIENTE";
            this.Load += new System.EventHandler(this.RequisitosPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEstadoCiv;
        private System.Windows.Forms.ComboBox cbxNivelEsco;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.ComboBox cbxRegimen;
        private System.Windows.Forms.ComboBox cbxTipoID;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblContEmerg;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblEPS;
        private System.Windows.Forms.Label lblNivelEsc;
        private System.Windows.Forms.Label lblOcup;
        private System.Windows.Forms.Label lblTelRes;
        private System.Windows.Forms.Label lblCiudadRes;
        private System.Windows.Forms.Label lblDirecRes;
        private System.Windows.Forms.Label lblEstCivil;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNumID;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtContEmerg;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelCont;
        private System.Windows.Forms.TextBox txtDirecRes;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNumID;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.ComboBox cbxEPS;
        private System.Windows.Forms.ComboBox cbxOcupacion;
        private System.Windows.Forms.ComboBox cbxCiudad;
    }
}