namespace School.Core.Model
{
    public class Student :   Person, IStudent
    {
        [Key]
        public int StudentId { get; set; }

        public override string FullName { get; set; }
        
        public override string DOB { get; set; }
        
        public Sub Yonalish { get; set; }
        
        public int Grade { get; set; }
        
        public override string PhoneNumber { get; set; }
        
        public override string Password { get; set; }
        
        public override int Mark { get; set; }

        public ICollection<Group> Groups { get; set; }
        
    }
}
