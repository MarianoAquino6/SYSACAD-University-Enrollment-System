namespace Forms_TP_SYSACAD
{
    partial class Form_Editar_Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Editar_Curso));
            lblInfoEditar = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblDescripcion = new Label();
            lblCupo = new Label();
            textBoxNombre = new TextBox();
            textBoxCodigo = new TextBox();
            textBoxCupo = new TextBox();
            richTextBoxDecripcion = new RichTextBox();
            btnConfirmarEdicion = new Button();
            lblAula = new Label();
            tbAula = new TextBox();
            lblTurno = new Label();
            lblDia = new Label();
            cbTurno = new ComboBox();
            cbDia = new ComboBox();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // lblInfoEditar
            // 
            lblInfoEditar.AutoSize = true;
            lblInfoEditar.BackColor = Color.Transparent;
            lblInfoEditar.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfoEditar.ForeColor = SystemColors.Window;
            lblInfoEditar.Location = new Point(12, 79);
            lblInfoEditar.Name = "lblInfoEditar";
            lblInfoEditar.Size = new Size(65, 26);
            lblInfoEditar.TabIndex = 0;
            lblInfoEditar.Text = "label1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(12, 128);
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
            lblCodigo.Location = new Point(12, 196);
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
            lblDescripcion.Location = new Point(12, 329);
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
            lblCupo.Location = new Point(12, 471);
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
            textBoxNombre.Location = new Point(12, 155);
            textBoxNombre.MaxLength = 25;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(181, 25);
            textBoxNombre.TabIndex = 5;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BackColor = SystemColors.WindowText;
            textBoxCodigo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodigo.ForeColor = Color.Red;
            textBoxCodigo.Location = new Point(12, 223);
            textBoxCodigo.MaxLength = 15;
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(181, 25);
            textBoxCodigo.TabIndex = 6;
            textBoxCodigo.TextChanged += textBoxCodigo_TextChanged;
            // 
            // textBoxCupo
            // 
            textBoxCupo.BackColor = SystemColors.WindowText;
            textBoxCupo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCupo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCupo.ForeColor = Color.Red;
            textBoxCupo.Location = new Point(12, 498);
            textBoxCupo.MaxLength = 3;
            textBoxCupo.Name = "textBoxCupo";
            textBoxCupo.Size = new Size(181, 25);
            textBoxCupo.TabIndex = 7;
            textBoxCupo.TextChanged += textBoxCupo_TextChanged;
            // 
            // richTextBoxDecripcion
            // 
            richTextBoxDecripcion.BackColor = SystemColors.WindowText;
            richTextBoxDecripcion.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxDecripcion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxDecripcion.ForeColor = Color.Red;
            richTextBoxDecripcion.Location = new Point(12, 360);
            richTextBoxDecripcion.MaxLength = 100;
            richTextBoxDecripcion.Name = "richTextBoxDecripcion";
            richTextBoxDecripcion.Size = new Size(282, 96);
            richTextBoxDecripcion.TabIndex = 8;
            richTextBoxDecripcion.Text = "";
            richTextBoxDecripcion.TextChanged += richTextBoxDecripcion_TextChanged;
            // 
            // btnConfirmarEdicion
            // 
            btnConfirmarEdicion.BackColor = SystemColors.WindowText;
            btnConfirmarEdicion.FlatStyle = FlatStyle.Popup;
            btnConfirmarEdicion.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarEdicion.ForeColor = SystemColors.Window;
            btnConfirmarEdicion.Location = new Point(364, 488);
            btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            btnConfirmarEdicion.Size = new Size(106, 41);
            btnConfirmarEdicion.TabIndex = 9;
            btnConfirmarEdicion.Text = "button1";
            btnConfirmarEdicion.UseVisualStyleBackColor = false;
            btnConfirmarEdicion.Click += btnConfirmarEdicion_Click;
            // 
            // lblAula
            // 
            lblAula.AutoSize = true;
            lblAula.BackColor = Color.Transparent;
            lblAula.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAula.ForeColor = SystemColors.Window;
            lblAula.Location = new Point(12, 262);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(46, 18);
            lblAula.TabIndex = 10;
            lblAula.Text = "label1";
            // 
            // tbAula
            // 
            tbAula.BackColor = SystemColors.WindowText;
            tbAula.BorderStyle = BorderStyle.FixedSingle;
            tbAula.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbAula.ForeColor = Color.Red;
            tbAula.Location = new Point(12, 289);
            tbAula.MaxLength = 3;
            tbAula.Name = "tbAula";
            tbAula.Size = new Size(100, 25);
            tbAula.TabIndex = 11;
            tbAula.TextChanged += tbAula_TextChanged;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.BackColor = Color.Transparent;
            lblTurno.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurno.ForeColor = SystemColors.Window;
            lblTurno.Location = new Point(309, 128);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(46, 18);
            lblTurno.TabIndex = 12;
            lblTurno.Text = "label2";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.BackColor = Color.Transparent;
            lblDia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDia.ForeColor = SystemColors.Window;
            lblDia.Location = new Point(309, 196);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(46, 18);
            lblDia.TabIndex = 13;
            lblDia.Text = "label3";
            // 
            // cbTurno
            // 
            cbTurno.BackColor = SystemColors.WindowText;
            cbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTurno.FlatStyle = FlatStyle.Popup;
            cbTurno.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbTurno.ForeColor = Color.Red;
            cbTurno.FormattingEnabled = true;
            cbTurno.Location = new Point(309, 155);
            cbTurno.Name = "cbTurno";
            cbTurno.Size = new Size(121, 25);
            cbTurno.TabIndex = 14;
            cbTurno.SelectedIndexChanged += cbTurno_SelectedIndexChanged;
            // 
            // cbDia
            // 
            cbDia.BackColor = SystemColors.WindowText;
            cbDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDia.FlatStyle = FlatStyle.Popup;
            cbDia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbDia.ForeColor = Color.Red;
            cbDia.FormattingEnabled = true;
            cbDia.Location = new Point(309, 223);
            cbDia.Name = "cbDia";
            cbDia.Size = new Size(121, 25);
            cbDia.TabIndex = 15;
            cbDia.SelectedIndexChanged += cbDia_SelectedIndexChanged;
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
            btnAtras.TabIndex = 16;
            btnAtras.Text = "button1";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // Form_Editar_Curso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(482, 542);
            Controls.Add(btnAtras);
            Controls.Add(cbDia);
            Controls.Add(cbTurno);
            Controls.Add(lblDia);
            Controls.Add(lblTurno);
            Controls.Add(tbAula);
            Controls.Add(lblAula);
            Controls.Add(btnConfirmarEdicion);
            Controls.Add(richTextBoxDecripcion);
            Controls.Add(textBoxCupo);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxNombre);
            Controls.Add(lblCupo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCodigo);
            Controls.Add(lblNombre);
            Controls.Add(lblInfoEditar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Editar_Curso";
            Text = "Form_Editar_Curso";
            Load += Form_Editar_Curso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoEditar;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblDescripcion;
        private Label lblCupo;
        private TextBox textBoxNombre;
        private TextBox textBoxCodigo;
        private TextBox textBoxCupo;
        private RichTextBox richTextBoxDecripcion;
        private Button btnConfirmarEdicion;
        private Label lblAula;
        private TextBox tbAula;
        private Label lblTurno;
        private Label lblDia;
        private ComboBox cbTurno;
        private ComboBox cbDia;
        private Button btnAtras;
    }
}