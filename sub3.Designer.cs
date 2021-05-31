
namespace Espeleta_ContactTracing
{
    partial class sub3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search_name = new System.Windows.Forms.Button();
            this.user_info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // last
            // 
            this.last.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.last.Location = new System.Drawing.Point(12, 50);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(192, 43);
            this.last.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(226, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 43);
            this.textBox1.TabIndex = 3;
            // 
            // search_name
            // 
            this.search_name.BackColor = System.Drawing.SystemColors.Highlight;
            this.search_name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_name.Location = new System.Drawing.Point(442, 21);
            this.search_name.Name = "search_name";
            this.search_name.Size = new System.Drawing.Size(256, 72);
            this.search_name.TabIndex = 4;
            this.search_name.Text = "SEARCH NAME";
            this.search_name.UseVisualStyleBackColor = false;
            // 
            // user_info
            // 
            this.user_info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_info.Location = new System.Drawing.Point(12, 99);
            this.user_info.Multiline = true;
            this.user_info.Name = "user_info";
            this.user_info.Size = new System.Drawing.Size(686, 572);
            this.user_info.TabIndex = 5;
            // 
            // sub3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 683);
            this.Controls.Add(this.user_info);
            this.Controls.Add(this.search_name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.last);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sub3";
            this.Text = "sub3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search_name;
        private System.Windows.Forms.TextBox user_info;
    }
}