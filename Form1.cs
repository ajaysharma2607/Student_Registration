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

namespace Student_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = LAPTOP-1F3RIS2D\\SQLEXPRESS; Initial Catalog = gcbd");
        SqlCommand cmd;
        SqlDataReader read;
        string id;
        bool mode = true;
        string sql;





        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string course = txtCourse.Text;
            string fee = txtFee.Text;   

            if(mode == true)
            {
                sql = "insert into student(Stname,Course,Fee) values(@Stname,@Course,@Fee)";
                con.Open();
                cmd = new SqlCommand(sql, con); 
                cmd.Parameters.AddWithValue("@Stname", name);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.Parameters.AddWithValue("@Fee", fee);
                MessageBox.Show("Recorded Addeddd");
                cmd.ExecuteNonQuery(); 
                
                txtName.Clear();
                txtCourse.Clear();
                txtFee.Clear();
                txtName.Focus();


            }
            else
            {

            }
            con.Close();    

        }
    }
}
