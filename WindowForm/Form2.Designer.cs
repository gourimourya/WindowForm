namespace WindowForm
{
    partial class Form2
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
            this.saved = new System.Windows.Forms.Button();
            this.textfirstname = new System.Windows.Forms.TextBox();
            this.textsecondname = new System.Windows.Forms.TextBox();
            this.btshowdata = new System.Windows.Forms.DataGridView();
            this.show = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btshowdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "SecondName";
            // 
            // saved
            // 
            this.saved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saved.Location = new System.Drawing.Point(194, 148);
            this.saved.Name = "saved";
            this.saved.Size = new System.Drawing.Size(75, 34);
            this.saved.TabIndex = 2;
            this.saved.Text = "Save";
            this.saved.UseVisualStyleBackColor = true;
            this.saved.Click += new System.EventHandler(this.saved_Click);
            // 
            // textfirstname
            // 
            this.textfirstname.Location = new System.Drawing.Point(171, 64);
            this.textfirstname.Name = "textfirstname";
            this.textfirstname.Size = new System.Drawing.Size(131, 20);
            this.textfirstname.TabIndex = 3;
            // 
            // textsecondname
            // 
            this.textsecondname.Location = new System.Drawing.Point(171, 109);
            this.textsecondname.Name = "textsecondname";
            this.textsecondname.Size = new System.Drawing.Size(131, 20);
            this.textsecondname.TabIndex = 4;
            // 
            // btshowdata
            // 
            this.btshowdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btshowdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.btshowdata.Location = new System.Drawing.Point(384, 83);
            this.btshowdata.Name = "btshowdata";
            this.btshowdata.Size = new System.Drawing.Size(244, 281);
            this.btshowdata.TabIndex = 5;
            this.btshowdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btshowdata_CellContentClick);
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(384, 44);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(115, 33);
            this.show.TabIndex = 6;
            this.show.Text = "Show Data";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.btshowdata);
            this.Controls.Add(this.textsecondname);
            this.Controls.Add(this.textfirstname);
            this.Controls.Add(this.saved);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.btshowdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saved;
        private System.Windows.Forms.TextBox textfirstname;
        private System.Windows.Forms.TextBox textsecondname;
        private System.Windows.Forms.DataGridView btshowdata;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}