namespace Forms_TP_SYSACAD
{
    partial class Form_Pago_Transferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pago_Transferencia));
            lblRemitente = new Label();
            btnAtras = new Button();
            lblNombreRemit = new Label();
            tbNombreRemit = new TextBox();
            lblCuentaRemit = new Label();
            tbCuentaRemit = new TextBox();
            lblBeneficiario = new Label();
            lblNombreBenef = new Label();
            lblCuentaBenef = new Label();
            lblMonto = new Label();
            btnContinuar = new Button();
            SuspendLayout();
            // 
            // lblRemitente
            // 
            lblRemitente.AutoSize = true;
            lblRemitente.BackColor = Color.Transparent;
            lblRemitente.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRemitente.ForeColor = SystemColors.Window;
            lblRemitente.Location = new Point(27, 67);
            lblRemitente.Name = "lblRemitente";
            lblRemitente.Size = new Size(65, 26);
            lblRemitente.TabIndex = 0;
            lblRemitente.Text = "label1";
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
            // lblNombreRemit
            // 
            lblNombreRemit.AutoSize = true;
            lblNombreRemit.BackColor = Color.Transparent;
            lblNombreRemit.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreRemit.ForeColor = SystemColors.Window;
            lblNombreRemit.Location = new Point(27, 108);
            lblNombreRemit.Name = "lblNombreRemit";
            lblNombreRemit.Size = new Size(46, 18);
            lblNombreRemit.TabIndex = 2;
            lblNombreRemit.Text = "label2";
            // 
            // tbNombreRemit
            // 
            tbNombreRemit.BackColor = SystemColors.WindowText;
            tbNombreRemit.BorderStyle = BorderStyle.FixedSingle;
            tbNombreRemit.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombreRemit.ForeColor = Color.Red;
            tbNombreRemit.Location = new Point(27, 135);
            tbNombreRemit.MaxLength = 30;
            tbNombreRemit.Name = "tbNombreRemit";
            tbNombreRemit.Size = new Size(194, 25);
            tbNombreRemit.TabIndex = 3;
            tbNombreRemit.TextChanged += tbNombreRemit_TextChanged;
            // 
            // lblCuentaRemit
            // 
            lblCuentaRemit.AutoSize = true;
            lblCuentaRemit.BackColor = Color.Transparent;
            lblCuentaRemit.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuentaRemit.ForeColor = SystemColors.Window;
            lblCuentaRemit.Location = new Point(27, 172);
            lblCuentaRemit.Name = "lblCuentaRemit";
            lblCuentaRemit.Size = new Size(46, 18);
            lblCuentaRemit.TabIndex = 4;
            lblCuentaRemit.Text = "label3";
            // 
            // tbCuentaRemit
            // 
            tbCuentaRemit.BackColor = SystemColors.WindowText;
            tbCuentaRemit.BorderStyle = BorderStyle.FixedSingle;
            tbCuentaRemit.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCuentaRemit.ForeColor = Color.Red;
            tbCuentaRemit.Location = new Point(27, 199);
            tbCuentaRemit.MaxLength = 22;
            tbCuentaRemit.Name = "tbCuentaRemit";
            tbCuentaRemit.Size = new Size(194, 25);
            tbCuentaRemit.TabIndex = 5;
            tbCuentaRemit.TextChanged += tbCuentaRemit_TextChanged;
            // 
            // lblBeneficiario
            // 
            lblBeneficiario.AutoSize = true;
            lblBeneficiario.BackColor = Color.Transparent;
            lblBeneficiario.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBeneficiario.ForeColor = SystemColors.Window;
            lblBeneficiario.Location = new Point(27, 247);
            lblBeneficiario.Name = "lblBeneficiario";
            lblBeneficiario.Size = new Size(65, 26);
            lblBeneficiario.TabIndex = 6;
            lblBeneficiario.Text = "label4";
            // 
            // lblNombreBenef
            // 
            lblNombreBenef.AutoSize = true;
            lblNombreBenef.BackColor = Color.Transparent;
            lblNombreBenef.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreBenef.ForeColor = SystemColors.Window;
            lblNombreBenef.Location = new Point(27, 289);
            lblNombreBenef.Name = "lblNombreBenef";
            lblNombreBenef.Size = new Size(46, 18);
            lblNombreBenef.TabIndex = 7;
            lblNombreBenef.Text = "label5";
            // 
            // lblCuentaBenef
            // 
            lblCuentaBenef.AutoSize = true;
            lblCuentaBenef.BackColor = Color.Transparent;
            lblCuentaBenef.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuentaBenef.ForeColor = SystemColors.Window;
            lblCuentaBenef.Location = new Point(27, 316);
            lblCuentaBenef.Name = "lblCuentaBenef";
            lblCuentaBenef.Size = new Size(46, 18);
            lblCuentaBenef.TabIndex = 8;
            lblCuentaBenef.Text = "label6";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.Transparent;
            lblMonto.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonto.ForeColor = SystemColors.Window;
            lblMonto.Location = new Point(27, 343);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 18);
            lblMonto.TabIndex = 9;
            lblMonto.Text = "label7";
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.WindowText;
            btnContinuar.FlatStyle = FlatStyle.Popup;
            btnContinuar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = SystemColors.Window;
            btnContinuar.Location = new Point(443, 336);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(93, 30);
            btnContinuar.TabIndex = 10;
            btnContinuar.Text = "button2";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // Form_Pago_Transferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(548, 383);
            Controls.Add(btnContinuar);
            Controls.Add(lblMonto);
            Controls.Add(lblCuentaBenef);
            Controls.Add(lblNombreBenef);
            Controls.Add(lblBeneficiario);
            Controls.Add(tbCuentaRemit);
            Controls.Add(lblCuentaRemit);
            Controls.Add(tbNombreRemit);
            Controls.Add(lblNombreRemit);
            Controls.Add(btnAtras);
            Controls.Add(lblRemitente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Pago_Transferencia";
            Text = "Form_Pago_Transferia";
            Load += Form_Pago_Transferencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRemitente;
        private Button btnAtras;
        private Label lblNombreRemit;
        private TextBox tbNombreRemit;
        private Label lblCuentaRemit;
        private TextBox tbCuentaRemit;
        private Label lblBeneficiario;
        private Label lblNombreBenef;
        private Label lblCuentaBenef;
        private Label lblMonto;
        private Button btnContinuar;
    }
}