namespace _00015913_back_end.Models
{

    /*     00015913      */
    public class JobPost
    {
        public int JobPostId { get; set; } // Primary Key
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostedDate { get; set; }
        public int CompanyId { get; set; } // Foreign Key

        // Navigation Property
        public Company Company { get; set; }
    }

}
/*     00015913      */