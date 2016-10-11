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
    /// Interaction logic for StringiDalog.xaml
    /// </summary>
    public partial class StringiDalog : Window
    {
        public StringiDalog()
        {
            InitializeComponent();
            DataContext = this;
            yourStringTextBox.Focus();
        }
        public bool Accept;

        public string WhatText
        {
            get { return (string)GetValue(WhatTextProperty); }
            set { SetValue(WhatTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WhatText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WhatTextProperty =
            DependencyProperty.Register("WhatText", typeof(string), typeof(StringiDalog), new PropertyMetadata(""));



        public string YourString
        {
            get { return (string)GetValue(YourStringProperty); }
            set { SetValue(YourStringProperty, value); }
        }

        // Using a DependencyProperty as the backing store for YourString.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty YourStringProperty =
            DependencyProperty.Register("YourString", typeof(string), typeof(StringiDalog), new PropertyMetadata(""));

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
