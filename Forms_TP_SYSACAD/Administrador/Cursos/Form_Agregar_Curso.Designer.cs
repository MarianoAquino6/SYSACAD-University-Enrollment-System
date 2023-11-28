namespace Forms_TP_SYSACAD
{
    partial class Form_Agregar_Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Agregar_Curso));
            lblInfoAgregar = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblDescripcion = new Label();
            lblCupo = new Label();
            textBoxNombre = new TextBox();
            textBoxCodigo = new TextBox();
            textBoxCupo = new TextBox();
            richTextBoxDescripcion = new RichTextBox();
            btnAgregar = new Button();
            lblTurno = new Label();
            lblAula = new Label();
            tbAula = new TextBox();
            lblDia = new Label();
            cbDia = new ComboBox();
            cbTurno = new ComboBox();
            btnAtras = new Button();
            lblCarrera = new Label();
            cbCarrera = new ComboBox();
            SuspendLayout();
            // 
            // lblInfoAgregar
            // 
            lblInfoAgregar.AutoSize = true;
            lblInfoAgregar.BackColor = Color.Transparent;
            lblInfoAgregar.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfoAgregar.ForeColor = SystemColors.Window;
            lblInfoAgregar.Location = new Point(12, 73);
            lblInfoAgregar.Name = "lblInfoAgregar";
            lblInfoAgregar.Size = new Size(65, 26);
            lblInfoAgregar.TabIndex = 0;
            lblInfoAgregar.Text = "label1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(12, 125);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(46, 18);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label2";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.ForeColor = SystemColors.Window;
            lblCodigo.Location = new Point(12, 198);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 18);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "label3";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.ForeColor = SystemColors.Window;
            lblDescripcion.Location = new Point(12, 340);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(46, 18);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "label4";
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.BackColor = Color.Transparent;
            lblCupo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCupo.ForeColor = SystemColors.Window;
            lblCupo.Location = new Point(12, 479);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(46, 18);
            lblCupo.TabIndex = 4;
            lblCupo.Text = "label5";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.WindowText;
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = Color.Red;
            textBoxNombre.Location = new Point(12, 152);
            textBoxNombre.MaxLength = 25;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(180, 25);
            textBoxNombre.TabIndex = 5;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BackColor = SystemColors.WindowText;
            textBoxCodigo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodigo.ForeColor = Color.Red;
            textBoxCodigo.Location = new Point(12, 226);
            textBoxCodigo.MaxLength = 15;
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(180, 25);
            textBoxCodigo.TabIndex = 6;
            textBoxCodigo.TextChanged += textBoxCodigo_TextChanged;
            // 
            // textBoxCupo
            // 
            textBoxCupo.BackColor = SystemColors.WindowText;
            textBoxCupo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCupo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCupo.ForeColor = Color.Red;
            textBoxCupo.Location = new Point(12, 506);
            textBoxCupo.MaxLength = 3;
            textBoxCupo.Name = "textBoxCupo";
            textBoxCupo.Size = new Size(180, 25);
            textBoxCupo.TabIndex = 7;
            textBoxCupo.TextChanged += textBoxCupo_TextChanged;
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.BackColor = SystemColors.WindowText;
            richTextBoxDescripcion.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxDescripcion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxDescripcion.ForeColor = Color.Red;
            richTextBoxDescripcion.Location = new Point(12, 367);
            richTextBoxDescripcion.MaxLength = 150;
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(291, 96);
            richTextBoxDescripcion.TabIndex = 8;
            richTextBoxDescripcion.Text = "";
            richTextBoxDescripcion.TextChanged += richTextBoxDescripcion_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.WindowText;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(367, 497);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 38);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "button1";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.BackColor = Color.Transparent;
            lblTurno.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurno.ForeColor = SystemColors.Window;
            lblTurno.Location = new Point(308, 125);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(46, 18);
            lblTurno.TabIndex = 10;
            lblTurno.Text = "label1";
            // 
            // lblAula
            // 
            lblAula.AutoSize = true;
            lblAula.BackColor = Color.Transparent;
            lblAula.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAula.ForeColor = SystemColors.Window;
            lblAula.Location = new Point(12, 270);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(46, 18);
            lblAula.TabIndex = 14;
            lblAula.Text = "label2";
            // 
            // tbAula
            // 
            tbAula.BackColor = SystemColors.WindowText;
            tbAula.BorderStyle = BorderStyle.FixedSingle;
            tbAula.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbAula.ForeColor = Color.Red;
            tbAula.Location = new Point(12, 297);
            tbAula.MaxLength = 3;
            tbAula.Name = "tbAula";
            tbAula.Size = new Size(100, 25);
            tbAula.TabIndex = 15;
            tbAula.TextChanged += tbAula_TextChanged;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.BackColor = Color.Transparent;
            lblDia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDia.ForeColor = SystemColors.Window;
            lblDia.Location = new Point(308, 198);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(46, 18);
            lblDia.TabIndex = 16;
            lblDia.Text = "label3";
            // 
            // cbDia
            // 
            cbDia.BackColor = SystemColors.WindowText;
            cbDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDia.FlatStyle = FlatStyle.Popup;
            cbDia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbDia.ForeColor = Color.Red;
            cbDia.FormattingEnabled = true;
            cbDia.Location = new Point(308, 226);
            cbDia.Name = "cbDia";
            cbDia.Size = new Size(121, 25);
            cbDia.TabIndex = 17;
            cbDia.SelectedIndexChanged += cbDia_SelectedIndexChanged;
            // 
            // cbTurno
            // 
            cbTurno.BackColor = SystemColors.WindowText;
            cbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTurno.FlatStyle = FlatStyle.Popup;
            cbTurno.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbTurno.ForeColor = Color.Red;
            cbTurno.FormattingEnabled = true;
            cbTurno.Location = new Point(308, 152);
            cbTurno.Name = "cbTurno";
            cbTurno.Size = new Size(121, 25);
            cbTurno.TabIndex = 18;
            cbTurno.SelectedIndexChanged += cbTurno_SelectedIndexChanged;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkRed;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.ForeColor = SystemColors.Window;
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 19;
            btnAtras.Text = "button1";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.Transparent;
            lblCarrera.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarrera.ForeColor = SystemColors.Window;
            lblCarrera.Location = new Point(308, 273);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(46, 18);
            lblCarrera.TabIndex = 20;
            lblCarrera.Text = "label1";
            // 
            // cbCarrera
            // 
            cbCarrera.BackColor = SystemColors.WindowText;
            cbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCarrera.FlatStyle = FlatStyle.Popup;
            cbCarrera.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCarrera.ForeColor = Color.Red;
            cbCarrera.FormattingEnabled = true;
            cbCarrera.Location = new Point(308, 299);
            cbCarrera.Name = "cbCarrera";
            cbCarrera.Size = new Size(121, 25);
            cbCarrera.TabIndex = 21;
            cbCarrera.SelectedIndexChanged += cbCarrera_SelectedIndexChanged;
            // 
            // Form_Agregar_Curso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(485, 547);
            Controls.Add(cbCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(btnAtras);
            Controls.Add(cbTurno);
            Controls.Add(cbDia);
            Controls.Add(lblDia);
            Controls.Add(tbAula);
            Controls.Add(lblAula);
            Controls.Add(lblTurno);
            Controls.Add(btnAgregar);
            Controls.Add(richTextBoxDescripcion);
            Controls.Add(textBoxCupo);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxNombre);
            Controls.Add(lblCupo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCodigo);
            Controls.Add(lblNombre);
            Controls.Add(lblInfoAgregar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Agregar_Curso";
            Text = "Form_Agregar_Curso";
            Load += Form_Agregar_Curso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoAgregar;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblDescripcion;
        private Label lblCupo;
        private TextBox textBoxNombre;
        private TextBox textBoxCodigo;
        private TextBox textBoxCupo;
        private RichTextBox richTextBoxDescripcion;
        private Button btnAgregar;
        private Label lblTurno;
        private Label lblAula;
        private TextBox tbAula;
        private Label lblDia;
        private ComboBox cbDia;
        private ComboBox cbTurno;
        private Button btnAtras;
        private Label lblCarrera;
        private ComboBox cbCarrera;
    }
}