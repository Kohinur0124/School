namespace School.Core.Model
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        public string Name { get; set; }

        public int SubjectId { get; set; }

        public int TeacherId { get; set; }

        public int Grade { get; set; }

        public Subject Subject { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
