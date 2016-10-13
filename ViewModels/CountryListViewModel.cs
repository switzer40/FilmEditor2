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
using FilmEditor2.Views.BaseViews;
using FilmEditor2.Views.UtilityViews;

namespace FilmEditor2.ViewModels
{
    public class CountryListViewModel : DependencyObject
    {
        private IRepositoryFactory _factory;
        private CountryRepository _countryRepository;
        public CountryListViewModel(IRepositoryFactory factory)
        {
            _factory = factory;
            _countryRepository = factory.CreateCountryRepository();
            Countries = new ObservableCollection<Country>(_countryRepository.List());
            CurrentCountry = _countryRepository.List().FirstOrDefault();
        }


        public ObservableCollection<Country> Countries
        {
            get { return (ObservableCollection<Country>)GetValue(CountriesProperty); }
            set { SetValue(CountriesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Countries.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountriesProperty =
            DependencyProperty.Register("Countries", typeof(ObservableCollection<Country>), typeof(CountryListViewModel), new PropertyMetadata(null));



        public Country CurrentCountry
        {
            get { return (Country)GetValue(CurrentCountryProperty); }
            set { SetValue(CurrentCountryProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentCountry.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentCountryProperty =
            DependencyProperty.Register("CurrentCountry", typeof(Country), typeof(CountryListViewModel), new PropertyMetadata(null));

        internal void Find()
        {
            StringiDalog dialog = new StringiDalog();
            dialog.WhatText = "A country abbreviation";
            dialog.ShowDialog();
            if(dialog.Accept)
            {
                string abbreviation = dialog.YourString;
                var foundCountry = _countryRepository.GetByAbreviation(abbreviation);
                if(foundCountry != null)
                {
                    CurrentCountry = foundCountry;
                    CountryView view = new CountryView(CurrentCountry);
                    view.Show();
                }
                else
                {
                    FilmMessageBox box = new FilmMessageBox("No known country has abbreviation " + abbreviation);
                    box.Show();
                }
                
            }
        }

        internal void New()
        {
            throw new NotImplementedException();
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }

        internal void Delete()
        {
            throw new NotImplementedException();
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }
}
