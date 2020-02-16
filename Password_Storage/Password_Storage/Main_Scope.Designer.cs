namespace Passwords_Storage
{
    partial class Main_Scope
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
            this.addBtn = new System.Windows.Forms.Button();
            this.listInfo = new System.Windows.Forms.ListBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Address:";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(610, 543);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(350, 77);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add one New";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // listInfo
            // 
            this.listInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listInfo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInfo.FormattingEnabled = true;
            this.listInfo.ItemHeight = 81;
            this.listInfo.Location = new System.Drawing.Point(0, 659);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(1265, 571);
            this.listInfo.TabIndex = 2;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(610, 146);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(616, 71);
            this.emailTxt.TabIndex = 3;
            // 
            // loginTxt
            // 
            this.loginTxt.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTxt.Location = new System.Drawing.Point(610, 244);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(616, 71);
            this.loginTxt.TabIndex = 4;
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.Location = new System.Drawing.Point(610, 341);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(616, 71);
            this.passTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 65);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login / Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 65);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 65);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name of Site:";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(610, 46);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(616, 71);
            this.nameTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 65);
            this.label5.TabIndex = 13;
            this.label5.Text = "URL:";
            // 
            // urlTxt
            // 
            this.urlTxt.Font = new System.Drawing.Font("Palatino Linotype", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTxt.Location = new System.Drawing.Point(610, 439);
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.Size = new System.Drawing.Size(616, 71);
            this.urlTxt.TabIndex = 12;
            // 
            // Main_Scope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 1230);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.urlTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.listInfo);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Name = "Main_Scope";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Scope";
            this.Load += new System.EventHandler(this.Main_Scope_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox listInfo;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox urlTxt;
    }
}