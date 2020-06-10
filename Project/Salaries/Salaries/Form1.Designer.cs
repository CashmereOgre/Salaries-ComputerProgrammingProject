namespace Salaries
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAW = new System.Windows.Forms.Button();
            this.buttonAS = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonDAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAW
            // 
            this.buttonAW.Location = new System.Drawing.Point(42, 27);
            this.buttonAW.Name = "buttonAW";
            this.buttonAW.Size = new System.Drawing.Size(328, 66);
            this.buttonAW.TabIndex = 0;
            this.buttonAW.Text = "Add Worker";
            this.buttonAW.UseVisualStyleBackColor = true;
            this.buttonAW.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAS
            // 
            this.buttonAS.Location = new System.Drawing.Point(42, 134);
            this.buttonAS.Name = "buttonAS";
            this.buttonAS.Size = new System.Drawing.Size(328, 66);
            this.buttonAS.TabIndex = 1;
            this.buttonAS.Text = "Add Salary";
            this.buttonAS.UseVisualStyleBackColor = true;
            this.buttonAS.Click += new System.EventHandler(this.buttonAS_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(328, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Display workers";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ButtonDAS
            // 
            this.ButtonDAS.Location = new System.Drawing.Point(42, 348);
            this.ButtonDAS.Name = "ButtonDAS";
            this.ButtonDAS.Size = new System.Drawing.Size(328, 66);
            this.ButtonDAS.TabIndex = 3;
            this.ButtonDAS.Text = "Display all salaries";
            this.ButtonDAS.UseVisualStyleBackColor = true;
            this.ButtonDAS.Click += new System.EventHandler(this.ButtonDAS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 446);
            this.Controls.Add(this.ButtonDAS);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAS);
            this.Controls.Add(this.buttonAW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAW;
        private System.Windows.Forms.Button buttonAS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonDAS;
    }
}

