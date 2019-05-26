/**************************************************************************
 *                                                                        *
 *  Copyright:   (c) 2019, Pomirleanu Ioana-Roxana,                       *
 *                         Rusu Teona-Stefana,                            *
 *                         Tucaliuc Mariana                               *
 *  Description: Proiect la Ingineria Programarii                         *
 *                                                                        *
 **************************************************************************/

namespace DataStore
{
    /// <summary>
    /// Autor: Pomirleanu Ioana-Roxana
    /// Clasa Question descrie structura unei intrebari.
    /// </summary>
    public class Question
    {
        #region Private Member Variables
        private int _questionNumber = 0;
        private string _questionText = string.Empty;
        private string _answerA = string.Empty;
        private string _answerB = string.Empty;
        private string _answerC = string.Empty;
        private string _correctAnswer = string.Empty;
        #endregion

        #region Constructor
        public Question(int questionNumber, string questionText, string answerA, string answerB, string answerC, string correctAnswer)
        {
            _questionNumber = questionNumber;
            _questionText = questionText;
            _answerA = answerA;
            _answerB = answerB;
            _answerC = answerC;
            _correctAnswer = correctAnswer;
        }
        #endregion

        #region Public Properties
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
