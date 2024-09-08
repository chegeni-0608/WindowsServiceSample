namespace CallWidowsServiceSample
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
            this.CallAddWebService = new System.Windows.Forms.Button();
            this.btnCallAdvantechWebService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CallAddWebService
            // 
            this.CallAddWebService.Location = new System.Drawing.Point(12, 22);
            this.CallAddWebService.Name = "CallAddWebService";
            this.CallAddWebService.Size = new System.Drawing.Size(212, 28);
            this.CallAddWebService.TabIndex = 0;
            this.CallAddWebService.Text = "Call Add Web Service";
            this.CallAddWebService.UseVisualStyleBackColor = true;
            this.CallAddWebService.Click += new System.EventHandler(this.CallAddWebService_Click);
            // 
            // btnCallAdvantechWebService
            // 
            this.btnCallAdvantechWebService.Location = new System.Drawing.Point(12, 82);
            this.btnCallAdvantechWebService.Name = "btnCallAdvantechWebService";
            this.btnCallAdvantechWebService.Size = new System.Drawing.Size(212, 28);
            this.btnCallAdvantechWebService.TabIndex = 1;
            this.btnCallAdvantechWebService.Text = "Call Advantech Web Service";
            this.btnCallAdvantechWebService.UseVisualStyleBackColor = true;
            this.btnCallAdvantechWebService.Click += new System.EventHandler(this.btnCallAdvantechWebService_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCallAdvantechWebService);
            this.Controls.Add(this.CallAddWebService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CallAddWebService;
        private System.Windows.Forms.Button btnCallAdvantechWebService;
    }
}

