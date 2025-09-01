using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Code_Debugging
{
    public partial class Form2 : Form
    {
        private List<string> codeSnippets = new List<string>();
        private List<string> correctAnswers = new List<string>();
        private int currentIndex;

        public Form2()
        {
            InitializeComponent();
            LoadFillInTheBlanks();
        }
        

        private void LoadFillInTheBlanks()
        {
            
            try
            {
                string connectionString = "server=localhost;user=root;password=;database=codes;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT code_with_blank, correct_word FROM fillintheblanks ORDER BY id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codeSnippets.Add(reader.GetString(0));
                            correctAnswers.Add(reader.GetString(1));
                        }
                    }
                    conn.Close();
                }

                if (codeSnippets.Count == 0)
                {
                    MessageBox.Show("No data found in database.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void newquestion()
        {
            Random random = new Random();
            currentIndex = random.Next(codeSnippets.Count);
            lblCode.Text = codeSnippets[currentIndex];
            txtAnswer.Text = "";
            txtAnswer.Focus();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (codeSnippets.Count == 0)
            {
                MessageBox.Show("No code snippets available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            newquestion();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentIndex < 0 || currentIndex >= correctAnswers.Count)
            {
                MessageBox.Show("No question selected. Click 'Next' to load one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userInput = txtAnswer.Text.Trim();
            string correctAnswer = correctAnswers[currentIndex].Trim();

            if (string.Equals(userInput, correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Correct! 🎉", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newquestion();
            }
            else
            {
                MessageBox.Show($"Incorrect. ❌\nCorrect answer: {correctAnswer}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newquestion();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (codeSnippets.Count == 0)
            {
                MessageBox.Show("No code snippets available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newquestion();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (currentIndex < 0 || currentIndex >= correctAnswers.Count)
            {
                MessageBox.Show("No question selected. Click 'Next' to load one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userInput = txtAnswer.Text.Trim();
            string correctAnswer = correctAnswers[currentIndex].Trim();

            if (string.Equals(userInput, correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Correct! 🎉", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); newquestion();
            }
            else
            {
                MessageBox.Show($"Incorrect. ❌\nCorrect answer: {correctAnswer}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning); newquestion();
            }
        }

        private void cyberButton3_Click(object sender, EventArgs e)
        {
            Menu myForm = new Menu();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
