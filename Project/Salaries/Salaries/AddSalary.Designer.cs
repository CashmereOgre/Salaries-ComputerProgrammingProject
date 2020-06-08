namespace Salaries
{
    partial class AddSalary
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
            this.AddSalaryWorker = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AddSalaryWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSalaryWorker
            // 
            this.AddSalaryWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddSalaryWorker.Location = new System.Drawing.Point(13, 13);
            this.AddSalaryWorker.Name = "AddSalaryWorker";
            this.AddSalaryWorker.RowHeadersWidth = 51;
            this.AddSalaryWorker.RowTemplate.Height = 24;
            this.AddSalaryWorker.Size = new System.Drawing.Size(775, 72);
            this.AddSalaryWorker.TabIndex = 0;
            // 
            // AddSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddSalaryWorker);
            this.Name = "AddSalary";
            this.Text = "Add Salary";
            ((System.ComponentModel.ISupportInitialize)(this.AddSalaryWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AddSalaryWorker;
    }
}