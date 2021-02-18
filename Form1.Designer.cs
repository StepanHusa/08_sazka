namespace _08_sazka
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
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.numbers = new System.Windows.Forms.ListBox();
            this.home = new System.Windows.Forms.ListBox();
            this.host = new System.Windows.Forms.ListBox();
            this.dashes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.d = new System.Windows.Forms.CheckedListBox();
            this.c = new System.Windows.Forms.CheckedListBox();
            this.comment1 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.error = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(79, 9);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(150, 38);
            this.id.TabIndex = 1;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(235, 9);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 39);
            this.enter.TabIndex = 2;
            this.enter.Text = "ENTER";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // numbers
            // 
            this.numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbers.FormattingEnabled = true;
            this.numbers.ItemHeight = 20;
            this.numbers.Location = new System.Drawing.Point(31, 37);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(29, 264);
            this.numbers.TabIndex = 3;
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.FormattingEnabled = true;
            this.home.ItemHeight = 20;
            this.home.Location = new System.Drawing.Point(66, 37);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(196, 264);
            this.home.TabIndex = 4;
            // 
            // host
            // 
            this.host.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host.FormattingEnabled = true;
            this.host.ItemHeight = 20;
            this.host.Location = new System.Drawing.Point(408, 36);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(198, 264);
            this.host.TabIndex = 5;
            // 
            // dashes
            // 
            this.dashes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashes.FormattingEnabled = true;
            this.dashes.ItemHeight = 20;
            this.dashes.Items.AddRange(new object[] {
            "  -",
            "  -",
            "  -",
            "  -",
            "  -",
            "  -",
            "  -",
            "  -",
            "  -",
            "  -",
            "  -",
            "  -",
            "  -"});
            this.dashes.Location = new System.Drawing.Point(315, 36);
            this.dashes.Name = "dashes";
            this.dashes.Size = new System.Drawing.Size(29, 264);
            this.dashes.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.comment1);
            this.groupBox1.Controls.Add(this.results);
            this.groupBox1.Controls.Add(this.submit);
            this.groupBox1.Controls.Add(this.home);
            this.groupBox1.Controls.Add(this.numbers);
            this.groupBox1.Controls.Add(this.host);
            this.groupBox1.Controls.Add(this.dashes);
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 385);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // d
            // 
            this.d.CheckOnClick = true;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.d.FormattingEnabled = true;
            this.d.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.d.Location = new System.Drawing.Point(364, 36);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(19, 264);
            this.d.TabIndex = 37;
            this.d.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.d_ItemCheck);
            // 
            // c
            // 
            this.c.CheckOnClick = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.c.FormattingEnabled = true;
            this.c.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.c.Location = new System.Drawing.Point(278, 37);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(19, 264);
            this.c.TabIndex = 36;
            this.c.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.c_ItemCheck);
            // 
            // comment1
            // 
            this.comment1.AutoSize = true;
            this.comment1.Location = new System.Drawing.Point(280, 318);
            this.comment1.Name = "comment1";
            this.comment1.Size = new System.Drawing.Size(103, 13);
            this.comment1.TabIndex = 35;
            this.comment1.Text = "for draw leave blank";
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(410, 318);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(198, 48);
            this.results.TabIndex = 34;
            this.results.Text = "End and Enter Results";
            this.results.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(31, 318);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(84, 48);
            this.submit.TabIndex = 33;
            this.submit.Text = "SAVE";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(333, 34);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.error);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.ListBox numbers;
        private System.Windows.Forms.ListBox home;
        private System.Windows.Forms.ListBox host;
        private System.Windows.Forms.ListBox dashes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button results;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label comment1;
        private System.Windows.Forms.CheckedListBox d;
        private System.Windows.Forms.CheckedListBox c;
    }
}

