using System;
using System.Windows;
using System.Windows.Controls;
using WPF20220613.Models;

namespace WPF20220613.Views
{
    /// <summary>
    /// Interaction logic for SaveOwnerPage.xaml
    /// </summary>
    public partial class SaveOwnerPage : Page
    {
        public event EventHandler MegseClick;
        public event EventHandler<TulajdonosEventArgs> MentesClick;

        private readonly Tulajdonos tulajdonos;
        public SaveOwnerPage(Tulajdonos tulajdonos)
        {
            DataContext = tulajdonos;
            InitializeComponent();
            this.tulajdonos = tulajdonos;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) 
                || string.IsNullOrEmpty(tbPlaceOfBirth.Text) 
                || dpDateOfBirth.SelectedDate == null)
            {
                MessageBox.Show("Az adatokat kötelező megadni!");
                return;
            }

            tulajdonos.Nev = tbName.Text;
            tulajdonos.SzuletesiIdo = DateOnly.Parse(dpDateOfBirth.SelectedDate?.ToString("yyyy-MM-dd"));
            tulajdonos.SzuletesiHely = tbPlaceOfBirth.Text;

            MentesClick?.Invoke(this, new TulajdonosEventArgs(tulajdonos));
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            MegseClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
