class Student
{
    public string Name { get; set; }
    public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    public Student(string name)
    {
        Name = name;
    }
}

class Course
{
    public string Name { get; set; }   
    public int Number { get; set; }
    public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    public Course(string name, int number )
    {
        Name = name;
        Number = number;
    
    }
}

static class School
{
    public static string Name { get; set; } = "MITT";
    public static List<Course> Courses { get; set; } = new List<Course>();
    public static List<Student> Students { get; set; } = new List<Student>();
    public static List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public static Student AdmitStudent(string name)
    {
        Student newStudent = new Student(name);
        Students.Add(newStudent);
        return newStudent;
    }

    public static void AddCourse (string name, int number)
    {
        Course newCourse = new Course(name, number);
        Courses.Add(newCourse);
    }

    public static void AddStudentToCourse(Student student, Course course, int grade)
    {
        Enrollment newEnrollment = new Enrollment(student, course, grade);
        newEnrollment.EnrollmentID = Enrollments.Count + 1;  
        
        student.Enrollments.Add(newEnrollment);
        course.Enrollments.Add(newEnrollment);
        Enrollments.Add(newEnrollment);
    }

    public static Course GetCourseByNum(int number)
    {
        foreach(Course course in Courses)
        {
            if (course.Number == number )
            {
                return course;
            }
        }

        return null;
    }

    public static Student GetStudentByName(string name)
    {
        foreach (Student student in Students)
        {
            if ( string.Equals(student.Name, name))
            {
                return student;
            }
        }
        return null;
    }

}

// change the system so that instead of adding students to list of courses and vice-versa,
// we use an Enrollment class to handle when students are added 

class Enrollment
{
    public int EnrollmentID { get; set; } 
    public Student Student { get; set; }
    public Course Course { get; set; }
    public int Grade { get; set; }
    public Enrollment(Student student, Course course,int grade )
    {
        Student = student;
        Grade = grade;
        Course = course;

    }

}








