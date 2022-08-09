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
	public partial class AddUser : Form
	{
		public AddUser()
		{
			InitializeComponent();
		}
		SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + @"C:\Users\Mychal Esurena\Documents\PUP\1st Year\OOP\Visual Studio\WindowsFormsApp1\WindowsFormsApp1\Database00.mdf" + ";Integrated Security = True");
		private void button1_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO users(username,password,lastname,firstname) VALUES (@username,@password,@lastname,@firstname)", conn);

			if (fntextBox.Text != "" && lntextBox.Text != "")
			{
				cmd.Parameters.Add("@firstname", fntextBox.Text);
				cmd.Parameters.Add("@lastname", lntextBox.Text);
				cmd.Parameters.Add("@username", usertextBox.Text);
				cmd.Parameters.Add("@password", passtextBox.Text);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Added Successfully.");
				AdminForm af = new AdminForm();
				af.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Incomplete Data. Please fill up all necessary details.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			}

		}

		private void cancelbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
