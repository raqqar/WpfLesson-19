using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfLesson_19.Models;

namespace WpfLesson_19.ViewModels
{
    internal class MainWindowViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private int number1;
        public int Number1
        {
            get
            {
                return number1;
            }
            set
            {
                number1 = value;
            }
        }
        private int number2;
        public int Number2
        {
            get
            {
                return number2;
            }
            set
            {
                number2 = value;
            }
        }
        private int number3;
        public int Number3
        {
            get
            {
                return number3;
            }
            set
            {
                number3 = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            Number3 = Ariph.Add(Number1, Number2);
        }
        private bool CanAddCommandExecute(object p)
        {
            if (Number1!=0 || Number2!=0)
            
                return true;
            else
                return false;  
        }
        public MainWindowViewModels()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecute);
        }
    }
}
