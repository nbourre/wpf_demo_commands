using System.Windows.Input;

namespace wpf_command_helloWorld
{
    class MainViewModel : BaseViewModel
    {
        private string _message;
        private bool _canExecute = true;

        public bool CanExecute {
            get => _canExecute;
            set
            {
                _canExecute = value;
                OnPropertyChanged();
            }
        }


        public string Message {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public ICommand ShowMessageCommand { get; set; }

        public MainViewModel()
        {
            ShowMessageCommand = new DelegateCommand<string>(ShowMessage, CanShowMessage);
        }

        private bool CanShowMessage(string obj)
        {
            return CanExecute;
        }

        private void ShowMessage(string obj)
        {
            Message = obj;
        }
    }
}
