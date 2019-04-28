// Jake Kampf

using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static System.Environment;

namespace TriviaNow
{
    public partial class MainWindow : Form
    {
        // Declares Object references for later use.
        BindingList<Question> listOfQuestions;
        Question selectedQuestion;
        AddQuestion addQuestionForm;
        SearchQuestions searchQuestionsForm;
        UpdateQuestion updateQuestionForm;
        TriviaGame triviaGameForm;

        // Default Constructor for the MainWindow form.
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for when the form first loads.
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Instantiates listOfQuestions and assigns it as the data source of questionsListBox.
            listOfQuestions = new BindingList<Question>();
            questionsListBox.DataSource = listOfQuestions;
        }

        // Event handler for clicking the Add button.
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instantiates a new AddQuestion form.
            addQuestionForm = new AddQuestion();

            // Wires the QuestionAdded event handler to the corresponding event.
            addQuestionForm.QuestionAdded += new QuestionEventHandler(AddQuestion_QuestionAdded);

            // Invokes the ShowDialog method of addQuestionForm to prevent the user from interacting with the main form while addQuestionForm is open. This displays the form to the user.
            addQuestionForm.ShowDialog();
        }

        // Event handler for adding a new question.
        private void AddQuestion_QuestionAdded(object sender, Question q)
        {
            // Adds a new question to the list of questions.
            listOfQuestions.Add(q);

            // Updates StatusLabel's text to reflect the changes to the form.
            StatusLabel.Text = $"New Question Added - {q.QuestionText}";

            // Enables the timer in order to invoke timer_tick event. 
            timer.Enabled = true;
        }

        // Event handler for double clicking a question from questionsListBox.
        private void QuestionsListBox_DoubleClick(object sender, EventArgs e)
        {
            // If the item selected by the user in questionsListBox is null,
            if (questionsListBox.SelectedItem == null)
            {
                // Returns without doing anything.
                return;
            }

            // Instantiates selectedQuestion and assigns it a selectedItem Question object from questionsListBox using casting.
            selectedQuestion = (Question)questionsListBox.SelectedItem;

            updateQuestionForm = new UpdateQuestion();
            updateQuestionForm.QuestionUpdated += new QuestionEventHandler(UpdateQuestion_QuestionUpdated);

            // Invokes the PopulateData method of questionUpdateForm to pass selectedQuestion.
            updateQuestionForm.PopulateData(selectedQuestion);

            updateQuestionForm.ShowDialog();
        }

        // Event handler for updating an existing question.
        private void UpdateQuestion_QuestionUpdated(object sender, Question q)
        {
            // Resets the bindings of listOfQuestions.
            listOfQuestions.ResetBindings();

            StatusLabel.Text = $"Question Updated - {q.QuestionText}";
            timer.Enabled = true;
        }

        // Event handler for clicking the Start button.
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            // If listOfQuestions has less than 3 questions,
            if (listOfQuestions.Count < 3)
            {
                // Informs the user that they need to add more questions before they can play the game.
                MessageBox.Show("At least three questions must be added first.");
            }
            // In all other scenarios,
            else
            {
                // Instantiates a new TriviaGame form using listOfQuestions as a parameter.
                triviaGameForm = new TriviaGame(listOfQuestions);

                triviaGameForm.ShowDialog();
            }
        }

        // Event handler for clicking the Exit button.
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Asks the users if they want to save before quitting the program. The message box buttons are set to yes, no, and cancel. The message box icon is a question mark.
            DialogResult result = MessageBox.Show("Would you like to save before quitting?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            // If the user presses the Yes button,
            if (result == DialogResult.Yes)
            {
                // Invokes the SaveFile method.
                SaveFile();

                // Exits the program.
                Exit(0);
            }
            // If the user presses the No button,
            else if (result == DialogResult.No)
            {
                Exit(0);
            }
            // If the user presses the cancel button,
            else
            {
                // Exits the event without doing anything.
                return;
            }
        }

        // Event handler for clicking the Open button.
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Prompts the user to open a .dat file containing question data to load into the program.
                openFileDialog.FileName = "";
                openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    listOfQuestions = (BindingList<Question>)bf.Deserialize(file);
                    questionsListBox.DataSource = listOfQuestions;
                    StatusLabel.Text = "Data loaded.";
                    timer.Enabled = true;
                }
            }

            // Generic exception prevents the program from crashing.
            catch (Exception)
            {
                StatusLabel.Text = "Data loading not successful.";
                timer.Enabled = true;
            }
        }

        // Event handler for clicking the Save button.
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Invokes the SaveFile method.
            SaveFile();
        }

        // Event handler for clicking the Search button.
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If listOfQuestions is empty,
            if (listOfQuestions.Count == 0)
            {
                // Informs the user that questions must be added first and exits the event.
                MessageBox.Show("Questions must be added first.");
                return;
            }

            searchQuestionsForm = new SearchQuestions();
            searchQuestionsForm.PopulateData(listOfQuestions);
            searchQuestionsForm.ShowDialog();
        }

        // Event handler for pressing down on a key while on questionsListBox.
        private void QuestionsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user presses the delete or back key and a question from the listbox is currently selected, 
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back && questionsListBox.SelectedItem != null)
            {
                // Displays a message box to the user asking them if they are sure they want to delete the question.
                DialogResult result = MessageBox.Show("Delete this question?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                // If the user presses the OK button,
                if (result == DialogResult.OK)
                {
                    selectedQuestion = (Question)questionsListBox.SelectedItem;

                    // Removes selectedQuestion from listOfQuestions.
                    listOfQuestions.Remove(selectedQuestion);

                    // Assigns the data source of questionsListBox to the newly-updated listOfQuestions.
                    questionsListBox.DataSource = listOfQuestions;

                    StatusLabel.Text = "Question deleted.";
                    timer.Enabled = true;
                }
                else
                {
                    // Exits the event without doing anything.
                    return;
                }
            }
        }

        // Method prompts the user to save a .dat file containing question data.
        private void SaveFile()
        {
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, listOfQuestions);
                    file.Close();
                    StatusLabel.Text = "File saved.";
                    timer.Enabled = true;
                }
                catch (Exception)
                {
                    StatusLabel.Text = "Save not successful.";
                    timer.Enabled = true;
                }
            }
        }

        // Event handler for a timer tick.
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Resets the timer's values.
            timer.Enabled = false;
            StatusLabel.Text = "Ready.";
        }
    }
}
