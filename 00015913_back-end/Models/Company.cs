namespace _00015913_back_end.Models
{
    /*     00015913      */
    public class Company
    {
        public int CompanyId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Address { get; set; }

        // Navigation Property
        public ICollection<JobPost> JobPosts { get; set; }
    }

}


/*     00015913      */