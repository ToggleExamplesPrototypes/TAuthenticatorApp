namespace TAuthenticatorApp
{
    partial class frmCredits
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
            this.btnCredits = new System.Windows.Forms.Button();
            this.lbCreditsTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCredits
            // 
            this.btnCredits.Font = new System.Drawing.Font("SF Pro Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.Location = new System.Drawing.Point(1517, 946);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(375, 83);
            this.btnCredits.TabIndex = 11;
            this.btnCredits.Text = "Back to Landing Page";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // lbCreditsTitle
            // 
            this.lbCreditsTitle.AutoSize = true;
            this.lbCreditsTitle.Font = new System.Drawing.Font("SF Pro Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreditsTitle.Location = new System.Drawing.Point(13, 13);
            this.lbCreditsTitle.Name = "lbCreditsTitle";
            this.lbCreditsTitle.Size = new System.Drawing.Size(186, 58);
            this.lbCreditsTitle.TabIndex = 12;
            this.lbCreditsTitle.Text = "Credits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Text", 24F);
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Text", 24F);
            this.label2.Location = new System.Drawing.Point(802, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "For";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Text", 24F);
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(614, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Evgeni Moryakov from the Noun Project\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Text", 24F);
            this.label4.Location = new System.Drawing.Point(802, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(908, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "Default \"Site\" image on the Main Screen Menu Form Thing.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Text", 24F);
            this.label5.Location = new System.Drawing.Point(16, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(749, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "Copy by Graphik Designz from NounProject.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Text", 24F);
            this.label6.Location = new System.Drawing.Point(802, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 38);
            this.label6.TabIndex = 18;
            this.label6.Text = "Copy Image";
            // 
            // frmCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCreditsTitle);
            this.Controls.Add(this.btnCredits);
            this.Name = "frmCredits";
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.frmCredits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Label lbCreditsTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}