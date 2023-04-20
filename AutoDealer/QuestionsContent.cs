namespace AutoDealer
{
    /// <summary>Класс для контента со списком вопросов</summary>
    public class QuestionsContent : BaseContent
    {
        #region Поля для хранения значений свойств
        private QuestionVM[] _questions;
        private QuestionVM _currentQuestion;
        private int _currQuestionIndex;
        private RelayCommand _jumpQuestionCommand;
        #endregion

        /// <summary>Вопросы</summary>
        public QuestionVM[] Questions { get => _questions; set { _questions = value; OnPropertyChanged(); CurrQuestionIndex = -1; JumpQuestionMetod(1); } }

        /// <summary>Текущий вопрос</summary>
        public QuestionVM CurrentQuestion { get => _currentQuestion; set { _currentQuestion = value; OnPropertyChanged(); } }

        /// <summary>Индекс текущего вопроса</summary>
        private int CurrQuestionIndex { get => _currQuestionIndex; set { _currQuestionIndex = value; OnPropertyChanged(); } }

        /// <summary>Конструктор наследующий от базового конструктора</summary>
        /// <param name="execute">Делегат метода исполняющего выход из контента</param>
        /// <param name="canExecute">Делегат метода проверяющего выход из контента</param>
        public QuestionsContent(ExecuteHandler execute, CanExecuteHandler canExecute = null)
            : base(execute, canExecute) { }

        /// <summary>Команда для перехода между вопросами</summary>
        public RelayCommand JumpQuestionCommand => _jumpQuestionCommand ?? (_jumpQuestionCommand = new RelayCommand(JumpQuestionMetod, JumpQuestionCanMetod));

        /// <summary>Метод проверяющий переход на вопрос с указанным смещением</summary>
        /// <param name="parameter">Смешение на следующий вопрос</param>
        /// <returns><see langword="true"/> если переход возможен</returns>
        private bool JumpQuestionCanMetod(object parameter)
        => parameter != null
            && int.TryParse(parameter.ToString(), out int parInt)
            && CurrQuestionIndex + parInt >= 0 && CurrQuestionIndex + parInt < Questions.Length;

        /// <summary>Метод перехода на вопрос с указанным смещением</summary>
        /// <param name="parameter">Смешение на следующий вопрос</param>
        private void JumpQuestionMetod(object parameter)
        {
            int newIndex = CurrQuestionIndex + int.Parse(parameter.ToString());
            if (newIndex != CurrQuestionIndex)
            {
                CurrQuestionIndex = newIndex;
                CurrentQuestion = Questions[CurrQuestionIndex];
            }
        }

    }
}
