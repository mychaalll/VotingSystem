namespace WindowsFormsApp1
{
	partial class AddStudent
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
			this.agecomboBox = new System.Windows.Forms.ComboBox();
			this.femaleradioButton = new System.Windows.Forms.RadioButton();
			this.maleradioButton = new System.Windows.Forms.RadioButton();
			this.fntextBox = new System.Windows.Forms.TextBox();
			this.lntextBox = new System.Windows.Forms.TextBox();
			this.idtextBox = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.Addbutton = new System.Windows.Forms.Button();
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
			this.groupBox1.Controls.Add(this.agecomboBox);
			this.groupBox1.Controls.Add(this.femaleradioButton);
			this.groupBox1.Controls.Add(this.maleradioButton);
			this.groupBox1.Controls.Add(this.fntextBox);
			this.groupBox1.Controls.Add(this.lntextBox);
			this.groupBox1.Controls.Add(this.idtextBox);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.Addbutton);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(537, 423);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Students here";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
			this.agecomboBox.Location = new System.Drawing.Point(204, 207);
			this.agecomboBox.Name = "agecomboBox";
			this.agecomboBox.Size = new System.Drawing.Size(283, 26);
			this.agecomboBox.TabIndex = 12;
			// 
			// femaleradioButton
			// 
			this.femaleradioButton.AutoSize = true;
			this.femaleradioButton.Location = new System.Drawing.Point(204, 297);
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
			this.maleradioButton.Location = new System.Drawing.Point(204, 257);
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
			this.fntextBox.Location = new System.Drawing.Point(204, 159);
			this.fntextBox.Name = "fntextBox";
			this.fntextBox.Size = new System.Drawing.Size(283, 27);
			this.fntextBox.TabIndex = 9;
			// 
			// lntextBox
			// 
			this.lntextBox.Location = new System.Drawing.Point(204, 107);
			this.lntextBox.Name = "lntextBox";
			this.lntextBox.Size = new System.Drawing.Size(283, 27);
			this.lntextBox.TabIndex = 8;
			// 
			// idtextBox
			// 
			this.idtextBox.Location = new System.Drawing.Point(204, 56);
			this.idtextBox.Name = "idtextBox";
			this.idtextBox.Size = new System.Drawing.Size(283, 27);
			this.idtextBox.TabIndex = 7;
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(396, 337);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(91, 38);
			this.button2.TabIndex = 6;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Addbutton
			// 
			this.Addbutton.ForeColor = System.Drawing.Color.Black;
			this.Addbutton.Location = new System.Drawing.Point(264, 337);
			this.Addbutton.Name = "Addbutton";
			this.Addbutton.Size = new System.Drawing.Size(106, 38);
			this.Addbutton.TabIndex = 5;
			this.Addbutton.Text = "Add";
			this.Addbutton.UseVisualStyleBackColor = true;
			this.Addbutton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(51, 259);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Gender:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(78, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Age:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "First Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Number:";
			// 
			// AddStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(561, 447);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "AddStudent";
			this.Text = "AddStudent";
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
		private System.Windows.Forms.Button Addbutton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}