

namespace ksksk
{
    public class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }
        public Student[] Students = new Student[0];
        
        public bool CheckGroupNumber()
        {
            foreach (char i in GroupNo)
            {
                if (char.IsUpper(GroupNo[0])&& char.IsUpper(GroupNo[1]))
                {
                    return true;
                }
                else if (char.IsDigit(GroupNo[i]))
                {
                    return true;
                }
            }
            return false;
        }
        
        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit) {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
        }

        public Student GetStudent(int id, Student[] students)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    return student ;
                }
            }
            return null;
            
        }
         public void GetAllStudents()
        {
            foreach(var student in Students)
            {
                Console.WriteLine(student.StudentInfo());
            }
        }

        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Students = new Student[0];
        }


    }
}
