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
	public partial class ViewStudents : Form
	{
		public ViewStudents()
		{
			InitializeComponent();
		}
		SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + @"C:\Users\Mychal Esurena\Documents\PUP\1st Year\OOP\Visual Studio\WindowsFormsApp1\WindowsFormsApp1\Database00.mdf" + ";Integrated Security = True");

		private void ViewStudents_Load(object sender, EventArgs e)
		{
			conn.Open();
			Populate();
		}

		private void addstudentbutton_Click(object sender, EventArgs e)
		{
			AddStudent adds = new AddStudent();
			adds.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AdminForm af = new AdminForm();
			af.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				SqlCommand cm = new SqlCommand("DELETE FROM students WHERE Id = @Id", conn);
				cm.Parameters.AddWithValue("@Id", studentlistView.SelectedItems[0].Text);

				try
				{
					cm.ExecuteNonQuery();
					Populate();
					removebutton.Enabled = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (studentlistView.SelectedItems.Count > 0)
			{
				removebutton.Enabled = true;
			}
			else
				removebutton.Enabled = false;
		}
		private void Populate()
		{
			{
				studentlistView.Items.Clear();
				SqlCommand cmd = new SqlCommand("select Id,lastname,firstname,age,gender from students", conn);
				try
				{
					SqlDataReader rd = cmd.ExecuteReader();
					while (rd.Read())
					{
						ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
						lv.SubItems.Add(rd.GetString(1).ToString());
						lv.SubItems.Add(rd.GetString(2).ToString());
						lv.SubItems.Add(rd.GetInt32(3).ToString());
						lv.SubItems.Add(rd.GetString(4).ToString());

						studentlistView.Items.Add(lv);
					}
					rd.Close();
					rd.Dispose();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
					Application.ExitThread();
				}
			}
		}
	}
}
