using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WPF20220613.Models;

namespace WPF20220613.Views
{
    /// <summary>
    /// Interaction logic for EstatesPage.xaml
    /// </summary>
    public partial class EstatesPage : Page
    {
        public event EventHandler MegseClick;
        public event EventHandler<IngatlanEventArgs> IngatlanClick;

        public ObservableCollection<Ingatlan> Ingatlanok { get; }

        public EstatesPage(ObservableCollection<Ingatlan> ingatlanok)
        {
            DataContext = this;
            Ingatlanok = ingatlanok;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
            => IngatlanClick?.Invoke(this, new IngatlanEventArgs());
        
        private void CancelButton_Click(object sender, EventArgs e)
            => MegseClick?.Invoke(this, EventArgs.Empty);

        private void EditButton_Click(object sender, RoutedEventArgs e)
            => IngatlanClick?.Invoke(this, new IngatlanEventArgs((Ingatlan) dgMain.SelectedItem));

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
            => Ingatlanok.Remove((Ingatlan) dgMain.SelectedItem);
    }
}
