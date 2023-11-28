namespace Forms_TP_SYSACAD
{
    partial class Form_Reportes_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reportes_Principal));
            lblInfo = new Label();
            btnAtras = new Button();
            rbInscripcionPeriodo = new RadioButton();
            rbCantidadPorCurso = new RadioButton();
            rbIngresosPorConcepto = new RadioButton();
            rbInscripcionPorCarrera = new RadioButton();
            rbListasDeEspera = new RadioButton();
            btnGenerarInforme = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.FlatStyle = FlatStyle.Popup;
            lblInfo.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.Window;
            lblInfo.Location = new Point(12, 70);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(65, 26);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "label1";
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
            // rbInscripcionPeriodo
            // 
            rbInscripcionPeriodo.AutoSize = true;
            rbInscripcionPeriodo.BackColor = Color.Transparent;
            rbInscripcionPeriodo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbInscripcionPeriodo.ForeColor = SystemColors.Window;
            rbInscripcionPeriodo.Location = new Point(12, 114);
            rbInscripcionPeriodo.Name = "rbInscripcionPeriodo";
            rbInscripcionPeriodo.Size = new Size(107, 22);
            rbInscripcionPeriodo.TabIndex = 2;
            rbInscripcionPeriodo.TabStop = true;
            rbInscripcionPeriodo.Text = "radioButton1";
            rbInscripcionPeriodo.UseVisualStyleBackColor = false;
            rbInscripcionPeriodo.Click += rbInscripcionPeriodo_Click;
            // 
            // rbCantidadPorCurso
            // 
            rbCantidadPorCurso.AutoSize = true;
            rbCantidadPorCurso.BackColor = Color.Transparent;
            rbCantidadPorCurso.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbCantidadPorCurso.ForeColor = SystemColors.Window;
            rbCantidadPorCurso.Location = new Point(12, 151);
            rbCantidadPorCurso.Name = "rbCantidadPorCurso";
            rbCantidadPorCurso.Size = new Size(107, 22);
            rbCantidadPorCurso.TabIndex = 3;
            rbCantidadPorCurso.TabStop = true;
            rbCantidadPorCurso.Text = "radioButton2";
            rbCantidadPorCurso.UseVisualStyleBackColor = false;
            rbCantidadPorCurso.Click += rbCantidadPorCurso_Click;
            // 
            // rbIngresosPorConcepto
            // 
            rbIngresosPorConcepto.AutoSize = true;
            rbIngresosPorConcepto.BackColor = Color.Transparent;
            rbIngresosPorConcepto.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbIngresosPorConcepto.ForeColor = SystemColors.Window;
            rbIngresosPorConcepto.Location = new Point(12, 188);
            rbIngresosPorConcepto.Name = "rbIngresosPorConcepto";
            rbIngresosPorConcepto.Size = new Size(107, 22);
            rbIngresosPorConcepto.TabIndex = 4;
            rbIngresosPorConcepto.TabStop = true;
            rbIngresosPorConcepto.Text = "radioButton3";
            rbIngresosPorConcepto.UseVisualStyleBackColor = false;
            rbIngresosPorConcepto.Click += rbIngresosPorConcepto_Click;
            // 
            // rbInscripcionPorCarrera
            // 
            rbInscripcionPorCarrera.AutoSize = true;
            rbInscripcionPorCarrera.BackColor = Color.Transparent;
            rbInscripcionPorCarrera.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbInscripcionPorCarrera.ForeColor = SystemColors.Window;
            rbInscripcionPorCarrera.Location = new Point(12, 225);
            rbInscripcionPorCarrera.Name = "rbInscripcionPorCarrera";
            rbInscripcionPorCarrera.Size = new Size(107, 22);
            rbInscripcionPorCarrera.TabIndex = 5;
            rbInscripcionPorCarrera.TabStop = true;
            rbInscripcionPorCarrera.Text = "radioButton4";
            rbInscripcionPorCarrera.UseVisualStyleBackColor = false;
            rbInscripcionPorCarrera.Click += rbInscripcionPorCarrera_Click;
            // 
            // rbListasDeEspera
            // 
            rbListasDeEspera.AutoSize = true;
            rbListasDeEspera.BackColor = Color.Transparent;
            rbListasDeEspera.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbListasDeEspera.ForeColor = SystemColors.Window;
            rbListasDeEspera.Location = new Point(12, 262);
            rbListasDeEspera.Name = "rbListasDeEspera";
            rbListasDeEspera.Size = new Size(107, 22);
            rbListasDeEspera.TabIndex = 6;
            rbListasDeEspera.TabStop = true;
            rbListasDeEspera.Text = "radioButton5";
            rbListasDeEspera.UseVisualStyleBackColor = false;
            rbListasDeEspera.Click += rbListasDeEspera_Click;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = SystemColors.WindowText;
            btnGenerarInforme.FlatStyle = FlatStyle.Popup;
            btnGenerarInforme.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerarInforme.ForeColor = SystemColors.Window;
            btnGenerarInforme.Location = new Point(314, 253);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(113, 31);
            btnGenerarInforme.TabIndex = 15;
            btnGenerarInforme.Text = "button2";
            btnGenerarInforme.UseVisualStyleBackColor = false;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // Form_Reportes_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(450, 306);
            Controls.Add(btnGenerarInforme);
            Controls.Add(rbListasDeEspera);
            Controls.Add(rbInscripcionPorCarrera);
            Controls.Add(rbIngresosPorConcepto);
            Controls.Add(rbCantidadPorCurso);
            Controls.Add(rbInscripcionPeriodo);
            Controls.Add(btnAtras);
            Controls.Add(lblInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Reportes_Principal";
            Text = "Form_Reportes";
            Load += Form_Reportes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Button btnAtras;
        private RadioButton rbInscripcionPeriodo;
        private RadioButton rbCantidadPorCurso;
        private RadioButton rbIngresosPorConcepto;
        private RadioButton rbInscripcionPorCarrera;
        private RadioButton rbListasDeEspera;
        private Button btnGenerarInforme;
    }
}