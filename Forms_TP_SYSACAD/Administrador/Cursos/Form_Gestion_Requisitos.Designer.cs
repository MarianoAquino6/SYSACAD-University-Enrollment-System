namespace Forms_TP_SYSACAD
{
    partial class Form_Gestion_Requisitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestion_Requisitos));
            btnAtras = new Button();
            lblCurso = new Label();
            cbCursos = new ComboBox();
            lblRequisitoCursos = new Label();
            listViewCursosRequisitos = new ListView();
            columnaCodigo = new ColumnHeader();
            columnaCurso = new ColumnHeader();
            lblRequisitoCreditos = new Label();
            lblRequisitoPromedio = new Label();
            tbCreditos = new TextBox();
            tbPromedio = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            lblAgregar = new Label();
            cbAgregarCorrelatividad = new ComboBox();
            btnAgregar = new Button();
            lblModificar = new Label();
            lblEliminar = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            btnAtras.TabIndex = 0;
            btnAtras.Text = "button1";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.BackColor = Color.Transparent;
            lblCurso.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurso.ForeColor = SystemColors.Window;
            lblCurso.Location = new Point(12, 92);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(46, 18);
            lblCurso.TabIndex = 1;
            lblCurso.Text = "label1";
            // 
            // cbCursos
            // 
            cbCursos.BackColor = SystemColors.WindowText;
            cbCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCursos.FlatStyle = FlatStyle.Popup;
            cbCursos.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCursos.ForeColor = Color.Red;
            cbCursos.FormattingEnabled = true;
            cbCursos.Location = new Point(12, 122);
            cbCursos.Name = "cbCursos";
            cbCursos.Size = new Size(200, 25);
            cbCursos.TabIndex = 2;
            cbCursos.SelectedIndexChanged += cbCursos_SelectedIndexChanged;
            // 
            // lblRequisitoCursos
            // 
            lblRequisitoCursos.AutoSize = true;
            lblRequisitoCursos.BackColor = Color.Transparent;
            lblRequisitoCursos.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequisitoCursos.ForeColor = SystemColors.Window;
            lblRequisitoCursos.Location = new Point(12, 169);
            lblRequisitoCursos.Name = "lblRequisitoCursos";
            lblRequisitoCursos.Size = new Size(46, 18);
            lblRequisitoCursos.TabIndex = 3;
            lblRequisitoCursos.Text = "label2";
            // 
            // listViewCursosRequisitos
            // 
            listViewCursosRequisitos.BackColor = SystemColors.WindowText;
            listViewCursosRequisitos.BorderStyle = BorderStyle.FixedSingle;
            listViewCursosRequisitos.Columns.AddRange(new ColumnHeader[] { columnaCodigo, columnaCurso });
            listViewCursosRequisitos.ForeColor = Color.Red;
            listViewCursosRequisitos.FullRowSelect = true;
            listViewCursosRequisitos.Location = new Point(12, 197);
            listViewCursosRequisitos.Name = "listViewCursosRequisitos";
            listViewCursosRequisitos.Size = new Size(444, 253);
            listViewCursosRequisitos.TabIndex = 4;
            listViewCursosRequisitos.UseCompatibleStateImageBehavior = false;
            listViewCursosRequisitos.View = View.Details;
            listViewCursosRequisitos.ItemSelectionChanged += listViewCursosRequisitos_ItemSelectionChanged;
            // 
            // columnaCodigo
            // 
            columnaCodigo.Text = "CodigoFamilia";
            columnaCodigo.Width = 220;
            // 
            // columnaCurso
            // 
            columnaCurso.Text = "Curso";
            columnaCurso.TextAlign = HorizontalAlignment.Center;
            columnaCurso.Width = 220;
            // 
            // lblRequisitoCreditos
            // 
            lblRequisitoCreditos.AutoSize = true;
            lblRequisitoCreditos.BackColor = Color.Transparent;
            lblRequisitoCreditos.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequisitoCreditos.ForeColor = SystemColors.Window;
            lblRequisitoCreditos.Location = new Point(12, 468);
            lblRequisitoCreditos.Name = "lblRequisitoCreditos";
            lblRequisitoCreditos.Size = new Size(46, 18);
            lblRequisitoCreditos.TabIndex = 5;
            lblRequisitoCreditos.Text = "label3";
            // 
            // lblRequisitoPromedio
            // 
            lblRequisitoPromedio.AutoSize = true;
            lblRequisitoPromedio.BackColor = Color.Transparent;
            lblRequisitoPromedio.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequisitoPromedio.ForeColor = SystemColors.Window;
            lblRequisitoPromedio.Location = new Point(12, 539);
            lblRequisitoPromedio.Name = "lblRequisitoPromedio";
            lblRequisitoPromedio.Size = new Size(46, 18);
            lblRequisitoPromedio.TabIndex = 6;
            lblRequisitoPromedio.Text = "label4";
            // 
            // tbCreditos
            // 
            tbCreditos.BackColor = SystemColors.WindowText;
            tbCreditos.BorderStyle = BorderStyle.FixedSingle;
            tbCreditos.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCreditos.ForeColor = Color.Red;
            tbCreditos.Location = new Point(12, 495);
            tbCreditos.MaxLength = 4;
            tbCreditos.Name = "tbCreditos";
            tbCreditos.Size = new Size(121, 25);
            tbCreditos.TabIndex = 7;
            tbCreditos.TextChanged += tbCreditos_TextChanged;
            // 
            // tbPromedio
            // 
            tbPromedio.BackColor = SystemColors.WindowText;
            tbPromedio.BorderStyle = BorderStyle.FixedSingle;
            tbPromedio.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbPromedio.ForeColor = Color.Red;
            tbPromedio.Location = new Point(12, 566);
            tbPromedio.MaxLength = 3;
            tbPromedio.Name = "tbPromedio";
            tbPromedio.PlaceholderText = "HASTA 1 DECIMAL. USE COMA";
            tbPromedio.Size = new Size(188, 25);
            tbPromedio.TabIndex = 8;
            tbPromedio.TextChanged += tbPromedio_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.WindowText;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(632, 550);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 39);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "button2";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.WindowText;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.Window;
            btnEliminar.Location = new Point(9, 49);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 22);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "button3";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgregar.ForeColor = SystemColors.Window;
            lblAgregar.Location = new Point(9, 15);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(46, 18);
            lblAgregar.TabIndex = 11;
            lblAgregar.Text = "label5";
            // 
            // cbAgregarCorrelatividad
            // 
            cbAgregarCorrelatividad.BackColor = SystemColors.WindowText;
            cbAgregarCorrelatividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAgregarCorrelatividad.FlatStyle = FlatStyle.Popup;
            cbAgregarCorrelatividad.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbAgregarCorrelatividad.ForeColor = Color.Red;
            cbAgregarCorrelatividad.FormattingEnabled = true;
            cbAgregarCorrelatividad.Location = new Point(9, 43);
            cbAgregarCorrelatividad.Name = "cbAgregarCorrelatividad";
            cbAgregarCorrelatividad.Size = new Size(205, 25);
            cbAgregarCorrelatividad.TabIndex = 12;
            cbAgregarCorrelatividad.SelectedIndexChanged += cbAgregarCorrelatividad_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.WindowText;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(134, 80);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(80, 25);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "button1";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificar.ForeColor = SystemColors.Window;
            lblModificar.Location = new Point(52, 12);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(46, 18);
            lblModificar.TabIndex = 14;
            lblModificar.Text = "label1";
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEliminar.ForeColor = SystemColors.Window;
            lblEliminar.Location = new Point(9, 14);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(46, 18);
            lblEliminar.TabIndex = 15;
            lblEliminar.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblModificar);
            panel1.Location = new Point(508, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 262);
            panel1.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblAgregar);
            panel3.Controls.Add(cbAgregarCorrelatividad);
            panel3.Controls.Add(btnAgregar);
            panel3.Location = new Point(-1, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 119);
            panel3.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblEliminar);
            panel2.Controls.Add(btnEliminar);
            panel2.Location = new Point(-1, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 100);
            panel2.TabIndex = 16;
            // 
            // Form_Gestion_Requisitos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(753, 616);
            Controls.Add(panel1);
            Controls.Add(btnGuardar);
            Controls.Add(tbPromedio);
            Controls.Add(tbCreditos);
            Controls.Add(lblRequisitoPromedio);
            Controls.Add(lblRequisitoCreditos);
            Controls.Add(listViewCursosRequisitos);
            Controls.Add(lblRequisitoCursos);
            Controls.Add(cbCursos);
            Controls.Add(lblCurso);
            Controls.Add(btnAtras);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Gestion_Requisitos";
            Text = "Form_Gestion_Requisitos";
            Load += Form_Gestion_Requisitos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label lblCurso;
        private ComboBox cbCursos;
        private Label lblRequisitoCursos;
        private ListView listViewCursosRequisitos;
        private Label lblRequisitoCreditos;
        private Label lblRequisitoPromedio;
        private TextBox tbCreditos;
        private TextBox tbPromedio;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label lblAgregar;
        private ColumnHeader columnaCodigo;
        private ColumnHeader columnaCurso;
        private ComboBox cbAgregarCorrelatividad;
        private Button btnAgregar;
        private Label lblModificar;
        private Label lblEliminar;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}