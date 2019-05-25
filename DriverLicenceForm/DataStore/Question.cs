using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Autor: Ioana Pomirleanu
/// Clasa Question descrie structura unei intrebari.
/// </summary>

namespace DataStore
{
    public class Question
    {
        #region private members
        private int _questionNumber = 0;
        private string _questionText = string.Empty;
        private string _answerA = string.Empty;
        private string _answerB = string.Empty;
        private string _answerC = string.Empty;
        private string _correctAnswer = string.Empty;
        #endregion

        // constructor
        public Question(int questionNumber, string questionText, string answerA, string answerB, string answerC, string correctAnswer)
        {
            _questionNumber = questionNumber;
            _questionText = questionText;
            _answerA = answerA;
            _answerB = answerB;
            _answerC = answerC;
            _correctAnswer = correctAnswer;
        }

        #region getter properties
        public int QuestionNumber
        {
            get
            {
                return _questionNumber;
            }
        }

        public string QuestionText
        {
            get
            {
                return _questionText;
            }
        }

        public string AnswerTextA
        {
            get
            {
                return _answerA;
            }
        }
        public string AnswerTextB
        {
            get
            {
                return _answerB;
            }
        }
        public string AnswerTextC
        {
            get
            {
                return _answerC;
            }
        }
        public string CorrectAnswerText
        {
            get
            {
                return _correctAnswer;
            }
        }
        #endregion
    }
}
