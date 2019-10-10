using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf_command_helloWorld
{
    class MainViewModel : BaseViewModel
    {
        private string _message;

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
            return true;
        }

        private void ShowMessage(string obj)
        {
            Message = obj;
        }
    }
}
