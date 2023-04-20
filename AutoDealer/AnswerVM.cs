namespace AutoDealer
{
    /// <summary>Класс ответа на вопрос для ViewModel</summary>
    public class AnswerVM : OnPropertyChangedClass
    {
        /// <summary>Базовый ответ типа Модели</summary>
        private readonly TestClassAnswer TestAnswer;

        /// <summary>Поле для хранения значения свойства</summary>
        private bool _isRightView;

        /// <summary>Конструтор из ответа типа Модели</summary>
        /// <param name="testAnswer">Базовый ответ типа Модели</param>
        public AnswerVM(TestClassAnswer testAnswer) => TestAnswer = testAnswer;

        /// <summary>Текст ответа</summary>
        public string Text => TestAnswer.Text;

        /// <summary>Свойство для выбора ответа</summary>
        public bool IsRightView { get => _isRightView; set { _isRightView = value; OnPropertyChanged(); } }

        /// <summary>Возвращает <see langword="true"/> при правильном выборе</summary>
        public bool Value => IsRightView == TestAnswer.IsRight;
    }
}
