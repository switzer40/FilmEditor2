using FilmEditor2.Core.Abstractions;
using FilmEditor2.Core.Interfaces;
using FilmEditor2.Infrastructure.ConcreteRepositories.InMemory;
using FilmEditor2.ViewModels;
using FilmEditor2.Views;
using FilmEditor2.Views.ListViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FilmEditor2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IRepositoryFactory _factory;
        public MainWindow()
        {
            InitializeComponent();
            _factory = new InMemoryRepositoryFactory();
            PopulteRepositories();
        }

        private void PopulteRepositories()
        {
            FilmRepository filmRepo = _factory.CreateFilmRepository();
            filmRepo.AddRange(SeedCollection._baseFilmList);
            PersonRepository personRepo = _factory.CreatePersonRepository();
            personRepo.AddRange(SeedCollection._basePersonList);
            CountryRepository countryRepo = _factory.CreateCountryRepository();
            countryRepo.AddRange(SeedCollection._baseCountryList);
            LocationRepository locationRepo = _factory.CreateLocationRepository();
            locationRepo.AddRange(SeedCollection._baseLocationist);
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void FilmPanel(object sender, RoutedEventArgs e)
        {                                                 
            FilmListView filmView = new FilmListView(_factory);
            filmView.Show();            
        }

        private void PersonPanel(object sender, RoutedEventArgs e)
        {                               
            PersonListView personView = new PersonListView(_factory);
            personView.Show();
        }

        private void CountryPanel(object sender, RoutedEventArgs e)
        {
            CountryListView countryView = new CountryListView(_factory);
            countryView.Show();

        }

        private void LocationPanel(object sender, RoutedEventArgs e)
        {

        }
    }
}
