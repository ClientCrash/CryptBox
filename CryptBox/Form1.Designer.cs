
namespace CryptBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.licenselabel = new System.Windows.Forms.Label();
            this.jobnamelabel = new System.Windows.Forms.Label();
            this.issueButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "This program checks file hashes to find non matching files.";
            // 
            // licenselabel
            // 
            this.licenselabel.AutoSize = true;
            this.licenselabel.Location = new System.Drawing.Point(372, 153);
            this.licenselabel.Name = "licenselabel";
            this.licenselabel.Size = new System.Drawing.Size(77, 13);
            this.licenselabel.TabIndex = 2;
            this.licenselabel.Text = "LICENSE: MIT";
            // 
            // jobnamelabel
            // 
            this.jobnamelabel.AutoSize = true;
            this.jobnamelabel.Location = new System.Drawing.Point(16, 83);
            this.jobnamelabel.Name = "jobnamelabel";
            this.jobnamelabel.Size = new System.Drawing.Size(64, 13);
            this.jobnamelabel.TabIndex = 3;
            this.jobnamelabel.Text = "JOB_NAME";
            // 
            // issueButton
            // 
            this.issueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueButton.Location = new System.Drawing.Point(13, 144);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(67, 21);
            this.issueButton.TabIndex = 4;
            this.issueButton.Text = "Report Issue";
            this.issueButton.UseVisualStyleBackColor = true;
            this.issueButton.Click += new System.EventHandler(this.issueButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(412, 18);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(37, 13);
            this.versionLabel.TabIndex = 5;
            this.versionLabel.Text = "v0.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Checking...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(462, 175);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.issueButton);
            this.Controls.Add(this.jobnamelabel);
            this.Controls.Add(this.licenselabel);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(478, 214);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label licenselabel;
        private System.Windows.Forms.Label jobnamelabel;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label2;
    }
}

