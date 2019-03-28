using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TravelApp.Model;
using TravelApp.Views;

namespace TravelApp.ViewModels
{
   public class ConcertViewModel : IPageViewModel
    {
        public ObservableCollection<Concertstuff> stuff { get; set; }
        public ConcertViewModel()
        {  stuff = new ObservableCollection<Concertstuff>();
              stuff.Add(new Concertstuff()
            {
                name="aydan",
                place="berlin"

            });
           
        }

        //private ICommand hiButtonCommand;

        //private ICommand toggleExecuteCommand { get; set; }

        //private bool canExecute = true;



        //public bool CanExecute
        //{
        //    get
        //    {
        //        return this.canExecute;
        //    }

        //    set
        //    {
        //        if (this.canExecute == value)
        //        {
        //            return;
        //        }

        //        this.canExecute = value;
        //    }
        //}

        //public ICommand ToggleExecuteCommand
        //{
        //    get
        //    {
        //        return toggleExecuteCommand;
        //    }
        //    set
        //    {
        //        toggleExecuteCommand = value;
        //    }
        //}

        //public ICommand HiButtonCommand
        //{
        //    get
        //    {
        //        return hiButtonCommand;
        //    }
        //    set
        //    {
        //        hiButtonCommand = value;
        //    }
        //}

        //public ConcertViewModel()
        //{
        //    HiButtonCommand = new RelayCommand (no);

        //    //HiButtonCommand = new RelayCommand(ShowMessage, param => this.canExecute);
        //   toggleExecuteCommand = new RelayCommand(ChangeCanExecute);
        //}

        //public void ShowMessage(object aydan)
        //{
        //    MessageBox.Show(aydan.ToString());
        //}
        // public void no(object a)
        //{
        //    Window1 b = new Window1();
        //    b.Show();


        //} 

        //public void ChangeCanExecute(object a)
        //{
        //    canExecute = !canExecute;
        //}

        public void Load()
        {

          
        }
        public string Name
        {
            get
            {
                return "Concert";
            }
        }


    }
}
