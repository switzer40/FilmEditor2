﻿using FilmEditor2.Core.Abstractions;
using FilmEditor2.Infrastructure.ConcreteRepositories.InMemory;
using FilmEditor2.ViewModels;
using FilmEditor2.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FilmEditor2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void FilmPanel(object sender, RoutedEventArgs e)
        {
            InMemoryRepositoryFactory factory = new InMemoryRepositoryFactory();
            FilmRepository filmRepo = factory.CreateFilmRepository();
            filmRepo.AddRange(SeedCollection._baseFilmList);
            FilmListViewModel model = new FilmListViewModel(factory);
            FilmListView filmView = new FilmListView(model);
            filmView.Show();            
        }

        private void PersonPanel(object sender, RoutedEventArgs e)
        {

        }

        private void CountryPanel(object sender, RoutedEventArgs e)
        {

        }

        private void LocationPanel(object sender, RoutedEventArgs e)
        {

        }
    }
}
