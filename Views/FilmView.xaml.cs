using FilmEditor2.Core.Model;
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
using FilmEditor2.ViewModels;

namespace FilmEditor2.Views
{
    /// <summary>
    /// Interaction logic for FilmView.xaml
    /// </summary>
    public partial class FilmView : Window
    {
        public FilmView(Film film)
        {
            InitializeComponent();
            Film = film;
            DataContext = Film;
        }


        public Film Film
        {
            get { return (Film)GetValue(FilmProperty); }
            set { SetValue(FilmProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Film.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilmProperty =
            DependencyProperty.Register("Film", typeof(Film), typeof(FilmView), new PropertyMetadata(null));
        private FilmListViewModel model;

        private void SetLocation(object sender, RoutedEventArgs e)
        {

        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
