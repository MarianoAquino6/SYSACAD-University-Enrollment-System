namespace Forms_TP_SYSACAD
{
    partial class Form_Inscripcion_Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inscripcion_Cursos));
            lblInfoCursos = new Label();
            btnAtras = new Button();
            listViewCursosEst = new ListView();
            Nombre = new ColumnHeader();
            Codigo = new ColumnHeader();
            Descripcion = new ColumnHeader();
            CupoMaximo = new ColumnHeader();
            CupoDisp = new ColumnHeader();
            Turno = new ColumnHeader();
            Dia = new ColumnHeader();
            Aula = new ColumnHeader();
            Creditos = new ColumnHeader();
            Promedio = new ColumnHeader();
            Carrera = new ColumnHeader();
            btnInscribirse = new Button();
            lblCreditos = new Label();
            lblPromedio = new Label();
            SuspendLayout();
            // 
            // lblInfoCursos
            // 
            lblInfoCursos.AutoSize = true;
            lblInfoCursos.BackColor = Color.Transparent;
            lblInfoCursos.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfoCursos.ForeColor = SystemColors.Window;
            lblInfoCursos.Location = new Point(21, 67);
            lblInfoCursos.Name = "lblInfoCursos";
            lblInfoCursos.Size = new Size(65, 26);
            lblInfoCursos.TabIndex = 0;
            lblInfoCursos.Text = "label1";
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
            btnAtras.TabIndex = 1;
            btnAtras.Text = "button1";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // listViewCursosEst
            // 
            listViewCursosEst.BackColor = SystemColors.WindowText;
            listViewCursosEst.BorderStyle = BorderStyle.FixedSingle;
            listViewCursosEst.Columns.AddRange(new ColumnHeader[] { Nombre, Codigo, Descripcion, CupoMaximo, CupoDisp, Turno, Dia, Aula, Creditos, Promedio, Carrera });
            listViewCursosEst.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            listViewCursosEst.ForeColor = Color.Red;
            listViewCursosEst.FullRowSelect = true;
            listViewCursosEst.Location = new Point(21, 116);
            listViewCursosEst.Name = "listViewCursosEst";
            listViewCursosEst.Size = new Size(1164, 264);
            listViewCursosEst.TabIndex = 2;
            listViewCursosEst.UseCompatibleStateImageBehavior = false;
            listViewCursosEst.View = View.Details;
            listViewCursosEst.ItemSelectionChanged += listViewCursosEst_ItemSelectionChanged;
            // 
            // Nombre
            // 
            Nombre.Tag = "";
            Nombre.Text = "Nombre";
            Nombre.Width = 120;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo";
            Codigo.TextAlign = HorizontalAlignment.Center;
            Codigo.Width = 80;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            Descripcion.TextAlign = HorizontalAlignment.Center;
            Descripcion.Width = 320;
            // 
            // CupoMaximo
            // 
            CupoMaximo.Text = "Cupo Maximo";
            CupoMaximo.TextAlign = HorizontalAlignment.Center;
            CupoMaximo.Width = 100;
            // 
            // CupoDisp
            // 
            CupoDisp.Text = "CupoDisponible";
            CupoDisp.TextAlign = HorizontalAlignment.Center;
            CupoDisp.Width = 100;
            // 
            // Turno
            // 
            Turno.Text = "Turno";
            Turno.TextAlign = HorizontalAlignment.Center;
            Turno.Width = 80;
            // 
            // Dia
            // 
            Dia.Text = "Dia";
            Dia.TextAlign = HorizontalAlignment.Center;
            Dia.Width = 80;
            // 
            // Aula
            // 
            Aula.Text = "Aula";
            Aula.TextAlign = HorizontalAlignment.Center;
            Aula.Width = 80;
            // 
            // Creditos
            // 
            Creditos.Text = "Creditos";
            Creditos.TextAlign = HorizontalAlignment.Center;
            // 
            // Promedio
            // 
            Promedio.Text = "Promedio";
            Promedio.TextAlign = HorizontalAlignment.Center;
            // 
            // Carrera
            // 
            Carrera.Text = "Carrera";
            Carrera.TextAlign = HorizontalAlignment.Center;
            Carrera.Width = 80;
            // 
            // btnInscribirse
            // 
            btnInscribirse.BackColor = SystemColors.WindowText;
            btnInscribirse.FlatStyle = FlatStyle.Popup;
            btnInscribirse.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribirse.ForeColor = SystemColors.Window;
            btnInscribirse.Location = new Point(1078, 463);
            btnInscribirse.Name = "btnInscribirse";
            btnInscribirse.Size = new Size(107, 33);
            btnInscribirse.TabIndex = 3;
            btnInscribirse.Text = "button2";
            btnInscribirse.UseVisualStyleBackColor = false;
            btnInscribirse.Click += btnInscribirse_Click;
            // 
            // lblCreditos
            // 
            lblCreditos.AutoSize = true;
            lblCreditos.BackColor = Color.Transparent;
            lblCreditos.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreditos.ForeColor = SystemColors.Window;
            lblCreditos.Location = new Point(21, 419);
            lblCreditos.Name = "lblCreditos";
            lblCreditos.Size = new Size(46, 18);
            lblCreditos.TabIndex = 4;
            lblCreditos.Text = "label1";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.BackColor = Color.Transparent;
            lblPromedio.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPromedio.ForeColor = SystemColors.Window;
            lblPromedio.Location = new Point(21, 455);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(46, 18);
            lblPromedio.TabIndex = 5;
            lblPromedio.Text = "label2";
            // 
            // Form_Inscripcion_Cursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1210, 508);
            Controls.Add(lblPromedio);
            Controls.Add(lblCreditos);
            Controls.Add(btnInscribirse);
            Controls.Add(listViewCursosEst);
            Controls.Add(btnAtras);
            Controls.Add(lblInfoCursos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Inscripcion_Cursos";
            Text = "Form_Inscripcion_Cursos";
            Load += Form_Inscripcion_Cursos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoCursos;
        private Button btnAtras;
        private ListView listViewCursosEst;
        private Button btnInscribirse;
        private ColumnHeader Nombre;
        private ColumnHeader Codigo;
        private ColumnHeader Descripcion;
        private ColumnHeader CupoMaximo;
        private ColumnHeader Turno;
        private ColumnHeader Dia;
        private ColumnHeader Aula;
        private ColumnHeader CupoDisp;
        private ColumnHeader Carrera;
        private ColumnHeader Creditos;
        private ColumnHeader Promedio;
        private Label lblCreditos;
        private Label lblPromedio;
    }
}