namespace Forms_TP_SYSACAD
{
    partial class Form_Registro_Estudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Registro_Estudiantes));
            lblInfoRegistro = new Label();
            lblNombre = new Label();
            lblLegajo = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblContraseñaProv = new Label();
            textBoxNombre = new TextBox();
            textBoxLegajo = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxContraseñaProv = new TextBox();
            lblCambioContraseña = new Label();
            checkBoxCambioContraseña = new CheckBox();
            btnRegistrar = new Button();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // lblInfoRegistro
            // 
            lblInfoRegistro.AutoSize = true;
            lblInfoRegistro.BackColor = Color.Transparent;
            lblInfoRegistro.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfoRegistro.ForeColor = SystemColors.Window;
            lblInfoRegistro.Location = new Point(22, 66);
            lblInfoRegistro.Name = "lblInfoRegistro";
            lblInfoRegistro.Size = new Size(65, 26);
            lblInfoRegistro.TabIndex = 0;
            lblInfoRegistro.Text = "label1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.FlatStyle = FlatStyle.Flat;
            lblNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(26, 122);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(46, 18);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label2";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.BackColor = Color.Transparent;
            lblLegajo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLegajo.ForeColor = SystemColors.Window;
            lblLegajo.Location = new Point(339, 122);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(46, 18);
            lblLegajo.TabIndex = 2;
            lblLegajo.Text = "label3";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.ForeColor = SystemColors.Window;
            lblDireccion.Location = new Point(26, 196);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(46, 18);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "label4";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.ForeColor = SystemColors.Window;
            lblTelefono.Location = new Point(339, 196);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(46, 18);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "label5";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = SystemColors.Window;
            lblCorreo.Location = new Point(26, 273);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(46, 18);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "label6";
            // 
            // lblContraseñaProv
            // 
            lblContraseñaProv.AutoSize = true;
            lblContraseñaProv.BackColor = Color.Transparent;
            lblContraseñaProv.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseñaProv.ForeColor = SystemColors.Window;
            lblContraseñaProv.Location = new Point(339, 273);
            lblContraseñaProv.Name = "lblContraseñaProv";
            lblContraseñaProv.Size = new Size(46, 18);
            lblContraseñaProv.TabIndex = 6;
            lblContraseñaProv.Text = "label7";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.WindowText;
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = Color.Red;
            textBoxNombre.Location = new Point(26, 152);
            textBoxNombre.MaxLength = 30;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(200, 25);
            textBoxNombre.TabIndex = 7;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxLegajo
            // 
            textBoxLegajo.BackColor = SystemColors.WindowText;
            textBoxLegajo.BorderStyle = BorderStyle.FixedSingle;
            textBoxLegajo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLegajo.ForeColor = Color.Red;
            textBoxLegajo.Location = new Point(339, 152);
            textBoxLegajo.MaxLength = 8;
            textBoxLegajo.Name = "textBoxLegajo";
            textBoxLegajo.Size = new Size(195, 25);
            textBoxLegajo.TabIndex = 8;
            textBoxLegajo.TextChanged += textBoxLegajo_TextChanged;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BackColor = SystemColors.WindowText;
            textBoxDireccion.BorderStyle = BorderStyle.FixedSingle;
            textBoxDireccion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.ForeColor = Color.Red;
            textBoxDireccion.Location = new Point(26, 227);
            textBoxDireccion.MaxLength = 40;
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(200, 25);
            textBoxDireccion.TabIndex = 9;
            textBoxDireccion.TextChanged += textBoxDireccion_TextChanged;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.BackColor = SystemColors.WindowText;
            textBoxTelefono.BorderStyle = BorderStyle.FixedSingle;
            textBoxTelefono.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTelefono.ForeColor = Color.Red;
            textBoxTelefono.Location = new Point(339, 227);
            textBoxTelefono.MaxLength = 10;
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(195, 25);
            textBoxTelefono.TabIndex = 10;
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BackColor = SystemColors.WindowText;
            textBoxCorreo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCorreo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.Red;
            textBoxCorreo.Location = new Point(26, 303);
            textBoxCorreo.MaxLength = 50;
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(200, 25);
            textBoxCorreo.TabIndex = 11;
            textBoxCorreo.TextChanged += textBoxCorreo_TextChanged;
            // 
            // textBoxContraseñaProv
            // 
            textBoxContraseñaProv.BackColor = SystemColors.WindowText;
            textBoxContraseñaProv.BorderStyle = BorderStyle.FixedSingle;
            textBoxContraseñaProv.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContraseñaProv.ForeColor = Color.Red;
            textBoxContraseñaProv.Location = new Point(339, 303);
            textBoxContraseñaProv.MaxLength = 30;
            textBoxContraseñaProv.Name = "textBoxContraseñaProv";
            textBoxContraseñaProv.Size = new Size(195, 25);
            textBoxContraseñaProv.TabIndex = 12;
            textBoxContraseñaProv.TextChanged += textBoxContraseñaProv_TextChanged;
            // 
            // lblCambioContraseña
            // 
            lblCambioContraseña.AutoSize = true;
            lblCambioContraseña.BackColor = Color.Transparent;
            lblCambioContraseña.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCambioContraseña.ForeColor = SystemColors.Window;
            lblCambioContraseña.Location = new Point(26, 347);
            lblCambioContraseña.Name = "lblCambioContraseña";
            lblCambioContraseña.Size = new Size(46, 18);
            lblCambioContraseña.TabIndex = 13;
            lblCambioContraseña.Text = "label8";
            // 
            // checkBoxCambioContraseña
            // 
            checkBoxCambioContraseña.AutoSize = true;
            checkBoxCambioContraseña.BackColor = Color.Transparent;
            checkBoxCambioContraseña.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxCambioContraseña.ForeColor = SystemColors.Window;
            checkBoxCambioContraseña.Location = new Point(26, 375);
            checkBoxCambioContraseña.Name = "checkBoxCambioContraseña";
            checkBoxCambioContraseña.Size = new Size(92, 22);
            checkBoxCambioContraseña.TabIndex = 14;
            checkBoxCambioContraseña.Text = "checkBox1";
            checkBoxCambioContraseña.UseVisualStyleBackColor = false;
            checkBoxCambioContraseña.CheckedChanged += checkBoxCambioContraseña_CheckedChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.WindowText;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = SystemColors.Window;
            btnRegistrar.Location = new Point(432, 365);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(102, 41);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "button1";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
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
            btnAtras.TabIndex = 16;
            btnAtras.Text = "button1";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // Form_Registro_Estudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(570, 429);
            Controls.Add(btnAtras);
            Controls.Add(btnRegistrar);
            Controls.Add(checkBoxCambioContraseña);
            Controls.Add(lblCambioContraseña);
            Controls.Add(textBoxContraseñaProv);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxLegajo);
            Controls.Add(textBoxNombre);
            Controls.Add(lblContraseñaProv);
            Controls.Add(lblCorreo);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblLegajo);
            Controls.Add(lblNombre);
            Controls.Add(lblInfoRegistro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Registro_Estudiantes";
            Text = "Form_Registro_Estudiantes";
            Load += Form_Registro_Estudiantes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoRegistro;
        private Label lblNombre;
        private Label lblLegajo;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblContraseñaProv;
        private TextBox textBoxNombre;
        private TextBox textBoxLegajo;
        private TextBox textBoxDireccion;
        private TextBox textBoxTelefono;
        private TextBox textBoxCorreo;
        private TextBox textBoxContraseñaProv;
        private Label lblCambioContraseña;
        private CheckBox checkBoxCambioContraseña;
        private Button btnRegistrar;
        private Button btnAtras;
    }
}