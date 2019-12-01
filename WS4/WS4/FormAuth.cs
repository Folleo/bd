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

namespace WS4
{
    public partial class FormAuth : Form
    {
        public bool IsAuth = false;
        public string con = "Data Source=LAPTOP-M31KA9FP;Initial Catalog = BD; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public FormAuth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                string command = "select * from users where login = @login and password = @password";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@login", login);
                    sqlCommand.Parameters.AddWithValue("@password", password);


                    SqlDataReader result = sqlCommand.ExecuteReader();
                    if (result.HasRows)
                    {
                        IsAuth = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login or password are incorrect");
                    }
                }                
            }
           

        }
    }
}
