using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Event;
using TravelApp.Model;

namespace TravelApp.ViewModels
{
    public class PlanViewModel: ViewModelBase, IPageViewModel
    {
        private IEventAggregator _eventAggregator;
        public bool Editable { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public PlanningStuff planFlight { get; set; }
        public PlanViewModel(IEventAggregator eventAggregator)

        {
            planFlight = new PlanningStuff();
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<SendToPlanEvent>().Subscribe(OnGotEvent);
            _eventAggregator.GetEvent<LoadEvent>().Subscribe(OnLoadEvent);
            plans = new ObservableCollection<PlanningStuff>();
            AddCommand=new DelegateCommand(OnAddExecute, OnAddCanExecute);
            EditCommand=new DelegateCommand(OnEditExecute, OnAddCanExecute);
            Editable = false;
           
        }

        private void OnLoadEvent(int obj)
        {
            load();
        }

        private void load()
        {
            //planFlight.FlInfo.airport = pla;
            //planFlight.FlInfo.arriveTime = at;
            //planFlight.FlInfo.arriveDate = ad;
        }
        public string pla { get; set; }
        public string at { get; set; }
        public string ad { get; set; }
        private void OnGotEvent(PlanFlight obj)
        {
            pla = $"{obj.airport} Airport";
            //planFlight.FlInfo.airport = $"{obj.airport} Airport";
            ad = obj.arriveDate;
            at = obj.arriveTime;
        }

        private void OnEditExecute()
        {
            Editable = true;
            Load();
        }

        private bool OnAddCanExecute()
        {
            return true;
        }

        private void OnAddExecute()
        {
            plans.Add(new PlanningStuff()
            {
                checking = false,
                place = "Berlin",
                time = "today",
                price = "free"

            });
        }

        public ObservableCollection<PlanningStuff> plans { get; set; }

        public void Load()
        {

            //plans.Add(new PlanningStuff()
            //{
            //    checking = false,
            //    place = "Berlin",
            //    time = "today",
            //    price = "free"

            //});
        }

    }
}
