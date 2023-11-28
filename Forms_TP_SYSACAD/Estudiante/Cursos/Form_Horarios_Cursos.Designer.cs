namespace Forms_TP_SYSACAD
{
    partial class Form_Horarios_Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Horarios_Cursos));
            btnAtras = new Button();
            listViewHorarios = new ListView();
            nombre = new ColumnHeader();
            horario = new ColumnHeader();
            dia = new ColumnHeader();
            aula = new ColumnHeader();
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
            btnAtras.Click += btnAtras_Click_1;
            // 
            // listViewHorarios
            // 
            listViewHorarios.BackColor = SystemColors.WindowText;
            listViewHorarios.BorderStyle = BorderStyle.FixedSingle;
            listViewHorarios.Columns.AddRange(new ColumnHeader[] { nombre, horario, dia, aula });
            listViewHorarios.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            listViewHorarios.ForeColor = Color.Red;
            listViewHorarios.Location = new Point(45, 82);
            listViewHorarios.Name = "listViewHorarios";
            listViewHorarios.Size = new Size(514, 263);
            listViewHorarios.TabIndex = 2;
            listViewHorarios.UseCompatibleStateImageBehavior = false;
            listViewHorarios.View = View.Details;
            // 
            // nombre
            // 
            nombre.Text = "Nombre";
            nombre.Width = 150;
            // 
            // horario
            // 
            horario.Text = "Horario";
            horario.TextAlign = HorizontalAlignment.Center;
            horario.Width = 160;
            // 
            // dia
            // 
            dia.Text = "Dia";
            dia.TextAlign = HorizontalAlignment.Center;
            dia.Width = 100;
            // 
            // aula
            // 
            aula.Text = "Aula";
            aula.TextAlign = HorizontalAlignment.Center;
            aula.Width = 100;
            // 
            // Form_Horarios_Cursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(606, 380);
            Controls.Add(listViewHorarios);
            Controls.Add(btnAtras);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Horarios_Cursos";
            Text = "Form_Horarios_Cursos";
            Load += Form_Horarios_Cursos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private ListView listViewHorarios;
        private ColumnHeader nombre;
        private ColumnHeader horario;
        private ColumnHeader dia;
        private ColumnHeader aula;
    }
}