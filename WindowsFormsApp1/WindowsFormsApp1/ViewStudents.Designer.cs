namespace WindowsFormsApp1
{
	partial class ViewStudents
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
			this.studentlistView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.addstudentbutton = new System.Windows.Forms.Button();
			this.removebutton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.removebutton);
			this.groupBox1.Controls.Add(this.addstudentbutton);
			this.groupBox1.Controls.Add(this.studentlistView);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(20, 9);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(501, 375);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Students List";
			// 
			// studentlistView
			// 
			this.studentlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.studentlistView.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentlistView.FullRowSelect = true;
			this.studentlistView.GridLines = true;
			this.studentlistView.Location = new System.Drawing.Point(22, 25);
			this.studentlistView.Name = "studentlistView";
			this.studentlistView.Size = new System.Drawing.Size(447, 287);
			this.studentlistView.TabIndex = 0;
			this.studentlistView.UseCompatibleStateImageBehavior = false;
			this.studentlistView.View = System.Windows.Forms.View.Details;
			this.studentlistView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Student Number";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Last Name";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "First Name";
			this.columnHeader3.Width = 120;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Age";
			this.columnHeader4.Width = 40;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Gender";
			this.columnHeader5.Width = 80;
			// 
			// addstudentbutton
			// 
			this.addstudentbutton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addstudentbutton.ForeColor = System.Drawing.Color.Black;
			this.addstudentbutton.Location = new System.Drawing.Point(22, 318);
			this.addstudentbutton.Name = "addstudentbutton";
			this.addstudentbutton.Size = new System.Drawing.Size(153, 36);
			this.addstudentbutton.TabIndex = 2;
			this.addstudentbutton.Text = "Add a Student";
			this.addstudentbutton.UseVisualStyleBackColor = true;
			this.addstudentbutton.Click += new System.EventHandler(this.addstudentbutton_Click);
			// 
			// removebutton
			// 
			this.removebutton.Enabled = false;
			this.removebutton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removebutton.ForeColor = System.Drawing.Color.Black;
			this.removebutton.Location = new System.Drawing.Point(170, 318);
			this.removebutton.Name = "removebutton";
			this.removebutton.Size = new System.Drawing.Size(146, 36);
			this.removebutton.TabIndex = 3;
			this.removebutton.Text = "Remove Student";
			this.removebutton.UseVisualStyleBackColor = true;
			this.removebutton.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(315, 318);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(154, 36);
			this.button2.TabIndex = 4;
			this.button2.Text = "Go Back";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ViewStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(548, 395);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "ViewStudents";
			this.Text = "ViewStudents";
			this.Load += new System.EventHandler(this.ViewStudents_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView studentlistView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button removebutton;
		private System.Windows.Forms.Button addstudentbutton;
	}
}