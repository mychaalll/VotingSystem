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
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
		}
		SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + @"C:\Users\Mychal Esurena\Documents\PUP\1st Year\OOP\Visual Studio\WindowsFormsApp1\WindowsFormsApp1\Database00.mdf" + ";Integrated Security = True");
		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AddUser ads = new AddUser();
			ads.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			VoteStandings vs = new VoteStandings();
			vs.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			conn.Open();
			try
			{
				if(MessageBox.Show("Are you sure?","Reset Votes?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
				{
					resetpres();
					resetvpres();
					resetsec();
					resettrea();
					resetaudit();
					resetpio();
					MessageBox.Show("Reset Successfully.", "Reset Votes", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
			conn.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 fm1 = new Form1();
			fm1.Show();
			this.Hide();
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{

		}

		private void addcandidbutton_Click(object sender, EventArgs e)
		{
			AddCandidate adc = new AddCandidate();
			adc.Show();
		}
		private void resetpres()
		{
			SqlCommand cmd2 = new SqlCommand("UPDATE president SET votecount = 0 WHERE votecount > 0 ", conn);
			cmd2.ExecuteNonQuery();
		}
		private void resetvpres()
		{
			SqlCommand cmd2 = new SqlCommand("UPDATE vpresident SET votecount = 0 WHERE votecount > 0 ", conn);
			cmd2.ExecuteNonQuery();
		}
		private void resetsec()
		{
			SqlCommand cmd2 = new SqlCommand("UPDATE secretary SET votecount = 0 WHERE votecount > 0 ", conn);
			cmd2.ExecuteNonQuery();
		}
		private void resettrea()
		{
			SqlCommand cmd2 = new SqlCommand("UPDATE treasurer SET votecount = 0 WHERE votecount > 0 ", conn);
			cmd2.ExecuteNonQuery();
		}
		private void resetaudit()
		{
			SqlCommand cmd2 = new SqlCommand("UPDATE auditor SET votecount = 0 WHERE votecount > 0 ", conn);
			cmd2.ExecuteNonQuery();
		}
		private void resetpio()
		{
			SqlCommand cmd2 = new SqlCommand("UPDATE pio SET votecount = 0 WHERE votecount > 0 ", conn);
			cmd2.ExecuteNonQuery();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			ViewStudents vs = new ViewStudents();
			vs.Show();
		}
	}
}
