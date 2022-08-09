namespace WindowsFormsApp1
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.usertextBox = new System.Windows.Forms.TextBox();
			this.passtextBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.Exitbutton = new System.Windows.Forms.Button();
			this.Loginbutton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(80, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(512, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Shuchiin Academy Voting System";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(49, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(49, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password:";
			// 
			// usertextBox
			// 
			this.usertextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usertextBox.Location = new System.Drawing.Point(196, 43);
			this.usertextBox.Name = "usertextBox";
			this.usertextBox.Size = new System.Drawing.Size(260, 26);
			this.usertextBox.TabIndex = 3;
			// 
			// passtextBox
			// 
			this.passtextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passtextBox.Location = new System.Drawing.Point(196, 90);
			this.passtextBox.Name = "passtextBox";
			this.passtextBox.PasswordChar = '*';
			this.passtextBox.Size = new System.Drawing.Size(260, 26);
			this.passtextBox.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.Exitbutton);
			this.groupBox1.Controls.Add(this.Loginbutton);
			this.groupBox1.Controls.Add(this.usertextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.passtextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(86, 126);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(506, 219);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Log In here";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(351, 122);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(84, 22);
			this.radioButton2.TabIndex = 8;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Student";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(237, 122);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(72, 22);
			this.radioButton1.TabIndex = 7;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Admin";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// Exitbutton
			// 
			this.Exitbutton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Exitbutton.ForeColor = System.Drawing.Color.Black;
			this.Exitbutton.Location = new System.Drawing.Point(330, 167);
			this.Exitbutton.Name = "Exitbutton";
			this.Exitbutton.Size = new System.Drawing.Size(126, 36);
			this.Exitbutton.TabIndex = 6;
			this.Exitbutton.Text = "Exit";
			this.Exitbutton.UseVisualStyleBackColor = true;
			this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
			// 
			// Loginbutton
			// 
			this.Loginbutton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Loginbutton.ForeColor = System.Drawing.Color.Black;
			this.Loginbutton.Location = new System.Drawing.Point(196, 167);
			this.Loginbutton.Name = "Loginbutton";
			this.Loginbutton.Size = new System.Drawing.Size(128, 36);
			this.Loginbutton.TabIndex = 5;
			this.Loginbutton.Text = "Log In";
			this.Loginbutton.UseVisualStyleBackColor = true;
			this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(676, 378);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "LOG IN";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Exitbutton;
		public System.Windows.Forms.TextBox usertextBox;
		public System.Windows.Forms.TextBox passtextBox;
		public System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.Button Loginbutton;
		public System.Windows.Forms.RadioButton radioButton2;
		public System.Windows.Forms.RadioButton radioButton1;
	}
}

