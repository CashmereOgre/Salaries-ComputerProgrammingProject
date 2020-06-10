namespace Salaries
{
    partial class DisplayAllSalaries
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
            this.DispAllSalaries = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DispAllSalaries)).BeginInit();
            this.SuspendLayout();
            // 
            // DispAllSalaries
            // 
            this.DispAllSalaries.AllowUserToAddRows = false;
            this.DispAllSalaries.AllowUserToDeleteRows = false;
            this.DispAllSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DispAllSalaries.Location = new System.Drawing.Point(12, 12);
            this.DispAllSalaries.Name = "DispAllSalaries";
            this.DispAllSalaries.ReadOnly = true;
            this.DispAllSalaries.RowHeadersWidth = 51;
            this.DispAllSalaries.RowTemplate.Height = 24;
            this.DispAllSalaries.Size = new System.Drawing.Size(754, 426);
            this.DispAllSalaries.TabIndex = 0;
            // 
            // DisplayAllSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.DispAllSalaries);
            this.Name = "DisplayAllSalaries";
            this.Text = "Display All Salaries";
            ((System.ComponentModel.ISupportInitialize)(this.DispAllSalaries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DispAllSalaries;
    }
}