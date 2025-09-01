using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Code_Debugging
{
    public partial class Form5 : Form
    {
        private List<MCQ> questions = new List<MCQ>();
        private int currentIndex = 0;

        public Form5()
        {
            InitializeComponent();
            LoadQuestionsFromDatabase();
        }

        private void LoadQuestionsFromDatabase()
        {
            try
            {
                string connectionString = "server=localhost;user=root;password=;database=codes;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT question, optionA, optionB, optionC, optionD, correct_option FROM mcqquestions";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questions.Add(new MCQ
                            {
                                Question = reader.GetString("question"),
                                OptionA = reader.GetString("optionA"),
                                OptionB = reader.GetString("optionB"),
                                OptionC = reader.GetString("optionC"),
                                OptionD = reader.GetString("optionD"),
                                CorrectOption = reader.GetString("correct_option")
                            });
                        }
                    }
                }

                if (questions.Count > 0)
                {
                    DisplayQuestion(0);
                }
                else
                {
                    MessageBox.Show("No questions found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading questions: " + ex.Message);
            }
        }

        private void DisplayQuestion(int index)
        {
            var q = questions[index];
            lblQuestion.Text = q.Question;
            radioA.Text = q.OptionA;
            radioB.Text = q.OptionB;
            radioC.Text = q.OptionC;
            radioD.Text = q.OptionD;
            radioA.Checked = radioB.Checked = radioC.Checked = radioD.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (questions.Count == 0) return;

            string selected = "";
            if (radioA.Checked) selected = "A";
            else if (radioB.Checked) selected = "B";
            else if (radioC.Checked) selected = "C";
            else if (radioD.Checked) selected = "D";

            if (selected == "")
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            var correct = questions[currentIndex].CorrectOption;
            if (selected == correct)
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Wrong! Correct answer: " + correct);
            }

            currentIndex++;
            if (currentIndex < questions.Count)
            {
                DisplayQuestion(currentIndex);
            }
            else
            {
                MessageBox.Show("You have completed all questions!");
                btnSubmit.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (questions.Count == 0) return;

            string selected = "";
            if (radioA.Checked) selected = "A";
            else if (radioB.Checked) selected = "B";
            else if (radioC.Checked) selected = "C";
            else if (radioD.Checked) selected = "D";

            if (selected == "")
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            var correct = questions[currentIndex].CorrectOption;
            if (selected == correct)
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Wrong! Correct answer: " + correct);
            }

            currentIndex++;
            if (currentIndex < questions.Count)
            {
                DisplayQuestion(currentIndex);
            }
            else
            {
                MessageBox.Show("You have completed all questions!");
                btnSubmit.Enabled = false;
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }

    public class MCQ
    {
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
}
