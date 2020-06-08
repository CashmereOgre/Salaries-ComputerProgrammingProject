namespace Salaries
{
    partial class ChooseWorker
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
            this.DispWorkers = new System.Windows.Forms.DataGridView();
            this.SelectWorker = new System.Windows.Forms.Button();
            this.AddNewWorker = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DispWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // DispWorkers
            // 
            this.DispWorkers.AllowUserToAddRows = false;
            this.DispWorkers.AllowUserToDeleteRows = false;
            this.DispWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DispWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DispWorkers.Location = new System.Drawing.Point(15, 14);
            this.DispWorkers.MultiSelect = false;
            this.DispWorkers.Name = "DispWorkers";
            this.DispWorkers.ReadOnly = true;
            this.DispWorkers.RowHeadersWidth = 51;
            this.DispWorkers.RowTemplate.Height = 24;
            this.DispWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DispWorkers.Size = new System.Drawing.Size(697, 352);
            this.DispWorkers.TabIndex = 0;
            // 
            // SelectWorker
            // 
            this.SelectWorker.Location = new System.Drawing.Point(15, 399);
            this.SelectWorker.Name = "SelectWorker";
            this.SelectWorker.Size = new System.Drawing.Size(294, 39);
            this.SelectWorker.TabIndex = 1;
            this.SelectWorker.Text = "Add Salary to chosen Worker";
            this.SelectWorker.UseVisualStyleBackColor = true;
            this.SelectWorker.Click += new System.EventHandler(this.SelectWorker_Click);
            // 
            // AddNewWorker
            // 
            this.AddNewWorker.Location = new System.Drawing.Point(342, 399);
            this.AddNewWorker.Name = "AddNewWorker";
            this.AddNewWorker.Size = new System.Drawing.Size(294, 39);
            this.AddNewWorker.TabIndex = 2;
            this.AddNewWorker.Text = "or add new Worker";
            this.AddNewWorker.UseVisualStyleBackColor = true;
            this.AddNewWorker.Click += new System.EventHandler(this.AddNewWorker_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(666, 399);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(294, 39);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // AddSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.AddNewWorker);
            this.Controls.Add(this.SelectWorker);
            this.Controls.Add(this.DispWorkers);
            this.Name = "AddSalary";
            this.Text = "AddSalary";
            ((System.ComponentModel.ISupportInitialize)(this.DispWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DispWorkers;
        private System.Windows.Forms.Button SelectWorker;
        private System.Windows.Forms.Button AddNewWorker;
        private System.Windows.Forms.Button Refresh;
    }
}