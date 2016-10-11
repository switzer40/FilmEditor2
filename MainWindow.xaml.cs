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
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void FilmPanel(object sender, RoutedEventArgs e)
        {             
            FilmRepository filmRepo = _factory.CreateFilmRepository();
            filmRepo.AddRange(SeedCollection._baseFilmList);
            FilmListViewModel model = new FilmListViewModel(_factory);
            FilmListView filmView = new FilmListView(model);
            filmView.Show();            
        }

        private void PersonPanel(object sender, RoutedEventArgs e)
        {
            PersonRepository personRepo = this._factory.CreatePersonRepository();
            personRepo.AddRange(SeedCollection._basePersonList);           
            PersonListView personView = new PersonListView(_factory);
            personView.Show();
        }

        private void CountryPanel(object sender, RoutedEventArgs e)
        {
            

        }

        private void LocationPanel(object sender, RoutedEventArgs e)
        {

        }
    }
}
