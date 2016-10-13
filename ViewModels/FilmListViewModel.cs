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
using FilmEditor2.Views;
using FilmEditor2.Views.UtilityViews;

namespace FilmEditor2.ViewModels
{
    public class FilmListViewModel : DependencyObject
    {
        private IRepositoryFactory _factory;
        private FilmRepository _filmRepository;
        public FilmListViewModel(IRepositoryFactory factory)
        {
            _factory = factory;
            _filmRepository = factory.CreateFilmRepository();
            Films = new ObservableCollection<Film>(_filmRepository.List());
            CurrentFilm = _filmRepository.List().FirstOrDefault();
        }



        public ObservableCollection<Film> Films
        {
            get { return (ObservableCollection<Film>)GetValue(FilmsProperty); }
            set { SetValue(FilmsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Films.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilmsProperty =
            DependencyProperty.Register("Films", typeof(ObservableCollection<Film>), typeof(FilmListViewModel), new PropertyMetadata(null));



        public Film CurrentFilm
        {
            get { return (Film)GetValue(CurrentFilmProperty); }
            set { SetValue(CurrentFilmProperty, value); }
        }



        internal void New()
        {
            CurrentFilm = new Film();
        }

        internal void ShowContributors(Role role)
        {
            FilmPersonRepository filmPersonRepo = _factory.CreateFilmPersonRepository();
            PersonRepository personRepo = _factory.CreatePersonRepository();
            List<Guid> ids = filmPersonRepo.ListPersonIdsForFilmIdAndRole(CurrentFilm.Id, role) as List<Guid>;
            List<string> fullNames = new List<string>();
            foreach (Guid g in ids)
            {
                Person p = personRepo.GetById(g);
                fullNames.Add(p.FullName);
            }
            StringChooser chooser = new StringChooser(fullNames);
            chooser.Show();
        }
        

        internal void Save()
        {
            CurrentFilm = _filmRepository.Add(CurrentFilm);
        }

        internal void Delete()
        {
            _filmRepository.Delete(CurrentFilm);
            CurrentFilm = _filmRepository.List().FirstOrDefault();
        }
        internal void Update()
        {
            _filmRepository.Update(CurrentFilm);
        }

        internal void Find()
        {
            FilmDialog dialog = new FilmDialog();
            dialog.ShowDialog();
            if (dialog.Accept)
            {
                string title = dialog.FilmTitle;
                bool bluray = dialog.IsBluray;
                CurrentFilm = _filmRepository.GetByTitelAndType(title, bluray);
                FilmView view = new FilmView(CurrentFilm);
                view.Show();

            }
        }

        internal void ShowCountries()
        {
            FilmCountryRepository fcRepo = _factory.CreateFilmCountryRepository();
            CountryRepository cRepo = _factory.CreateCountryRepository();
            List<Guid> ids = fcRepo.ListCountryIdsForFilmId(CurrentFilm.Id) as List<Guid>;
            List<string> names = new List<string>();          
            foreach(Guid g in ids)
            {
                Country c = cRepo.GetById(g);
                names.Add(c.Name);
            }
            if (names.Count == 0)
            {
                FilmMessageBox box = new FilmMessageBox("There are as yet no countries defined for this film.");
                box.Show();
            }
            else
            {
                StringChooser chooser = new StringChooser(names);
                chooser.Show();
            }
           
        }

        // Using a DependencyProperty as the backing store for CurrentFilm.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentFilmProperty =
            DependencyProperty.Register("CurrentFilm", typeof(Film), typeof(FilmListViewModel), new PropertyMetadata(null));

        internal void AddContributor(Role role)
        {
            string lastName = GetAString("A partial last name");
            Person p = GetPersonByLastName(lastName);
            FilmPersonRepository filmPersonRepo = _factory.CreateFilmPersonRepository();
            FilmPerson fp = new FilmPerson();
            fp.FilmId = CurrentFilm.Id;
            fp.PersonId = p.Id;
            fp.Roles.Add(role);
            filmPersonRepo.Add(fp);
        }

        private Person GetPersonByLastName(string lastName)
        {
            Person result = null;
            PersonRepository personRepo = _factory.CreatePersonRepository();
            List<Person> candidates = personRepo.ListByLastName(lastName) as List<Person>;
            switch(candidates.Count)
            {
                case 0:
                    FilmMessageBox box = new FilmMessageBox("The database knows no person with last name containing " + lastName);                    
                    box.Show();
                    break;
                case 1:
                    result = candidates[0];
                    break;
                default:
                    result = ChooseOnePerson(candidates);
                    break;
            }
            return result;
        }

        private Person ChooseOnePerson(List<Person> candidates)
        {
            Person result = null;
            List<string> fullNames = new List<string>();
            PersonRepository personRepo = _factory.CreatePersonRepository();
            foreach(Person p in candidates)
            {
                fullNames.Add(p.FullName);
            }
            StringChooser chooser = new StringChooser(fullNames);
            chooser.ShowDialog();
            if (chooser.Accepted)
            {
                string fullName = chooser.ChosenString;
                result = personRepo.GetByFullName(fullName);
            }               
            return result;
        }

        private string GetAString(string whatToAskFor)
        {
            string result = "";
            StringiDalog dialog = new StringiDalog();
            dialog.WhatText = whatToAskFor;
            dialog.ShowDialog();
            if (dialog.Accept)
                result = dialog.YourString;
            return result;
        }

        public void AddCountry()
        {
            string abbrev = GetAString("A country abbreviation");
            CountryRepository countryRepo = _factory.CreateCountryRepository();
            Country c = countryRepo.GetByAbreviation(abbrev);
            FilmCountry fc = new FilmCountry();
            fc.FilmId = CurrentFilm.Id;
            fc.CountryId = c.Id;
            FilmCountryRepository filmCountryRepo = _factory.CreateFilmCountryRepository();
            filmCountryRepo.Add(fc);            
        }
    }
}


   
