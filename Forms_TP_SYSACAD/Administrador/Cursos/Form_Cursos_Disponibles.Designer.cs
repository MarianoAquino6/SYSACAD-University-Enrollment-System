namespace Forms_TP_SYSACAD
{
    partial class Form_Cursos_Disponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cursos_Disponibles));
            lblInfoCursos = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            listView1 = new ListView();
            columnaNombre = new ColumnHeader();
            columnaCodigo = new ColumnHeader();
            columnaDescripcion = new ColumnHeader();
            columnaCupos = new ColumnHeader();
            columnCuposDispon = new ColumnHeader();
            columnaTurno = new ColumnHeader();
            columnaDia = new ColumnHeader();
            columnaAula = new ColumnHeader();
            columnaCarrera = new ColumnHeader();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // lblInfoCursos
            // 
            lblInfoCursos.AutoSize = true;
            lblInfoCursos.BackColor = Color.Transparent;
            lblInfoCursos.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfoCursos.ForeColor = SystemColors.Window;
            lblInfoCursos.Location = new Point(24, 66);
            lblInfoCursos.Name = "lblInfoCursos";
            lblInfoCursos.Size = new Size(65, 26);
            lblInfoCursos.TabIndex = 0;
            lblInfoCursos.Text = "label1";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.WindowText;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(245, 454);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 52);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "button1";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.WindowText;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.Window;
            btnModificar.Location = new Point(442, 454);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 52);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "button2";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.WindowText;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.Window;
            btnEliminar.Location = new Point(637, 454);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 52);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "button3";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.WindowText;
            listView1.Columns.AddRange(new ColumnHeader[] { columnaNombre, columnaCodigo, columnaDescripcion, columnaCupos, columnCuposDispon, columnaTurno, columnaDia, columnaAula, columnaCarrera });
            listView1.ForeColor = Color.Red;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(24, 106);
            listView1.Name = "listView1";
            listView1.Size = new Size(1034, 322);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            // 
            // columnaNombre
            // 
            columnaNombre.Text = "Nombre";
            columnaNombre.Width = 120;
            // 
            // columnaCodigo
            // 
            columnaCodigo.Text = "Codigo";
            columnaCodigo.TextAlign = HorizontalAlignment.Center;
            columnaCodigo.Width = 80;
            // 
            // columnaDescripcion
            // 
            columnaDescripcion.Text = "Descripcion";
            columnaDescripcion.TextAlign = HorizontalAlignment.Center;
            columnaDescripcion.Width = 350;
            // 
            // columnaCupos
            // 
            columnaCupos.Text = "CuposTot";
            columnaCupos.TextAlign = HorizontalAlignment.Center;
            columnaCupos.Width = 80;
            // 
            // columnCuposDispon
            // 
            columnCuposDispon.Text = "Cupos Disp";
            columnCuposDispon.TextAlign = HorizontalAlignment.Center;
            columnCuposDispon.Width = 80;
            // 
            // columnaTurno
            // 
            columnaTurno.Text = "Turno";
            columnaTurno.TextAlign = HorizontalAlignment.Center;
            columnaTurno.Width = 80;
            // 
            // columnaDia
            // 
            columnaDia.Text = "Dia";
            columnaDia.TextAlign = HorizontalAlignment.Center;
            columnaDia.Width = 80;
            // 
            // columnaAula
            // 
            columnaAula.Text = "Aula";
            columnaAula.TextAlign = HorizontalAlignment.Center;
            columnaAula.Width = 80;
            // 
            // columnaCarrera
            // 
            columnaCarrera.Text = "Carrera";
            columnaCarrera.TextAlign = HorizontalAlignment.Center;
            columnaCarrera.Width = 80;
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
            btnAtras.TabIndex = 6;
            btnAtras.Text = "button1";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // Form_Cursos_Disponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 527);
            Controls.Add(btnAtras);
            Controls.Add(listView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lblInfoCursos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Cursos_Disponibles";
            Text = "Form_Cursos_Disponibles";
            Load += Form_Cursos_Disponibles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoCursos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListView listView1;
        private ColumnHeader columnaNombre;
        private ColumnHeader columnaCodigo;
        private ColumnHeader columnaDescripcion;
        private ColumnHeader columnaCupos;
        private Button btnAtras;
        private ColumnHeader columnaTurno;
        private ColumnHeader columnaDia;
        private ColumnHeader columnaAula;
        private ColumnHeader columnCuposDispon;
        private ColumnHeader columnaCarrera;
    }
}