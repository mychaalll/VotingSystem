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
	public partial class AddCandidate : Form
	{
		public AddCandidate()
		{
			InitializeComponent();
		}
		SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + @"C:\Users\Mychal Esurena\Documents\PUP\1st Year\OOP\Visual Studio\WindowsFormsApp1\WindowsFormsApp1\Database00.mdf" + ";Integrated Security = True");
		string gender = "";
		private void button1_Click(object sender, EventArgs e)
		{
			int idnum = 0;
            if (int.TryParse(idtextBox.Text, out idnum))
			{
				if (idtextBox.Text != "" && lntextBox.Text != "" && fntextBox.Text != "" && agecomboBox.SelectedIndex != -1 && gender != "" && positioncomboBox.SelectedIndex != -1)
				{
					if(positioncomboBox.SelectedIndex == 0)
					{
						addcandidateforpresident();
						MessageBox.Show("Added Successfully.");
						AdminForm af = new AdminForm();
						af.Show();
						this.Hide();
					}
					if (positioncomboBox.SelectedIndex == 1)
					{
						addcandidateforvpresident();
						MessageBox.Show("Added Successfully.");
						AdminForm af = new AdminForm();
						af.Show();
						this.Hide();
					}
					if (positioncomboBox.SelectedIndex == 2)
					{
						addcandidateforsecretary();
						MessageBox.Show("Added Successfully.");
						AdminForm af = new AdminForm();
						af.Show();
						this.Hide();
					}
					if (positioncomboBox.SelectedIndex == 3)
					{
						addcandidatefortreasurer();
						MessageBox.Show("Added Successfully.");
						AdminForm af = new AdminForm();
						af.Show();
						this.Hide();
					}
					if (positioncomboBox.SelectedIndex == 4)
					{
						addcandidateforauditor();
						MessageBox.Show("Added Successfully.");
						AdminForm af = new AdminForm();
						af.Show();
						this.Hide();
					}
					if (positioncomboBox.SelectedIndex == 5)
					{
						addcandidateforPIO();
						MessageBox.Show("Added Successfully.");
						AdminForm af = new AdminForm();
						af.Show();
						this.Hide();
					}
				}
				else
				{
					MessageBox.Show("Incomplete Data. Please fill up all necessary details.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				}
			}
	}
		private void addcandidateforpresident()
		{
			int votecount = 0;
			conn.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO president(Id,lastname,firstname,age,gender,votecount) VALUES (@Id,@lastname,@firstname,@age,@gender,@votecount)", conn);
			cmd.Parameters.Add("@Id", idtextBox.Text);
			cmd.Parameters.Add("@lastname", lntextBox.Text);
			cmd.Parameters.Add("@firstname", fntextBox.Text);
			cmd.Parameters.Add("@age", agecomboBox.SelectedItem);
			cmd.Parameters.Add("@gender", gender);
			cmd.Parameters.Add("@votecount", votecount);
			cmd.ExecuteNonQuery();
			conn.Close();
		}
		private void addcandidateforvpresident()
		{
			int votecount = 0;
			conn.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO vpresident(Id,lastname,firstname,age,gender,votecount) VALUES (@Id,@lastname,@firstname,@age,@gender,@votecount)", conn);
			cmd.Parameters.Add("@Id", idtextBox.Text);
			cmd.Parameters.Add("@lastname", lntextBox.Text);
			cmd.Parameters.Add("@firstname", fntextBox.Text);
			cmd.Parameters.Add("@age", agecomboBox.SelectedItem);
			cmd.Parameters.Add("@gender", gender);
			cmd.Parameters.Add("@votecount", votecount);
			cmd.ExecuteNonQuery();
			conn.Close();
		}
		private void addcandidateforsecretary()
		{
			int votecount = 0;
			conn.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO secretary(Id,lastname,firstname,age,gender,votecount) VALUES (@Id,@lastname,@firstname,@age,@gender,@votecount)", conn);
			cmd.Parameters.Add("@Id", idtextBox.Text);
			cmd.Parameters.Add("@lastname", lntextBox.Text);
			cmd.Parameters.Add("@firstname", fntextBox.Text);
			cmd.Parameters.Add("@age", agecomboBox.SelectedItem);
			cmd.Parameters.Add("@gender", gender);
			cmd.Parameters.Add("@votecount", votecount);
			cmd.ExecuteNonQuery();
			conn.Close();
		}
		private void addcandidatefortreasurer()
		{
			int votecount = 0;
			conn.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO treasurer(Id,lastname,firstname,age,gender,votecount) VALUES (@Id,@lastname,@firstname,@age,@gender,@votecount)", conn);
			cmd.Parameters.Add("@Id", idtextBox.Text);
			cmd.Parameters.Add("@lastname", lntextBox.Text);
			cmd.Parameters.Add("@firstname", fntextBox.Text);
			cmd.Parameters.Add("@age", agecomboBox.SelectedItem);
			cmd.Parameters.Add("@gender", gender);
			cmd.Parameters.Add("@votecount", votecount);
			cmd.ExecuteNonQuery();
			conn.Close();
		}
		private void addcandidateforauditor()
		{
			int votecount = 0;
			conn.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO auditor(Id,lastname,firstname,age,gender,votecount) VALUES (@Id,@lastname,@firstname,@age,@gender,@votecount)", conn);
			cmd.Parameters.Add("@Id", idtextBox.Text);
			cmd.Parameters.Add("@lastname", lntextBox.Text);
			cmd.Parameters.Add("@firstname", fntextBox.Text);
			cmd.Parameters.Add("@age", agecomboBox.SelectedItem);
			cmd.Parameters.Add("@gender", gender);
			cmd.Parameters.Add("@votecount", votecount);
			cmd.ExecuteNonQuery();
			conn.Close();
		}
		private void addcandidateforPIO()
		{
			int votecount = 0;
			conn.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO pio(Id,lastname,firstname,age,gender,votecount) VALUES (@Id,@lastname,@firstname,@age,@gender,@votecount)", conn);
			cmd.Parameters.Add("@Id", idtextBox.Text);
			cmd.Parameters.Add("@lastname", lntextBox.Text);
			cmd.Parameters.Add("@firstname", fntextBox.Text);
			cmd.Parameters.Add("@age", agecomboBox.SelectedItem);
			cmd.Parameters.Add("@gender", gender);
			cmd.Parameters.Add("@votecount", votecount);
			cmd.ExecuteNonQuery();
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

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
