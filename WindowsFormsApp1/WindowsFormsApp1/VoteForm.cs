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
	public partial class VoteForm : Form
	{
		public VoteForm()
		{
			InitializeComponent();
		}
		SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + @"C:\Users\Mychal Esurena\Documents\PUP\1st Year\OOP\Visual Studio\WindowsFormsApp1\WindowsFormsApp1\Database00.mdf" + ";Integrated Security = True");
		private void PopulatePres()
		{
			prescomboBox.Items.Clear();
			conn.Open();
			SqlCommand cmd1 = new SqlCommand("select lastname,firstname from president",conn);
			try
			{
				SqlDataReader rd = cmd1.ExecuteReader();
				while (rd.Read())
				{
					prescomboBox.Items.Add(rd.GetString(0).ToString());
				}
				rd.Close();
				rd.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}
		private void PopulateVPres()
		{
			vprescomboBox.Items.Clear();
			conn.Open();
			SqlCommand cmd1 = new SqlCommand("select lastname,firstname from vpresident", conn);
			try
			{
				SqlDataReader rd = cmd1.ExecuteReader();
				while (rd.Read())
				{
					vprescomboBox.Items.Add(rd.GetString(0).ToString());
				}
				rd.Close();
				rd.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}
		private void PopulateSecretary()
		{
			secrecomboBox.Items.Clear();
			conn.Open();
			SqlCommand cmd1 = new SqlCommand("select lastname,firstname from secretary", conn);
			try
			{
				SqlDataReader rd = cmd1.ExecuteReader();
				while (rd.Read())
				{
					secrecomboBox.Items.Add(rd.GetString(0).ToString());
				}
				rd.Close();
				rd.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}
		private void PopulateTreasurer()
		{
			treacomboBox.Items.Clear();
			conn.Open();
			SqlCommand cmd1 = new SqlCommand("select lastname,firstname from treasurer", conn);
			try
			{
				SqlDataReader rd = cmd1.ExecuteReader();
				while (rd.Read())
				{
					treacomboBox.Items.Add(rd.GetString(0).ToString());
				}
				rd.Close();
				rd.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}
		private void PopulateAuditor()
		{
			auditcomboBox.Items.Clear();
			conn.Open();
			SqlCommand cmd1 = new SqlCommand("select lastname,firstname from auditor", conn);
			try
			{
				SqlDataReader rd = cmd1.ExecuteReader();
				while (rd.Read())
				{
					auditcomboBox.Items.Add(rd.GetString(0).ToString());
				}
				rd.Close();
				rd.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}

		private void button_Click(object sender, EventArgs e)
		{
			if (prescomboBox.SelectedIndex != -1 && vprescomboBox.SelectedIndex != -1 && secrecomboBox.SelectedIndex != -1 && treacomboBox.SelectedIndex != -1 && auditcomboBox.SelectedIndex != -1 && piocomboBox.SelectedIndex != -1)
			{
				
				if (MessageBox.Show("Are you sure?", "Vote", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{

					VoteCountForPresident();
					VoteCountForVicePresident();
					VoteCountForSecretary();
					VoteCountForTreasurer();
					VoteCountForAuditor();
					VoteCountForPIO();
					MessageBox.Show("Voted Successfully. \nThank you for voting ! ^-^","Voted Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
					Form1 fm1 = new Form1();
					fm1.Show();
					this.Hide();
				}
			}
			else
			{
				MessageBox.Show("Please fill all the positions.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void PopulatePIO()
		{
			piocomboBox.Items.Clear();
			conn.Open();
			SqlCommand cmd1 = new SqlCommand("select lastname,firstname from PIO", conn);
			try
			{
				SqlDataReader rd = cmd1.ExecuteReader();
				while (rd.Read())
				{
					piocomboBox.Items.Add(rd.GetString(0).ToString());
				}
				rd.Close();
				rd.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}
		public void VoteCountForPresident()
		{
			conn.Open();
			try
			{
				SqlCommand cmd2 = new SqlCommand("UPDATE president SET votecount=votecount+1 WHERE lastname='"+prescomboBox.SelectedItem.ToString() + "'",conn);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}
		public void VoteCountForVicePresident()
		{
			conn.Open();
			try
			{
				SqlCommand cmd2 = new SqlCommand("UPDATE vpresident SET votecount=votecount+1 WHERE lastname='" + vprescomboBox.SelectedItem.ToString() + "'", conn);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}
		public void VoteCountForSecretary()
		{
			conn.Open();
			try
			{
				SqlCommand cmd2 = new SqlCommand("UPDATE secretary SET votecount=votecount+1 WHERE lastname='" + secrecomboBox.SelectedItem.ToString() + "'", conn);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}
		public void VoteCountForTreasurer()
		{
			conn.Open();
			try
			{
				SqlCommand cmd2 = new SqlCommand("UPDATE treasurer SET votecount=votecount+1 WHERE lastname='" + treacomboBox.SelectedItem.ToString() + "'", conn);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}
		public void VoteCountForAuditor()
		{
			conn.Open();
			try
			{
				SqlCommand cmd2 = new SqlCommand("UPDATE auditor SET votecount=votecount+1 WHERE lastname='" + auditcomboBox.SelectedItem.ToString() + "'", conn);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}
		public void VoteCountForPIO()
		{
			conn.Open();
			try
			{
				SqlCommand cmd2 = new SqlCommand("UPDATE pio SET votecount=votecount+1 WHERE lastname='" + piocomboBox.SelectedItem.ToString() + "'", conn);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}


		public Form1 frm1;
		private void VoteForm_Load(object sender, EventArgs e)
		{
			label12.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy  hh:mm tt");
			PopulatePres();
			PopulateVPres();
			PopulateSecretary();
			PopulateTreasurer();
			PopulateAuditor();
			PopulatePIO();
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form1 frm01 = new Form1();
			frm01.Show();
			this.Close();
		}
	}
}
