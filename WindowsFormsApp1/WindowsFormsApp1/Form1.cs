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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public Form1 fm1;
		public VoteForm vf;
		SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + @"C:\Users\Mychal Esurena\Documents\PUP\1st Year\OOP\Visual Studio\WindowsFormsApp1\WindowsFormsApp1\Database00.mdf" + ";Integrated Security = True");
		private void Loginbutton_Click(object sender, EventArgs e)
		{
			try
			{
				if (usertextBox.Text != "" && passtextBox.Text != "")
				{
					if (radioButton1.Checked)
					{
						SqlDataAdapter sda = new SqlDataAdapter("select count (*) from users where username ='" + usertextBox.Text + "'and password='" + passtextBox.Text + "'", conn);
						DataTable dt = new DataTable();
						sda.Fill(dt);
						if (dt.Rows[0][0].ToString() == "1")
						{
							MessageBox.Show("Welcome " + usertextBox.Text + "!!!", "WELCOME!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
							AdminForm ad = new AdminForm();
							ad.Show();
							this.Hide();
						}
						else
							MessageBox.Show("Incorrect Credentials.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
						usertextBox.Clear();
						passtextBox.Clear();
					}
					else if(radioButton2.Checked)
					{
						SqlDataAdapter sda = new SqlDataAdapter("select count (*) from students where lastname ='" + usertextBox.Text + "'and Id='" + passtextBox.Text + "'", conn);
					//	SqlCommand cmd = new SqlCommand("select Id,lastname,firstname,age,gender from students", conn);
						DataTable dt = new DataTable();
						sda.Fill(dt);
						if (dt.Rows[0][0].ToString() == "1")
						{
							conn.Open();
							MessageBox.Show("Welcome " + usertextBox.Text + "!!!", "WELCOME!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
							VoteForm vf = new VoteForm();
							vf.Show();
							int i = Convert.ToInt32(passtextBox.Text);
							try
							{
								SqlCommand cmd1 = new SqlCommand("select Id,lastname,firstname,age,gender from students where Id='"+ Convert.ToInt32(passtextBox.Text) + "'", conn);

								SqlDataReader rd = cmd1.ExecuteReader();
								while (rd.Read())
								{
									vf.lnlabel.Text = rd.GetString(1).ToString();
									vf.fnlabel.Text = rd.GetString(2).ToString();
									vf.idlabel.Text = rd.GetInt32(0).ToString();
									vf.genderlabel.Text = rd.GetString(4).ToString();
									vf.agelabel.Text = rd.GetInt32(3).ToString();
								}
								rd.Close();
								rd.Dispose();
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
								Application.ExitThread();
							}
							this.Hide();
							conn.Close();
						}
						else
							MessageBox.Show("Incorrect Credentials.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
						usertextBox.Clear();
						passtextBox.Clear();
					}
					else 
						MessageBox.Show("Please choose a radiobutton.","ADMIN OR STUDENT?",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
				}
				else
						MessageBox.Show("Incomplete Input.", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
		}

		private void Exitbutton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
