namespace Explorer
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
            this.bntBack = new System.Windows.Forms.Button();
            this.bntFoward = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // bntBack
            // 
            this.bntBack.Location = new System.Drawing.Point(-1, 12);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(38, 23);
            this.bntBack.TabIndex = 0;
            this.bntBack.Text = "<<";
            this.bntBack.UseVisualStyleBackColor = true;
            this.bntBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntFoward
            // 
            this.bntFoward.Location = new System.Drawing.Point(43, 12);
            this.bntFoward.Name = "bntFoward";
            this.bntFoward.Size = new System.Drawing.Size(38, 23);
            this.bntFoward.TabIndex = 1;
            this.bntFoward.Text = ">>";
            this.bntFoward.UseVisualStyleBackColor = true;
            this.bntFoward.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(792, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.Location = new System.Drawing.Point(100, 15);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(37, 16);
            this.Path.TabIndex = 3;
            this.Path.Text = "Path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(140, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(646, 22);
            this.txtPath.TabIndex = 4;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(-1, 43);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(868, 453);
            this.webBrowser.TabIndex = 5;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 490);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.bntFoward);
            this.Controls.Add(this.bntBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntBack;
        private System.Windows.Forms.Button bntFoward;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

