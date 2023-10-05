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

namespace Exam_Recording_System
{
    public partial class FrmStudentDetail : Form
    {
        public FrmStudentDetail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string number;


        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-BALF27M\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");

        private void FrmStudentDetail_Load(object sender, EventArgs e)
        {
            LBLNUMBER.Text = number;

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBL_LESSON where STDNO=@p1", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", number);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                LBLNAMESURNAME.Text = reader[2].ToString() + " " + reader[3].ToString();
                LBLEXAM1.Text = reader[4].ToString();
                LBLEXAM2.Text = reader[5].ToString();
                LBLEXAM3.Text = reader[6].ToString();
                LBLAVERAGE.Text = reader[7].ToString();
                LBLSITUATION.Text = reader[8].ToString();
            }
            sqlConnection.Close();
        }
    }
}
