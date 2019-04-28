// Jake Kampf

using System;

namespace TriviaNow
{
    [Serializable]
    public class Question
    {
        // Declares private variables.
        private string questionText;
        private string choiceOne;
        private string choiceTwo;
        private string choiceThree;
        private string choiceFour;
        private string feedback;
        private string correctChoice;
        private bool usedAlready;

        // Declares public properties for the private variables.
        public string QuestionText { get => questionText; set => questionText = value; }
        public string ChoiceOne { get => choiceOne; set => choiceOne = value; }
        public string ChoiceTwo { get => choiceTwo; set => choiceTwo = value; }
        public string ChoiceThree { get => choiceThree; set => choiceThree = value; }
        public string ChoiceFour { get => choiceFour; set => choiceFour = value; }
        public string Feedback { get => feedback; set => feedback = value; }
        public string CorrectChoice { get => correctChoice; set => correctChoice = value; }
        public bool UsedAlready { get => usedAlready; set => usedAlready = value; }

        // Overloaded Constructor for question.
        public Question(string questionText, string choiceOne, string choiceTwo, string choiceThree, string choiceFour, string feedback, string correctChoice)
        {
            this.questionText = questionText;
            this.choiceOne = choiceOne;
            this.choiceTwo = choiceTwo;
            this.choiceThree = choiceThree;
            this.choiceFour = choiceFour;
            this.feedback = feedback;
            this.correctChoice = correctChoice;
        }

        // Overrided ToString method displays the Question Object's questionText.
        public override string ToString()
        {
            return questionText;
        }
    }
}
