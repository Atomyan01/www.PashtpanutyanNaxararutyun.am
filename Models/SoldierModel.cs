namespace www.PashtpanutyanNaxararutyun.am.Models
{
    public class SoldierModel
    {
        public string MilitaryRank { get; set; } // Զինվորական կոչում
        public string ServiceNumber { get; set; } // Ծառայության համար
        public string Unit { get; set; } // Բանակի ստորաբաժանում
        public DateTime EnlistmentDate { get; set; } // Ծառայության սկիզբ
        public DateTime? DischargeDate { get; set; } // Ծառայության ավարտ (եթե կա)
        public bool IsSpecialForces { get; set; } // Հատուկ ջոկատայինների անդամություն
    }
}
