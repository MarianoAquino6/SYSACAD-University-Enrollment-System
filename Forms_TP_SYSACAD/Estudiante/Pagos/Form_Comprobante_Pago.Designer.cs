namespace Forms_TP_SYSACAD
{
    partial class Form_Comprobante_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Comprobante_Pago));
            lblExitoso = new Label();
            btnVolver = new Button();
            lblDetalles = new Label();
            lblFecha = new Label();
            lblMonto = new Label();
            lblConceptos = new Label();
            SuspendLayout();
            // 
            // lblExitoso
            // 
            lblExitoso.AutoSize = true;
            lblExitoso.BackColor = Color.Transparent;
            lblExitoso.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblExitoso.ForeColor = SystemColors.Window;
            lblExitoso.Location = new Point(25, 30);
            lblExitoso.Name = "lblExitoso";
            lblExitoso.Size = new Size(65, 26);
            lblExitoso.TabIndex = 0;
            lblExitoso.Text = "label1";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.WindowText;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.Window;
            btnVolver.Location = new Point(340, 276);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(103, 29);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "button1";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += button1_Click;
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.BackColor = Color.Transparent;
            lblDetalles.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDetalles.ForeColor = SystemColors.Window;
            lblDetalles.Location = new Point(25, 89);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(46, 18);
            lblDetalles.TabIndex = 2;
            lblDetalles.Text = "label2";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.Window;
            lblFecha.Location = new Point(25, 123);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(46, 18);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "label3";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.Transparent;
            lblMonto.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonto.ForeColor = SystemColors.Window;
            lblMonto.Location = new Point(25, 151);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 18);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "label4";
            // 
            // lblConceptos
            // 
            lblConceptos.AutoSize = true;
            lblConceptos.BackColor = Color.Transparent;
            lblConceptos.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblConceptos.ForeColor = SystemColors.Window;
            lblConceptos.Location = new Point(25, 178);
            lblConceptos.Name = "lblConceptos";
            lblConceptos.Size = new Size(46, 18);
            lblConceptos.TabIndex = 5;
            lblConceptos.Text = "label5";
            // 
            // Form_Comprobante_Pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(455, 317);
            Controls.Add(lblConceptos);
            Controls.Add(lblMonto);
            Controls.Add(lblFecha);
            Controls.Add(lblDetalles);
            Controls.Add(btnVolver);
            Controls.Add(lblExitoso);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Comprobante_Pago";
            Text = "Form_Comprobante_Pago";
            Load += Form_Comprobante_Pago_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExitoso;
        private Button btnVolver;
        private Label lblDetalles;
        private Label lblFecha;
        private Label lblMonto;
        private Label lblConceptos;
    }
}