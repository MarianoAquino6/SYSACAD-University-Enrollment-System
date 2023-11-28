namespace Forms_TP_SYSACAD
{
    partial class Form_LogIn_Administrador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LogIn_Administrador));
            lblBienvenida = new Label();
            textBoxEmail = new TextBox();
            textBoxContraseña = new TextBox();
            lblMail = new Label();
            lblContraseña = new Label();
            btnIngresar = new Button();
            btnAtras = new Button();
            lblCodigoAcceso = new Label();
            btnAutoCompletar = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBienvenida.ForeColor = SystemColors.Window;
            lblBienvenida.Location = new Point(12, 74);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(65, 26);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "label1";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.WindowText;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.ForeColor = Color.Red;
            textBoxEmail.Location = new Point(12, 150);
            textBoxEmail.MaxLength = 40;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(235, 25);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = SystemColors.WindowText;
            textBoxContraseña.BorderStyle = BorderStyle.FixedSingle;
            textBoxContraseña.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContraseña.ForeColor = Color.Red;
            textBoxContraseña.Location = new Point(12, 231);
            textBoxContraseña.MaxLength = 40;
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.Size = new Size(235, 25);
            textBoxContraseña.TabIndex = 2;
            textBoxContraseña.TextChanged += textBoxContraseña_TextChanged;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = Color.Transparent;
            lblMail.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.ForeColor = SystemColors.Window;
            lblMail.Location = new Point(12, 118);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(46, 18);
            lblMail.TabIndex = 3;
            lblMail.Text = "label1";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.ForeColor = SystemColors.Window;
            lblContraseña.Location = new Point(12, 199);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(46, 18);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "label2";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.WindowText;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Window;
            btnIngresar.Location = new Point(367, 218);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(116, 46);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "button1";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkRed;
            btnAtras.BackgroundImageLayout = ImageLayout.None;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.ForeColor = SystemColors.Window;
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 7;
            btnAtras.Text = "button1";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblCodigoAcceso
            // 
            lblCodigoAcceso.AutoSize = true;
            lblCodigoAcceso.BackColor = Color.Transparent;
            lblCodigoAcceso.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCodigoAcceso.ForeColor = SystemColors.Window;
            lblCodigoAcceso.Location = new Point(260, 17);
            lblCodigoAcceso.Name = "lblCodigoAcceso";
            lblCodigoAcceso.Size = new Size(46, 18);
            lblCodigoAcceso.TabIndex = 8;
            lblCodigoAcceso.Text = "label1";
            // 
            // btnAutoCompletar
            // 
            btnAutoCompletar.BackColor = SystemColors.WindowText;
            btnAutoCompletar.FlatStyle = FlatStyle.Popup;
            btnAutoCompletar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAutoCompletar.ForeColor = SystemColors.Window;
            btnAutoCompletar.Location = new Point(367, 150);
            btnAutoCompletar.Name = "btnAutoCompletar";
            btnAutoCompletar.Size = new Size(116, 46);
            btnAutoCompletar.TabIndex = 9;
            btnAutoCompletar.Text = "button1";
            btnAutoCompletar.UseVisualStyleBackColor = false;
            btnAutoCompletar.Click += btnAutoCompletar_Click;
            // 
            // Form_LogIn_Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(527, 296);
            Controls.Add(btnAutoCompletar);
            Controls.Add(lblCodigoAcceso);
            Controls.Add(btnAtras);
            Controls.Add(btnIngresar);
            Controls.Add(lblContraseña);
            Controls.Add(lblMail);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxEmail);
            Controls.Add(lblBienvenida);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_LogIn_Administrador";
            Text = "Form1";
            Load += Inicio_Sesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private TextBox textBoxEmail;
        private TextBox textBoxContraseña;
        private Label lblMail;
        private Label lblContraseña;
        private Button btnIngresar;
        private Button btnAtras;
        private Label lblCodigoAcceso;
        private Button btnAutoCompletar;
    }
}