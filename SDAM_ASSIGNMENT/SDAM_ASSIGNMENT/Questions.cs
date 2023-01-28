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
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
            GetSubjects();
            DisplayQuestions();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VGI4HKR;Initial Catalog=SDAM_ASSIGNMENT;Integrated Security=True");

        private void GetSubjects()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select SName from SubjectTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(rdr);
            SubjectCb.ValueMember = "SName";
            SubjectCb.DataSource = dt;
            Con.Close();
        }

        private void Reset()
        {
            QuestTb.Text = "";
            Op1Tb.Text = "";
            Op2Tb.Text = "";
            Op3Tb.Text = "";
            Op4Tb.Text = "";
            AnswerTb.Text = "";
            SubjectCb.SelectedIndex = 0;

        }

        private void DisplayQuestions()
        {
            Con.Open();
            String Query = "select * from QuestionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into QuestionTbl (QDesc,Q01,Q02,Q03,Q04,QA,QS) values (@Qd,@01,@02,@03,@04,@Qan,@Qsu)", Con);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@01", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@02", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@03", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@04", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Saved");
                    Con.Close();

                    Reset();
                    DisplayQuestions();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Questions_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Hide();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int Key;
        private void QuestionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QuestTb.Text = QuestionsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Op1Tb.Text = QuestionsDGV.SelectedRows[0].Cells[2].Value.ToString();
            Op2Tb.Text = QuestionsDGV.SelectedRows[0].Cells[3].Value.ToString();
            Op3Tb.Text = QuestionsDGV.SelectedRows[0].Cells[4].Value.ToString();
            Op4Tb.Text = QuestionsDGV.SelectedRows[0].Cells[5].Value.ToString();
            AnswerTb.Text = QuestionsDGV.SelectedRows[0].Cells[6].Value.ToString();
            SubjectCb.SelectedValue = QuestionsDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (QuestTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(QuestionsDGV.SelectedRows[0].Cells[1].Value.ToString());
            }
        }
    }
}
