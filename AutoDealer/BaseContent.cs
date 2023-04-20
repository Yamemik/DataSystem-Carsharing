namespace AutoDealer
{
    /// <summary>Базовый класс для контента ViewModel</summary>
    public class BaseContent : OnPropertyChangedClass
    {
        /// <summary>Команда перехода к следующему контенту</summary>
        public RelayCommand JumpCommand { get; }

        /// <summary>Конструктор с делегатами для команды</summary>
        /// <param name="execute">Делегат метода перехода к следующему контенту</param>
        /// <param name="canExecute">Делегат метода проверяющего переход к следующему контенту</param>
        public BaseContent(ExecuteHandler execute, CanExecuteHandler canExecute = null) 
            => JumpCommand = new RelayCommand(execute, canExecute);
    }
}
