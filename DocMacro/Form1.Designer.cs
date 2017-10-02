namespace DocMacro
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
            this.openPDFbutton = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // openPDFbutton
            // 
            this.openPDFbutton.Location = new System.Drawing.Point(12, 12);
            this.openPDFbutton.Name = "openPDFbutton";
            this.openPDFbutton.Size = new System.Drawing.Size(179, 58);
            this.openPDFbutton.TabIndex = 0;
            this.openPDFbutton.Text = "Select PDF";
            this.openPDFbutton.UseVisualStyleBackColor = true;
            this.openPDFbutton.Click += new System.EventHandler(this.openPDFbutton_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "pdf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 208);
            this.Controls.Add(this.openPDFbutton);
            this.Name = "Form1";
            this.Text = "DocMacro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openPDFbutton;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

