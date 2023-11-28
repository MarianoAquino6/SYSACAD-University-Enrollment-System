namespace Forms_TP_SYSACAD
{
    partial class Form_Reporte_Inscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reporte_Inscripciones));
            listViewInscripciones = new ListView();
            columnaCarrera = new ColumnHeader();
            columnaLegajoEst = new ColumnHeader();
            columnaNombreEst = new ColumnHeader();
            columnaCodigoCurso = new ColumnHeader();
            columnaNombreCurso = new ColumnHeader();
            columnaFecha = new ColumnHeader();
            btnPanel = new Button();
            btnPDF = new Button();
            lblInfo = new Label();
            lblTotales = new Label();
            lblFechaPopular = new Label();
            lblMediaPorDia = new Label();
            SuspendLayout();
            // 
            // listViewInscripciones
            // 
            listViewInscripciones.BackColor = SystemColors.WindowText;
            listViewInscripciones.BorderStyle = BorderStyle.FixedSingle;
            listViewInscripciones.Columns.AddRange(new ColumnHeader[] { columnaCarrera, columnaLegajoEst, columnaNombreEst, columnaCodigoCurso, columnaNombreCurso, columnaFecha });
            listViewInscripciones.ForeColor = Color.Red;
            listViewInscripciones.Location = new Point(30, 45);
            listViewInscripciones.Name = "listViewInscripciones";
            listViewInscripciones.Size = new Size(774, 310);
            listViewInscripciones.TabIndex = 0;
            listViewInscripciones.UseCompatibleStateImageBehavior = false;
            listViewInscripciones.View = View.Details;
            // 
            // columnaCarrera
            // 
            columnaCarrera.Text = "Carrera";
            columnaCarrera.Width = 80;
            // 
            // columnaLegajoEst
            // 
            columnaLegajoEst.Text = "Legajo Alumno";
            columnaLegajoEst.TextAlign = HorizontalAlignment.Center;
            columnaLegajoEst.Width = 100;
            // 
            // columnaNombreEst
            // 
            columnaNombreEst.Text = "Nombre Alumno";
            columnaNombreEst.TextAlign = HorizontalAlignment.Center;
            columnaNombreEst.Width = 120;
            // 
            // columnaCodigoCurso
            // 
            columnaCodigoCurso.Text = "Codigo Curso";
            columnaCodigoCurso.TextAlign = HorizontalAlignment.Center;
            columnaCodigoCurso.Width = 120;
            // 
            // columnaNombreCurso
            // 
            columnaNombreCurso.Text = "Nombre Curso";
            columnaNombreCurso.TextAlign = HorizontalAlignment.Center;
            columnaNombreCurso.Width = 200;
            // 
            // columnaFecha
            // 
            columnaFecha.Text = "Fecha Inscripcion";
            columnaFecha.TextAlign = HorizontalAlignment.Center;
            columnaFecha.Width = 150;
            // 
            // btnPanel
            // 
            btnPanel.BackColor = SystemColors.WindowText;
            btnPanel.FlatStyle = FlatStyle.Popup;
            btnPanel.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPanel.ForeColor = SystemColors.Window;
            btnPanel.Location = new Point(690, 494);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(114, 33);
            btnPanel.TabIndex = 1;
            btnPanel.Text = "button1";
            btnPanel.UseVisualStyleBackColor = false;
            btnPanel.Click += btnPanel_Click;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = SystemColors.WindowText;
            btnPDF.FlatStyle = FlatStyle.Popup;
            btnPDF.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPDF.ForeColor = SystemColors.Window;
            btnPDF.Location = new Point(528, 494);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(114, 33);
            btnPDF.TabIndex = 2;
            btnPDF.Text = "button2";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.Window;
            lblInfo.Location = new Point(30, 381);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(65, 26);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "label1";
            // 
            // lblTotales
            // 
            lblTotales.AutoSize = true;
            lblTotales.BackColor = Color.Transparent;
            lblTotales.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotales.ForeColor = SystemColors.Window;
            lblTotales.Location = new Point(30, 416);
            lblTotales.Name = "lblTotales";
            lblTotales.Size = new Size(46, 18);
            lblTotales.TabIndex = 4;
            lblTotales.Text = "label2";
            // 
            // lblFechaPopular
            // 
            lblFechaPopular.AutoSize = true;
            lblFechaPopular.BackColor = Color.Transparent;
            lblFechaPopular.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaPopular.ForeColor = SystemColors.Window;
            lblFechaPopular.Location = new Point(30, 447);
            lblFechaPopular.Name = "lblFechaPopular";
            lblFechaPopular.Size = new Size(46, 18);
            lblFechaPopular.TabIndex = 5;
            lblFechaPopular.Text = "label3";
            // 
            // lblMediaPorDia
            // 
            lblMediaPorDia.AutoSize = true;
            lblMediaPorDia.BackColor = Color.Transparent;
            lblMediaPorDia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMediaPorDia.ForeColor = SystemColors.Window;
            lblMediaPorDia.Location = new Point(30, 478);
            lblMediaPorDia.Name = "lblMediaPorDia";
            lblMediaPorDia.Size = new Size(46, 18);
            lblMediaPorDia.TabIndex = 6;
            lblMediaPorDia.Text = "label4";
            // 
            // Form_Reporte_Inscripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(840, 539);
            Controls.Add(lblMediaPorDia);
            Controls.Add(lblFechaPopular);
            Controls.Add(lblTotales);
            Controls.Add(lblInfo);
            Controls.Add(btnPDF);
            Controls.Add(btnPanel);
            Controls.Add(listViewInscripciones);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Reporte_Inscripciones";
            Text = "Form_Reporte_Inscr_Totales_Por_Periodo";
            Load += Form_Inscr_Totales_Periodo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewInscripciones;
        private ColumnHeader columnaCarrera;
        private ColumnHeader columnaLegajoEst;
        private ColumnHeader columnaNombreEst;
        private ColumnHeader columnaCodigoCurso;
        private ColumnHeader columnaNombreCurso;
        private ColumnHeader columnaFecha;
        private Button btnPanel;
        private Button btnPDF;
        private Label lblInfo;
        private Label lblTotales;
        private Label lblFechaPopular;
        private Label lblMediaPorDia;
    }
}