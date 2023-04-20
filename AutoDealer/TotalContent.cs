namespace AutoDealer
{
    /// <summary>Клас окончания теста контента ViewModel</summary>
    public class TotalContent : BaseContent
    {
        private int _countRight;
        private int _countTotal;

        /// <summary>Количество правильных ответов</summary>
        public int CountRight { get => _countRight; set { _countRight = value; OnPropertyChanged(); } }

        /// <summary>Количество вопросов в тесте</summary>
        public int CountTotal { get => _countTotal; set { _countTotal = value; OnPropertyChanged(); } }

        /// <summary>Конструтор через базовый конструтор</summary>
        /// <param name="execute">Метод перехода к повтору теста</param>
        /// <param name="canExecute">Метод проверяющий переход к повтору теста</param>
        public TotalContent(ExecuteHandler execute, CanExecuteHandler canExecute = null) : base(execute, canExecute) { }
    }
}
