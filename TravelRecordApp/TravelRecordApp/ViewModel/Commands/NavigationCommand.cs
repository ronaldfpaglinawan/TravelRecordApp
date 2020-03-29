using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TravelRecordApp.ViewModel.Commands
{
    public class NavigationCommand : ICommand
    {
        public HomeViewModel HomeVM { get; set; }

        public NavigationCommand(HomeViewModel homeVM)
        {
            HomeVM = homeVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            HomeVM.Navigate();
        }
    }
}
