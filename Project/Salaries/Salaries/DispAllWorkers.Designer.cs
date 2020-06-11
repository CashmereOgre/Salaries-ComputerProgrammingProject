namespace Salaries
{
    partial class DispAllWorkers
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
            this.DispAllWorkersDGV = new System.Windows.Forms.DataGridView();
            this.ShowSalaries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DispAllWorkersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DispAllWorkersDGV
            // 
            this.DispAllWorkersDGV.AllowUserToAddRows = false;
            this.DispAllWorkersDGV.AllowUserToDeleteRows = false;
            this.DispAllWorkersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DispAllWorkersDGV.Location = new System.Drawing.Point(12, 12);
            this.DispAllWorkersDGV.Name = "DispAllWorkersDGV";
            this.DispAllWorkersDGV.ReadOnly = true;
            this.DispAllWorkersDGV.RowHeadersWidth = 51;
            this.DispAllWorkersDGV.RowTemplate.Height = 24;
            this.DispAllWorkersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DispAllWorkersDGV.Size = new System.Drawing.Size(638, 426);
            this.DispAllWorkersDGV.TabIndex = 0;
            // 
            // ShowSalaries
            // 
            this.ShowSalaries.Location = new System.Drawing.Point(669, 374);
            this.ShowSalaries.Name = "ShowSalaries";
            this.ShowSalaries.Size = new System.Drawing.Size(185, 63);
            this.ShowSalaries.TabIndex = 1;
            this.ShowSalaries.Text = "Show Salaries of chosen Worker";
            this.ShowSalaries.UseVisualStyleBackColor = true;
            this.ShowSalaries.Click += new System.EventHandler(this.ShowSalaries_Click);
            // 
            // DispAllWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.ShowSalaries);
            this.Controls.Add(this.DispAllWorkersDGV);
            this.Name = "DispAllWorkers";
            this.Text = "Display all Workers";
            ((System.ComponentModel.ISupportInitialize)(this.DispAllWorkersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DispAllWorkersDGV;
        private System.Windows.Forms.Button ShowSalaries;
    }
}