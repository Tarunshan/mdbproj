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

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadRecord();
            LoadTransfer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=think\\sqlexpress;Initial Catalog=database3;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[donor_details]
           ([ID]
           ,[Firstname]
           ,[Lastname]
           ,[Bloodgroup]
           ,[Phone])
     VALUES
           ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedItem + "','" + textBox5.Text + "')", con);
            SqlCommand cmd1 = new SqlCommand("update blood_aval set Avaliable=Avaliable+1 where Blood_group='" + comboBox1.SelectedItem + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successfully");
            LoadRecord();
            LoadTransfer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void LoadRecord()
        {
            SqlConnection con = new SqlConnection("Data Source=think\\sqlexpress;Initial Catalog=database3;Integrated Security=True");
            SqlCommand comm = new SqlCommand("select * from donor_details", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=think\\sqlexpress;Initial Catalog=database3;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"update [dbo].[donor_details] set firstname='" + textBox2.Text + "',lastname='" + textBox3.Text + "',bloodgroup='" + comboBox1.SelectedItem + "',phone='" + textBox5.Text + "' where id='" + textBox1.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            LoadRecord();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=think\\sqlexpress;Initial Catalog=database3;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"delete [dbo].[donor_details] where id='" + textBox1.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
            LoadRecord();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        void LoadTransfer()
        {
            SqlConnection con = new SqlConnection("Data Source=think\\sqlexpress;Initial Catalog=database3;Integrated Security=True");
            SqlCommand comm = new SqlCommand("select * from blood_aval", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=think\\sqlexpress;Initial Catalog=database3;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"update blood_aval set Avaliable=Avaliable-1 where blood_group='" + comboBox2.SelectedItem + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            LoadTransfer();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}