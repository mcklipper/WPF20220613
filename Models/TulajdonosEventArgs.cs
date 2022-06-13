using System;

namespace WPF20220613.Models
{
    public class TulajdonosEventArgs : EventArgs
    {
        public Tulajdonos? Tulajdonos { get; set; }

        public TulajdonosEventArgs(Tulajdonos? tulajdonos = null)
        {
            Random rnd = new();

            if (tulajdonos == null)
                Tulajdonos = new(rnd.Next(3, 9999999), "", "1970-01-01", "", null);
            else Tulajdonos = tulajdonos;
        }
    }
}
