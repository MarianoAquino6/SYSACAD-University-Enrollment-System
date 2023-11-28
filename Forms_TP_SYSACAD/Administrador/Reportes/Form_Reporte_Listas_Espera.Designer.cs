namespace Forms_TP_SYSACAD.Administrador.Reportes
{
    partial class Form_Reporte_Listas_Espera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reporte_Listas_Espera));
            listViewListasEspera = new ListView();
            curso = new ColumnHeader();
            turno = new ColumnHeader();
            alumno = new ColumnHeader();
            fecha = new ColumnHeader();
            btnPDF = new Button();
            btnPanel = new Button();
            SuspendLayout();
            // 
            // listViewListasEspera
            // 
            listViewListasEspera.BackColor = SystemColors.WindowText;
            listViewListasEspera.BorderStyle = BorderStyle.FixedSingle;
            listViewListasEspera.Columns.AddRange(new ColumnHeader[] { curso, turno, alumno, fecha });
            listViewListasEspera.ForeColor = Color.Red;
            listViewListasEspera.Location = new Point(35, 36);
            listViewListasEspera.Name = "listViewListasEspera";
            listViewListasEspera.Size = new Size(534, 284);
            listViewListasEspera.TabIndex = 0;
            listViewListasEspera.UseCompatibleStateImageBehavior = false;
            listViewListasEspera.View = View.Details;
            // 
            // curso
            // 
            curso.Text = "Curso";
            curso.Width = 150;
            // 
            // turno
            // 
            turno.Text = "Turno";
            turno.TextAlign = HorizontalAlignment.Center;
            turno.Width = 80;
            // 
            // alumno
            // 
            alumno.Text = "Alumno";
            alumno.TextAlign = HorizontalAlignment.Center;
            alumno.Width = 150;
            // 
            // fecha
            // 
            fecha.Text = "Fecha Inscripcion";
            fecha.TextAlign = HorizontalAlignment.Center;
            fecha.Width = 150;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = SystemColors.WindowText;
            btnPDF.FlatStyle = FlatStyle.Popup;
            btnPDF.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPDF.ForeColor = SystemColors.Window;
            btnPDF.Location = new Point(156, 366);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(98, 36);
            btnPDF.TabIndex = 5;
            btnPDF.Text = "button1";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnPanel
            // 
            btnPanel.BackColor = SystemColors.WindowText;
            btnPanel.FlatStyle = FlatStyle.Popup;
            btnPanel.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPanel.ForeColor = SystemColors.Window;
            btnPanel.Location = new Point(337, 366);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(98, 36);
            btnPanel.TabIndex = 6;
            btnPanel.Text = "button2";
            btnPanel.UseVisualStyleBackColor = false;
            btnPanel.Click += btnPanel_Click;
            // 
            // Form_Reporte_Listas_Espera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(604, 421);
            Controls.Add(btnPanel);
            Controls.Add(btnPDF);
            Controls.Add(listViewListasEspera);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Reporte_Listas_Espera";
            Text = "Form_Reporte_Listas_Espera";
            Load += Form_Reporte_Listas_Espera_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewListasEspera;
        private ColumnHeader curso;
        private ColumnHeader turno;
        private ColumnHeader alumno;
        private ColumnHeader fecha;
        private Button btnPDF;
        private Button btnPanel;
    }
}