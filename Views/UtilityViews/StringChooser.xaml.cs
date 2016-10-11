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
    /// Interaction logic for StringChooser.xaml
    /// </summary>
    public partial class StringChooser : Window
    {
        public StringChooser(List<string> choices)
        {
            InitializeComponent();
            Choices = choices;
            DataContext = this;
        }

       public  bool Accepted;


        public List<string> Choices
        {
            get { return (List<string>)GetValue(ChoicesProperty); }
            set { SetValue(ChoicesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Choices.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChoicesProperty =
            DependencyProperty.Register("Choices", typeof(List<string>), typeof(StringChooser), new PropertyMetadata(null));



        public string ChosenString
        {
            get { return (string)GetValue(ChosenStringProperty); }
            set { SetValue(ChosenStringProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ChosenString.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChosenStringProperty =
            DependencyProperty.Register("ChosenString", typeof(string), typeof(StringChooser), new PropertyMetadata(""));

        private void Accept(object sender, RoutedEventArgs e)
        {
            Accepted = true;
            Close();
        }

        private void Reject(object sender, RoutedEventArgs e)
        {
            Accepted = false;
            Close();
        }
    }
}
