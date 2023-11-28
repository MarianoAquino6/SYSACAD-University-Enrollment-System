namespace Forms_TP_SYSACAD
{
    partial class Form_Pago_Tarjetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pago_Tarjetas));
            btnAtras = new Button();
            lblNombre = new Label();
            tbNombre = new TextBox();
            lblNumero = new Label();
            tbNumero = new TextBox();
            lblVencimiento = new Label();
            tbVencimiento = new TextBox();
            lblCodigo = new Label();
            tbCodigo = new TextBox();
            btnPagar = new Button();
            lblMonto = new Label();
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
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(23, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(46, 18);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label1";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.WindowText;
            tbNombre.BorderStyle = BorderStyle.FixedSingle;
            tbNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.ForeColor = Color.Red;
            tbNombre.Location = new Point(23, 97);
            tbNombre.MaxLength = 30;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(185, 25);
            tbNombre.TabIndex = 2;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.ForeColor = SystemColors.Window;
            lblNumero.Location = new Point(23, 133);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(46, 18);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "label2";
            // 
            // tbNumero
            // 
            tbNumero.BackColor = SystemColors.WindowText;
            tbNumero.BorderStyle = BorderStyle.FixedSingle;
            tbNumero.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbNumero.ForeColor = Color.Red;
            tbNumero.Location = new Point(23, 160);
            tbNumero.MaxLength = 16;
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(185, 25);
            tbNumero.TabIndex = 4;
            tbNumero.TextChanged += tbNumero_TextChanged;
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.BackColor = Color.Transparent;
            lblVencimiento.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVencimiento.ForeColor = SystemColors.Window;
            lblVencimiento.Location = new Point(23, 197);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(46, 18);
            lblVencimiento.TabIndex = 5;
            lblVencimiento.Text = "label3";
            // 
            // tbVencimiento
            // 
            tbVencimiento.BackColor = SystemColors.WindowText;
            tbVencimiento.BorderStyle = BorderStyle.FixedSingle;
            tbVencimiento.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbVencimiento.ForeColor = Color.Red;
            tbVencimiento.Location = new Point(23, 219);
            tbVencimiento.MaxLength = 5;
            tbVencimiento.Name = "tbVencimiento";
            tbVencimiento.Size = new Size(100, 25);
            tbVencimiento.TabIndex = 6;
            tbVencimiento.TextChanged += tbVencimiento_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.ForeColor = SystemColors.Window;
            lblCodigo.Location = new Point(23, 254);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 18);
            lblCodigo.TabIndex = 7;
            lblCodigo.Text = "label4";
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = SystemColors.WindowText;
            tbCodigo.BorderStyle = BorderStyle.FixedSingle;
            tbCodigo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCodigo.ForeColor = Color.Red;
            tbCodigo.Location = new Point(23, 281);
            tbCodigo.MaxLength = 3;
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(100, 25);
            tbCodigo.TabIndex = 8;
            tbCodigo.TextChanged += tbCodigo_TextChanged;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = SystemColors.WindowText;
            btnPagar.FlatStyle = FlatStyle.Popup;
            btnPagar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = SystemColors.Window;
            btnPagar.Location = new Point(420, 296);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(88, 33);
            btnPagar.TabIndex = 9;
            btnPagar.Text = "button2";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.Transparent;
            lblMonto.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMonto.ForeColor = SystemColors.Window;
            lblMonto.Location = new Point(259, 219);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(65, 26);
            lblMonto.TabIndex = 10;
            lblMonto.Text = "label1";
            // 
            // Form_Pago_Tarjetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(529, 341);
            Controls.Add(lblMonto);
            Controls.Add(btnPagar);
            Controls.Add(tbCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(tbVencimiento);
            Controls.Add(lblVencimiento);
            Controls.Add(tbNumero);
            Controls.Add(lblNumero);
            Controls.Add(tbNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnAtras);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Pago_Tarjetas";
            Text = "Form_Pago_Tarjetas";
            Load += Form_Pago_Tarjetas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label lblNombre;
        private TextBox tbNombre;
        private Label lblNumero;
        private TextBox tbNumero;
        private Label lblVencimiento;
        private TextBox tbVencimiento;
        private Label lblCodigo;
        private TextBox tbCodigo;
        private Button btnPagar;
        private Label lblMonto;
    }
}