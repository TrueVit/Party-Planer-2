namespace Party_Planer_2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.costDinnerPartyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.healthyOptionCheckbox = new System.Windows.Forms.CheckBox();
            this.fancyDecorationsDinnerChekbox = new System.Windows.Forms.CheckBox();
            this.numberOfPeopleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.cakeWritingTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.costBirthdayPartyLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fancyDecorationBirthdayChekbox = new System.Windows.Forms.CheckBox();
            this.numberOfPeopleOnBirthday = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleOnBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(211, 195);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.costDinnerPartyLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.healthyOptionCheckbox);
            this.tabPage1.Controls.Add(this.fancyDecorationsDinnerChekbox);
            this.tabPage1.Controls.Add(this.numberOfPeopleNumericUpDown);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(203, 169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // costDinnerPartyLabel
            // 
            this.costDinnerPartyLabel.AutoSize = true;
            this.costDinnerPartyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costDinnerPartyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costDinnerPartyLabel.Location = new System.Drawing.Point(58, 133);
            this.costDinnerPartyLabel.Name = "costDinnerPartyLabel";
            this.costDinnerPartyLabel.Size = new System.Drawing.Size(76, 22);
            this.costDinnerPartyLabel.TabIndex = 5;
            this.costDinnerPartyLabel.Text = "$425.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // healthyOptionCheckbox
            // 
            this.healthyOptionCheckbox.AutoSize = true;
            this.healthyOptionCheckbox.Location = new System.Drawing.Point(11, 83);
            this.healthyOptionCheckbox.Name = "healthyOptionCheckbox";
            this.healthyOptionCheckbox.Size = new System.Drawing.Size(96, 17);
            this.healthyOptionCheckbox.TabIndex = 3;
            this.healthyOptionCheckbox.Text = "Healthy Option";
            this.healthyOptionCheckbox.UseVisualStyleBackColor = true;
            this.healthyOptionCheckbox.CheckedChanged += new System.EventHandler(this.healthyOptionCheckbox_CheckedChanged);
            // 
            // fancyDecorationsDinnerChekbox
            // 
            this.fancyDecorationsDinnerChekbox.AutoSize = true;
            this.fancyDecorationsDinnerChekbox.Checked = true;
            this.fancyDecorationsDinnerChekbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDecorationsDinnerChekbox.Location = new System.Drawing.Point(11, 59);
            this.fancyDecorationsDinnerChekbox.Name = "fancyDecorationsDinnerChekbox";
            this.fancyDecorationsDinnerChekbox.Size = new System.Drawing.Size(115, 17);
            this.fancyDecorationsDinnerChekbox.TabIndex = 2;
            this.fancyDecorationsDinnerChekbox.Text = "Fancy Decorations";
            this.fancyDecorationsDinnerChekbox.UseVisualStyleBackColor = true;
            this.fancyDecorationsDinnerChekbox.CheckedChanged += new System.EventHandler(this.fancyDecorationsDinnerChekbox_CheckedChanged);
            // 
            // numberOfPeopleNumericUpDown
            // 
            this.numberOfPeopleNumericUpDown.Location = new System.Drawing.Point(11, 20);
            this.numberOfPeopleNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberOfPeopleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeopleNumericUpDown.Name = "numberOfPeopleNumericUpDown";
            this.numberOfPeopleNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numberOfPeopleNumericUpDown.TabIndex = 1;
            this.numberOfPeopleNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfPeopleNumericUpDown.ValueChanged += new System.EventHandler(this.numberOfPeopleNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.cakeWritingTextBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.costBirthdayPartyLabel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.fancyDecorationBirthdayChekbox);
            this.tabPage2.Controls.Add(this.numberOfPeopleOnBirthday);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(203, 169);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.tooLongLabel.Location = new System.Drawing.Point(94, 83);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.tooLongLabel.TabIndex = 14;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // cakeWritingTextBox
            // 
            this.cakeWritingTextBox.Location = new System.Drawing.Point(10, 100);
            this.cakeWritingTextBox.Name = "cakeWritingTextBox";
            this.cakeWritingTextBox.Size = new System.Drawing.Size(185, 20);
            this.cakeWritingTextBox.TabIndex = 13;
            this.cakeWritingTextBox.Text = "Happy Birthday";
            this.cakeWritingTextBox.TextChanged += new System.EventHandler(this.cakeWritingTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = " Cake Writing";
            // 
            // costBirthdayPartyLabel
            // 
            this.costBirthdayPartyLabel.AutoSize = true;
            this.costBirthdayPartyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costBirthdayPartyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costBirthdayPartyLabel.Location = new System.Drawing.Point(58, 133);
            this.costBirthdayPartyLabel.Name = "costBirthdayPartyLabel";
            this.costBirthdayPartyLabel.Size = new System.Drawing.Size(76, 22);
            this.costBirthdayPartyLabel.TabIndex = 11;
            this.costBirthdayPartyLabel.Text = "$425.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost";
            // 
            // fancyDecorationBirthdayChekbox
            // 
            this.fancyDecorationBirthdayChekbox.AutoSize = true;
            this.fancyDecorationBirthdayChekbox.Checked = true;
            this.fancyDecorationBirthdayChekbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDecorationBirthdayChekbox.Location = new System.Drawing.Point(11, 59);
            this.fancyDecorationBirthdayChekbox.Name = "fancyDecorationBirthdayChekbox";
            this.fancyDecorationBirthdayChekbox.Size = new System.Drawing.Size(115, 17);
            this.fancyDecorationBirthdayChekbox.TabIndex = 8;
            this.fancyDecorationBirthdayChekbox.Text = "Fancy Decorations";
            this.fancyDecorationBirthdayChekbox.UseVisualStyleBackColor = true;
            this.fancyDecorationBirthdayChekbox.CheckedChanged += new System.EventHandler(this.fancyDecorationBirthday_CheckedChanged);
            // 
            // numberOfPeopleOnBirthday
            // 
            this.numberOfPeopleOnBirthday.Location = new System.Drawing.Point(11, 20);
            this.numberOfPeopleOnBirthday.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberOfPeopleOnBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeopleOnBirthday.Name = "numberOfPeopleOnBirthday";
            this.numberOfPeopleOnBirthday.Size = new System.Drawing.Size(120, 20);
            this.numberOfPeopleOnBirthday.TabIndex = 7;
            this.numberOfPeopleOnBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfPeopleOnBirthday.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number Of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 195);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Planer 2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleOnBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label costDinnerPartyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox healthyOptionCheckbox;
        private System.Windows.Forms.CheckBox fancyDecorationsDinnerChekbox;
        private System.Windows.Forms.NumericUpDown numberOfPeopleNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.TextBox cakeWritingTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label costBirthdayPartyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fancyDecorationBirthdayChekbox;
        private System.Windows.Forms.NumericUpDown numberOfPeopleOnBirthday;
        private System.Windows.Forms.Label label5;
    }
}

