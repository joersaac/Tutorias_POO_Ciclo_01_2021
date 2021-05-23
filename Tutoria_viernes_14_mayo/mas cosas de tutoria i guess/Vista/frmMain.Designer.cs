namespace mas_cosas_de_tutoria_i_guess
{
    partial class frmMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnEstudiante, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMateria, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInscripcion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLog, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstudiante.Location = new System.Drawing.Point(753, 3);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(182, 115);
            this.btnEstudiante.TabIndex = 0;
            this.btnEstudiante.Text = "Estudiantes";
            this.btnEstudiante.UseVisualStyleBackColor = true;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMateria.Location = new System.Drawing.Point(753, 124);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(182, 115);
            this.btnMateria.TabIndex = 1;
            this.btnMateria.Text = "Materias";
            this.btnMateria.UseVisualStyleBackColor = true;
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInscripcion.Location = new System.Drawing.Point(753, 245);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(182, 115);
            this.btnInscripcion.TabIndex = 2;
            this.btnInscripcion.Text = "Inscripcion";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // btnLog
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLog.Location = new System.Drawing.Point(753, 366);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(182, 115);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Consultar";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnMateria;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Button btnLog;
    }
}

