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
using FilmEditor2.Core.Model;

namespace FilmEditor2.Views.BaseViews
{
    /// <summary>
    /// Interaction logic for CountryView.xaml
    /// </summary>
    public partial class CountryView : Window
    {
        public CountryView(Country country)
        {
            InitializeComponent();
            Country = country;
            DataContext = Country;
        }


        public Country Country
        {
            get { return (Country)GetValue(CountryProperty); }
            set { SetValue(CountryProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Country.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountryProperty =
            DependencyProperty.Register("Country", typeof(Country), typeof(CountryView), new PropertyMetadata(null));



        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
