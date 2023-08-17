namespace ThinKsaDev.ItDeveloper.Mvc.Extensions.ViewComponents.Helper
{
    public class CounterPatientStatus
    {
         // classe POCO - Plain Old CLR Object - classe simples
         //Objeto simples, sem herança ou atributos especiais., não depender de nenhum framework.

         public int Partial { get; set; }
        public string? Percent { get; set; }
        public string? ClassContainer { get; set; }
        public string? Title { get; set; }
        public decimal Progress { get; set; }
        public string? IconLg { get; set; }
        public string? IconSm { get; set; }

    }
}
