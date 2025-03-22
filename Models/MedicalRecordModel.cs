namespace www.PashtpanutyanNaxararutyun.am.Models
{
    public class MedicalRecordModel
    {
        // Բժշկական գրառման ID
        public int Id { get; set; }

        // Նորակոչիկի ID (կապվում է PersonModel-ով)
        public int SoldierId { get; set; }

        // Բժշկի անունը
        public string DoctorName { get; set; }

        // Հանդիպման ամսաթիվ
        public DateTime AppointmentDate { get; set; }

        // Օգտատիրոջ նշած ախտանիշները
        public string Symptoms { get; set; }

        // Բժշկի կողմից առաջարկված բուժման պլան
        public string TreatmentPlan { get; set; }

        // Բժշկական գրառման կարգավիճակը
        public MedicalRecordStatus Status { get; set; }
    }

    // Enum կարգավիճակների համար
    public enum MedicalRecordStatus
    {
        Pending,
        Completed,
        Canceled
    }
}
