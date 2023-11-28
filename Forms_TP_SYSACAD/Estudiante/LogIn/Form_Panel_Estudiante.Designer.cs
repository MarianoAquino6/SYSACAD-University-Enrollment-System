namespace Forms_TP_SYSACAD
{
    partial class Form_Panel_Estudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Panel_Estudiante));
            lblInfoPanel = new Label();
            lblCursos = new Label();
            btnInscripcion = new Button();
            btnAtras = new Button();
            lblPagos = new Label();
            btnPagos = new Button();
            lblHorarios = new Label();
            btnHorarios = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblInfoPanel
            // 
            lblInfoPanel.AutoSize = true;
            lblInfoPanel.BackColor = Color.Transparent;
            lblInfoPanel.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfoPanel.ForeColor = SystemColors.Window;
            lblInfoPanel.Location = new Point(12, 82);
            lblInfoPanel.Name = "lblInfoPanel";
            lblInfoPanel.Size = new Size(65, 26);
            lblInfoPanel.TabIndex = 0;
            lblInfoPanel.Text = "label1";
            // 
            // lblCursos
            // 
            lblCursos.AutoSize = true;
            lblCursos.BackColor = Color.Transparent;
            lblCursos.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCursos.ForeColor = SystemColors.Window;
            lblCursos.Location = new Point(12, 125);
            lblCursos.Name = "lblCursos";
            lblCursos.Size = new Size(46, 18);
            lblCursos.TabIndex = 1;
            lblCursos.Text = "label2";
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = SystemColors.WindowText;
            btnInscripcion.FlatStyle = FlatStyle.Popup;
            btnInscripcion.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscripcion.ForeColor = SystemColors.Window;
            btnInscripcion.Location = new Point(12, 152);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(157, 31);
            btnInscripcion.TabIndex = 3;
            btnInscripcion.Text = "button1";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
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
            btnAtras.TabIndex = 4;
            btnAtras.Text = "button1";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblPagos
            // 
            lblPagos.AutoSize = true;
            lblPagos.BackColor = Color.Transparent;
            lblPagos.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagos.ForeColor = SystemColors.Window;
            lblPagos.Location = new Point(12, 195);
            lblPagos.Name = "lblPagos";
            lblPagos.Size = new Size(49, 18);
            lblPagos.TabIndex = 5;
            lblPagos.Text = "label 3";
            // 
            // btnPagos
            // 
            btnPagos.BackColor = SystemColors.WindowText;
            btnPagos.FlatStyle = FlatStyle.Popup;
            btnPagos.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagos.ForeColor = SystemColors.Window;
            btnPagos.Location = new Point(12, 222);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(157, 31);
            btnPagos.TabIndex = 6;
            btnPagos.Text = "btnPagos";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.BackColor = Color.Transparent;
            lblHorarios.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHorarios.ForeColor = SystemColors.Window;
            lblHorarios.Location = new Point(12, 265);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(46, 18);
            lblHorarios.TabIndex = 7;
            lblHorarios.Text = "label1";
            // 
            // btnHorarios
            // 
            btnHorarios.BackColor = SystemColors.WindowText;
            btnHorarios.FlatStyle = FlatStyle.Popup;
            btnHorarios.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHorarios.ForeColor = SystemColors.Window;
            btnHorarios.Location = new Point(12, 293);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Size = new Size(157, 31);
            btnHorarios.TabIndex = 8;
            btnHorarios.Text = "button1";
            btnHorarios.UseVisualStyleBackColor = false;
            btnHorarios.Click += btnHorarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form_Panel_Estudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(516, 347);
            Controls.Add(pictureBox1);
            Controls.Add(btnHorarios);
            Controls.Add(lblHorarios);
            Controls.Add(btnPagos);
            Controls.Add(lblPagos);
            Controls.Add(btnAtras);
            Controls.Add(btnInscripcion);
            Controls.Add(lblCursos);
            Controls.Add(lblInfoPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Panel_Estudiante";
            Text = "Form_Panel_Estudiante";
            Load += Form_Panel_Estudiante_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoPanel;
        private Label lblCursos;
        private Button btnInscripcion;
        private Button btnAtras;
        private Label lblPagos;
        private Button btnPagos;
        private Label lblHorarios;
        private Button btnHorarios;
        private PictureBox pictureBox1;
    }
}