using Newtonsoft.Json;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TravelApp.Event;
using TravelApp.Model;
using unirest_net.http;

namespace TravelApp.ViewModels
{
    public class FlightViewModel : ViewModelBase, IPageViewModel
    {

        private IEventAggregator _eventAggregator;
        ListPlaces lp { get; set; }
        Flight flight { get; set; }
        string ms { get; set; }
        public ICommand FindCommand { get; set; }

        public FlightViewModel(IEventAggregator eventAggregator)
        {

            FindCommand = new DelegateCommand(OnFindExecute, OnFindCanExecute);
            flight = new Flight();
            TextEvent += new TextHandler(ListPlaces);
            _eventAggregator = eventAggregator;
           
           // _eventAggregator.GetEvent<PostEvent>().Subscribe(OnOpenFriendDetailView);


        }
        public delegate void FindSuccessfullyHandler();
        public event FindSuccessfullyHandler FindSuccessfullyEvent;

        private void create()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress =
                    new Uri("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/pricing/v1.0");

                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "107dc24922mshbd9bd597451997fp19a55fjsnc869fe1003a4");
                client.DefaultRequestHeaders.Add(HttpRequestHeader.ContentType.ToString(), "application/x-www-form-urlencoded");

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("children", "0"),
                    new KeyValuePair<string, string>("infants", "0"),
                    new KeyValuePair<string, string>("country", "US"),
                    new KeyValuePair<string, string>("currency", "USD"),
                    new KeyValuePair<string, string>("locale", "en-US"),
                    new KeyValuePair<string, string>("originPlace", "SFO-sky"),
                    new KeyValuePair<string, string>("destinationPlace", "LHR-sky"),
                    new KeyValuePair<string, string>("outboundDate", "2019-04-01"),
                    new KeyValuePair<string, string>("adults", "1")
                });

                var result = client.PostAsync("", content).Result;

                var resultContent = result.Content.ReadAsStringAsync().Result;

                Console.WriteLine(resultContent);


                ms = result.Headers.Location.ToString().Split('/').Last();
            }
        }
        private void OnFindExecute()
        {

            create();
            _eventAggregator.GetEvent<PostEvent>().Publish(ms);
            FindSuccessfullyEvent();
           // TextEvent();
        }


        public delegate void TextHandler();
        public event TextHandler TextEvent;

        private void ListPlaces()
        {
            //			var places = Unirest.get("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/autosuggest/v1.0/UK/GBP/en-GB/?query="+Flight.ToLocation)
            //.header("X-RapidAPI-Key", "107dc24922mshbd9bd597451997fp19a55fjsnc869fe1003a4")
            //.asJson<string>();

            //			lp = JsonConvert.DeserializeObject<ListPlaces>(places.Body);
            //			//foreach (var item in ress.Places)
            //			//{
            //			//	ListPlacess.Add(item);
            //			//}
            //			MessageBox.Show(lp.Places[0]["PlaceId"]);
        }

        public ObservableCollection<Dictionary<string, string>> ListPlacess { get; set; }
        public string Location
        {
            get { return flight.FromLocation; }
            set
            {
                if (value != flight.FromLocation)
                {
                    flight.FromLocation = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Destination
        {
            get { return flight.ToLocation; }
            set
            {
                if (value != flight.ToLocation)
                {
                    flight.ToLocation = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime StartTime
        {
            get { return flight.StartTime; }
            set
            {
                if (value != flight.StartTime)
                {
                    flight.StartTime = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime EndTime
        {
            get { return flight.EndTime; }
            set
            {
                if (value != flight.EndTime)
                {
                    flight.EndTime = value;
                    OnPropertyChanged();
                }
            }
        }
        //public Flight Flight
        //{
        //	get => flight;
        //	set
        //	{
        //		flight = value;
        //		//TextEvent();       
        //		OnPropertyChanged();
        //	}
        //}
        private bool OnFindCanExecute()
        {
            return true;
        }


    }
}
