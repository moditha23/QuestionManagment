using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM_ASSIGNMENT
{
    public partial class Exams : Form
    {
        public Exams()
        {
            InitializeComponent();
           // multirandom();
            FetchQuestions();
            

        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VGI4HKR;Initial Catalog=SDAM_ASSIGNMENT;Integrated Security=True");

        string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;

        private int GenerateRand()
        {
            Random rd = new Random();
            int x = rd.Next(1, 4);
            int y = rd.Next(1, 4);
            int z = rd.Next(1, 4);
            MessageBox.Show(""+x+ "and" + y+"and"+z);
            return x;
        }

        /* private void Shufle()
         {
            var rnd = new Random();
        }*/

        int[] Keys = new int[10];
        private void multirandom()
        {
            HashSet<int> numbers = new HashSet<int>();
            var rnd = new Random();
            while (numbers.Count<10)
            {
                numbers.Add(rnd.Next(1, 5));

            }
            for(int i=0;i<10;i++)
            {
                Keys[i] = numbers.ElementAt(i);
            }
        }
        private void FetchQuestions()
        {
            try
            {
               // int Qnum = GenerateRand();
                multirandom();
                Con.Open();
                string Query = "select * from QuestionTbl where QId=" +Keys[0]+"";
                SqlCommand cmd = new SqlCommand(Query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q1.Text = dr["QDesc"].ToString();
                        Q101.Text = dr["Q01"].ToString();
                        Q102.Text = dr["Q02"].ToString();
                        Q103.Text = dr["Q03"].ToString();
                        Q104.Text = dr["Q04"].ToString();
                        a1 = dr["QA"].ToString();

                    }

                string Query1 = "select * from QuestionTbl where QId=" + Keys[1] + "";
                cmd = new SqlCommand(Query1, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q2.Text = dr["QDesc"].ToString();
                    Q201.Text = dr["Q01"].ToString();
                    Q202.Text = dr["Q02"].ToString();
                    Q203.Text = dr["Q03"].ToString();
                    Q204.Text = dr["Q04"].ToString();
                    a2 = dr["QA"].ToString();
                }

                string Query2 = "select * from QuestionTbl where QId=" + Keys[2] + "";
                cmd = new SqlCommand(Query2, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q3.Text = dr["QDesc"].ToString();
                    Q301.Text = dr["Q01"].ToString();
                    Q302.Text = dr["Q02"].ToString();
                    Q303.Text = dr["Q03"].ToString();
                    Q304.Text = dr["Q04"].ToString();
                    a3 = dr["QA"].ToString();
                }

                string Query3 = "select * from QuestionTbl where QId=" + Keys[3] + "";
                cmd = new SqlCommand(Query3, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q4.Text = dr["QDesc"].ToString();
                    Q401.Text = dr["Q01"].ToString();
                    Q402.Text = dr["Q02"].ToString();
                    Q403.Text = dr["Q03"].ToString();
                    Q404.Text = dr["Q04"].ToString();
                    a4 = dr["QA"].ToString();
                }

                string Query4 = "select * from QuestionTbl where QId=" + Keys[4] + "";
                cmd = new SqlCommand(Query4, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q5.Text = dr["QDesc"].ToString();
                    Q501.Text = dr["Q01"].ToString();
                    Q502.Text = dr["Q02"].ToString();
                    Q503.Text = dr["Q03"].ToString();
                    Q504.Text = dr["Q04"].ToString();
                    a5 = dr["QA"].ToString();
                }

                string Query5 = "select * from QuestionTbl where QId=" + Keys[5] + "";
                cmd = new SqlCommand(Query5, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q6.Text = dr["QDesc"].ToString();
                    Q601.Text = dr["Q01"].ToString();
                    Q602.Text = dr["Q02"].ToString();
                    Q603.Text = dr["Q03"].ToString();
                    Q604.Text = dr["Q04"].ToString();
                    a6 = dr["QA"].ToString();
                }

                string Query6 = "select * from QuestionTbl where QId=" + Keys[6] + "";
                cmd = new SqlCommand(Query6, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q7.Text = dr["QDesc"].ToString();
                    Q701.Text = dr["Q01"].ToString();
                    Q702.Text = dr["Q02"].ToString();
                    Q703.Text = dr["Q03"].ToString();
                    Q704.Text = dr["Q04"].ToString();
                    a7 = dr["QA"].ToString();
                }

                string Query7 = "select * from QuestionTbl where QId=" + Keys[7] + "";
                cmd = new SqlCommand(Query7, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q8.Text = dr["QDesc"].ToString();
                    Q801.Text = dr["Q01"].ToString();
                    Q802.Text = dr["Q02"].ToString();
                    Q803.Text = dr["Q03"].ToString();
                    Q804.Text = dr["Q04"].ToString();
                    a8 = dr["QA"].ToString();
                }

                string Query8 = "select * from QuestionTbl where QId=" + Keys[8] + "";
                cmd = new SqlCommand(Query8, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q9.Text = dr["QDesc"].ToString();
                    Q901.Text = dr["Q01"].ToString();
                    Q902.Text = dr["Q02"].ToString();
                    Q903.Text = dr["Q03"].ToString();
                    Q904.Text = dr["Q04"].ToString();
                    a9 = dr["QA"].ToString();
                }

                string Query9 = "select * from QuestionTbl where QId=" + Keys[9] + "";
                cmd = new SqlCommand(Query9, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q10.Text = dr["QDesc"].ToString();
                    Q1001.Text = dr["Q01"].ToString();
                    Q1002.Text = dr["Q02"].ToString();
                    Q1003.Text = dr["Q03"].ToString();
                    Q1004.Text = dr["Q04"].ToString();
                    a10 = dr["QA"].ToString();
                }

                Con.Close();
            }
            catch (Exception ex)
            {

            }
         }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
