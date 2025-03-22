namespace www.PashtpanutyanNaxararutyun.am.Models
{
    public class UserModel
    {
        // Օգտատիրոջ ID
        public int Id { get; set; }

        // Օգտատիրոջ անունը
        public string FirstName { get; set; }

        // Օգտատիրոջ ազգանունը
        public string LastName { get; set; }

        // Էլեկտրոնային փոստի հասցե
        public string Email { get; set; }

        // Պահանջվող գաղտնաբառ (օրինակ՝ Hash-ի տեսքով)
        public string Password { get; set; }

        // Օգտատիրոջ կարգավիճակը (օրինակ՝ Admin, User, Soldier)
        public UserRole Role { get; set; }

        // Գրանցման ամսաթիվը
        public DateTime RegistrationDate { get; set; }
    }

    // Enum՝ Օգտատիրոջ կարգավիճակի համար
    public enum UserRole
    {
        Admin, // Ադմինիստրատոր
        User,  // Օգտագործող
        Soldier, // Զինվոր
        Recruit // Նորակոչիկ
    }
}

