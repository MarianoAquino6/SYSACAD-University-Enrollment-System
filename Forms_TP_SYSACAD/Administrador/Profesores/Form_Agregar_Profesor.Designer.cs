namespace Forms_TP_SYSACAD.Administrador.Profesores
{
    partial class Form_Agregar_Profesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Agregar_Profesor));
            btnAtras = new Button();
            lblInfo = new Label();
            lblNombre = new Label();
            tbNombre = new TextBox();
            lblTelefono = new Label();
            tbTelefono = new TextBox();
            tbCorreo = new TextBox();
            lblCorreo = new Label();
            lblDireccion = new Label();
            tbDireccion = new TextBox();
            lblEspecializacion = new Label();
            tbEspecializacion = new TextBox();
            btnAgregar = new Button();
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
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.Window;
            lblInfo.Location = new Point(12, 71);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(65, 26);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "label1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(12, 130);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(46, 18);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "label2";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.WindowText;
            tbNombre.BorderStyle = BorderStyle.FixedSingle;
            tbNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.ForeColor = Color.Red;
            tbNombre.Location = new Point(12, 158);
            tbNombre.MaxLength = 30;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(160, 25);
            tbNombre.TabIndex = 3;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.ForeColor = SystemColors.Window;
            lblTelefono.Location = new Point(12, 211);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(46, 18);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "label3";
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = SystemColors.WindowText;
            tbTelefono.BorderStyle = BorderStyle.FixedSingle;
            tbTelefono.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbTelefono.ForeColor = Color.Red;
            tbTelefono.Location = new Point(12, 239);
            tbTelefono.MaxLength = 10;
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(160, 25);
            tbTelefono.TabIndex = 5;
            tbTelefono.TextChanged += tbTelefono_TextChanged;
            // 
            // tbCorreo
            // 
            tbCorreo.BackColor = SystemColors.WindowText;
            tbCorreo.BorderStyle = BorderStyle.FixedSingle;
            tbCorreo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCorreo.ForeColor = Color.Red;
            tbCorreo.Location = new Point(234, 158);
            tbCorreo.MaxLength = 25;
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(160, 25);
            tbCorreo.TabIndex = 6;
            tbCorreo.TextChanged += tbCorreo_TextChanged;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = SystemColors.Window;
            lblCorreo.Location = new Point(234, 130);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(46, 18);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "label4";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.ForeColor = SystemColors.Window;
            lblDireccion.Location = new Point(234, 211);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(46, 18);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "label5";
            // 
            // tbDireccion
            // 
            tbDireccion.BackColor = SystemColors.WindowText;
            tbDireccion.BorderStyle = BorderStyle.FixedSingle;
            tbDireccion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDireccion.ForeColor = Color.Red;
            tbDireccion.Location = new Point(234, 239);
            tbDireccion.MaxLength = 30;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(160, 25);
            tbDireccion.TabIndex = 9;
            tbDireccion.TextChanged += tbDireccion_TextChanged;
            // 
            // lblEspecializacion
            // 
            lblEspecializacion.AutoSize = true;
            lblEspecializacion.BackColor = Color.Transparent;
            lblEspecializacion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecializacion.ForeColor = SystemColors.Window;
            lblEspecializacion.Location = new Point(12, 291);
            lblEspecializacion.Name = "lblEspecializacion";
            lblEspecializacion.Size = new Size(46, 18);
            lblEspecializacion.TabIndex = 10;
            lblEspecializacion.Text = "label6";
            // 
            // tbEspecializacion
            // 
            tbEspecializacion.BackColor = SystemColors.WindowText;
            tbEspecializacion.BorderStyle = BorderStyle.FixedSingle;
            tbEspecializacion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbEspecializacion.ForeColor = Color.Red;
            tbEspecializacion.Location = new Point(12, 321);
            tbEspecializacion.MaxLength = 30;
            tbEspecializacion.Name = "tbEspecializacion";
            tbEspecializacion.Size = new Size(160, 25);
            tbEspecializacion.TabIndex = 11;
            tbEspecializacion.TextChanged += tbEspecializacion_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.WindowText;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(302, 343);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 33);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "button2";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form_Agregar_Profesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(422, 388);
            Controls.Add(btnAgregar);
            Controls.Add(tbEspecializacion);
            Controls.Add(lblEspecializacion);
            Controls.Add(tbDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(lblCorreo);
            Controls.Add(tbCorreo);
            Controls.Add(tbTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(tbNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblInfo);
            Controls.Add(btnAtras);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Agregar_Profesor";
            Text = "Form_Agregar_Profesor";
            Load += Form_Agregar_Profesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label lblInfo;
        private Label lblNombre;
        private TextBox tbNombre;
        private Label lblTelefono;
        private TextBox tbTelefono;
        private TextBox tbCorreo;
        private Label lblCorreo;
        private Label lblDireccion;
        private TextBox tbDireccion;
        private Label lblEspecializacion;
        private TextBox tbEspecializacion;
        private Button btnAgregar;
    }
}