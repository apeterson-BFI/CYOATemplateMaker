namespace CYOATemplateMaker
{
    partial class AdventureViewer
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
            this.AdventureBrowser = new System.Windows.Forms.WebBrowser();
            this.lblOption1 = new System.Windows.Forms.LinkLabel();
            this.lblOption2 = new System.Windows.Forms.LinkLabel();
            this.lblOption3 = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblOption4 = new System.Windows.Forms.LinkLabel();
            this.lblOption5 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AdventureBrowser
            // 
            this.AdventureBrowser.AllowWebBrowserDrop = false;
            this.AdventureBrowser.Location = new System.Drawing.Point(3, 0);
            this.AdventureBrowser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AdventureBrowser.MinimumSize = new System.Drawing.Size(33, 31);
            this.AdventureBrowser.Name = "AdventureBrowser";
            this.AdventureBrowser.Size = new System.Drawing.Size(1055, 387);
            this.AdventureBrowser.TabIndex = 0;
            // 
            // lblOption1
            // 
            this.lblOption1.Location = new System.Drawing.Point(14, 399);
            this.lblOption1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(538, 20);
            this.lblOption1.TabIndex = 1;
            this.lblOption1.TabStop = true;
            this.lblOption1.Text = "option1";
            // 
            // lblOption2
            // 
            this.lblOption2.Location = new System.Drawing.Point(14, 428);
            this.lblOption2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(538, 20);
            this.lblOption2.TabIndex = 2;
            this.lblOption2.TabStop = true;
            this.lblOption2.Text = "option2";
            // 
            // lblOption3
            // 
            this.lblOption3.Location = new System.Drawing.Point(14, 457);
            this.lblOption3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(538, 20);
            this.lblOption3.TabIndex = 3;
            this.lblOption3.TabStop = true;
            this.lblOption3.Text = "option3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblOption4
            // 
            this.lblOption4.Location = new System.Drawing.Point(14, 486);
            this.lblOption4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOption4.Name = "lblOption4";
            this.lblOption4.Size = new System.Drawing.Size(538, 20);
            this.lblOption4.TabIndex = 5;
            this.lblOption4.TabStop = true;
            this.lblOption4.Text = "option4";
            // 
            // lblOption5
            // 
            this.lblOption5.Location = new System.Drawing.Point(14, 515);
            this.lblOption5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOption5.Name = "lblOption5";
            this.lblOption5.Size = new System.Drawing.Size(538, 20);
            this.lblOption5.TabIndex = 6;
            this.lblOption5.TabStop = true;
            this.lblOption5.Text = "option5";
            // 
            // AdventureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 568);
            this.Controls.Add(this.lblOption5);
            this.Controls.Add(this.lblOption4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblOption3);
            this.Controls.Add(this.lblOption2);
            this.Controls.Add(this.lblOption1);
            this.Controls.Add(this.AdventureBrowser);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AdventureViewer";
            this.Text = "Adventure Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser AdventureBrowser;
        private System.Windows.Forms.LinkLabel lblOption1;
        private System.Windows.Forms.LinkLabel lblOption2;
        private System.Windows.Forms.LinkLabel lblOption3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.LinkLabel lblOption4;
        private System.Windows.Forms.LinkLabel lblOption5;
    }
}

