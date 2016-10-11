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
        public FilmListView(FilmListViewModel model)
        {
            InitializeComponent();
            Model = model;
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

        }

        private void Directors(object sender, RoutedEventArgs e)
        {

        }

        private void Composers(object sender, RoutedEventArgs e)
        {

        }

        private void New(object sender, RoutedEventArgs e)
        {

        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Update(object sender, RoutedEventArgs e)
        {

        }

        private void Find(object sender, RoutedEventArgs e)
        {

        }

        private void Countries(object sender, RoutedEventArgs e)
        {

        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
