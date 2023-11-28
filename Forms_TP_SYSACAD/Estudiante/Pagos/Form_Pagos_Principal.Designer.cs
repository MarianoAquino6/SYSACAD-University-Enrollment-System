using System.Windows.Forms;

namespace Forms_TP_SYSACAD
{
    partial class Form_Pagos_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pagos_Principal));
            dgvPagos = new DataGridView();
            btnAtras = new Button();
            lblTotalAPagar = new Label();
            lblMedioDePago = new Label();
            btnContinuar = new Button();
            rbCredito = new RadioButton();
            rbDebito = new RadioButton();
            rbTransferencia = new RadioButton();
            Concepto = new DataGridViewTextBoxColumn();
            MontoDebe = new DataGridViewTextBoxColumn();
            MontoAbonar = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // dgvPagos
            // 
            dgvPagos.BackgroundColor = SystemColors.WindowText;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { Concepto, MontoDebe, MontoAbonar });
            dgvPagos.GridColor = SystemColors.WindowText;
            dgvPagos.Location = new Point(61, 84);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowTemplate.Height = 25;
            dgvPagos.Size = new Size(543, 282);
            dgvPagos.TabIndex = 0;
            dgvPagos.CellValueChanged += DataGridViewCellValueChanged;
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
            // lblTotalAPagar
            // 
            lblTotalAPagar.AutoSize = true;
            lblTotalAPagar.BackColor = Color.Transparent;
            lblTotalAPagar.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTotalAPagar.ForeColor = SystemColors.Window;
            lblTotalAPagar.Location = new Point(386, 390);
            lblTotalAPagar.Name = "lblTotalAPagar";
            lblTotalAPagar.Size = new Size(65, 26);
            lblTotalAPagar.TabIndex = 2;
            lblTotalAPagar.Text = "label1";
            // 
            // lblMedioDePago
            // 
            lblMedioDePago.AutoSize = true;
            lblMedioDePago.BackColor = Color.Transparent;
            lblMedioDePago.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedioDePago.ForeColor = SystemColors.Window;
            lblMedioDePago.Location = new Point(61, 398);
            lblMedioDePago.Name = "lblMedioDePago";
            lblMedioDePago.Size = new Size(46, 18);
            lblMedioDePago.TabIndex = 4;
            lblMedioDePago.Text = "label1";
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.WindowText;
            btnContinuar.FlatStyle = FlatStyle.Popup;
            btnContinuar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = SystemColors.Window;
            btnContinuar.Location = new Point(498, 468);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(106, 35);
            btnContinuar.TabIndex = 7;
            btnContinuar.Text = "button1";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.BackColor = Color.Transparent;
            rbCredito.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbCredito.ForeColor = SystemColors.Window;
            rbCredito.Location = new Point(61, 431);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(107, 22);
            rbCredito.TabIndex = 9;
            rbCredito.Text = "radioButton1";
            rbCredito.UseVisualStyleBackColor = false;
            rbCredito.Click += rbCredito_Click;
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.BackColor = Color.Transparent;
            rbDebito.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbDebito.ForeColor = SystemColors.Window;
            rbDebito.Location = new Point(61, 456);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(107, 22);
            rbDebito.TabIndex = 10;
            rbDebito.Text = "radioButton2";
            rbDebito.UseVisualStyleBackColor = false;
            rbDebito.Click += rbDebito_Click;
            // 
            // rbTransferencia
            // 
            rbTransferencia.AutoSize = true;
            rbTransferencia.BackColor = Color.Transparent;
            rbTransferencia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbTransferencia.ForeColor = SystemColors.Window;
            rbTransferencia.Location = new Point(61, 481);
            rbTransferencia.Name = "rbTransferencia";
            rbTransferencia.Size = new Size(107, 22);
            rbTransferencia.TabIndex = 11;
            rbTransferencia.Text = "radioButton3";
            rbTransferencia.UseVisualStyleBackColor = false;
            rbTransferencia.Click += rbTransferencia_Click;
            // 
            // Concepto
            // 
            Concepto.Frozen = true;
            Concepto.HeaderText = "Concepto";
            Concepto.Name = "Concepto";
            Concepto.ReadOnly = true;
            Concepto.Width = 200;
            // 
            // MontoDebe
            // 
            MontoDebe.Frozen = true;
            MontoDebe.HeaderText = "Monto que Debe";
            MontoDebe.Name = "MontoDebe";
            MontoDebe.ReadOnly = true;
            MontoDebe.Width = 150;
            // 
            // MontoAbonar
            // 
            MontoAbonar.Frozen = true;
            MontoAbonar.HeaderText = "Monto a Abonar";
            MontoAbonar.MaxInputLength = 5;
            MontoAbonar.Name = "MontoAbonar";
            MontoAbonar.Width = 150;
            // 
            // Form_Pagos_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(665, 530);
            Controls.Add(rbTransferencia);
            Controls.Add(rbCredito);
            Controls.Add(rbDebito);
            Controls.Add(btnContinuar);
            Controls.Add(lblMedioDePago);
            Controls.Add(lblTotalAPagar);
            Controls.Add(btnAtras);
            Controls.Add(dgvPagos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Pagos_Principal";
            Text = "Form_Pagos_Principal";
            Load += Form_Pagos_Principal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPagos;
        private Button btnAtras;
        private Label lblTotalAPagar;
        private Label lblMedioDePago;
        private Button btnContinuar;
        private RadioButton rbCredito;
        private RadioButton rbDebito;
        private RadioButton rbTransferencia;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn MontoDebe;
        private DataGridViewTextBoxColumn MontoAbonar;
    }
}