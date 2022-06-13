using System;
using System.Windows;
using System.Windows.Controls;
using WPF20220613.Models;

namespace WPF20220613.Views
{
    /// <summary>
    /// Interaction logic for SaveEstatePage.xaml
    /// </summary>
    public partial class SaveEstatePage : Page
    {
        public event EventHandler MegseClick;
        public event EventHandler<IngatlanEventArgs> MentesClick;
        public Ingatlan Ingatlan { get; set; }
        
        public SaveEstatePage(Ingatlan ingatlan)
        {
            DataContext = this;
            Ingatlan = ingatlan;

            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
            => MegseClick?.Invoke(this, EventArgs.Empty);
    }
}
