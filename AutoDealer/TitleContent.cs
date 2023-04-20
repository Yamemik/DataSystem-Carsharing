namespace AutoDealer
{
    /// <summary>Класс начала теста контента ViewModel</summary>
    public class TitleContent : BaseContent
    {
        private string _nameTest;
        /// <summary>Название теста</summary>
        public string NameTest { get => _nameTest; set { _nameTest = value; OnPropertyChanged(); } }

        /// <summary>Конструтор через базовый конструтор</summary>
        /// <param name="execute">Метод перехода к списку вопросов</param>
        /// <param name="canExecute">Метод проверяющий переход к списку вопросов</param>
        public TitleContent(ExecuteHandler execute, CanExecuteHandler canExecute = null) : base(execute, canExecute) { }

    }
}
