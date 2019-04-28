// Jake Kampf

using System;
using System.Windows.Forms;
using static System.String;

namespace TriviaNow
{
    public partial class UpdateQuestion : Form
    {
        // Declares an Object reference for later use.
        private Question currentQuestion;

        // Declares an Event for when a Question object is updated using the QuestionEventHandler Delegate.
        public event QuestionEventHandler QuestionUpdated;

        // Default Constructor for the UpdateQuestion form.
        public UpdateQuestion()
        {
            InitializeComponent();
        }

        // Event handler for clicking the Update button.
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Declares and instantiates a new Question object using the overloaded Question constructor and the form TextBox text as parameters.
            Question tmpQuestion = new Question(questionTextBox.Text, choiceoneTextBox.Text, choicetwoTextBox.Text, choicethreeTextBox.Text, choicefourTextBox.Text, feedbackTextBox.Text, correctchoiceComboBox.SelectedItem.ToString());

            // Assigns the TextBox text and ComboBox selection from the user to the corresponding Property values of currentQuestion.
            currentQuestion.QuestionText = questionTextBox.Text;
            currentQuestion.ChoiceOne = choiceoneTextBox.Text;
            currentQuestion.ChoiceTwo = choicetwoTextBox.Text;
            currentQuestion.ChoiceThree = choicethreeTextBox.Text;
            currentQuestion.ChoiceFour = choicefourTextBox.Text;
            currentQuestion.Feedback = feedbackTextBox.Text;
            currentQuestion.CorrectChoice = correctchoiceComboBox.SelectedItem.ToString();

            // If any of the text fields are empty,
            if (questionTextBox.Text == Empty || choiceoneTextBox.Text == Empty || choicetwoTextBox.Text == Empty || choicethreeTextBox.Text == Empty || choicefourTextBox.Text == Empty || feedbackTextBox.Text == Empty || correctchoiceComboBox.Text == Empty)
            {
                // Informs the user that no data fields can be left empty.
                MessageBox.Show("Enter all data fields.");

                // Prevents the user from submitting incomplete Question data.
                return;
            }

            // Invokes the QuestionUpdated Event if it hasn't already been invoked using this form and the Question object as parameters.
            QuestionUpdated?.Invoke(this, tmpQuestion);

            // Closes the form.
            Close();
        }

        // Method assigns the Question object's data to the form's corresponding values.
        public void PopulateData(Question question)
        {
            currentQuestion = question;
            questionTextBox.Text = currentQuestion.QuestionText;
            choiceoneTextBox.Text = currentQuestion.ChoiceOne;
            choicetwoTextBox.Text = currentQuestion.ChoiceTwo;
            choicethreeTextBox.Text = currentQuestion.ChoiceThree;
            choicefourTextBox.Text = currentQuestion.ChoiceFour;
            feedbackTextBox.Text = currentQuestion.Feedback;
            correctchoiceComboBox.SelectedItem = currentQuestion.CorrectChoice.ToString();
        }
    }
}
