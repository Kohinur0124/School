namespace School.Core.Model
{
    public class Teacher : Person, ITeacher
    {
        [Key]
        public int TeacherId { get; set; }

        public override string FullName { get; set; }
        
        public override string DOB { get; set; }
        
        public DateTime Kirgan_yil { get; set; }
        
        public int SubjectId { get; set; }
        
        public override string PhoneNumber { get; set; }
        
        public override string Password { get; set; }
        
        public override int Mark { get; set; }

        public Subject Subject { get; set; }

        public ICollection <Group> Groups { get; set; }

    }
}
