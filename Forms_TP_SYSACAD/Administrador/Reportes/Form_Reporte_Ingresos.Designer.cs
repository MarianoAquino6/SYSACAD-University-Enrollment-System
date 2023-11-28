namespace Forms_TP_SYSACAD
{
    partial class Form_Reporte_Ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reporte_Ingresos));
            btnPanel = new Button();
            listViewPagos = new ListView();
            columnaConcepto = new ColumnHeader();
            columnaNombre = new ColumnHeader();
            columnaLegajo = new ColumnHeader();
            columnaMonto = new ColumnHeader();
            columnaFecha = new ColumnHeader();
            btnPDF = new Button();
            lblInfo = new Label();
            lblCantidadDeRegistros = new Label();
            lblIngresosTotales = new Label();
            lblFechaPopular = new Label();
            SuspendLayout();
            // 
            // btnPanel
            // 
            btnPanel.BackColor = SystemColors.WindowText;
            btnPanel.FlatStyle = FlatStyle.Popup;
            btnPanel.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPanel.ForeColor = SystemColors.Window;
            btnPanel.Location = new Point(623, 514);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(107, 31);
            btnPanel.TabIndex = 0;
            btnPanel.Text = "button1";
            btnPanel.UseVisualStyleBackColor = false;
            btnPanel.Click += btnPanel_Click;
            // 
            // listViewPagos
            // 
            listViewPagos.BackColor = SystemColors.WindowText;
            listViewPagos.BorderStyle = BorderStyle.FixedSingle;
            listViewPagos.Columns.AddRange(new ColumnHeader[] { columnaConcepto, columnaNombre, columnaLegajo, columnaMonto, columnaFecha });
            listViewPagos.ForeColor = Color.Red;
            listViewPagos.Location = new Point(36, 36);
            listViewPagos.Name = "listViewPagos";
            listViewPagos.Size = new Size(694, 339);
            listViewPagos.TabIndex = 1;
            listViewPagos.UseCompatibleStateImageBehavior = false;
            listViewPagos.View = View.Details;
            // 
            // columnaConcepto
            // 
            columnaConcepto.Text = "Concepto";
            columnaConcepto.Width = 200;
            // 
            // columnaNombre
            // 
            columnaNombre.Text = "Estudiante";
            columnaNombre.TextAlign = HorizontalAlignment.Center;
            columnaNombre.Width = 150;
            // 
            // columnaLegajo
            // 
            columnaLegajo.Text = "Legajo";
            columnaLegajo.TextAlign = HorizontalAlignment.Center;
            columnaLegajo.Width = 100;
            // 
            // columnaMonto
            // 
            columnaMonto.Text = "Ingreso";
            columnaMonto.TextAlign = HorizontalAlignment.Center;
            columnaMonto.Width = 120;
            // 
            // columnaFecha
            // 
            columnaFecha.Text = "Fecha";
            columnaFecha.TextAlign = HorizontalAlignment.Center;
            columnaFecha.Width = 120;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = SystemColors.WindowText;
            btnPDF.FlatStyle = FlatStyle.Popup;
            btnPDF.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPDF.ForeColor = SystemColors.Window;
            btnPDF.Location = new Point(483, 514);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(107, 31);
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
            lblInfo.Location = new Point(52, 402);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(65, 26);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "label1";
            // 
            // lblCantidadDeRegistros
            // 
            lblCantidadDeRegistros.AutoSize = true;
            lblCantidadDeRegistros.BackColor = Color.Transparent;
            lblCantidadDeRegistros.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadDeRegistros.ForeColor = SystemColors.Window;
            lblCantidadDeRegistros.Location = new Point(52, 443);
            lblCantidadDeRegistros.Name = "lblCantidadDeRegistros";
            lblCantidadDeRegistros.Size = new Size(46, 18);
            lblCantidadDeRegistros.TabIndex = 4;
            lblCantidadDeRegistros.Text = "label2";
            // 
            // lblIngresosTotales
            // 
            lblIngresosTotales.AutoSize = true;
            lblIngresosTotales.BackColor = Color.Transparent;
            lblIngresosTotales.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngresosTotales.ForeColor = SystemColors.Window;
            lblIngresosTotales.Location = new Point(52, 471);
            lblIngresosTotales.Name = "lblIngresosTotales";
            lblIngresosTotales.Size = new Size(46, 18);
            lblIngresosTotales.TabIndex = 5;
            lblIngresosTotales.Text = "label3";
            // 
            // lblFechaPopular
            // 
            lblFechaPopular.AutoSize = true;
            lblFechaPopular.BackColor = Color.Transparent;
            lblFechaPopular.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaPopular.ForeColor = SystemColors.Window;
            lblFechaPopular.Location = new Point(52, 497);
            lblFechaPopular.Name = "lblFechaPopular";
            lblFechaPopular.Size = new Size(46, 18);
            lblFechaPopular.TabIndex = 6;
            lblFechaPopular.Text = "label1";
            // 
            // Form_Reporte_Ingresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(770, 557);
            Controls.Add(lblFechaPopular);
            Controls.Add(lblIngresosTotales);
            Controls.Add(lblCantidadDeRegistros);
            Controls.Add(lblInfo);
            Controls.Add(btnPDF);
            Controls.Add(listViewPagos);
            Controls.Add(btnPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Reporte_Ingresos";
            Text = "Form_Inscr_Concepto_Periodo";
            Load += Form_Reporte_Ingresos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPanel;
        private ListView listViewPagos;
        private Button btnPDF;
        private ColumnHeader columnaConcepto;
        private ColumnHeader columnaNombre;
        private ColumnHeader columnaLegajo;
        private ColumnHeader columnaMonto;
        private ColumnHeader columnaFecha;
        private Label lblInfo;
        private Label lblCantidadDeRegistros;
        private Label lblIngresosTotales;
        private Label lblFechaPopular;
    }
}