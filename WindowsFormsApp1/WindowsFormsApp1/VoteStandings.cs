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
	public partial class VoteStandings : Form
	{
		public VoteStandings()
		{
			InitializeComponent();
		}
		SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + @"C:\Users\Mychal Esurena\Documents\PUP\1st Year\OOP\Visual Studio\WindowsFormsApp1\WindowsFormsApp1\Database00.mdf" + ";Integrated Security = True");
		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void VoteStandings_Load(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				PopulatePres();
				PopulateVPres();
				PopulateSecretary();
				PopulateTreasurer();
				PopulateAuditor();
				PopulatePIO();
				conn.Close();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
		}
		private void PopulatePres()
		{
			listView1.Items.Clear();
			SqlCommand cmd = new SqlCommand("select lastname,votecount from president ORDER BY votecount Desc", conn);
			try
			{
				SqlDataReader rd = cmd.ExecuteReader();
				while (rd.Read())
				{
					ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
					lv.SubItems.Add(rd.GetInt32(1).ToString());
					listView1.Items.Add(lv);
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
		private void PopulateVPres()
		{
			listView2.Items.Clear();
			SqlCommand cmd = new SqlCommand("select lastname,votecount from vpresident ORDER BY votecount Desc", conn);
			try
			{
				SqlDataReader rd = cmd.ExecuteReader();
				while (rd.Read())
				{
					ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
					lv.SubItems.Add(rd.GetInt32(1).ToString());
					listView2.Items.Add(lv);
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
		private void PopulateSecretary()
		{
			listView3.Items.Clear();
			SqlCommand cmd = new SqlCommand("select lastname,votecount from secretary ORDER BY votecount Desc", conn);
			try
			{
				SqlDataReader rd = cmd.ExecuteReader();
				while (rd.Read())
				{
					ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
					lv.SubItems.Add(rd.GetInt32(1).ToString());
					listView3.Items.Add(lv);
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
		private void PopulateTreasurer()
		{
			listView4.Items.Clear();
			SqlCommand cmd = new SqlCommand("select lastname,votecount from treasurer ORDER BY votecount Desc", conn);
			try
			{
				SqlDataReader rd = cmd.ExecuteReader();
				while (rd.Read())
				{
					ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
					lv.SubItems.Add(rd.GetInt32(1).ToString());
					listView4.Items.Add(lv);
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
		private void PopulateAuditor()
		{
			listView5.Items.Clear();
			SqlCommand cmd = new SqlCommand("select lastname,votecount from auditor ORDER BY votecount Desc", conn);
			try
			{
				SqlDataReader rd = cmd.ExecuteReader();
				while (rd.Read())
				{
					ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
					lv.SubItems.Add(rd.GetInt32(1).ToString());
					listView5.Items.Add(lv);
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
		private void PopulatePIO()
		{
			listView6.Items.Clear();
			SqlCommand cmd = new SqlCommand("select lastname,votecount from pio ORDER BY votecount Desc", conn);
			try
			{
				SqlDataReader rd = cmd.ExecuteReader();
				while (rd.Read())
				{
					ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
					lv.SubItems.Add(rd.GetInt32(1).ToString());
					listView6.Items.Add(lv);
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

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
