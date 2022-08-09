using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	public partial class AddStudent : Form
	{
		public AddStudent()
		{
			InitializeComponent();
		}
		SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + @"C:\Users\Mychal Esurena\Documents\PUP\1st Year\OOP\Visual Studio\WindowsFormsApp1\WindowsFormsApp1\Database00.mdf" + ";Integrated Security = True");
		string gender = "";
		private void button1_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO students(Id,lastname,firstname,age,gender) VALUES (@Id,@lastname,@firstname,@age,@gender)", conn);
			int idnum; 
			if (int.TryParse(idtextBox.Text, out idnum))
			{
				if (fntextBox.Text != "" && lntextBox.Text != "" && agecomboBox.SelectedIndex != -1 && gender !="")
				{
					cmd.Parameters.Add("@Id", idtextBox.Text);
					cmd.Parameters.Add("@lastname", lntextBox.Text);
					cmd.Parameters.Add("@firstname", fntextBox.Text);
					cmd.Parameters.Add("@age", agecomboBox.SelectedItem);
					cmd.Parameters.Add("@gender", gender);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Added Successfully.");
					AdminForm af = new AdminForm();
					af.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Incomplete Data. Please fill up all necessary details.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Invalid input in ID Number or Age.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			}
			conn.Close();
		}

		private void maleradioButton_CheckedChanged(object sender, EventArgs e)
		{
			gender = "Male";
		}

		private void femaleradioButton_CheckedChanged(object sender, EventArgs e)
		{
			gender = "Female";
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
			idtextBox.Focus();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
