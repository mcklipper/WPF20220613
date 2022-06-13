using System;
using System.Collections.ObjectModel;

namespace WPF20220613.Models
{
    public class Tulajdonos
    {
        public int Id { get; set; }
        public string? Nev { get; set; }
        public DateOnly SzuletesiIdo { get; set; }
        public string? SzuletesiHely { get; set; }
        public ObservableCollection<Ingatlan>? Ingatlanok { get; set; }

        public Tulajdonos(
            int id, 
            string? nev, 
            string szuletesiIdo, 
            string? szuletesiHely,
            ObservableCollection<Ingatlan>? ingatlanok
        ) {
            Id = id;
            Nev = nev;
            SzuletesiIdo = DateOnly.Parse(szuletesiIdo);
            SzuletesiHely = szuletesiHely;
            Ingatlanok = ingatlanok;
        }
    }
}
