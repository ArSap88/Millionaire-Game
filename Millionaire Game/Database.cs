using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class Database
    {
        internal Question Question1 { get; private set; }
        internal Question Question2 { get; private set; }
        internal Question Question3 { get; private set; }
        internal Question Question4 { get; private set; }
        internal Question Question5 { get; private set; }

        internal void QandA()
        {
            Question Q1 = new Question("Первый вопрос?");
            Q1.Answers = new Answer[4];
            Q1.Answers[0] = new AnswerWrong("Неправильно");
            Q1.Answers[1] = new AnswerCorrect("Правильно");
            Q1.Answers[2] = new AnswerWrong("Неправильно");
            Q1.Answers[3] = new AnswerWrong("Неправильно");
            Question Q2 = new Question("Второй вопрос?");
            Q2.Answers = new Answer[4];
            Q2.Answers[0] = new AnswerCorrect("Правильно");
            Q2.Answers[1] = new AnswerWrong("Неправильно");
            Q2.Answers[2] = new AnswerWrong("Неправильно");
            Q2.Answers[3] = new AnswerWrong("Неправильно");
            Question Q3 = new Question("Третий вопрос?");
            Q3.Answers = new Answer[4];
            Q3.Answers[0] = new AnswerWrong("Неправильно");
            Q3.Answers[1] = new AnswerWrong("Неправильно");
            Q3.Answers[2] = new AnswerWrong("Неправильно");
            Q3.Answers[3] = new AnswerCorrect("Правильно");
            Question Q4 = new Question("Четвертый вопрос?");
            Q4.Answers = new Answer[4];
            Q4.Answers[0] = new AnswerWrong("Неправильно");
            Q4.Answers[1] = new AnswerWrong("Неправильно");
            Q4.Answers[2] = new AnswerCorrect("Правильно");
            Q4.Answers[3] = new AnswerWrong("Неправильно");
            Question Q5 = new Question("Пятый вопрос?");
            Q5.Answers = new Answer[4];
            Q5.Answers[0] = new AnswerWrong("Неправильно");
            Q5.Answers[1] = new AnswerCorrect("Правильно");
            Q5.Answers[2] = new AnswerWrong("Неправильно");
            Q5.Answers[3] = new AnswerWrong("Неправильно");

            Question1 = Q1;
            Question2 = Q2;
            Question3 = Q3;
            Question4 = Q4;
            Question5 = Q5;
        }
    }
}
