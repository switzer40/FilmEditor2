using FilmEditor2.Core.Abstractions;
using FilmEditor2.Core.Interfaces;
using FilmEditor2.Core.Model;
using FilmEditor2.ViewModels;
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
using System.Windows.Shapes;

namespace FilmEditor2.Views
{
    /// <summary>
    /// Interaction logic for FilmListView.xaml
    /// </summary>
    public partial class FilmListView : Window
    {
        private IRepositoryFactory _factory;
        private bool _doubleClicked = false;
        public FilmListView(IRepositoryFactory factory)
        {
            InitializeComponent();
            _factory = factory;
            FilmRepository filmRepo = _factory.CreateFilmRepository();
            Model = new FilmListViewModel(factory);
            DataContext = Model;
        }



        public FilmListViewModel Model
        {
            get { return (FilmListViewModel)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Model.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ModelProperty =
            DependencyProperty.Register("Model", typeof(FilmListViewModel), typeof(FilmListView), new PropertyMetadata(null));





        private void Actors(object sender, RoutedEventArgs e)
        {
            Model.ShowContributors(Role.Actor);
        }

        private void Directors(object sender, RoutedEventArgs e)
        {
            Model.ShowContributors(Role.Director);
        }

        private void Composers(object sender, RoutedEventArgs e)
        {
            Model.ShowContributors(Role.Composer);
        }

        private void New(object sender, RoutedEventArgs e)
        {
            Model.New();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Model.Save();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            Model.Delete();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            Model.Update();
        }

        private void Find(object sender, RoutedEventArgs e)
        {
            Model.Find();
        }

        private void Countries(object sender, RoutedEventArgs e)
        {
            Model.ShowCountries();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddActor(object sender, RoutedEventArgs e)
        {
            AddContributor(Role.Actor);
        }
        private void AddContributor(Role role)
        {
            Model.AddContributor(role);
        }

        private void AddDirector(object sender, RoutedEventArgs e)
        {
            AddContributor(Role.Director);
        }

        private void AddComposer(object sender, RoutedEventArgs e)
        {
            AddContributor(Role.Composer);
        }

        private void AddCountry(object sender, RoutedEventArgs e)
        {
            Model.AddCountry();
        }


        private void filmListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(_doubleClicked)
            {
                Model.CurrentFilm = e.AddedItems[0] as Film;
                _doubleClicked = false;
            }
            
        }

        private void filmListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _doubleClicked = true;
        }
        
    }
}