using FilmEditor2.Core.Abstractions;
using FilmEditor2.Core.Interfaces;
using FilmEditor2.Core.Model;
using FilmEditor2.ViewModels;
using FilmEditor2.Views.BaseViews;
using FilmEditor2.Views.UtilityViews;
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
    /// Interaction logic for PersonListView.xaml
    /// </summary>
    public partial class PersonListView : Window
    {
        private IRepositoryFactory _factory;
        public PersonListView(IRepositoryFactory factory)
        {
            InitializeComponent();
            _factory = factory;
            Model = new PersonListViewModel(factory);
            DataContext = Model;
        }




        public PersonListViewModel Model
        {
            get { return (PersonListViewModel)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Model.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ModelProperty =
            DependencyProperty.Register("Model", typeof(PersonListViewModel), typeof(PersonListView), new PropertyMetadata(null));




        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Find(object sender, RoutedEventArgs e)
        {
            Person p = PersonToLookup();
            PersonView view = new PersonView(p);
            view.Show();           
        }

        private Person PersonToLookup()
        {
            Person result = null;
            StringiDalog dialog = new StringiDalog();
            dialog.WhatText = "A partial Last Name";
            dialog.ShowDialog();
            if (dialog.Accept)
            {
                string lastName = dialog.YourString;
                PersonRepository personRepo = _factory.CreatePersonRepository();
                List<Person> candidates = personRepo.ListByLastName(lastName) as List<Person>;
                switch (candidates.Count)
                {
                    case 0:
                        FilmMessageBox box = new FilmMessageBox();
                        box.Message = "No known person has a last name containing " + lastName;
                        box.Show();
                        break;
                    case 1:
                        result = candidates[0];
                        break;
                    default:
                        List<string> nameList = NameList(candidates);
                        StringChooser chooser = new StringChooser(nameList);
                        chooser.ShowDialog();
                        if (chooser.Accepted)
                        {
                            string fullName = chooser.ChosenString;
                            result = personRepo.GetByFullName(fullName);
                        }
                        break;
                    }
                }
                return result;
            }
            
       

    


        private List<string> NameList(List<Person> candidates)
        {
            throw new NotImplementedException();
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

        private void PlayedIn(object sender, RoutedEventArgs e)
        {

        }

        private void Directed(object sender, RoutedEventArgs e)
        {

        }

        private void Composed(object sender, RoutedEventArgs e)
        {

        }
    }
}
