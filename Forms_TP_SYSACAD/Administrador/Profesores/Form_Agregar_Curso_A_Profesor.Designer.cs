namespace Forms_TP_SYSACAD.Administrador.Profesores
{
    partial class Form_Agregar_Curso_A_Profesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Agregar_Curso_A_Profesor));
            listViewCursosDisponibles = new ListView();
            nombre = new ColumnHeader();
            codigo = new ColumnHeader();
            dia = new ColumnHeader();
            turno = new ColumnHeader();
            aula = new ColumnHeader();
            carrera = new ColumnHeader();
            btnAtras = new Button();
            lblInfo = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // listViewCursosDisponibles
            // 
            listViewCursosDisponibles.BackColor = SystemColors.WindowText;
            listViewCursosDisponibles.BorderStyle = BorderStyle.FixedSingle;
            listViewCursosDisponibles.Columns.AddRange(new ColumnHeader[] { nombre, codigo, dia, turno, aula, carrera });
            listViewCursosDisponibles.ForeColor = Color.Red;
            listViewCursosDisponibles.Location = new Point(12, 114);
            listViewCursosDisponibles.Name = "listViewCursosDisponibles";
            listViewCursosDisponibles.Size = new Size(614, 312);
            listViewCursosDisponibles.TabIndex = 0;
            listViewCursosDisponibles.UseCompatibleStateImageBehavior = false;
            listViewCursosDisponibles.View = View.Details;
            listViewCursosDisponibles.ItemSelectionChanged += listViewCursosDisponibles_ItemSelectionChanged;
            // 
            // nombre
            // 
            nombre.Text = "Nombre";
            nombre.Width = 150;
            // 
            // codigo
            // 
            codigo.Text = "Codigo";
            codigo.TextAlign = HorizontalAlignment.Center;
            codigo.Width = 100;
            // 
            // dia
            // 
            dia.Text = "Dia";
            dia.TextAlign = HorizontalAlignment.Center;
            dia.Width = 100;
            // 
            // turno
            // 
            turno.Text = "Turno";
            turno.TextAlign = HorizontalAlignment.Center;
            turno.Width = 100;
            // 
            // aula
            // 
            aula.Text = "Aula";
            aula.TextAlign = HorizontalAlignment.Center;
            aula.Width = 80;
            // 
            // carrera
            // 
            carrera.Text = "Carrera";
            carrera.TextAlign = HorizontalAlignment.Center;
            carrera.Width = 80;
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
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.Window;
            lblInfo.Location = new Point(12, 73);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(65, 26);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "label1";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.WindowText;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(525, 452);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 37);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "button2";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form_Agregar_Curso_A_Profesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(641, 501);
            Controls.Add(btnAgregar);
            Controls.Add(lblInfo);
            Controls.Add(btnAtras);
            Controls.Add(listViewCursosDisponibles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Agregar_Curso_A_Profesor";
            Text = "Form_Agregar_Curso_A_Profesor";
            Load += Form_Agregar_Curso_A_Profesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewCursosDisponibles;
        private Button btnAtras;
        private Label lblInfo;
        private ColumnHeader nombre;
        private ColumnHeader codigo;
        private ColumnHeader dia;
        private ColumnHeader turno;
        private ColumnHeader aula;
        private ColumnHeader carrera;
        private Button btnAgregar;
    }
}