

namespace ksksk
{
    public class Student: User
    {

        public int Point { get; set; }
        public Student(string fullname, string email,  int point) : base(fullname, email, id)
        {
           Point = point;
        }
        public string StudentInfo()
        {
            return $"{Id},{Fullname},{Point}";
        }
    }
}
