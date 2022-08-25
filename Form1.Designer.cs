namespace asynchronousForm
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnImpact = new System.Windows.Forms.Button();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(97, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "TOPLA";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnImpact
            // 
            this.btnImpact.Location = new System.Drawing.Point(253, 179);
            this.btnImpact.Name = "btnImpact";
            this.btnImpact.Size = new System.Drawing.Size(99, 43);
            this.btnImpact.TabIndex = 1;
            this.btnImpact.Text = "ÇARPMA";
            this.btnImpact.UseVisualStyleBackColor = true;
            this.btnImpact.Click += new System.EventHandler(this.btnImpact_Click);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(103, 85);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(104, 22);
            this.tbx1.TabIndex = 2;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(104, 133);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(104, 22);
            this.tbx2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.btnImpact);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnImpact;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx2;
    }
}

