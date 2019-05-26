using Microsoft.VisualStudio.TestTools.UnitTesting;
using DriverLicenceForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLicenceForm.Tests
{
    [TestClass()]
    public class FormQuizTests
    {
        [TestMethod()]
        public void ResetValuesTest()
        {
            FormQuiz quiz = new FormQuiz();
            quiz.ResetValues();
            Assert.AreEqual(quiz.CorrectAnswersCount, 0);
            Assert.AreEqual(quiz.IncorrectAnswersCount, 0);
            Assert.AreEqual(quiz.PanelsCounter, 0);
        }

        [TestMethod()]
        public void UpdateQuizResult_0_A()
        {
            FormQuiz quiz = new FormQuiz();
            quiz.ResetValues();
            RadioButton button = new RadioButton();
            button.Name = "A";
            quiz.UpdateQuizResult(button);
            Assert.AreEqual(quiz.CorrectAnswersCount,0);
            Assert.AreEqual(quiz.IncorrectAnswersCount, 1);
        }

        [TestMethod()]
        public void UpdateQuizResult_0_C()
        {
            FormQuiz quiz = new FormQuiz();
            quiz.ResetValues();
            RadioButton button = new RadioButton();
            button.Name = "C";
            quiz.UpdateQuizResult(button);
            Assert.AreEqual(quiz.CorrectAnswersCount, 1);
            Assert.AreEqual(quiz.IncorrectAnswersCount, 0);
        }
        [TestMethod()]
        public void UpdateQuizResult_0_B()
        {
            FormQuiz quiz = new FormQuiz();
            quiz.ResetValues();
            RadioButton button = new RadioButton();
            button.Name = "B";
            quiz.UpdateQuizResult(button);
            Assert.AreEqual(quiz.CorrectAnswersCount, 0);
            Assert.AreEqual(quiz.IncorrectAnswersCount, 1);
        }

        [TestMethod()]
        public void UpdateQuizResult_0_D()
        {
            FormQuiz quiz = new FormQuiz();
            quiz.ResetValues();
            RadioButton button = new RadioButton();
            button.Name = "D";
            quiz.UpdateQuizResult(button);
            Assert.AreEqual(quiz.CorrectAnswersCount, 0);
            Assert.AreEqual(quiz.IncorrectAnswersCount, 1);
        }

        [TestMethod()]
        public void UpdateQuizResult_10_A()
        {
            FormQuiz quiz = new FormQuiz();
            quiz.PanelsCounter = 9;
            quiz.IncorrectAnswersCount = 9;
            RadioButton button = new RadioButton();
            button.Name = "D";
            quiz.UpdateQuizResult(button);
            Assert.AreEqual(quiz.CorrectAnswersCount, 0);
            Assert.AreEqual(quiz.IncorrectAnswersCount, 10);
        }
    }
}