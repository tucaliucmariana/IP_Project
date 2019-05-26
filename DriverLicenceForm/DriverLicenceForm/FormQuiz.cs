/**************************************************************************
 *                                                                        *
 *  Copyright:   (c) 2019, Pomirleanu Ioana-Roxana,                       *
 *                         Rusu Teona-Stefana,                            *
 *                         Tucaliuc Mariana                               *
 *  Description: Proiect la Ingineria Programarii                         *
 *                                                                        *
 **************************************************************************/

using DataStore;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DriverLicenceForm
{
    /// <summary>
    /// Autor interfata: Rusu Teona-Stefana
    /// Autor functionalitate: Tucaliuc Mariana
    /// Form Quiz Design
    /// Afiseaza intrebarile catre utilizator
    /// Valideaza raspunsurile si afiseaza mesaje
    /// </summary>
    public partial class FormQuiz : Form
    {
        #region Public Member Variables
        public QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
        public int PanelsCount = 0;
        public int CorrectAnswersCount = 0;
        public int IncorrectAnswersCount = 0;
        #endregion

        public FormQuiz()
        {
            InitializeComponent();
        }

        #region Event Handlers
        // inceperea testului
        private void OnStartButtonClick(object sender, EventArgs e)
        {
            //afisarea panelului de intrebari
            panelQuestion.BringToFront();

            UpdatePanel();

            ResetAnswers();
        }

        private void OnSubmitButtonClick(object sender, EventArgs e)
        {
            RadioButton selectedOption = GetSelectedOption();

            UpdateQuizResult(selectedOption);

            PanelsCount++;

            // verifica daca s-a ajuns la sfarsitul testului
            if (PanelsCount >= DataInstance.QuestionsList.Count)
            {
                DisplayMessage("Rezultat test: ");
                //revenire la panelul initial
                panelQuestion.SendToBack();
                //resetarea valorilor pentru reinceperea testului
                ResetValues();
                return;
            }

            UpdatePanel();

            ResetAnswers();
        }

        private void OnHelpButtonClick(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "DriverLicenceForm.chm");
        }

        private void OnExitButtonClick(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        #endregion

        #region Private Methods
        // resetare checkbox-uri
        private void ResetAnswers()
        {
            A.Checked = false;
            B.Checked = false;
            C.Checked = false;
            A.ForeColor = Color.Black;
            B.ForeColor = Color.Black;
            C.ForeColor = Color.Black;
        }

        public void ResetValues()
        {
            PanelsCount = 0;
            CorrectAnswersCount = 0;
            IncorrectAnswersCount = 0;
        }

        // afiseaza in panelul existent urmatoarea intrebare
        private void UpdatePanel()
        {
            try
            {
                textBoxQuestion.Text = DataInstance.QuestionsList[PanelsCount].QuestionText;
                A.Text = DataInstance.QuestionsList[PanelsCount].AnswerTextA;
                B.Text = DataInstance.QuestionsList[PanelsCount].AnswerTextB;
                C.Text = DataInstance.QuestionsList[PanelsCount].AnswerTextC;
            }
            catch (System.IndexOutOfRangeException e)
            {
                System.Console.WriteLine(e.Message);
                throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
            }

        }

        // metoda care incrementeaza raspunsurile corecte/incorecte pentru fiecare intrebare
        public void UpdateQuizResult(RadioButton selectedOption)
        {
            if (DataInstance.QuestionsList[PanelsCount].CorrectAnswerText == selectedOption.Name)
            {
                selectedOption.ForeColor = Color.Green;
                CorrectAnswersCount++;
                DisplayMessage("Raspuns corect!");
            }
            else
            {
                ShowCorrectAnswer(selectedOption);
                selectedOption.ForeColor = Color.Red;
                IncorrectAnswersCount++;
                DisplayMessage("Raspuns Incorect!");
            }
        }

        private void ShowCorrectAnswer(RadioButton selectedOption)
        {
            if (A != selectedOption && A.Name == DataInstance.QuestionsList[PanelsCount].CorrectAnswerText)
            {
                A.ForeColor = Color.Green;
            }
            else
            {
                if (B != selectedOption && B.Name == DataInstance.QuestionsList[PanelsCount].CorrectAnswerText)
                {
                    B.ForeColor = Color.Green;
                }
                else
                {
                    if (C != selectedOption && C.Name == DataInstance.QuestionsList[PanelsCount].CorrectAnswerText)
                    {
                        C.ForeColor = Color.Green;
                    }
                }
            }
        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show($"{message}{Environment.NewLine} Raspunsuri corecte: {CorrectAnswersCount}, Raspunsuri gresite {IncorrectAnswersCount}");
        }

        // Get selected option from checkboxes
        private RadioButton GetSelectedOption()
        {
            RadioButton selectedOption = new RadioButton();
            if (A.Checked == true)
            {
                selectedOption = A;
            }
            else
            {
                if (B.Checked == true)
                {
                    selectedOption = B;
                }
                else
                {
                    if (C.Checked == true)
                    {
                        selectedOption = C;
                    }
                }
            }
            return selectedOption;
        }
        #endregion
    }
}
