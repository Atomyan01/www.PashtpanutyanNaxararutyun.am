namespace www.PashtpanutyanNaxararutyun.am.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public int Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string HealthStatus { get; set; }

        // Նորակոչիկի տվյալներ
        public string SpecialUnitInterest { get; set; } // Հատուկ ստորաբաժանման հանդեպ հետաքրքրություն
        public DateTime? SubmissionDate { get; set; } // Դիմումի ներկայացման ամսաթիվ (optional)
    }
}
