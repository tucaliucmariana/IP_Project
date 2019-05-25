using DataStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Creat de Tucaliuc Mariana, Rusu Teona
/// Form Quiz
/// </summary>
/// 
namespace DriverLicenceForm
{
    public partial class FormQuiz : Form
    {
        #region private members

        private QuestionsRetriever _questions = QuestionsRetriever.Instance();
        private int _panelCount = 0;
        private int _correctAnswers = 0;
        private int _incorrectAnswers = 0;

        #endregion
        public FormQuiz()
        {
            InitializeComponent();
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {

        }

        #region event handlers
        // inceperea testului
        private void OnButtonStartClick(object sender, EventArgs e)
        {
            //afisarea panelului de intrebari
            panelQuestion.BringToFront();

            UpdatePanel();

            resetAnswers();
        }

        private void OnButtonSubmitClick(object sender, EventArgs e)
        {
            string selectedOption = GetSelectedOption();

            UpdateQuizResult(selectedOption);

            _panelCount++;

            // verifica daca s-a ajuns la sfarsitul testului
            if (_panelCount >= _questions.QuestionsList.Count)
            {
                DisplayMessage("Rezultat test: ");
                //revenire la panelul initial
                panelQuestion.SendToBack();
                //resetarea valorilor pentru reinceperea testului
                ResetValues();
                return;
            }

            UpdatePanel();

            resetAnswers();
        }
        #endregion

        #region static methods
        // resetare checkbox-uri
        private void resetAnswers()
        {
            A.Checked = false;
            B.Checked = false;
            C.Checked = false;
        }
        private void ResetValues()
        {
            _panelCount = 0;
            _correctAnswers = 0;
            _incorrectAnswers = 0;
        }

        // afiseaza in panelul existent urmatoarea intrebare
        private void UpdatePanel()
        {
            try
            {
                textBoxQuestion.Text = _questions.QuestionsList[_panelCount].QuestionText;
                A.Text = _questions.QuestionsList[_panelCount].AnswerTextA;
                B.Text = _questions.QuestionsList[_panelCount].AnswerTextB;
                C.Text = _questions.QuestionsList[_panelCount].AnswerTextC;
            }
            catch (System.IndexOutOfRangeException e)
            {
                System.Console.WriteLine(e.Message);
                throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
            }

        }

        // metoda care incrementeaza raspunsurile corecte/incorecte pentru fiecare intrebare
        private void UpdateQuizResult(string selectedOption)
        {
            if (_questions.QuestionsList[_panelCount].CorrectAnswerText == selectedOption)
            {
                _correctAnswers++;
                DisplayMessage("Raspuns corect!");

            }
            else
            {
                _incorrectAnswers++;
                DisplayMessage("Raspuns Incorect!");
            }
        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show($"{message}{Environment.NewLine} Raspunsuri corecte: {_correctAnswers}, Raspunsuri gresite {_incorrectAnswers}");
        }

        // Get selected option from checkboxes
        private string GetSelectedOption()
        {
            string selectedOption = string.Empty;
            if (A.Checked == true)
            {
                selectedOption = A.Name;
            }
            else
            {
                if (B.Checked == true)
                {
                    selectedOption = B.Name;
                }
                else
                {
                    if (C.Checked == true)
                    {
                        selectedOption = C.Name;
                    }
                }
            }
            return selectedOption;
        }
        #endregion
    }
}
