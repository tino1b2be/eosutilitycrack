namespace WindowsFormsApplication1
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
            this.crack_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eoslink = new System.Windows.Forms.LinkLabel();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // crack_btn
            // 
            this.crack_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crack_btn.Location = new System.Drawing.Point(121, 54);
            this.crack_btn.Name = "crack_btn";
            this.crack_btn.Size = new System.Drawing.Size(116, 49);
            this.crack_btn.TabIndex = 0;
            this.crack_btn.Text = "Crack!";
            this.crack_btn.UseVisualStyleBackColor = true;
            this.crack_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "EOS Utility Crack";
            // 
            // eoslink
            // 
            this.eoslink.AutoSize = true;
            this.eoslink.Location = new System.Drawing.Point(18, 114);
            this.eoslink.Name = "eoslink";
            this.eoslink.Size = new System.Drawing.Size(326, 17);
            this.eoslink.TabIndex = 2;
            this.eoslink.TabStop = true;
            this.eoslink.Text = "Click to download EOS Utility from Canon\'s website";
            this.eoslink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // logo
            // 
            this.logo.Image = global::WindowsFormsApplication1.Properties.Resources.logo22;
            this.logo.Location = new System.Drawing.Point(117, 142);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(124, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 204);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.eoslink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crack_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EOS Utility Crack";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crack_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel eoslink;
        private System.Windows.Forms.PictureBox logo;
    }
}

