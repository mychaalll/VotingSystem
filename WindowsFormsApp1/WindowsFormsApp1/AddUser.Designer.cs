namespace WindowsFormsApp1
{
	partial class AddUser
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lntextBox = new System.Windows.Forms.TextBox();
			this.fntextBox = new System.Windows.Forms.TextBox();
			this.usertextBox = new System.Windows.Forms.TextBox();
			this.passtextBox = new System.Windows.Forms.TextBox();
			this.addbutton = new System.Windows.Forms.Button();
			this.cancelbutton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cancelbutton);
			this.groupBox1.Controls.Add(this.addbutton);
			this.groupBox1.Controls.Add(this.passtextBox);
			this.groupBox1.Controls.Add(this.usertextBox);
			this.groupBox1.Controls.Add(this.fntextBox);
			this.groupBox1.Controls.Add(this.lntextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(17, 18);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(487, 355);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Users here";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Last Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "First Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "User Name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password:";
			// 
			// lntextBox
			// 
			this.lntextBox.Location = new System.Drawing.Point(200, 57);
			this.lntextBox.Name = "lntextBox";
			this.lntextBox.Size = new System.Drawing.Size(228, 27);
			this.lntextBox.TabIndex = 4;
			// 
			// fntextBox
			// 
			this.fntextBox.Location = new System.Drawing.Point(200, 103);
			this.fntextBox.Name = "fntextBox";
			this.fntextBox.Size = new System.Drawing.Size(228, 27);
			this.fntextBox.TabIndex = 5;
			// 
			// usertextBox
			// 
			this.usertextBox.Location = new System.Drawing.Point(200, 152);
			this.usertextBox.Name = "usertextBox";
			this.usertextBox.Size = new System.Drawing.Size(228, 27);
			this.usertextBox.TabIndex = 6;
			// 
			// passtextBox
			// 
			this.passtextBox.Location = new System.Drawing.Point(200, 200);
			this.passtextBox.Name = "passtextBox";
			this.passtextBox.Size = new System.Drawing.Size(228, 27);
			this.passtextBox.TabIndex = 7;
			// 
			// addbutton
			// 
			this.addbutton.ForeColor = System.Drawing.Color.Black;
			this.addbutton.Location = new System.Drawing.Point(200, 269);
			this.addbutton.Name = "addbutton";
			this.addbutton.Size = new System.Drawing.Size(106, 39);
			this.addbutton.TabIndex = 8;
			this.addbutton.Text = "Add";
			this.addbutton.UseVisualStyleBackColor = true;
			this.addbutton.Click += new System.EventHandler(this.button1_Click);
			// 
			// cancelbutton
			// 
			this.cancelbutton.ForeColor = System.Drawing.Color.Black;
			this.cancelbutton.Location = new System.Drawing.Point(326, 269);
			this.cancelbutton.Name = "cancelbutton";
			this.cancelbutton.Size = new System.Drawing.Size(102, 39);
			this.cancelbutton.TabIndex = 9;
			this.cancelbutton.Text = "Cancel";
			this.cancelbutton.UseVisualStyleBackColor = true;
			this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
			// 
			// AddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(530, 390);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "AddUser";
			this.Text = "AddUser";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox passtextBox;
		private System.Windows.Forms.TextBox usertextBox;
		private System.Windows.Forms.TextBox fntextBox;
		private System.Windows.Forms.TextBox lntextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cancelbutton;
		private System.Windows.Forms.Button addbutton;
	}
}