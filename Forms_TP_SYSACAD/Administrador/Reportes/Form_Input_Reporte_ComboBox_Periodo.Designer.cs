namespace Forms_TP_SYSACAD
{
    partial class Form_Input_Reporte_ComboBox_Periodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Input_Reporte_ComboBox_Periodo));
            lblInfo = new Label();
            cbOpciones = new ComboBox();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            btnContinuar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.Window;
            lblInfo.Location = new Point(12, 26);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(49, 18);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "lblInfo";
            // 
            // cbOpciones
            // 
            cbOpciones.BackColor = SystemColors.WindowText;
            cbOpciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOpciones.FlatStyle = FlatStyle.Popup;
            cbOpciones.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbOpciones.ForeColor = Color.Red;
            cbOpciones.FormattingEnabled = true;
            cbOpciones.Location = new Point(12, 61);
            cbOpciones.Name = "cbOpciones";
            cbOpciones.Size = new Size(224, 25);
            cbOpciones.TabIndex = 1;
            cbOpciones.SelectedIndexChanged += cbOpciones_SelectedIndexChanged;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.BackColor = Color.Transparent;
            lblDesde.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesde.ForeColor = SystemColors.Window;
            lblDesde.Location = new Point(12, 110);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(46, 18);
            lblDesde.TabIndex = 2;
            lblDesde.Text = "label2";
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarForeColor = SystemColors.Window;
            dtpDesde.CalendarMonthBackground = SystemColors.WindowText;
            dtpDesde.CalendarTitleBackColor = Color.Red;
            dtpDesde.CalendarTitleForeColor = Color.Red;
            dtpDesde.Location = new Point(12, 138);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(224, 23);
            dtpDesde.TabIndex = 3;
            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.BackColor = Color.Transparent;
            lblHasta.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasta.ForeColor = SystemColors.Window;
            lblHasta.Location = new Point(296, 110);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(46, 18);
            lblHasta.TabIndex = 4;
            lblHasta.Text = "label3";
            // 
            // dtpHasta
            // 
            dtpHasta.CalendarForeColor = SystemColors.Window;
            dtpHasta.CalendarMonthBackground = SystemColors.WindowText;
            dtpHasta.CalendarTitleBackColor = Color.Red;
            dtpHasta.CalendarTitleForeColor = Color.Red;
            dtpHasta.Location = new Point(296, 138);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(224, 23);
            dtpHasta.TabIndex = 5;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.WindowText;
            btnContinuar.FlatStyle = FlatStyle.Popup;
            btnContinuar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = SystemColors.Window;
            btnContinuar.Location = new Point(426, 199);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(94, 30);
            btnContinuar.TabIndex = 6;
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
            btnCancelar.Location = new Point(12, 199);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 30);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "btnCancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form_Input_Reporte_ComboBox_Periodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(532, 241);
            Controls.Add(btnCancelar);
            Controls.Add(btnContinuar);
            Controls.Add(dtpHasta);
            Controls.Add(lblHasta);
            Controls.Add(dtpDesde);
            Controls.Add(lblDesde);
            Controls.Add(cbOpciones);
            Controls.Add(lblInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Input_Reporte_ComboBox_Periodo";
            Text = "Form_Reporte_Inscripciones_Curso";
            Load += Form_Input_Reporte_Inscripciones_Curso_o_Carrera_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private ComboBox cbOpciones;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Button btnContinuar;
        private Button btnCancelar;
    }
}