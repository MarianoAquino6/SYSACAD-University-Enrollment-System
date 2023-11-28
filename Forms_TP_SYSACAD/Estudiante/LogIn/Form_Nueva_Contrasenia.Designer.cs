namespace Forms_TP_SYSACAD
{
    partial class Form_Nueva_Contrasenia
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
            lblInfo = new Label();
            tbContra = new TextBox();
            btnCambiar = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.Window;
            lblInfo.Location = new Point(12, 31);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(46, 18);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "label1";
            // 
            // tbContra
            // 
            tbContra.BackColor = Color.Black;
            tbContra.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbContra.ForeColor = Color.Red;
            tbContra.Location = new Point(12, 65);
            tbContra.MaxLength = 30;
            tbContra.Name = "tbContra";
            tbContra.Size = new Size(228, 25);
            tbContra.TabIndex = 1;
            tbContra.TextChanged += tbContra_TextChanged;
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = Color.DarkRed;
            btnCambiar.FlatStyle = FlatStyle.Popup;
            btnCambiar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiar.ForeColor = SystemColors.Window;
            btnCambiar.Location = new Point(165, 109);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(75, 23);
            btnCambiar.TabIndex = 2;
            btnCambiar.Text = "button1";
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // Form_Nueva_Contrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(263, 152);
            Controls.Add(btnCambiar);
            Controls.Add(tbContra);
            Controls.Add(lblInfo);
            Name = "Form_Nueva_Contrasenia";
            Text = "Form_Nueva_Contrasenia";
            Load += Form_Nueva_Contrasenia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private TextBox tbContra;
        private Button btnCambiar;
    }
}