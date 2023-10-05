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

namespace Exam_Recording_System
{
    public partial class FrmTeacherDetail : Form
    {
        public FrmTeacherDetail()
        {
            InitializeComponent();
        }


        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-BALF27M\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");

        private void FrmTeacherDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.TBL_LESSON' table. You can move, or remove it, as needed.
            this.tBL_LESSONTableAdapter.Fill(this.studentDBDataSet.TBL_LESSON);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into TBL_LESSON(STDNO,STDNAME,STDSURNAME) values (@P1,@P2,@P3)", sqlConnection);
            cmd.Parameters.AddWithValue("@P1", MskNumber.Text);
            cmd.Parameters.AddWithValue("@P2", TxtName.Text);
            cmd.Parameters.AddWithValue("@P3", TxtSurname.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Student added to System");
            this.tBL_LESSONTableAdapter.Fill(this.studentDBDataSet.TBL_LESSON);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            MskNumber.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtName.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            TxtExam1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            TxtExam2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            TxtExam3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double average, e1,e2,e3;
            string situation;

            e1=Convert.ToDouble(TxtExam1.Text);
            e2=Convert.ToDouble(TxtExam2.Text);
            e3=Convert.ToDouble(TxtExam3.Text);

            average = (e1 + e2 + e3) / 3;
            LBLAVERAGE.Text= average.ToString();

            if (average >= 50)
            {
                situation = "True";
            }
            else
            {
                situation="False";
            }

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("update TBL_LESSON set STDE1=@P1,STDE2=@P2,STDE3=@P3,AVG=@P4,SITUATION=@P5 where STDNO=@P6", sqlConnection);
            cmd.Parameters.AddWithValue("@P1", TxtExam1.Text);
            cmd.Parameters.AddWithValue("@P2", TxtExam2.Text);
            cmd.Parameters.AddWithValue("@P3", TxtExam3.Text);
            cmd.Parameters.AddWithValue("@P4", decimal.Parse(LBLAVERAGE.Text));
            cmd.Parameters.AddWithValue("@P5", situation);
            cmd.Parameters.AddWithValue("@P6", MskNumber.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Student Exams Updated");
            this.tBL_LESSONTableAdapter.Fill(this.studentDBDataSet.TBL_LESSON);
        }


        private void label1_Click(object sender, EventArgs e)
        {
            LBLPASSED.Text=studentDBDataSet.TBL_LESSON.Count(x=>x.SITUATION==true).ToString();

            LBLFAILED.Text=studentDBDataSet.TBL_LESSON.Count(x=>x.SITUATION==false).ToString();

            LBLAVERAGE.Text=studentDBDataSet.TBL_LESSON.Sum(y=>y.AVG/(Convert.ToInt32(LBLPASSED.Text)+Convert.ToInt32(LBLFAILED.Text))).ToString();
        }
    }
}
