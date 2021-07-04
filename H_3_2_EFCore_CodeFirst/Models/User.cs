using System.Collections.Generic;

namespace H_3_2_EFCore_CodeFirst.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}