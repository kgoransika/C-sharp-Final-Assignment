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

namespace C_sharp_Final_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int month = now.Month-1;
            int year = now.Year;
            int endDate = 0;

            switch (month)
            {
                case 1: endDate = 31; break;
                case 2: endDate = 28; break;
                case 3: endDate = 31; break;
                case 4: endDate = 30; break;
                case 5: endDate = 31; break;
                case 6: endDate = 30; break;
                case 7: endDate = 31; break;
                case 8: endDate = 31; break;
                case 9: endDate = 30; break;
                case 10: endDate = 31; break;
                case 11: endDate = 30; break;
                case 12: endDate = 31; break;
                default: break;

            } 

            lblReportPeriod.Text = year.ToString() + " / " + month.ToString("00")+" / 01    -    "+ year.ToString()+" / " + month.ToString("00")+" / "+endDate.ToString();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ovinr\OneDrive\Documents\testdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string totalQtySold = "SELECT qtySold FROM Sales";
            string tot = totalQtySold[0].ToString();

            lblItemSalesCount.Text = tot;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
