namespace Forms_TP_SYSACAD
{
    partial class Form_Input_Reporte_Periodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Input_Reporte_Periodo));
            dtpDesde = new DateTimePicker();
            lblInfo = new Label();
            lblDesde = new Label();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            btnContinuar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarForeColor = SystemColors.Window;
            dtpDesde.CalendarMonthBackground = SystemColors.WindowText;
            dtpDesde.CalendarTitleBackColor = Color.Red;
            dtpDesde.CalendarTitleForeColor = Color.Red;
            dtpDesde.Location = new Point(12, 93);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(218, 23);
            dtpDesde.TabIndex = 0;
            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.Window;
            lblInfo.Location = new Point(12, 24);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(65, 26);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "label1";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.BackColor = Color.Transparent;
            lblDesde.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesde.ForeColor = SystemColors.Window;
            lblDesde.Location = new Point(12, 65);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(46, 18);
            lblDesde.TabIndex = 2;
            lblDesde.Text = "label2";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.BackColor = Color.Transparent;
            lblHasta.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasta.ForeColor = SystemColors.Window;
            lblHasta.Location = new Point(260, 65);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(46, 18);
            lblHasta.TabIndex = 3;
            lblHasta.Text = "label3";
            // 
            // dtpHasta
            // 
            dtpHasta.CalendarForeColor = SystemColors.Window;
            dtpHasta.CalendarMonthBackground = SystemColors.WindowText;
            dtpHasta.CalendarTitleBackColor = Color.Red;
            dtpHasta.CalendarTitleForeColor = Color.Red;
            dtpHasta.Location = new Point(260, 93);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(218, 23);
            dtpHasta.TabIndex = 4;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.WindowText;
            btnContinuar.FlatStyle = FlatStyle.Popup;
            btnContinuar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = SystemColors.Window;
            btnContinuar.Location = new Point(386, 139);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(92, 28);
            btnContinuar.TabIndex = 5;
            btnContinuar.Text = "button1";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.WindowText;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(12, 137);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 30);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "button1";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form_Input_Reporte_Periodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(490, 181);
            Controls.Add(btnCancelar);
            Controls.Add(btnContinuar);
            Controls.Add(dtpHasta);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(lblInfo);
            Controls.Add(dtpDesde);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Input_Reporte_Periodo";
            Text = "Form_Reporte_Inscripciones_Totales";
            Load += Form_Reporte_Inscripciones_Totales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDesde;
        private Label lblInfo;
        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Button btnContinuar;
        private Button btnCancelar;
    }
}