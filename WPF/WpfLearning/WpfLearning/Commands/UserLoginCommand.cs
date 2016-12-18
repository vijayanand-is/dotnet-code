using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLearning.ViewModels;

namespace WpfLearning.Commands
{
    public class UserLoginCommand : CommandBase
    {
        private UserViewModel userViewModel;

        public UserLoginCommand(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return userViewModel.CanAttemptLogin();
        }

        public override void Execute(object parameter)
        {
            base.Execute(parameter);
            userViewModel.Login();
        }
    }
}
