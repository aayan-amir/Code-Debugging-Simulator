using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Code_Debugging
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            LoadLeaderboard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {
            Form5 myForm = new Form5();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void cyberButton2_Click_1(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void cyberButton2_Click_2(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void cyberButton3_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            Form5 myForm = new Form5();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void LoadLeaderboard()
        {
            try
            {
                string connectionString = "server=localhost;user=root;password=;database=codes;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT username AS 'Username', score AS 'Score' FROM high_scores ORDER BY score DESC LIMIT 10";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewScores.DataSource = table;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading high scores:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
