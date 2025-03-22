namespace www.PashtpanutyanNaxararutyun.am.Models
{
    public class LeaveRequestModel
    {
        // Խնդրանքի ID
        public int Id { get; set; }

        // Զինվորի ID (կապվում է SoldierModel-ով)
        public int SoldierId { get; set; }

        // Արձակուրդի պատճառը (պատրաստակամ բացատրություն)
        public string Reason { get; set; }

        // Արձակուրդի սկիզբ (խնդրողի ցանկալի ժամկետ)
        public DateTime StartDate { get; set; }

        // Արձակուրդի ավարտ (խնդրողի ցանկալի ժամկետ)
        public DateTime EndDate { get; set; }

        // Կարգավիճակ (հաստատված, մերժված, սպասման մեջ)
        public LeaveRequestStatus Status { get; set; }

        // Նշում գնդապետից (այս տարածքում գնդապետը կարող է գրել իր որոշումը կամ մեկնաբանությունները)
        public string CommentsFromCommander { get; set; }

        // Խնդրանքի ներկայացման ամսաթիվ
        public DateTime RequestDate { get; set; }
    }

    // Enum՝ արձակուրդի խնդրանքի կարգավիճակների համար
    public enum LeaveRequestStatus
    {
        Pending,    // Սպասման մեջ
        Approved,   // Հաստատված
        Rejected    // Մերժված
    }
}

