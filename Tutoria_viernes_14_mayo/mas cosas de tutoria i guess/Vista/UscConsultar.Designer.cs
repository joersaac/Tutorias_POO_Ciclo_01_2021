namespace mas_cosas_de_tutoria_i_guess.Vista
{
    partial class UscConsultar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEnrollData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnrollData
            // 
            this.dgvEnrollData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnrollData.Location = new System.Drawing.Point(0, 0);
            this.dgvEnrollData.Name = "dgvEnrollData";
            this.dgvEnrollData.RowHeadersWidth = 62;
            this.dgvEnrollData.RowTemplate.Height = 28;
            this.dgvEnrollData.Size = new System.Drawing.Size(633, 544);
            this.dgvEnrollData.TabIndex = 0;
            // 
            // UscConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEnrollData);
            this.Name = "UscConsultar";
            this.Size = new System.Drawing.Size(633, 544);
            this.Load += new System.EventHandler(this.UscConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnrollData;
    }
}
