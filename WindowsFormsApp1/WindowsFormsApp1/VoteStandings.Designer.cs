namespace WindowsFormsApp1
{
	partial class VoteStandings
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
			this.listView6 = new System.Windows.Forms.ListView();
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listView5 = new System.Windows.Forms.ListView();
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listView4 = new System.Windows.Forms.ListView();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listView3 = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label6 = new System.Windows.Forms.Label();
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
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.listView6);
			this.groupBox1.Controls.Add(this.listView5);
			this.groupBox1.Controls.Add(this.listView4);
			this.groupBox1.Controls.Add(this.listView3);
			this.groupBox1.Controls.Add(this.listView2);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(724, 420);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Current Vote Standings";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(574, 381);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 32);
			this.button1.TabIndex = 12;
			this.button1.Text = "Go Back";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listView6
			// 
			this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
			this.listView6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView6.FullRowSelect = true;
			this.listView6.GridLines = true;
			this.listView6.Location = new System.Drawing.Point(491, 242);
			this.listView6.Name = "listView6";
			this.listView6.Size = new System.Drawing.Size(198, 133);
			this.listView6.TabIndex = 11;
			this.listView6.UseCompatibleStateImageBehavior = false;
			this.listView6.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Candidate";
			this.columnHeader11.Width = 150;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Vote";
			this.columnHeader12.Width = 40;
			// 
			// listView5
			// 
			this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
			this.listView5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView5.FullRowSelect = true;
			this.listView5.GridLines = true;
			this.listView5.Location = new System.Drawing.Point(262, 242);
			this.listView5.Name = "listView5";
			this.listView5.Size = new System.Drawing.Size(198, 133);
			this.listView5.TabIndex = 10;
			this.listView5.UseCompatibleStateImageBehavior = false;
			this.listView5.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Candidate";
			this.columnHeader9.Width = 150;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Vote";
			this.columnHeader10.Width = 40;
			// 
			// listView4
			// 
			this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
			this.listView4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView4.FullRowSelect = true;
			this.listView4.GridLines = true;
			this.listView4.Location = new System.Drawing.Point(31, 242);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(198, 133);
			this.listView4.TabIndex = 9;
			this.listView4.UseCompatibleStateImageBehavior = false;
			this.listView4.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Candidate";
			this.columnHeader7.Width = 150;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Vote";
			this.columnHeader8.Width = 40;
			// 
			// listView3
			// 
			this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
			this.listView3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView3.FullRowSelect = true;
			this.listView3.GridLines = true;
			this.listView3.Location = new System.Drawing.Point(491, 59);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(198, 133);
			this.listView3.TabIndex = 8;
			this.listView3.UseCompatibleStateImageBehavior = false;
			this.listView3.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Candidate";
			this.columnHeader5.Width = 150;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Vote";
			this.columnHeader6.Width = 40;
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this.listView2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Location = new System.Drawing.Point(262, 59);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(198, 133);
			this.listView2.TabIndex = 7;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Candidate";
			this.columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Vote";
			this.columnHeader4.Width = 40;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(31, 59);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(198, 133);
			this.listView1.TabIndex = 6;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Candidate";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Vote";
			this.columnHeader2.Width = 40;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(571, 221);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "PIO";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(327, 221);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Auditor";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(91, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Treasurer";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(554, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Secretary";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(298, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Vice President";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(89, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "President";
			// 
			// VoteStandings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(761, 444);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "VoteStandings";
			this.Text = "VoteStandings";
			this.Load += new System.EventHandler(this.VoteStandings_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView listView6;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ListView listView5;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}