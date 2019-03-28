using Autofac;
using Prism.Events;
using TravelApp.DataAccess;
using TravelApp.DataServices;
using TravelApp.ViewModels;

namespace TravelApp.Startup
{
    public class BootStrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            ////builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            ////builder.RegisterType<FriendOrganizerDbContext>().AsSelf();
            //builder.RegisterType<MyStatDbContext>().AsSelf();
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainWindowModel>().AsSelf();
            builder.RegisterType<GoodJobViewModel>().AsSelf();

            builder.RegisterType<SignInViewModel>().AsSelf();
            builder.RegisterType<RegisterViewModel>().AsSelf();
            builder.RegisterType<PlanViewModel>().AsSelf();
            builder.RegisterType<HotelViewModel>().AsSelf();
            builder.RegisterType<SlideViewModel>().AsSelf();

            builder.RegisterType<ApplicationViewModel>().AsSelf();
            builder.RegisterType<ConcertViewModel>().AsSelf();
            builder.RegisterType<MuseumViewModel>().AsSelf();
            builder.RegisterType<ParkViewModel>().AsSelf();
            builder.RegisterType<RestaurantViewModel>().AsSelf();


            builder.RegisterType<StartViewModel>().AsSelf();
            builder.RegisterType<WelcomeViewModel>().AsSelf();
            builder.RegisterType<TravelDbContext>().AsSelf();

            builder.RegisterType<FlightViewModel>().AsSelf();
			builder.RegisterType<FindDealsViewModel>().AsSelf();
			builder.RegisterType<FindDeals2ViewModel>().AsSelf();
            ////builder.RegisterType<FriendDetailViewModel>().As<IFriendDetailViewModel>();

            ////builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<UserDataService>().As<IUserDataService>();

            return builder.Build();
        }
    }
}