namespace HoursReport
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
            this.company_textBox = new System.Windows.Forms.TextBox();
            this.companies_listbox = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.end_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timeListView = new System.Windows.Forms.ListView();
            this.start_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.end_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shareTimeBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.Reason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // company_textBox
            // 
            this.company_textBox.AccessibleName = "company_text_box";
            this.company_textBox.Location = new System.Drawing.Point(36, 30);
            this.company_textBox.Name = "company_textBox";
            this.company_textBox.Size = new System.Drawing.Size(133, 20);
            this.company_textBox.TabIndex = 0;
            // 
            // companies_listbox
            // 
            this.companies_listbox.FormattingEnabled = true;
            this.companies_listbox.Location = new System.Drawing.Point(36, 87);
            this.companies_listbox.Name = "companies_listbox";
            this.companies_listbox.Size = new System.Drawing.Size(133, 173);
            this.companies_listbox.TabIndex = 1;
            this.companies_listbox.SelectedIndexChanged += new System.EventHandler(this.companies_listbox_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.AccessibleName = "add_button";
            this.add_button.Location = new System.Drawing.Point(197, 31);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(74, 19);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(196, 87);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // end_button
            // 
            this.end_button.Enabled = false;
            this.end_button.Location = new System.Drawing.Point(277, 87);
            this.end_button.Name = "end_button";
            this.end_button.Size = new System.Drawing.Size(75, 23);
            this.end_button.TabIndex = 4;
            this.end_button.Text = "end";
            this.end_button.UseVisualStyleBackColor = true;
            this.end_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(36, 266);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(133, 23);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(36, 295);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(133, 23);
            this.load_button.TabIndex = 6;
            this.load_button.Text = "load companies";
            this.load_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(36, 324);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(133, 23);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "save companies";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(36, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(133, 24);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Companies:";
            // 
            // timeListView
            // 
            this.timeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.start_time,
            this.end_time,
            this.sum,
            this.Day});
            this.timeListView.Location = new System.Drawing.Point(197, 124);
            this.timeListView.Name = "timeListView";
            this.timeListView.Size = new System.Drawing.Size(273, 169);
            this.timeListView.TabIndex = 9;
            this.timeListView.UseCompatibleStateImageBehavior = false;
            this.timeListView.View = System.Windows.Forms.View.Details;
            // 
            // start_time
            // 
            this.start_time.Tag = "st";
            this.start_time.Text = "start";
            this.start_time.Width = 55;
            // 
            // end_time
            // 
            this.end_time.Text = "end";
            this.end_time.Width = 82;
            // 
            // sum
            // 
            this.sum.Text = "hours";
            this.sum.Width = 57;
            // 
            // Day
            // 
            this.Day.Text = "Day";
            this.Day.Width = 74;
            // 
            // shareTimeBtn
            // 
            this.shareTimeBtn.Location = new System.Drawing.Point(36, 371);
            this.shareTimeBtn.Name = "shareTimeBtn";
            this.shareTimeBtn.Size = new System.Drawing.Size(133, 23);
            this.shareTimeBtn.TabIndex = 10;
            this.shareTimeBtn.Text = "add share time";
            this.shareTimeBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reason,
            this.Hours});
            this.listView1.Location = new System.Drawing.Point(197, 299);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(273, 125);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Hours
            // 
            this.Hours.DisplayIndex = 0;
            this.Hours.Text = "Hours";
            this.Hours.Width = 114;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "delete shared time";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Reason
            // 
            this.Reason.DisplayIndex = 1;
            this.Reason.Text = "Reason";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.shareTimeBtn);
            this.Controls.Add(this.timeListView);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.end_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.companies_listbox);
            this.Controls.Add(this.company_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button end_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ListBox companies_listbox;
        private System.Windows.Forms.TextBox company_textBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView timeListView;
        private System.Windows.Forms.ColumnHeader start_time;
        private System.Windows.Forms.ColumnHeader end_time;
        private System.Windows.Forms.ColumnHeader sum;
        private System.Windows.Forms.Button shareTimeBtn;
        private System.Windows.Forms.ListView listView1;
//        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Hours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader Reason;
    }
}

