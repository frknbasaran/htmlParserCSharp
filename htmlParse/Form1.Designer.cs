namespace htmlParse {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.h1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.tabloToolStripMenuItem,
            this.başlıkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem,
            this.passwordToolStripMenuItem,
            this.textareaToolStripMenuItem,
            this.buttonToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.passwordToolStripMenuItem.Text = "Password";
            this.passwordToolStripMenuItem.Click += new System.EventHandler(this.passwordToolStripMenuItem_Click);
            // 
            // textareaToolStripMenuItem
            // 
            this.textareaToolStripMenuItem.Name = "textareaToolStripMenuItem";
            this.textareaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.textareaToolStripMenuItem.Text = "Textarea";
            this.textareaToolStripMenuItem.Click += new System.EventHandler(this.textareaToolStripMenuItem_Click);
            // 
            // buttonToolStripMenuItem
            // 
            this.buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
            this.buttonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buttonToolStripMenuItem.Text = "Button";
            this.buttonToolStripMenuItem.Click += new System.EventHandler(this.buttonToolStripMenuItem_Click);
            // 
            // tabloToolStripMenuItem
            // 
            this.tabloToolStripMenuItem.Name = "tabloToolStripMenuItem";
            this.tabloToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.tabloToolStripMenuItem.Text = "Tablo";
            this.tabloToolStripMenuItem.Click += new System.EventHandler(this.tabloToolStripMenuItem_Click);
            // 
            // başlıkToolStripMenuItem
            // 
            this.başlıkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.h1ToolStripMenuItem});
            this.başlıkToolStripMenuItem.Name = "başlıkToolStripMenuItem";
            this.başlıkToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.başlıkToolStripMenuItem.Text = "Başlık";
            this.başlıkToolStripMenuItem.Click += new System.EventHandler(this.başlıkToolStripMenuItem_Click);
            // 
            // h1ToolStripMenuItem
            // 
            this.h1ToolStripMenuItem.Name = "h1ToolStripMenuItem";
            this.h1ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.h1ToolStripMenuItem.Text = "h1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(584, 361);
            this.webBrowser1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 385);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "mini web designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem h1ToolStripMenuItem;

    }
}

