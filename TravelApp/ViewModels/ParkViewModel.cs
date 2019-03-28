using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TravelApp.ViewModels
{
    class ParkViewModel:IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Park";
            }
        }




        private ICommand hiButtonCommand;

        private ICommand toggleExecuteCommand { get; set; }

        private bool canExecute = true;



        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }

            set
            {
                if (this.canExecute == value)
                {
                    return;
                }

                this.canExecute = value;
            }
        }

        public ICommand ToggleExecuteCommand
        {
            get
            {
                return toggleExecuteCommand;
            }
            set
            {
                toggleExecuteCommand = value;
            }
        }

        public ICommand HiButtonCommand
        {
            get
            {
                return hiButtonCommand;
            }
            set
            {
                hiButtonCommand = value;
            }
        }

       

        public void ShowMessage(object aydan)
        {
            MessageBox.Show(aydan.ToString());
        }
     
        

        public void ChangeCanExecute(object a)
        {
            canExecute = !canExecute;
        }
    }
}
