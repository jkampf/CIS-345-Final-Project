// Jake Kampf

using System;
using System.Windows.Forms;
using static System.String;

namespace TriviaNow
{
    // Declares a Delegate to handle all Question objects.
    public delegate void QuestionEventHandler(object sender, Question q);

    public partial class AddQuestion : Form
    {
        // Declares an Event for the creation of a new Question object using the QuestionEventHandler Delegate.
        public event QuestionEventHandler QuestionAdded;

        // Default constructor for the AddQuestion form.
        public AddQuestion()
        {
            InitializeComponent();
        }

        // Event handler for clicking the Add button.
        private void AddButton_Click(object sender, EventArgs e)
        {
            // If any of the text fields are empty,
            if (questionTextBox.Text == Empty || choice1TextBox.Text == Empty || choice2TextBox.Text == Empty || choice3TextBox.Text == Empty || choice4TextBox.Text == Empty || feedbackTextBox.Text == Empty || correctchoiceComboBox.Text == Empty)
            {
                // Informs the user that no data fields can be left empty.
                MessageBox.Show("Enter all data fields.");

                // Prevents the user from submitting incomplete Question data.
                return;
            }

            // Declares and instantiates a new Question object using the overloaded Question constructor and the form TextBox text as parameters.
            Question tmpQuestion = new Question(questionTextBox.Text, choice1TextBox.Text, choice2TextBox.Text, choice3TextBox.Text, choice4TextBox.Text, feedbackTextBox.Text, correctchoiceComboBox.SelectedItem.ToString());

            // Invokes the QuestionAdded event using this form and the tmpQuestion object.
            QuestionAdded(this, tmpQuestion);

            // Clears all text fields.
            questionTextBox.Clear();
            choice1TextBox.Clear();
            choice2TextBox.Clear();
            choice3TextBox.Clear();
            choice4TextBox.Clear();
            feedbackTextBox.Clear();
            correctchoiceComboBox.ResetText();

            // Closes the form.
            Close();
        }
    }
}
