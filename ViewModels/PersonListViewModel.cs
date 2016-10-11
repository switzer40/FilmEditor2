using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmEditor2.Core.Model;
using FilmEditor2.Core.Interfaces;
using FilmEditor2.Core.Abstractions;

namespace FilmEditor2.ViewModels
{
    public class PersonListViewModel : DependencyObject
    {
        private IRepositoryFactory _factory;
        private PersonRepository _personRepository;
        public PersonListViewModel(IRepositoryFactory factory)
        {
            _factory = factory;
            _personRepository = _factory.CreatePersonRepository();
            People = new ObservableCollection<Person>(_personRepository.List());
            CurrentPerson = _personRepository.List().FirstOrDefault();
        }

        public ObservableCollection<Person> People
        {
            get { return (ObservableCollection<Person>)GetValue(PeopleProperty); }
            set { SetValue(PeopleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for People.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PeopleProperty =
            DependencyProperty.Register("People", typeof(ObservableCollection<Person>), typeof(PersonListViewModel), new PropertyMetadata(null));



        public Person CurrentPerson
        {
            get { return (Person)GetValue(CurrentPersonProperty); }
            set { SetValue(CurrentPersonProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPerson.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPersonProperty =
            DependencyProperty.Register("CurrentPerson", typeof(Person), typeof(PersonListViewModel), new PropertyMetadata(null));


    }
}
