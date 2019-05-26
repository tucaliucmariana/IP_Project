/**************************************************************************
 *                                                                        *
 *  Copyright:   (c) 2019, Pomirleanu Ioana-Roxana,                       *
 *                         Rusu Teona-Stefana,                            *
 *                         Tucaliuc Mariana                               *
 *  Description: Proiect la Ingineria Programarii                         *
 *                                                                        *
 **************************************************************************/

using DataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStoreTests
{
    [TestClass]
    public class QuestionTests
    {
        [TestMethod]
        public void QuestionConstructor()
        {
            Question question = new Question(1, "Într-o zonă pietonală, semnalizată ca atare, sunteţi obligat să circulaţi cu o viteză de:",
                                "cel mult 30 km/h;",
                                "cel mult 20 km/h;",
                                "cel mult 5 km/h.",
                                "C");
            Assert.AreEqual(question.QuestionNumber,1);
            Assert.AreEqual(question.QuestionText, "Într-o zonă pietonală, semnalizată ca atare, sunteţi obligat să circulaţi cu o viteză de:");
            Assert.AreEqual(question.AnswerTextA, "cel mult 30 km/h;");
            Assert.AreEqual(question.AnswerTextB, "cel mult 20 km/h;");
            Assert.AreEqual(question.AnswerTextC, "cel mult 5 km/h.");
            Assert.AreEqual(question.CorrectAnswerText, "C");
        }

    }
}
