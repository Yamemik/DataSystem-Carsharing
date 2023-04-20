namespace AutoDealer
{
    /// <summary>Класс ViewModel</summary>
    public class ViewModel : OnPropertyChangedClass
    {
        /// <summary>Тест полученный от Модели</summary>
        private readonly TestClass Test;

        /// <summary>Тест созданый ViewModel для View</summary>
        public TestVM TestView { get; private set; }

        /// <summary>Поле для хранения значения контента</summary>
        private BaseContent _content;
        /// <summary>Контент ViewModel</summary>
        public BaseContent Content { get => _content; set { _content = value; OnPropertyChanged(); } }
        Model model;

        /// <summary>Конструтор создающий Модель и загружающий из неё тест</summary>
        public ViewModel()
        {
            model = new Model("Test.xml");
            Test = model.Test;
            TotalMetod(null);
        }

        /// <summary>Метод для контента начала теста</summary>
        /// <param name="parameter">Неиспользуется</param>
        private void TitleMetod(object parameter)
        {
            Content = new QuestionsContent(QuestionsMetod) { Questions = TestView.Questions };
        }

        /// <summary>Метод для контента вопросов теста</summary>
        /// <param name="parameter">Неиспользуется</param>
        private void QuestionsMetod(object parameter)
        {
            Content = new TotalContent(TotalMetod)
            {
                CountRight = TestView.CountRight(),
                CountTotal = TestView.Questions.Length
            };
        }

        /// <summary>Метод для контента окончания теста</summary>
        /// <param name="parameter">Неиспользуется</param>
        private void TotalMetod(object parameter)
        {
            TestView = new TestVM(Test);
            Content = new TitleContent(TitleMetod) { NameTest = TestView.NameTest };
        }
    }
}
