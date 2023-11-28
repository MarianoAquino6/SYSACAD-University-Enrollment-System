namespace Forms_TP_SYSACAD
{
    partial class Form_LogIn_Estudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LogIn_Estudiante));
            lblInfoEstudiante = new Label();
            btnAtras = new Button();
            lblCorreo = new Label();
            textBoxCorreo = new TextBox();
            lblContraseña = new Label();
            textBoxContraseña = new TextBox();
            btnIngresar = new Button();
            btnAutoCompletar = new Button();
            SuspendLayout();
            // 
            // lblInfoEstudiante
            // 
            lblInfoEstudiante.AutoSize = true;
            lblInfoEstudiante.BackColor = Color.Transparent;
            lblInfoEstudiante.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfoEstudiante.ForeColor = SystemColors.Window;
            lblInfoEstudiante.Location = new Point(12, 75);
            lblInfoEstudiante.Name = "lblInfoEstudiante";
            lblInfoEstudiante.Size = new Size(65, 26);
            lblInfoEstudiante.TabIndex = 0;
            lblInfoEstudiante.Text = "label1";
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
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.ForeColor = SystemColors.Window;
            lblCorreo.Location = new Point(12, 124);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(40, 15);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "label2";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BackColor = SystemColors.WindowText;
            textBoxCorreo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCorreo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.Red;
            textBoxCorreo.Location = new Point(12, 151);
            textBoxCorreo.MaxLength = 40;
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(208, 25);
            textBoxCorreo.TabIndex = 3;
            textBoxCorreo.TextChanged += textBoxCorreo_TextChanged;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.ForeColor = SystemColors.Window;
            lblContraseña.Location = new Point(12, 194);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(40, 15);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "label3";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = SystemColors.WindowText;
            textBoxContraseña.BorderStyle = BorderStyle.FixedSingle;
            textBoxContraseña.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContraseña.ForeColor = Color.Red;
            textBoxContraseña.Location = new Point(12, 221);
            textBoxContraseña.MaxLength = 40;
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.Size = new Size(208, 25);
            textBoxContraseña.TabIndex = 5;
            textBoxContraseña.TextChanged += textBoxContraseña_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.WindowText;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Window;
            btnIngresar.Location = new Point(328, 214);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(105, 35);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "button2";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnAutoCompletar
            // 
            btnAutoCompletar.BackColor = SystemColors.WindowText;
            btnAutoCompletar.FlatStyle = FlatStyle.Popup;
            btnAutoCompletar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAutoCompletar.ForeColor = SystemColors.Window;
            btnAutoCompletar.Location = new Point(328, 143);
            btnAutoCompletar.Name = "btnAutoCompletar";
            btnAutoCompletar.Size = new Size(105, 36);
            btnAutoCompletar.TabIndex = 7;
            btnAutoCompletar.Text = "button1";
            btnAutoCompletar.UseVisualStyleBackColor = false;
            btnAutoCompletar.Click += btnAutoCompletar_Click;
            // 
            // Form_LogIn_Estudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(480, 289);
            Controls.Add(btnAutoCompletar);
            Controls.Add(btnIngresar);
            Controls.Add(textBoxContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(textBoxCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(btnAtras);
            Controls.Add(lblInfoEstudiante);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_LogIn_Estudiante";
            Text = "Form_LogInEstudiante";
            Load += Form_LogInEstudiante_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoEstudiante;
        private Button btnAtras;
        private Label lblCorreo;
        private TextBox textBoxCorreo;
        private Label lblContraseña;
        private TextBox textBoxContraseña;
        private Button btnIngresar;
        private Button btnAutoCompletar;
    }
}