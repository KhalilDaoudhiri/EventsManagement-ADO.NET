using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PROJET
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            IDTxt.Text = row.Cells[0].Value.ToString();
            NomTxt.Text = row.Cells[1].Value.ToString();
            PrenomTxt.Text = row.Cells[2].Value.ToString();
            TelTxt.Text = row.Cells[3].Value.ToString();
            EmailTxt.Text = row.Cells[4].Value.ToString();
            AdresseTxt.Text = row.Cells[5].Value.ToString();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Server=. ; database=ProjetEventManagement ; Integrated Security=true; trustServerCertificate=true";

            //string connectionString = "Data Source=DESKTOP-IGTFCPP\\SQLEXPRESS;Initial Catalog=exprepa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Clients", cnx);
                    SqlDataAdapter dp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dp.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Server=. ; database=ProjetEventManagement ; Integrated Security=true; trustServerCertificate=true";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete Clients where ID_C=@ID_C", conn);
                    cmd.Parameters.AddWithValue("@ID_C", int.Parse(IDTxt.Text));
                    int v = cmd.ExecuteNonQuery();
                    MessageBox.Show($"{v}rows affected,Done!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Server=. ; database=ProjetEventManagement ; Integrated Security=true; trustServerCertificate=true";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Corrected SQL command with missing closing parenthesis
                    SqlCommand cmd = new SqlCommand("INSERT INTO Clients (Nom_C, Prenom_C,Tel_C,Email_C,Adresse_C) VALUES ( @Nom_C, @Prenom_C,@Tel_C,@Email_C,@Adresse_C)", conn);
                    //cmd.Parameters.AddWithValue("@ID_C", int.Parse(IDTxt.Text));
                    cmd.Parameters.AddWithValue("@Nom_C", NomTxt.Text);
                    cmd.Parameters.AddWithValue("@Prenom_C", PrenomTxt.Text);
                    cmd.Parameters.AddWithValue("@Tel_C", TelTxt.Text);
                    cmd.Parameters.AddWithValue("@Email_C", EmailTxt.Text);
                    cmd.Parameters.AddWithValue("@Adresse_C", AdresseTxt.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Process the result if needed
                    Console.WriteLine($"{rowsAffected} rows affected.");
                    MessageBox.Show("Added successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void TelTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Server=. ; database=ProjetEventManagement ; Integrated Security=true; trustServerCertificate=true";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update Clients set Nom_C=@Nom_C,Prenom_C=@Prenom_C,Tel_C=@Tel_C,Email_C=@Email_C,Adresse_C=Adresse_C where ID_C=@ID_C", conn);
                    cmd.Parameters.AddWithValue("@ID_C", int.Parse(IDTxt.Text));
                    cmd.Parameters.AddWithValue("@Nom_C", NomTxt.Text);
                    cmd.Parameters.AddWithValue("@Prenom_C", PrenomTxt.Text);
                    cmd.Parameters.AddWithValue("@Tel_C", TelTxt.Text);
                    cmd.Parameters.AddWithValue("@Email_C", EmailTxt.Text);
                    cmd.Parameters.AddWithValue("@Adresse_C", AdresseTxt.Text);
                    int v = cmd.ExecuteNonQuery();

                    MessageBox.Show($"{v}rows affected,Done!");
                    conn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
