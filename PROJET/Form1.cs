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
using Microsoft.Data.SqlClient;



namespace PROJET
{
    public partial class Form1 : Form
    {

        SqlConnection cnx;


        public Form1()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnx = Program.GetConnection();

        }

        private void CheckCnBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cnx.State.ToString());
        }

        private void OpenCnBtn_Click(object sender, EventArgs e)
        {
            cnx.Open();

        }

        private void CloseCnBtn_Click(object sender, EventArgs e)
        {
            cnx.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand query = new SqlCommand("SELECT Role_U FROM Utilisateurs WHERE Username_U=@login AND Password_U=@pwd", cnx);
            query.Parameters.AddWithValue("login", UserTxt.Text);
            query.Parameters.AddWithValue("pwd", PwdTxt.Text);
            object result = query.ExecuteScalar();
            if (result == null)
            {
                MessageBox.Show("Login ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(result.ToString());
                //if (result.ToString().Equals("ADMIN"))
                //    new AdminForm().Show();
                //else
                //    new GerantForm().Show();
                //Hide();
            }
        }
    }
}
