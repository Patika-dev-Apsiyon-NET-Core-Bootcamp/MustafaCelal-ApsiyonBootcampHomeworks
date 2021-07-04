namespace H_3_2_EFCore_CodeFirst.Models
{
    public class Comment {
        public int Id { get; set; }
        public User User { get; set; }
        public Movie Movie { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// 10 üzerinden
        /// </summary>
        public int Star { get; set; }
    }
}