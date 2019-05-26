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
using System;

namespace DataStoreTests
{
    [TestClass]
    public class QuestionRetrieverTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetQuestionById_0()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual(String.Empty, DataInstance.GetQuestionById(0));

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetQuestionById_11()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual(String.Empty, DataInstance.GetQuestionById(11));

        }

        [TestMethod]
        public void GetQuestionById_1()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual("Într-o zonă pietonală, semnalizată ca atare, sunteţi obligat să circulaţi cu o viteză de:", DataInstance.GetQuestionById(1));
        }

        [TestMethod]
        public void GetCorrectAnswerById_1()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual("C", DataInstance.GetRightAnswerByQuestionId(1));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetCorrectAnswerById_11()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual(String.Empty, DataInstance.GetRightAnswerByQuestionId(11));

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetCorrectAnswerById_0()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual(String.Empty, DataInstance.GetRightAnswerByQuestionId(0));
        }

        [TestMethod]
        public void GetFirstAnswerById_1()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual("cel mult 30 km/h;", DataInstance.GetFirstAnswerByQuestionId(1));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetFirstAnswerById_11()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual(String.Empty, DataInstance.GetFirstAnswerByQuestionId(11));

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetFirstAnswerById_0()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual(String.Empty, DataInstance.GetFirstAnswerByQuestionId(0));
        }

        [TestMethod]
        public void GetSecondAnswerById_1()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual("cel mult 20 km/h;", DataInstance.GetSecondAnswerByQuestionId(1));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetSecondAnswerById_11()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual(String.Empty, DataInstance.GetSecondAnswerByQuestionId(11));

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetSecondAnswerById_0()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual(String.Empty, DataInstance.GetSecondAnswerByQuestionId(0));
        }

        [TestMethod]
        public void GetThirdAnswerById_1()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual("cel mult 5 km/h.", DataInstance.GetThirdAnswerByQuestionId(1));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetThirdAnswerById_11()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual(String.Empty, DataInstance.GetThirdAnswerByQuestionId(11));

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetThirdAnswerById_0()
        {
            QuestionsRetriever DataInstance = QuestionsRetriever.Instance();
            Assert.AreEqual(String.Empty, DataInstance.GetSecondAnswerByQuestionId(0));
        }
    }
}
