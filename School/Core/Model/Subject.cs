namespace School.Core.Model
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public Sub Yonalish { get; set; }

        public ICollection<Exam> Exam { get; set; }

        public ICollection<Group> Groups { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
