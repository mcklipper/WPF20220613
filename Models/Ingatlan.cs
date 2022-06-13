namespace WPF20220613.Models
{
    public class Ingatlan
    {
        public int Id { get; set; }
        public string? Varos { get; set; }
        public string? KozteruletNeve { get; set; }
        public string? KozteruletJellege { get; set; }
        public int Hazszam { get; set; }
        public bool AllandoE { get; set; }

        public Ingatlan(
            int id, 
            string? varos,
            string? kozteruletNeve, 
            string? kozteruletJellege, 
            int hazszam, 
            bool allandoE = true
        ) {
            Id = id;
            Varos = varos;
            KozteruletNeve = kozteruletNeve;
            KozteruletJellege = kozteruletJellege;
            Hazszam = hazszam;
            AllandoE = allandoE;
        }
    }
}
