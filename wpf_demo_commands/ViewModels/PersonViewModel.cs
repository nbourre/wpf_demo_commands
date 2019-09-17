using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using wpf_demo_commands.Models;

namespace wpf_demo_commands.ViewModels
{
    class PersonViewModel
    {
        private ObservableCollection<Person> _personList;

        public PersonViewModel()
        {
            _personList = new ObservableCollection<Person>()
        {
            new Person(){Name="Nicolas", Address="Shawinigan"},
            new Person(){Name="Sylvain",Address="Trois-Rivières"}
        };

        }

        public ObservableCollection<Person> Persons
        {
            get { return _personList; }
            set { _personList = value; }
        }

        private ICommand mUpdater;
        
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
    }

    class Updater : ICommand
    {
        #region ICommand Members  

        public bool CanExecute(object parameter)
        {
            if (parameter != null) return true;

            return false;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public void Execute(object parameter)
        {
            //Ton code ici!  
        }
        #endregion
    }
}
