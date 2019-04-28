// Jake Kampf

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class SearchQuestions : Form
    {
        // Declares a BindingList of Question Objects for later use.
        BindingList<Question> listOfQuestions;

        // Default Constructor for SearchQuestions.
        public SearchQuestions()
        {
            InitializeComponent();
        }

        // Event handler for when the form first loads.
        private void SearchQuestions_Load(object sender, EventArgs e)
        {
            // Sets the visibility of StatusStrip to false.
            StatusStrip.Visible = false;
        }

        // Event handler for pressing down on a key while searchTextBox is selected.
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Assigns the text of searchTextBox to a new string and converts it to uppercase to ensure that search queries aren't case-sensitive.
            string searchTerm = searchTextBox.Text.ToUpper();

            BindingList<Question> matchingQuestions;

            // If the key the user presses down on the Enter key and the text of searchTextBox isn't empty,
            if (e.KeyCode == Keys.Enter && searchTextBox.Text != "")
            {
                // Instantiates the matchingQuestion BindingList.
                matchingQuestions = new BindingList<Question>();

                // For each Question Object in listOfQuestions,
                foreach (Question question in listOfQuestions)
                {
                    // If any of the question's property values contains text that matches the user's search criteria,
                    if (question.QuestionText.ToUpper().Contains(searchTerm) || question.ChoiceOne.ToUpper().Contains(searchTerm) || question.ChoiceTwo.ToUpper().Contains(searchTerm) || question.ChoiceThree.ToUpper().Contains(searchTerm) || question.ChoiceFour.ToUpper().Contains(searchTerm) || question.Feedback.ToUpper().Contains(searchTerm))
                    {
                        // Adds the Question object to matchingQuestions.
                        matchingQuestions.Add(question);
                    }
                }

                // Assigns matchingQuestions to the data source of matchingquestionsListBox.
                matchingquestionsListBox.DataSource = matchingQuestions;

                // Updates the status label's text to show the number of questions found that met the user's search criteria.
                ToolStripStatusLabel.Text = $"{matchingQuestions.Count} questions found.";

                // Sets StatusStrip's visibility to true.
                StatusStrip.Visible = true;
            }
        }

        // Method assigns the questions received from the main form (as a parameter) to this form's listOfQuestions.
        public void PopulateData(BindingList<Question> questions)
        {
            listOfQuestions = questions;
        }
    }
}
