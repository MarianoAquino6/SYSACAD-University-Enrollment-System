namespace Forms_TP_SYSACAD
{
    partial class Form_Gestion_Listas_Espera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestion_Listas_Espera));
            btnAtras = new Button();
            lblCurso = new Label();
            cbCursos = new ComboBox();
            lblListasDeEspera = new Label();
            btnAgregar = new Button();
            lblAgregar = new Label();
            tbLegajoAlumno = new TextBox();
            lblEliminar = new Label();
            btnEliminar = new Button();
            btnGuardar = new Button();
            listViewListaEspera = new ListView();
            nombre = new ColumnHeader();
            legajo = new ColumnHeader();
            fecha = new ColumnHeader();
            panel1 = new Panel();
            lblModificar = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
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
            lblCurso.Location = new Point(12, 78);
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
            cbCursos.Location = new Point(12, 106);
            cbCursos.Name = "cbCursos";
            cbCursos.Size = new Size(236, 25);
            cbCursos.TabIndex = 2;
            cbCursos.SelectedIndexChanged += cbCursos_SelectedIndexChanged;
            // 
            // lblListasDeEspera
            // 
            lblListasDeEspera.AutoSize = true;
            lblListasDeEspera.BackColor = Color.Transparent;
            lblListasDeEspera.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblListasDeEspera.ForeColor = SystemColors.Window;
            lblListasDeEspera.Location = new Point(12, 166);
            lblListasDeEspera.Name = "lblListasDeEspera";
            lblListasDeEspera.Size = new Size(46, 18);
            lblListasDeEspera.TabIndex = 4;
            lblListasDeEspera.Text = "label2";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.WindowText;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(116, 199);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "button2";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgregar.ForeColor = SystemColors.Window;
            lblAgregar.Location = new Point(10, 133);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(46, 18);
            lblAgregar.TabIndex = 6;
            lblAgregar.Text = "label3";
            // 
            // tbLegajoAlumno
            // 
            tbLegajoAlumno.BackColor = SystemColors.WindowText;
            tbLegajoAlumno.BorderStyle = BorderStyle.FixedSingle;
            tbLegajoAlumno.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbLegajoAlumno.ForeColor = Color.Red;
            tbLegajoAlumno.Location = new Point(10, 160);
            tbLegajoAlumno.MaxLength = 8;
            tbLegajoAlumno.Name = "tbLegajoAlumno";
            tbLegajoAlumno.Size = new Size(181, 25);
            tbLegajoAlumno.TabIndex = 7;
            tbLegajoAlumno.TextChanged += tbLegajoAlumno_TextChanged;
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEliminar.ForeColor = SystemColors.Window;
            lblEliminar.Location = new Point(10, 10);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(46, 18);
            lblEliminar.TabIndex = 8;
            lblEliminar.Text = "label4";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.WindowText;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.Window;
            btnEliminar.Location = new Point(10, 39);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "button3";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.WindowText;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(647, 480);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 35);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "button4";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // listViewListaEspera
            // 
            listViewListaEspera.BackColor = SystemColors.WindowText;
            listViewListaEspera.BorderStyle = BorderStyle.FixedSingle;
            listViewListaEspera.Columns.AddRange(new ColumnHeader[] { nombre, legajo, fecha });
            listViewListaEspera.ForeColor = Color.Red;
            listViewListaEspera.FullRowSelect = true;
            listViewListaEspera.Location = new Point(12, 204);
            listViewListaEspera.Name = "listViewListaEspera";
            listViewListaEspera.Size = new Size(504, 244);
            listViewListaEspera.TabIndex = 11;
            listViewListaEspera.UseCompatibleStateImageBehavior = false;
            listViewListaEspera.View = View.Details;
            listViewListaEspera.ItemSelectionChanged += listViewListaEspera_ItemSelectionChanged;
            // 
            // nombre
            // 
            nombre.Text = "Nombre";
            nombre.Width = 200;
            // 
            // legajo
            // 
            legajo.Text = "Legajo";
            legajo.TextAlign = HorizontalAlignment.Center;
            legajo.Width = 100;
            // 
            // fecha
            // 
            fecha.Text = "FechaInscripcion";
            fecha.TextAlign = HorizontalAlignment.Center;
            fecha.Width = 200;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblModificar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblAgregar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(tbLegajoAlumno);
            panel1.Location = new Point(538, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 244);
            panel1.TabIndex = 12;
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificar.ForeColor = SystemColors.Window;
            lblModificar.Location = new Point(46, 14);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(46, 18);
            lblModificar.TabIndex = 0;
            lblModificar.Text = "label1";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblEliminar);
            panel2.Controls.Add(btnEliminar);
            panel2.Location = new Point(-1, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 75);
            panel2.TabIndex = 0;
            // 
            // Form_Gestion_Listas_Espera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(770, 527);
            Controls.Add(panel1);
            Controls.Add(listViewListaEspera);
            Controls.Add(btnGuardar);
            Controls.Add(lblListasDeEspera);
            Controls.Add(cbCursos);
            Controls.Add(lblCurso);
            Controls.Add(btnAtras);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Gestion_Listas_Espera";
            Text = "Form_Gestion_Listas_Espera";
            Load += Form_Gestion_Listas_Espera_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label lblCurso;
        private ComboBox cbCursos;
        private Label lblListasDeEspera;
        private Button btnAgregar;
        private Label lblAgregar;
        private TextBox tbLegajoAlumno;
        private Label lblEliminar;
        private Button btnEliminar;
        private Button btnGuardar;
        private ListView listViewListaEspera;
        private ColumnHeader nombre;
        private ColumnHeader legajo;
        private ColumnHeader fecha;
        private Panel panel1;
        private Label lblModificar;
        private Panel panel2;
    }
}