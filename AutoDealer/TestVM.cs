using System;
using System.Linq;

namespace AutoDealer
{
    /// <summary>Класс теста для ViewModel</summary>
    public class TestVM : OnPropertyChangedClass
    {
        /// <summary>Статический ГСЧ</summary>
        private static readonly Random rand = new Random();
        /// <summary>Базовый тест типа Модели</summary>
        private readonly TestClass Test;

        /// <summary>Конструтор из базового теста типа Модели</summary>
        /// <param name="test">Базовый тест типа Модели</param>
        public TestVM(TestClass test)
        {
            Test = test;
            Questions = Test.Questions.Select(qu => QuestionVM.Create(qu))
                .OrderBy(x => rand.Next()).ToArray();
        }

        /// <summary>Название теста</summary>
        public string NameTest => Test.NameTest;

        /// <summary>Вопросы теста</summary>
        public QuestionVM[] Questions { get; }

        /// <summary>Количество вопросов с правильными ответами</summary>
        public int CountRight() => Questions.Count(qu => qu.Value);
    }
}
