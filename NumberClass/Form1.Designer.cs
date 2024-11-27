namespace NumberClass
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
            this.NumberList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LabelName1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelNum = new System.Windows.Forms.Label();
            this.LabelName0 = new System.Windows.Forms.Label();
            this.FilterBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.FilterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberList
            // 
            this.NumberList.FormattingEnabled = true;
            this.NumberList.Location = new System.Drawing.Point(31, 93);
            this.NumberList.Name = "NumberList";
            this.NumberList.Size = new System.Drawing.Size(408, 212);
            this.NumberList.Sorted = true;
            this.NumberList.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 3;
            // 
            // LabelName1
            // 
            this.LabelName1.AutoSize = true;
            this.LabelName1.Location = new System.Drawing.Point(208, 15);
            this.LabelName1.Name = "LabelName1";
            this.LabelName1.Size = new System.Drawing.Size(56, 13);
            this.LabelName1.TabIndex = 4;
            this.LabelName1.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "list";
            // 
            // LabelNum
            // 
            this.LabelNum.AutoSize = true;
            this.LabelNum.Location = new System.Drawing.Point(12, 39);
            this.LabelNum.Name = "LabelNum";
            this.LabelNum.Size = new System.Drawing.Size(44, 13);
            this.LabelNum.TabIndex = 6;
            this.LabelNum.Text = "Number";
            // 
            // LabelName0
            // 
            this.LabelName0.AutoSize = true;
            this.LabelName0.Location = new System.Drawing.Point(9, 15);
            this.LabelName0.Name = "LabelName0";
            this.LabelName0.Size = new System.Drawing.Size(55, 13);
            this.LabelName0.TabIndex = 7;
            this.LabelName0.Text = "First name";
            // 
            // FilterBox
            // 
            this.FilterBox.Controls.Add(this.radioButton2);
            this.FilterBox.Controls.Add(this.radioButton1);
            this.FilterBox.Location = new System.Drawing.Point(445, 15);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(82, 278);
            this.FilterBox.TabIndex = 8;
            this.FilterBox.TabStop = false;
            this.FilterBox.Text = "Filter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Last name";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "First name";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.LabelName0);
            this.Controls.Add(this.LabelNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelName1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NumberList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FilterBox.ResumeLayout(false);
            this.FilterBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NumberList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LabelName1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelNum;
        private System.Windows.Forms.Label LabelName0;
        private System.Windows.Forms.GroupBox FilterBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

