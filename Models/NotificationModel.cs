namespace www.PashtpanutyanNaxararutyun.am.Models
{
    public class NotificationModel
    {
        // Ծանուցման ID
        public int Id { get; set; }

        // Օգտատիրոջ ID, ով կստանա ծանուցումը
        public int UserId { get; set; }

        // Ծանուցման թեման (օրինակ՝ հանդիպման հիշեցում, բժշկական արդյունք)
        public string Title { get; set; }

        // Ծանուցման բովանդակությունը
        public string Message { get; set; }

        // Ծանուցման տիպը (օրինակ՝ տեղեկություն, ահազանգ, հիշեցում)
        public NotificationType Type { get; set; }

        // Ծանուցման ամսաթիվը
        public DateTime CreatedDate { get; set; }

        // Ծանուցման կարգավիճակը (դիտվել է թե ոչ)
        public bool IsRead { get; set; }
    }

    // Enum՝ Ծանուցման տեսակների համար
    public enum NotificationType
    {
        Info,    // Տեղեկություն
        Alert,   // Ահազանգ
        Reminder // Հիշեցում
    }
}

