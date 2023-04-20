using System;
using System.Xml.Serialization;

namespace AutoDealer
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false, ElementName ="Test")]
    public partial class TestClass
    {

        /// <summary>Название теста</summary>
        public string NameTest { get; set; }

        /// <summary>Вопросы теста</summary>
        [XmlArrayItem("Question", IsNullable = false)]
        public TestClassQuestion[] Questions { get; set; }
    }

    /// <summary>Класс вопроса Модели</summary>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class TestClassQuestion
    {

        /// <summary>Текст вопроса</summary>
        public string Text { get; set; }

        /// <summary>Тип вопроса: <see langword="true"/> - только один ответ правильный,
        /// <see langword="false"/> - несколько вопросов могут быть правильными</summary>
        [XmlAttribute()]
        public bool IsOnlyOne { get; set; }

        /// <summary>Варианты ответов на вопрос</summary>
        [XmlArrayItem("Answer", IsNullable = false)]
        public TestClassAnswer[] Answers { get; set; }
    }

    /// <summary>Класс ответа на вопрос Модели</summary>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class TestClassAnswer
    {

        /// <summary>Флаг верного ответа</summary>
        [XmlAttribute()]
        public bool IsRight { get; set; }

        /// <summary>Текст ответа</summary>
        [XmlText()]
        public string Text { get; set; }
    }
}
