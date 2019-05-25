using System;
using System.Collections.Generic;

namespace DataStore
{
    public class QuestionsRetriever
    {
        private List<Question> _questions;
        public List<Question> QuestionsList {
            get
            {
                return _questions;
            }
        }
        QuestionsRetriever()
        {
            _questions = new List<Question>()
            {
                new Question(),
                new Question()
            };
        }

    }
}
