
namespace Espeleta_ContactTracing
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.positive = new System.Windows.Forms.Button();
            this.close_contact = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 638);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // positive
            // 
            this.positive.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.positive.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positive.Location = new System.Drawing.Point(96, 95);
            this.positive.Name = "positive";
            this.positive.Size = new System.Drawing.Size(451, 77);
            this.positive.TabIndex = 5;
            this.positive.Text = "COVID POSITIVE";
            this.positive.UseVisualStyleBackColor = false;
            // 
            // close_contact
            // 
            this.close_contact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.close_contact.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.close_contact.Location = new System.Drawing.Point(96, 208);
            this.close_contact.Name = "close_contact";
            this.close_contact.Size = new System.Drawing.Size(451, 77);
            this.close_contact.TabIndex = 6;
            this.close_contact.Text = "COVID CLOSE CONTACT";
            this.close_contact.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(96, 332);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(451, 77);
            this.search.TabIndex = 7;
            this.search.Text = "SEARCH FILES";
            this.search.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(96, 452);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(451, 77);
            this.exit.TabIndex = 8;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 634);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.close_contact);
            this.Controls.Add(this.positive);
            this.Controls.Add(this.pictureBox1);
            this.Name = "main";
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button positive;
        private System.Windows.Forms.Button close_contact;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button exit;
    }
}