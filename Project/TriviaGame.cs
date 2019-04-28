// Jake Kampf

using System;
using System.ComponentModel;
using System.Media;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class TriviaGame : Form
    {
        // Declares variables.
        int questionsAnswered = 0;
        int correctAnswers = 0;

        // Declares Object references for later use.
        Question randomQuestion;
        SoundPlayer soundPlayer;

        // Declares and instanitates a new BindingList of Question Objects.
        BindingList<Question> listOfQuestions = new BindingList<Question>();

        // Declares an instantiates a new Random object.
        Random random = new Random();

        // Default Constructor for TriviaGame form uses a BindingList as a parameter.
        public TriviaGame(BindingList<Question> listOfQuestions)
        {
            InitializeComponent();

            // Assigns MainWindow's listOfQuestions to this form's listOfQuestions.
            this.listOfQuestions = listOfQuestions;
        }

        // Event handler for when the form first loads.
        private void TriviaGame_Load(object sender, EventArgs e)
        {
            // For each question in listOfQuestions,
            foreach (Question question in listOfQuestions)
            {
                // Sets the UsedAlready Property of the Question Object to false.
                question.UsedAlready = false;
            }

            // Disables submitButton.
            submitButton.Enabled = false;

            // Invokes the PlaySound and LoadRandomQuestion methods.
            PlaySound();
            LoadRandomQuestion();
        }

        // Event handler for when the form closes.
        private void TriviaGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            PlaySound();
        }

        // Event handler for clicking the Submit button.
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Increments questionAnswered.
            questionsAnswered++;

            // Shows feedbackLabel.
            feedbackLabel.Show();

            // If the user's answer is correct,
            if (choice1RadioButton.Checked == true && randomQuestion.CorrectChoice == "1" || choice2RadioButton.Checked == true && randomQuestion.CorrectChoice == "2" || choice3RadioButton.Checked == true && randomQuestion.CorrectChoice == "3" || choice4RadioButton.Checked == true && randomQuestion.CorrectChoice == "4")
            {
                correctAnswers++;

                // Updates correctchoiceLabel's text to reflect that the user selected the correct answer.
                correctchoiceLabel.Text = "Correct!";
            }

            correctchoiceLabel.Show();
            submitButton.Enabled = false;

            // Enables nextButton.
            nextButton.Enabled = true;

            // Disables choicesGroupBox.
            choicesGroupBox.Enabled = false;
        }

        // Event handler for clicking the Next button.
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Increments ProgressBar by 1.
            ProgressBar.Increment(1);

            // Makes ProgressBar visible.
            ProgressBar.Visible = true;

            // Unchecks all of the RadioButtons.
            choice1RadioButton.Checked = false;
            choice2RadioButton.Checked = false;
            choice3RadioButton.Checked = false;
            choice4RadioButton.Checked = false;

            submitButton.Enabled = false;

            // If less than three questions have been answered,
            if (questionsAnswered < 3)
            {
                // Makes StatusLabel visible.
                StatusLabel.Visible = true;

                // Updates StatusLabel's text to reflect the user's progress in the game.
                StatusLabel.Text = $"Question {ProgressBar.Value}/3";
                nextButton.Enabled = false;

                // Enables choicesGroupBox.
                choicesGroupBox.Enabled = true;

                LoadRandomQuestion();
            }
            // In all other scenarios,
            else
            {
                // Hides the form.
                Hide();

                // If the user answered 1 question correctly by the end of the game,
                if (correctAnswers == 1)
                {
                    // Displays a message to the user reflecting this.
                    MessageBox.Show("You answered 1 question correctly.");
                }
                else
                {
                    MessageBox.Show($"You answered {correctAnswers} questions correctly!");
                }

                // Closes the form.
                Close();
            }
        }

        // Event handler for when choice1RadioButton is checked or unchecked.
        private void Choice1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            submitButton.Enabled = true;
        }

        private void Choice2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            submitButton.Enabled = true;
        }
        private void Choice3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            submitButton.Enabled = true;
        }
        private void Choice4RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            submitButton.Enabled = true;
        }

        // Method selects a random Question Object when invoked.
        private void LoadRandomQuestion()
        {
            // Assigns a random question number from listOfQuestions to questionNumber.
            int questionNumber = random.Next(listOfQuestions.Count);

            // If the question has already been used in this game,
            if (listOfQuestions[questionNumber].UsedAlready == true)
            {
                // Reinvokes the method in order to get a question that hasn't been used already.
                LoadRandomQuestion();
            }
            else
            {
                // Assigns the question corresponding to questionNumber in listOfQuestions to randomQuestion.
                randomQuestion = listOfQuestions[questionNumber];

                // Sets the UsedAlready Property of the Question Object to true.
                listOfQuestions[questionNumber].UsedAlready = true;

                // Assigns the Property values of randomQuestion to the corresponding Label and RadioButton text.
                questiontextLabel.Text = randomQuestion.QuestionText;
                choice1RadioButton.Text = randomQuestion.ChoiceOne;
                choice2RadioButton.Text = randomQuestion.ChoiceTwo;
                choice3RadioButton.Text = randomQuestion.ChoiceThree;
                choice4RadioButton.Text = randomQuestion.ChoiceFour;
                feedbackLabel.Text = randomQuestion.Feedback;

                // Hides feedbackLabel.
                feedbackLabel.Hide();

                // By default, correctchoiceLabel's text informs the user that their choice was incorrect and shows them the correct choice.
                correctchoiceLabel.Text = "Incorrect! The correct choice was " + randomQuestion.CorrectChoice + ".";

                correctchoiceLabel.Hide();
                nextButton.Enabled = false;
            }
        }

        // Method plays a sound effect when invoked.
        private void PlaySound()
        {
            // Instantiates a new SoundPlayer Object and assigns it an audio file.
            soundPlayer = new SoundPlayer("soundeffect.wav");

            // Loads the audio file.
            soundPlayer.Load();

            // Plays the audio file.
            soundPlayer.Play();
        }
    }
}
