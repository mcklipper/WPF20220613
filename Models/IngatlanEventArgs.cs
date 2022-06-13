using System;

namespace WPF20220613.Models
{
    public class IngatlanEventArgs : EventArgs
    {
        public Ingatlan? Ingatlan { get; set; }

        public IngatlanEventArgs(Ingatlan? ingatlan = null)
        {
            Random rnd = new();

            if (ingatlan == null)
                Ingatlan = new(rnd.Next(3, 999999), "", "", "", 0, false);
            else Ingatlan = ingatlan;
        }
    }
}
