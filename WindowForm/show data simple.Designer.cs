namespace WindowForm
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxsecondname = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.showbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.textBoxfirstname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btshowdatabox = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.cbcolumn = new System.Windows.Forms.Label();
            this.textcolumn = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btshowdatabox)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(53, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(53, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "FirstName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(53, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "SecondName";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(162, 95);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(156, 20);
            this.textBoxID.TabIndex = 3;
            // 
            // textBoxsecondname
            // 
            this.textBoxsecondname.Location = new System.Drawing.Point(162, 170);
            this.textBoxsecondname.Name = "textBoxsecondname";
            this.textBoxsecondname.Size = new System.Drawing.Size(229, 20);
            this.textBoxsecondname.TabIndex = 4;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(60, 223);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(110, 34);
            this.savebutton.TabIndex = 5;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            // 
            // showbutton
            // 
            this.showbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.showbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbutton.Location = new System.Drawing.Point(34, 23);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(357, 39);
            this.showbutton.TabIndex = 6;
            this.showbutton.Text = "Show Data";
            this.showbutton.UseVisualStyleBackColor = false;
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(289, 222);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(102, 35);
            this.updatebutton.TabIndex = 7;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            // 
            // delbutton
            // 
            this.delbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbutton.Location = new System.Drawing.Point(289, 263);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(102, 32);
            this.delbutton.TabIndex = 8;
            this.delbutton.Text = "Delete";
            this.delbutton.UseVisualStyleBackColor = false;
            // 
            // textBoxfirstname
            // 
            this.textBoxfirstname.Location = new System.Drawing.Point(162, 129);
            this.textBoxfirstname.Name = "textBoxfirstname";
            this.textBoxfirstname.Size = new System.Drawing.Size(229, 20);
            this.textBoxfirstname.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.showbutton);
            this.panel1.Controls.Add(this.delbutton);
            this.panel1.Controls.Add(this.textBoxfirstname);
            this.panel1.Controls.Add(this.updatebutton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.savebutton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxsecondname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Location = new System.Drawing.Point(41, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 317);
            this.panel1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Fetch";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btshowdatabox
            // 
            this.btshowdatabox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btshowdatabox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.btshowdatabox.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.btshowdatabox.Location = new System.Drawing.Point(464, 56);
            this.btshowdatabox.Name = "btshowdatabox";
            this.btshowdatabox.Size = new System.Drawing.Size(531, 337);
            this.btshowdatabox.TabIndex = 11;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "FirstName";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "SecondName";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Edit";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Delete";
            this.Column13.Name = "Column13";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.text.Location = new System.Drawing.Point(686, 7);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(60, 20);
            this.text.TabIndex = 12;
            this.text.Text = "Search";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(680, 30);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(180, 20);
            this.textsearch.TabIndex = 13;
            this.textsearch.TextChanged += new System.EventHandler(this.textsearch_TextChanged);
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Gray;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.Location = new System.Drawing.Point(866, 25);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(129, 28);
            this.searchbutton.TabIndex = 14;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // cbcolumn
            // 
            this.cbcolumn.AutoSize = true;
            this.cbcolumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcolumn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbcolumn.Location = new System.Drawing.Point(485, 9);
            this.cbcolumn.Name = "cbcolumn";
            this.cbcolumn.Size = new System.Drawing.Size(67, 20);
            this.cbcolumn.TabIndex = 15;
            this.cbcolumn.Text = "Column:";
            // 
            // textcolumn
            // 
            this.textcolumn.Location = new System.Drawing.Point(480, 32);
            this.textcolumn.Name = "textcolumn";
            this.textcolumn.Size = new System.Drawing.Size(180, 20);
            this.textcolumn.TabIndex = 16;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(1011, 412);
            this.Controls.Add(this.textcolumn);
            this.Controls.Add(this.cbcolumn);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.text);
            this.Controls.Add(this.btshowdatabox);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btshowdatabox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textfirstname;
        private System.Windows.Forms.TextBox textsecondname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button textshow;
        private System.Windows.Forms.DataGridView btshowdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Button textupdate;
        private System.Windows.Forms.Button textfetch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button textdelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxsecondname;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.TextBox textBoxfirstname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView btshowdatabox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label cbcolumn;
        private System.Windows.Forms.TextBox textcolumn;
    }
}