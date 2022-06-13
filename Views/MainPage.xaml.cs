using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using WPF20220613.Models;

namespace WPF20220613.Views
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public event EventHandler<TulajdonosEventArgs> UjTulajdonosClick;
        public event EventHandler<TulajdonosEventArgs> TulajdonosTorlesClick;
        public event EventHandler<TulajdonosEventArgs> IngatlanokClick;
        public ObservableCollection<Tulajdonos> Tulajdonosok { get; set; }

        public MainPage(ObservableCollection<Tulajdonos> tulajdonosok)
        {
            DataContext = this;
            Tulajdonosok = tulajdonosok;

            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            UjTulajdonosClick?.Invoke(this, new TulajdonosEventArgs());
        }

        private void EditButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            UjTulajdonosClick?.Invoke(this, new TulajdonosEventArgs((Tulajdonos) dgMain.SelectedItem));
        }

        private void DeleteButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            TulajdonosTorlesClick?.Invoke(this, new TulajdonosEventArgs((Tulajdonos) dgMain.SelectedItem));
        }

        private void ShowEstatesButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            IngatlanokClick?.Invoke(this, new TulajdonosEventArgs((Tulajdonos) dgMain.SelectedItem));
        }
    }
}
