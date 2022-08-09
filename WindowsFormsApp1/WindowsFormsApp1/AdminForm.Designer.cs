namespace WindowsFormsApp1
{
	partial class AdminForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.addcandidbutton = new System.Windows.Forms.Button();
			this.viewbutton = new System.Windows.Forms.Button();
			this.resetbutton = new System.Windows.Forms.Button();
			this.adduserbutton = new System.Windows.Forms.Button();
			this.exitbutton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.addcandidbutton);
			this.groupBox1.Controls.Add(this.viewbutton);
			this.groupBox1.Controls.Add(this.resetbutton);
			this.groupBox1.Controls.Add(this.adduserbutton);
			this.groupBox1.Controls.Add(this.exitbutton);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(17, 46);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(255, 295);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select an Operation";
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(26, 108);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(202, 40);
			this.button1.TabIndex = 6;
			this.button1.Text = "View Students";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// addcandidbutton
			// 
			this.addcandidbutton.ForeColor = System.Drawing.Color.Black;
			this.addcandidbutton.Location = new System.Drawing.Point(26, 65);
			this.addcandidbutton.Name = "addcandidbutton";
			this.addcandidbutton.Size = new System.Drawing.Size(201, 37);
			this.addcandidbutton.TabIndex = 5;
			this.addcandidbutton.Text = "Add a Candidate";
			this.addcandidbutton.UseVisualStyleBackColor = true;
			this.addcandidbutton.Click += new System.EventHandler(this.addcandidbutton_Click);
			// 
			// viewbutton
			// 
			this.viewbutton.ForeColor = System.Drawing.Color.Black;
			this.viewbutton.Location = new System.Drawing.Point(25, 154);
			this.viewbutton.Name = "viewbutton";
			this.viewbutton.Size = new System.Drawing.Size(202, 40);
			this.viewbutton.TabIndex = 4;
			this.viewbutton.Text = "View Vote Standings";
			this.viewbutton.UseVisualStyleBackColor = true;
			this.viewbutton.Click += new System.EventHandler(this.button5_Click);
			// 
			// resetbutton
			// 
			this.resetbutton.ForeColor = System.Drawing.Color.Black;
			this.resetbutton.Location = new System.Drawing.Point(26, 200);
			this.resetbutton.Name = "resetbutton";
			this.resetbutton.Size = new System.Drawing.Size(201, 41);
			this.resetbutton.TabIndex = 3;
			this.resetbutton.Text = "Reset Vote Count";
			this.resetbutton.UseVisualStyleBackColor = true;
			this.resetbutton.Click += new System.EventHandler(this.button4_Click);
			// 
			// adduserbutton
			// 
			this.adduserbutton.ForeColor = System.Drawing.Color.Black;
			this.adduserbutton.Location = new System.Drawing.Point(26, 22);
			this.adduserbutton.Name = "adduserbutton";
			this.adduserbutton.Size = new System.Drawing.Size(201, 37);
			this.adduserbutton.TabIndex = 2;
			this.adduserbutton.Text = "Add a User";
			this.adduserbutton.UseVisualStyleBackColor = true;
			this.adduserbutton.Click += new System.EventHandler(this.button3_Click);
			// 
			// exitbutton
			// 
			this.exitbutton.ForeColor = System.Drawing.Color.Black;
			this.exitbutton.Location = new System.Drawing.Point(25, 247);
			this.exitbutton.Name = "exitbutton";
			this.exitbutton.Size = new System.Drawing.Size(201, 36);
			this.exitbutton.TabIndex = 0;
			this.exitbutton.Text = "Exit";
			this.exitbutton.UseVisualStyleBackColor = true;
			this.exitbutton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Welcome User!";
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(293, 350);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button viewbutton;
		private System.Windows.Forms.Button resetbutton;
		private System.Windows.Forms.Button adduserbutton;
		private System.Windows.Forms.Button exitbutton;
		private System.Windows.Forms.Button addcandidbutton;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}