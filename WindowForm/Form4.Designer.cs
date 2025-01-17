namespace WindowForm
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textfirst = new System.Windows.Forms.TextBox();
            this.textlast = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textconfirm = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonregister = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textfirst
            // 
            this.textfirst.Location = new System.Drawing.Point(308, 85);
            this.textfirst.Name = "textfirst";
            this.textfirst.Size = new System.Drawing.Size(227, 20);
            this.textfirst.TabIndex = 4;
            this.textfirst.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textlast
            // 
            this.textlast.Location = new System.Drawing.Point(308, 129);
            this.textlast.Name = "textlast";
            this.textlast.Size = new System.Drawing.Size(227, 20);
            this.textlast.TabIndex = 5;
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(308, 165);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(227, 20);
            this.textuser.TabIndex = 6;
            // 
            // textconfirm
            // 
            this.textconfirm.Location = new System.Drawing.Point(308, 249);
            this.textconfirm.Name = "textconfirm";
            this.textconfirm.Size = new System.Drawing.Size(227, 20);
            this.textconfirm.TabIndex = 7;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(308, 209);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(227, 20);
            this.textpass.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirm Password";
            // 
            // buttonregister
            // 
            this.buttonregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonregister.Location = new System.Drawing.Point(192, 316);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(280, 39);
            this.buttonregister.TabIndex = 10;
            this.buttonregister.Text = "Register";
            this.buttonregister.UseVisualStyleBackColor = false;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonlogin.Location = new System.Drawing.Point(660, 38);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(95, 33);
            this.buttonlogin.TabIndex = 12;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(137, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "STUDENT REGISTER FORM";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.buttonregister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textconfirm);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.textlast);
            this.Controls.Add(this.textfirst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textfirst;
        private System.Windows.Forms.TextBox textlast;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textconfirm;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button button1;
    }
}