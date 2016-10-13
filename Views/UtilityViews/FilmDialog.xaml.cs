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

namespace FilmEditor2.Views.UtilityViews
{
    /// <summary>
    /// Interaction logic for FilmDialog.xaml
    /// </summary>
    public partial class FilmDialog : Window
    {
        public FilmDialog()
        {
            InitializeComponent();
        }
        public bool Accept;


        public string FilmTitle
        {
            get { return (string)GetValue(FilmTitleProperty); }
            set { SetValue(FilmTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilmTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilmTitleProperty =
            DependencyProperty.Register("FilmTitle", typeof(string), typeof(FilmDialog), new PropertyMetadata(""));



        public bool IsBluray
        {
            get { return (bool)GetValue(IsBlurayProperty); }
            set { SetValue(IsBlurayProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsBluray.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsBlurayProperty =
            DependencyProperty.Register("IsBluray", typeof(bool), typeof(FilmDialog), new PropertyMetadata(false));



        private void DoAccept(object sender, RoutedEventArgs e)
        {
            Accept = true;
            Close();
        }

        private void DoReject(object sender, RoutedEventArgs e)
        {
            Accept = false;
            Close();
        }
    }
}
