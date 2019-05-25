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

namespace DriverLicenceForm
{
    public partial class FormQuiz : Form
    {
        private QuestionsRetriever _questions = QuestionsRetriever.Instance();
        private int _panelCount = 0;
        private int _correctAnswers = 0;
        private int _incorrectAnswers = 0;
        public FormQuiz()
        {
            InitializeComponent();
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            panelQuestion.BringToFront();

            textBoxQuestion.Text = _questions.QuestionsList.First().QuestionText;
            A.Text = _questions.QuestionsList.First().AnswerTextA;
            B.Text = _questions.QuestionsList.First().AnswerTextB;
            C.Text = _questions.QuestionsList.First().AnswerTextC;

            resetAnswers();
        }

        private void resetAnswers()
        {
            A.Checked = false;
            B.Checked = false;
            C.Checked = false;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string selectedOption = GetSelectedOption();

            IncrementQuizResult(selectedOption);

            if (_panelCount == _questions.QuestionsList.Count-1)
            {
                return;
            }

            _panelCount++;

            UpdatePanel();

            resetAnswers();
        }

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
                // Set IndexOutOfRangeException to the new exception's InnerException.
                throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
            }

        }

        private void IncrementQuizResult(string selectedOption)
        {
            if (_questions.QuestionsList[_panelCount].CorrectAnswerText == selectedOption)
            {
                MessageBox.Show("Raspuns Corect!");
                _correctAnswers++;
            }
            else
            {
                MessageBox.Show("Raspuns Incorect!");
                _incorrectAnswers++;
            }
        }

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

        private void RadioButtonA_CheckedChanged(object sender, EventArgs e)
        {

        }

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
