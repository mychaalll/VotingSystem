namespace WindowsFormsApp1
{
	partial class AddCandidate
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.positioncomboBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.agecomboBox = new System.Windows.Forms.ComboBox();
			this.femaleradioButton = new System.Windows.Forms.RadioButton();
			this.maleradioButton = new System.Windows.Forms.RadioButton();
			this.fntextBox = new System.Windows.Forms.TextBox();
			this.lntextBox = new System.Windows.Forms.TextBox();
			this.idtextBox = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.positioncomboBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.agecomboBox);
			this.groupBox1.Controls.Add(this.femaleradioButton);
			this.groupBox1.Controls.Add(this.maleradioButton);
			this.groupBox1.Controls.Add(this.fntextBox);
			this.groupBox1.Controls.Add(this.lntextBox);
			this.groupBox1.Controls.Add(this.idtextBox);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(14, 13);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.groupBox1.Size = new System.Drawing.Size(531, 466);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Candidates here";
			// 
			// positioncomboBox
			// 
			this.positioncomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.positioncomboBox.FormattingEnabled = true;
			this.positioncomboBox.Items.AddRange(new object[] {
            "President",
            "Vice President",
            "Secretary",
            "Treasurer",
            "Auditor",
            "PIO"});
			this.positioncomboBox.Location = new System.Drawing.Point(203, 343);
			this.positioncomboBox.Name = "positioncomboBox";
			this.positioncomboBox.Size = new System.Drawing.Size(284, 26);
			this.positioncomboBox.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(57, 346);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 18);
			this.label6.TabIndex = 13;
			this.label6.Text = "Position:";
			// 
			// agecomboBox
			// 
			this.agecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.agecomboBox.FormattingEnabled = true;
			this.agecomboBox.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
			this.agecomboBox.Location = new System.Drawing.Point(203, 204);
			this.agecomboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.agecomboBox.Name = "agecomboBox";
			this.agecomboBox.Size = new System.Drawing.Size(284, 26);
			this.agecomboBox.TabIndex = 12;
			// 
			// femaleradioButton
			// 
			this.femaleradioButton.AutoSize = true;
			this.femaleradioButton.Location = new System.Drawing.Point(203, 296);
			this.femaleradioButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.femaleradioButton.Name = "femaleradioButton";
			this.femaleradioButton.Size = new System.Drawing.Size(85, 22);
			this.femaleradioButton.TabIndex = 11;
			this.femaleradioButton.TabStop = true;
			this.femaleradioButton.Text = "Female";
			this.femaleradioButton.UseVisualStyleBackColor = true;
			this.femaleradioButton.CheckedChanged += new System.EventHandler(this.femaleradioButton_CheckedChanged);
			// 
			// maleradioButton
			// 
			this.maleradioButton.AutoSize = true;
			this.maleradioButton.Location = new System.Drawing.Point(203, 258);
			this.maleradioButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.maleradioButton.Name = "maleradioButton";
			this.maleradioButton.Size = new System.Drawing.Size(64, 22);
			this.maleradioButton.TabIndex = 10;
			this.maleradioButton.TabStop = true;
			this.maleradioButton.Text = "Male";
			this.maleradioButton.UseVisualStyleBackColor = true;
			this.maleradioButton.CheckedChanged += new System.EventHandler(this.maleradioButton_CheckedChanged);
			// 
			// fntextBox
			// 
			this.fntextBox.Location = new System.Drawing.Point(203, 154);
			this.fntextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.fntextBox.Name = "fntextBox";
			this.fntextBox.Size = new System.Drawing.Size(284, 27);
			this.fntextBox.TabIndex = 9;
			// 
			// lntextBox
			// 
			this.lntextBox.Location = new System.Drawing.Point(203, 104);
			this.lntextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.lntextBox.Name = "lntextBox";
			this.lntextBox.Size = new System.Drawing.Size(284, 27);
			this.lntextBox.TabIndex = 8;
			// 
			// idtextBox
			// 
			this.idtextBox.Location = new System.Drawing.Point(203, 54);
			this.idtextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.idtextBox.Name = "idtextBox";
			this.idtextBox.Size = new System.Drawing.Size(284, 27);
			this.idtextBox.TabIndex = 7;
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(380, 403);
			this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 44);
			this.button2.TabIndex = 6;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(259, 403);
			this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 44);
			this.button1.TabIndex = 5;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(65, 258);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Gender:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(92, 207);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Age:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 158);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "First Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 108);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 58);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Number:";
			// 
			// AddCandidate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(560, 492);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "AddCandidate";
			this.Text = "AddCandidate";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox agecomboBox;
		private System.Windows.Forms.RadioButton femaleradioButton;
		private System.Windows.Forms.RadioButton maleradioButton;
		private System.Windows.Forms.TextBox fntextBox;
		private System.Windows.Forms.TextBox lntextBox;
		private System.Windows.Forms.TextBox idtextBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox positioncomboBox;
		private System.Windows.Forms.Label label6;
	}
}