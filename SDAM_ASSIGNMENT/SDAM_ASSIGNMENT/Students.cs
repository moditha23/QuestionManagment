using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SDAM_ASSIGNMENT
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayCandidates();
        }
        private void Reset()
        {
            CNameTb.Text = "";
            CAgeTb.Text = "";
            PhoneTb.Text = "";
            AddressTb.Text = "";
            PasswordTb.Text = "";

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VGI4HKR;Initial Catalog=SDAM_ASSIGNMENT;Integrated Security=True");
        private void DisplayCandidates()
        {
            Con.Open();
            String Query = "select * from CandidateTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CandidatesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || CAgeTb.Text == "Age" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {

            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update CandidateTbl set CName=@Cn,CAge=@Ca,CPass=@Cp,CAdd=@Cad,CPhone=@Cph where Cid=@CKey", Con);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Cph", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");
                    Con.Close();

                    Reset();
                    DisplayCandidates();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into CandidateTbl (CName,CAge,CPass,CScore,CAdd,Cphone) values (@Cn,@Ca,@Cp,@Cs,@Cad,@Cph)", Con);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Cs", score);
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Cph", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Saved");
                    Con.Close();
                    Reset();
                    DisplayCandidates();
                   
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void CandidatesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTb.Text = CandidatesDGV.SelectedRows[0].Cells[1].Value.ToString();
            CAgeTb.Text = CandidatesDGV.SelectedRows[0].Cells[2].Value.ToString();
            PasswordTb.Text = CandidatesDGV.SelectedRows[0].Cells[3].Value.ToString();
            AddressTb.Text = CandidatesDGV.SelectedRows[0].Cells[5].Value.ToString();
            PhoneTb.Text = CandidatesDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (CNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CandidatesDGV.SelectedRows[0].Cells[1].Value.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects(); 
            Obj.Show();
            this.Hide();
        }
    }
}
