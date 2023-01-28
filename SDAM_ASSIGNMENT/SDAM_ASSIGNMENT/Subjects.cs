using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SDAM_ASSIGNMENT
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();

        }
        int Key = 0;
        private void Reset()
        {
            SNameTb.Text = "";
            Key = 0;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VGI4HKR;Initial Catalog=SDAM_ASSIGNMENT;Integrated Security=True");

        private void DisplaySubjects()
        {
            Con.Open();
            String Query = "select * from SubjectTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SubjectsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
         
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into SubjectTbl (SName) values (@Sn)", Con);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Saved");
                    Con.Close();
                    Reset();
                    DisplaySubjects();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SubjectsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SNameTb.Text = SubjectsDGV.SelectedRows[0].Cells[1].Value.ToString();
            if (SNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SubjectsDGV.SelectedRows[0].Cells[1].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                   
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update SubjectTbl set SName=@Sn where SId=@SKey", Con);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Updated");
                    Con.Close();

                    Reset();
                    DisplaySubjects();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }
    }
}
