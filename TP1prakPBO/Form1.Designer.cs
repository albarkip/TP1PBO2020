namespace TP1prakPBO
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginnama = new System.Windows.Forms.TextBox();
            this.loginkunci = new System.Windows.Forms.TextBox();
            this.tombollogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // loginnama
            // 
            this.loginnama.Location = new System.Drawing.Point(85, 112);
            this.loginnama.Name = "loginnama";
            this.loginnama.Size = new System.Drawing.Size(100, 20);
            this.loginnama.TabIndex = 3;
            this.loginnama.TextChanged += new System.EventHandler(this.loginnama_TextChanged);
            // 
            // loginkunci
            // 
            this.loginkunci.Location = new System.Drawing.Point(85, 170);
            this.loginkunci.Name = "loginkunci";
            this.loginkunci.PasswordChar = '*';
            this.loginkunci.Size = new System.Drawing.Size(100, 20);
            this.loginkunci.TabIndex = 4;
            this.loginkunci.TextChanged += new System.EventHandler(this.loginkunci_TextChanged);
            // 
            // tombollogin
            // 
            this.tombollogin.Location = new System.Drawing.Point(94, 223);
            this.tombollogin.Name = "tombollogin";
            this.tombollogin.Size = new System.Drawing.Size(75, 23);
            this.tombollogin.TabIndex = 5;
            this.tombollogin.Text = "login";
            this.tombollogin.UseVisualStyleBackColor = true;
            this.tombollogin.Click += new System.EventHandler(this.tombollogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 348);
            this.Controls.Add(this.tombollogin);
            this.Controls.Add(this.loginkunci);
            this.Controls.Add(this.loginnama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginnama;
        private System.Windows.Forms.TextBox loginkunci;
        private System.Windows.Forms.Button tombollogin;
    }
}

