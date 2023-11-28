namespace Forms_TP_SYSACAD.Administrador.Profesores
{
    partial class Form_Profesores_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Profesores_Principal));
            btnAtras = new Button();
            lblInfo = new Label();
            listViewProfesores = new ListView();
            nombre = new ColumnHeader();
            correo = new ColumnHeader();
            telefono = new ColumnHeader();
            especializacion = new ColumnHeader();
            cursos = new ColumnHeader();
            direccion = new ColumnHeader();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAgregarCurso = new Button();
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
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.Window;
            lblInfo.Location = new Point(12, 77);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(65, 26);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "label1";
            // 
            // listViewProfesores
            // 
            listViewProfesores.BackColor = SystemColors.WindowText;
            listViewProfesores.BorderStyle = BorderStyle.FixedSingle;
            listViewProfesores.Columns.AddRange(new ColumnHeader[] { nombre, correo, telefono, especializacion, cursos, direccion });
            listViewProfesores.ForeColor = Color.Red;
            listViewProfesores.FullRowSelect = true;
            listViewProfesores.Location = new Point(12, 112);
            listViewProfesores.Name = "listViewProfesores";
            listViewProfesores.Size = new Size(864, 270);
            listViewProfesores.TabIndex = 2;
            listViewProfesores.UseCompatibleStateImageBehavior = false;
            listViewProfesores.View = View.Details;
            listViewProfesores.ItemSelectionChanged += listViewProfesores_SelectedIndexChanged;
            // 
            // nombre
            // 
            nombre.Text = "Nombre";
            nombre.Width = 120;
            // 
            // correo
            // 
            correo.Text = "Correo";
            correo.TextAlign = HorizontalAlignment.Center;
            correo.Width = 160;
            // 
            // telefono
            // 
            telefono.Text = "Telefono";
            telefono.TextAlign = HorizontalAlignment.Center;
            telefono.Width = 110;
            // 
            // especializacion
            // 
            especializacion.Text = "Especializacion";
            especializacion.TextAlign = HorizontalAlignment.Center;
            especializacion.Width = 120;
            // 
            // cursos
            // 
            cursos.Text = "Cursos";
            cursos.TextAlign = HorizontalAlignment.Center;
            cursos.Width = 250;
            // 
            // direccion
            // 
            direccion.Text = "Direccion";
            direccion.TextAlign = HorizontalAlignment.Center;
            direccion.Width = 100;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.WindowText;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(110, 415);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 31);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "button2";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.WindowText;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = SystemColors.Window;
            btnEditar.Location = new Point(287, 415);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(106, 31);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "button3";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.WindowText;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.Window;
            btnEliminar.Location = new Point(461, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 31);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "button4";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.BackColor = SystemColors.WindowText;
            btnAgregarCurso.FlatStyle = FlatStyle.Popup;
            btnAgregarCurso.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCurso.ForeColor = SystemColors.Window;
            btnAgregarCurso.Location = new Point(646, 415);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(106, 31);
            btnAgregarCurso.TabIndex = 6;
            btnAgregarCurso.Text = "button5";
            btnAgregarCurso.UseVisualStyleBackColor = false;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
            // 
            // Form_Profesores_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(895, 477);
            Controls.Add(btnAgregarCurso);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(listViewProfesores);
            Controls.Add(lblInfo);
            Controls.Add(btnAtras);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Profesores_Principal";
            Text = "Form_Profesores_Principal";
            Load += Form_Profesores_Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label lblInfo;
        private ListView listViewProfesores;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnAgregarCurso;
        private ColumnHeader nombre;
        private ColumnHeader correo;
        private ColumnHeader telefono;
        private ColumnHeader especializacion;
        private ColumnHeader cursos;
        private ColumnHeader direccion;
    }
}