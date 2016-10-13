using FilmEditor2.Core.Interfaces;
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

namespace FilmEditor2.Views.ListViews
{
    /// <summary>
    /// Interaction logic for CountryListView.xaml
    /// </summary>
    public partial class CountryListView : Window
    {
        private IRepositoryFactory _factory;
        public CountryListView(IRepositoryFactory factory)
        {
            InitializeComponent();
            _factory = factory;
            Model = new CountryListViewModel(factory);
            DataContext = Model;
        }




        public CountryListViewModel Model
        {
            get { return (CountryListViewModel)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Model.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ModelProperty =
            DependencyProperty.Register("Model", typeof(CountryListViewModel), typeof(CountryListView), new PropertyMetadata(null));




        private void countryListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void countryListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Find(object sender, RoutedEventArgs e)
        {
            Model.Find();
        }

        private void New(object sender, RoutedEventArgs e)
        {
            Model.New();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Model.Save();
        }

        private void Derlete(object sender, RoutedEventArgs e)
        {
            Model.Delete();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            Model.Update();
        }
    }
}
