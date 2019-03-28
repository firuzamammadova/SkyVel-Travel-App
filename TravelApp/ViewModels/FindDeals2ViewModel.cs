using FindDeals;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Event;

namespace TravelApp.ViewModels
{
    public class FindDeals2ViewModel : ViewModelBase, IPageViewModel
    {

        private IEventAggregator _eventAggregator;
        public ICommand testcommand { get; set; }
        public FindDeals2ViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<SelectEvent>().Subscribe(OnSelectedEvent);
            Agents = new ObservableCollection<Useful2>();
        }
        public ObservableCollection<Useful2> Agents { get; set; }
        public Useful Useful { get; set; }
        public List<Agent> ag { get; set; }

        private void OnSelectedEvent(SelectEventArgs obj)
        {
            Useful = obj.sl;
            ag = obj.ag;
            load();
        }
        private Useful2 _selectedIt;
        public Useful2 SelectedIt
        {
            get { return _selectedIt; }
            set
            {
                _selectedIt = value;
                
                OnPropertyChanged();
                if (_selectedIt != null)
                {
                    GoodJobSuccessfullyEvent();
                    System.Diagnostics.Process.Start(_selectedIt.DeeplinkUrl);
                }
                
            }
        }
        public delegate void GoodJobSuccessfullyHandler();
        public event GoodJobSuccessfullyHandler GoodJobSuccessfullyEvent;
        public void load()
        {
            foreach (var item in Useful.PricingOptions)
            {
                Useful2 newo = new Useful2();
                newo.Price = $"{item.Price} $";
                newo.DeeplinkUrl = item.DeeplinkUrl;
                newo.Agent = ag.First(itemm => itemm.Id == item.Agents[0]);
                Agents.Add(newo);
            }
        }
    }
}
