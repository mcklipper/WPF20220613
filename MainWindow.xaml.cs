using System;
using System.Collections.ObjectModel;
using System.Windows;
using WPF20220613.Models;
using WPF20220613.Views;

namespace WPF20220613
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<Tulajdonos> tulajdonosok;

        public MainWindow()
        {
            tulajdonosok = new()
            {
                new Tulajdonos(1, "Egri Patrik", "1999-12-28", "Budapest", new() 
                { 
                    new Ingatlan(1, "Göd", "Petőfi Sándor", "utca", 48),
                    new Ingatlan(2, "Göd", "Pesti", "Út", 140, false)
                }),
                new Tulajdonos(2, "Farkas Balázs", "1997-08-17", "Budapest", new() 
                { 
                    new Ingatlan(1, "Budapest", "Váci", "út", 32),
                    new Ingatlan(2, "Vác", "Fecske", "utca", 2, false)
                })
            };

            InitializeComponent();

            ShowMainPage(null, EventArgs.Empty);
        }

        private void ShowSaveOwnerPage(object? sender, TulajdonosEventArgs e)
        {
            if (e.Tulajdonos != null)
            {
                var page = new SaveOwnerPage(e.Tulajdonos);
                page.MegseClick += ShowMainPage;
                page.MentesClick += AddOwner;
                page.MentesClick += ShowMainPage;
                frmMain.Content = page;
            }
        }

        private void ShowEstatesPage(object? sender, TulajdonosEventArgs e)
        {
            if (e.Tulajdonos != null && e.Tulajdonos.Ingatlanok != null)
            {
                var page = new EstatesPage(e.Tulajdonos.Ingatlanok);
                page.MegseClick += ShowMainPage;
                page.IngatlanClick += ShowSaveEstatePage;
                frmMain.Content = page;
            }
        }

        private void ShowSaveEstatePage(object? sender, IngatlanEventArgs e)
        {
            if (e.Ingatlan != null)
            {
                var page = new SaveEstatePage(e.Ingatlan);
                //page.MegseClick += ShowEstatesPage;
                frmMain.Content = page;
            }
        }

        private void AddOwner(object? sender, TulajdonosEventArgs e)
        {
            if (e.Tulajdonos != null && !tulajdonosok.Contains(e.Tulajdonos))
                tulajdonosok.Add(e.Tulajdonos);
        }

        private void ShowMainPage(object? sender, EventArgs e)
        {
            var page = new MainPage(tulajdonosok);
            page.UjTulajdonosClick += ShowSaveOwnerPage;
            page.TulajdonosTorlesClick += DeleteOwner;
            page.IngatlanokClick += ShowEstatesPage;

            frmMain.Content = page;
        }

        private void DeleteOwner(object? sender, TulajdonosEventArgs e)
        {
            if (e.Tulajdonos != null && tulajdonosok.Contains(e.Tulajdonos))
                tulajdonosok.Remove(e.Tulajdonos);
        }
    }
}
