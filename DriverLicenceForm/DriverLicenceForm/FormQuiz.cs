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
        #region public properties

        public QuestionsRetriever _questions = QuestionsRetriever.Instance();
        public int PanelCount = 0;
        public int CorrectAnswersCount = 0;
        public int IncorrectAnswersCount = 0;

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

            PanelCount++;

            // verifica daca s-a ajuns la sfarsitul testului
            if (PanelCount >= _questions.QuestionsList.Count)
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
        public void ResetValues()
        {
            PanelCount = 0;
            CorrectAnswersCount = 0;
            IncorrectAnswersCount = 0;
        }

        // afiseaza in panelul existent urmatoarea intrebare
        private void UpdatePanel()
        {
            try
            {
                textBoxQuestion.Text = _questions.QuestionsList[PanelCount].QuestionText;
                A.Text = _questions.QuestionsList[PanelCount].AnswerTextA;
                B.Text = _questions.QuestionsList[PanelCount].AnswerTextB;
                C.Text = _questions.QuestionsList[PanelCount].AnswerTextC;
            }
            catch (System.IndexOutOfRangeException e)
            {
                System.Console.WriteLine(e.Message);
                throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
            }

        }

        // metoda care incrementeaza raspunsurile corecte/incorecte pentru fiecare intrebare
        public void UpdateQuizResult(string selectedOption)
        {
            if (_questions.QuestionsList[PanelCount].CorrectAnswerText == selectedOption)
            {
                CorrectAnswersCount++;
                DisplayMessage("Raspuns corect!");
            }
            else
            {
                IncorrectAnswersCount++;
                DisplayMessage("Raspuns Incorect!");
            }
        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show($"{message}{Environment.NewLine} Raspunsuri corecte: {CorrectAnswersCount}, Raspunsuri gresite {IncorrectAnswersCount}");
        }

        // Get selected option from checkboxes
        public string GetSelectedOption()
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



        private void buttonHelp_Click(object sender, EventArgs e)
        {

            /*if (System.IO.File.Exists("DriverLicenceForm.chm"))
            {
                System.Diagnostics.Process.Start("DriverLicenceForm.chm");
            }*/
            //System.Diagnostics.Process.Start("DriverLicenceForm.chm");
            Help.ShowHelp(this, "DriverLicenceForm.chm");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
