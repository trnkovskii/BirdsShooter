namespace WindowsFormsApp1
{
    partial class Sure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sure));
            this.lblNo = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Showcard Gothic", 12.25F);
            this.lblNo.Location = new System.Drawing.Point(283, 185);
            this.lblNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(47, 31);
            this.lblNo.TabIndex = 7;
            this.lblNo.Text = "no";
            this.lblNo.Click += new System.EventHandler(this.lblNo_Click);
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.BackColor = System.Drawing.Color.Transparent;
            this.lblYes.Font = new System.Drawing.Font("Showcard Gothic", 12.25F);
            this.lblYes.Location = new System.Drawing.Point(124, 185);
            this.lblYes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(60, 31);
            this.lblYes.TabIndex = 6;
            this.lblYes.Text = "yes";
            this.lblYes.Click += new System.EventHandler(this.lblYes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12.25F);
            this.label2.Location = new System.Drawing.Point(124, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "exit the game?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12.25F);
            this.label1.Location = new System.Drawing.Point(52, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Are you sure you want to";
            // 
            // Sure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 257);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sure";
            this.Text = "Are you sure?";
            this.Load += new System.EventHandler(this.Sure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}