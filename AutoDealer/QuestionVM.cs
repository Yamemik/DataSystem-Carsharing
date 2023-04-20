using System;
using System.Linq;

namespace AutoDealer
{
    /// <summary>Базовый класс вопроса для ViewModel</summary>
    public class QuestionVM : OnPropertyChangedClass
    {
        /// <summary>Статический ГСЧ</summary>
        protected static readonly Random rand = new Random();

        /// <summary>Базовый вопрос типа Модели</summary>
        protected readonly TestClassQuestion TestQuestion;

        /// <summary>Конструтор из базового вопроса типа Модели</summary>
        /// <param name="testQuestion">Базовый вопрос типа Модели</param>
        public QuestionVM(TestClassQuestion testQuestion)
        {
            TestQuestion = testQuestion;
            Answers = TestQuestion.Answers.Select(ans => new AnswerVM(ans))
                .OrderBy(x => rand.Next()).ToArray();
        }

        /// <summary>Тип вопроса: <see langword="true"/> - только один правильный ответ, 
        /// <see langword="false"/> - может быть несколько правильных ответов</summary>
        public bool IsOnleOne => TestQuestion.IsOnlyOne;

        /// <summary>Текст вопроса</summary>
        public string Text => TestQuestion.Text;

        /// <summary>Варианты ответов</summary>
        public AnswerVM[] Answers { get; }

        /// <summary><see langword="true"/> - если выбраны правильные ответы</summary>
        public bool Value => Answers.All(ans => ans.Value);

        /// <summary>Статический конструктор из вопроса типа Модели</summary>
        /// <param name="testQuestion">Базовый вопрос типа Модели</param>
        /// <returns>Тип QuestionRadioButtonVM для вопросов с одним правильным ответом,
        /// тип QuestionCheckBoxVM для вопрсов с несколькимии правильными ответами</returns>
        public static QuestionVM Create(TestClassQuestion testQuestion)
        {
            if (testQuestion.IsOnlyOne)
                return new QuestionRadioButtonVM(testQuestion);
            return new QuestionCheckBoxVM(testQuestion);
        }
    }

    /// <summary>Класс вопроса для ViewModel с только одним правильным ответом</summary>
    public class QuestionRadioButtonVM : QuestionVM
    {
        /// <summary>Конструтор из базового вопроса типа Модели</summary>
        /// <param name="testQuestion">Базовый вопрос типа Модели</param>
        public QuestionRadioButtonVM(TestClassQuestion testQuestion)
            : base(testQuestion)
        {
            if (!IsOnleOne)
                throw new TestException("Неверное значение свойства IsOnlyOne!", testQuestion,
                    TestExceptionEnum.InvalidIsOnlyOne);
        }
    }

    /// <summary>Класс вопроса для ViewModel с несколькими правильными ответами</summary>
    public class QuestionCheckBoxVM : QuestionVM
    {
        /// <summary>Конструтор из базового вопроса типа Модели</summary>
        /// <param name="testQuestion">Базовый вопрос типа Модели</param>
        public QuestionCheckBoxVM(TestClassQuestion testQuestion)
            : base(testQuestion)
        {
            if (IsOnleOne)
                throw new TestException("Неверное значение свойства IsOnlyOne!", testQuestion,
                    TestExceptionEnum.InvalidIsOnlyOne);
        }
    }
}
