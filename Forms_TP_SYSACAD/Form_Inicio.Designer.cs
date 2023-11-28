namespace Forms_TP_SYSACAD
{
    partial class Form_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inicio));
            lblInfoInicio = new Label();
            btnEstudiante = new Button();
            btnAdmin = new Button();
            pictureBox1 = new PictureBox();
            progressBarCargando = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblInfoInicio
            // 
            lblInfoInicio.AutoSize = true;
            lblInfoInicio.BackColor = Color.Transparent;
            lblInfoInicio.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfoInicio.ForeColor = SystemColors.Window;
            lblInfoInicio.Location = new Point(139, 189);
            lblInfoInicio.Name = "lblInfoInicio";
            lblInfoInicio.Size = new Size(210, 26);
            lblInfoInicio.TabIndex = 0;
            lblInfoInicio.Text = "Bienvenido a SYSACAD";
            // 
            // btnEstudiante
            // 
            btnEstudiante.BackColor = SystemColors.WindowText;
            btnEstudiante.FlatStyle = FlatStyle.Popup;
            btnEstudiante.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEstudiante.ForeColor = SystemColors.Window;
            btnEstudiante.Location = new Point(149, 245);
            btnEstudiante.Name = "btnEstudiante";
            btnEstudiante.Size = new Size(186, 30);
            btnEstudiante.TabIndex = 1;
            btnEstudiante.Text = "button1";
            btnEstudiante.UseVisualStyleBackColor = false;
            btnEstudiante.Click += btnEstudiante_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Black;
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = SystemColors.Window;
            btnAdmin.Location = new Point(149, 291);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(186, 30);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "button2";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // progressBarCargando
            // 
            progressBarCargando.BackColor = SystemColors.WindowText;
            progressBarCargando.Cursor = Cursors.AppStarting;
            progressBarCargando.ForeColor = Color.Red;
            progressBarCargando.Location = new Point(378, 314);
            progressBarCargando.Name = "progressBarCargando";
            progressBarCargando.Size = new Size(100, 23);
            progressBarCargando.Style = ProgressBarStyle.Marquee;
            progressBarCargando.TabIndex = 4;
            progressBarCargando.Visible = false;
            // 
            // Form_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(490, 349);
            Controls.Add(progressBarCargando);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdmin);
            Controls.Add(btnEstudiante);
            Controls.Add(lblInfoInicio);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Inicio";
            Text = "Form_Inicio";
            Load += Form_Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoInicio;
        private Button btnEstudiante;
        private Button btnAdmin;
        private PictureBox pictureBox1;
        private ProgressBar progressBarCargando;
    }
}