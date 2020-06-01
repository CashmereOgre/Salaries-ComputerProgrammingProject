namespace Salaries
{
    partial class AddWorker
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DoBTB = new System.Windows.Forms.TextBox();
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PeselTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(242, 40);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(194, 22);
            this.NameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(242, 90);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(194, 22);
            this.SurnameTB.TabIndex = 3;
            this.SurnameTB.TextChanged += new System.EventHandler(this.SurnameTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender (F/M)";
            // 
            // GenderTB
            // 
            this.GenderTB.Location = new System.Drawing.Point(242, 137);
            this.GenderTB.Name = "GenderTB";
            this.GenderTB.Size = new System.Drawing.Size(194, 22);
            this.GenderTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of Birth (DD.MM.YYYY)";
            // 
            // DoBTB
            // 
            this.DoBTB.Location = new System.Drawing.Point(242, 187);
            this.DoBTB.Name = "DoBTB";
            this.DoBTB.Size = new System.Drawing.Size(194, 22);
            this.DoBTB.TabIndex = 7;
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Location = new System.Drawing.Point(43, 305);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(393, 37);
            this.AddWorkerButton.TabIndex = 8;
            this.AddWorkerButton.Text = "Add Worker";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PESEL";
            // 
            // PeselTB
            // 
            this.PeselTB.Location = new System.Drawing.Point(242, 237);
            this.PeselTB.Name = "PeselTB";
            this.PeselTB.Size = new System.Drawing.Size(194, 22);
            this.PeselTB.TabIndex = 10;
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 381);
            this.Controls.Add(this.PeselTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddWorkerButton);
            this.Controls.Add(this.DoBTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenderTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Name = "AddWorker";
            this.Text = "Add Worker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GenderTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DoBTB;
        private System.Windows.Forms.Button AddWorkerButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PeselTB;
    }
}