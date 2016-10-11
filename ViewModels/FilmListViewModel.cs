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
                bool bluray = dialog.IsBlurayOnly;
                CurrentFilm = _filmRepository.GetByTitelAndType(title, bluray);
                FilmView view = new FilmView(CurrentFilm);
                view.Show();

            }
        }

        // Using a DependencyProperty as the backing store for CurrentFilm.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentFilmProperty =
            DependencyProperty.Register("CurrentFilm", typeof(Film), typeof(FilmListViewModel), new PropertyMetadata(null));

    }
}


   
