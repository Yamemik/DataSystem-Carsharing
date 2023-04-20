using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace AutoDealer
{
    /// <summary>Класс Модели</summary>
    public class Model
    {
        /// <summary>Загруженный тест</summary>
        public TestClass Test { get; }

        /// <summary>Имя файла из которого загружен тест</summary>
        public string NameFileTest { get; }

        /// <summary>Конструтор с заданием имени файла из которого нужно загрузить тест</summary>
        /// <param name="nameFileTest">Имя файла теста</param>
        public Model(string nameFileTest)
        {
            XmlSerializer ser = new XmlSerializer(typeof(TestClass));
            using (FileStream file = new FileStream(nameFileTest, FileMode.Open))
            {
                Test = (TestClass)ser.Deserialize(file);
            }
            NameFileTest = nameFileTest;

            foreach (TestClassQuestion question in Test.Questions)
            {
                int countRight = question.Answers.Count(ans => ans.IsRight);
                if (countRight == 0)
                    throw new TestException("Хоть один ответ должен быть правильным!", question, TestExceptionEnum.NoRight);
                if (countRight != 1 && question.IsOnlyOne)
                    throw new TestException("Для этого вопроса только один ответ должен быть правильным!", question, TestExceptionEnum.NotOnlyOne);
            }
        }
        /// <summary>Конструтор без параметров. Загружает тест из файла "Test.xml"</summary>
        public Model() : this("Test.xml") { }
    }
    /// <summary>Перечисление для типов ошибок теста</summary>
    public enum TestExceptionEnum
    {
        /// <summary>Нет правильных ответов</summary>
        NoRight,
        /// <summary>Правильный должен быть только один ответ</summary>
        NotOnlyOne,
        /// <summary>Неверное значение свойства IsOnlyOne</summary>
        InvalidIsOnlyOne
    }

    /// <summary>Класс представления ошибки теста</summary>
    public class TestException : Exception
    {
        /// <summary>Вопрос теста в котором ошибка</summary>
        public TestClassQuestion Question { get; }

        /// <summary>Тип ошибки</summary>
        public TestExceptionEnum Error { get; }

        #region Конструторы с различным набором параметров
        public TestException(TestClassQuestion question, TestExceptionEnum error)
        {
            Question = question;
            Error = error;
        }
        public TestException(string message, TestClassQuestion question, TestExceptionEnum error)
            : base(message)
        {
            Question = question;
            Error = error;
        }
        public TestException(string message, Exception innerException, TestClassQuestion question, TestExceptionEnum error)
            : base(message, innerException)
        {
            Question = question;
            Error = error;
        }
        #endregion
    }
}
