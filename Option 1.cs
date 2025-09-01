using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Code_Debugging
{
    public partial class Form3 : Form
    {
        private List<string> begbug = new List<string>();
        private List<string> begsol = new List<string>();
        private int randomIndex;
        private int score = 0;

        public Form3()
        {
            InitializeComponent();
            LoadCodeFromDatabase();
        }

        private void LoadCodeFromDatabase()
        {
            try
            {
                string connectionString = "server=localhost;user=root;password=;database=codes;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT code FROM begbug ORDER BY id", conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            begbug.Add(reader.GetString(0));
                        }
                    }

                    using (MySqlCommand cmd = new MySqlCommand("SELECT code FROM begsol ORDER BY id", conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            begsol.Add(reader.GetString(0));
                        }
                    }

                    conn.Close();
                }

                if (begbug.Count != begsol.Count)
                {
                    MessageBox.Show("Bug and solution count mismatch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string CleanCode(string code)
        {
            return new string(code.Where(c => !char.IsWhiteSpace(c)).ToArray());
        }

        private void richTextBoxEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswerAndLoadNext();
            }
        }

        private void CheckAnswerAndLoadNext()
        {
            if (randomIndex < 0 || randomIndex >= begsol.Count)
            {
                MessageBox.Show("No bug selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userAnswer = CleanCode(richTextBoxEdit1.Text);
            string correctAnswer = CleanCode(begsol[randomIndex]);

            if (userAnswer == correctAnswer)
            {
                score += 10;
                MessageBox.Show("Correct! Well done.\nScore: " + score, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNextQuestion();
            }
            else
            {
                SaveScoreToDatabase(textBox1.Text, score);
                MessageBox.Show("Incorrect. Try again.\n\nCorrect Answer:\n\n" + begsol[randomIndex],
                    "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                score = 0;
                LoadNextQuestion();
            }
            
        }

        private void LoadNextQuestion()
        {
            if (begbug.Count == 0)
            {
                MessageBox.Show("No code loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random random = new Random();
            randomIndex = random.Next(begbug.Count);
            label2.Text = begbug[randomIndex];
            richTextBoxEdit1.Text = "";
            richTextBoxEdit1.Focus();
        }

        private void SaveScoreToDatabase(string username, int score)
        {
            try
            {
                string connectionString = "server=localhost;user=root;password=;database=codes;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO high_scores (username, score) VALUES (@username, @score)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving score:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            LoadNextQuestion();
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a username before playing.", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CheckAnswerAndLoadNext();
        }

        private void cyberButton3_Click(object sender, EventArgs e)
        {
            Menu myForm = new Menu();
            this.Hide();
            myForm.ShowDialog();
            this.Close();   
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadNextQuestion();
        }
    }
}
