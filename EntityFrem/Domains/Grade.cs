using System.Collections.Generic;

namespace EntityFrem.Domains
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
