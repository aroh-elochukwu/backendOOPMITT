/*  

  Create a class "Student" that contains few student properties
like (Name, Birthdate, Nationality)and 2 different constructors, one that takes only

the name and another one that takes all the fields

- Create another class called "Course", a course has
a Name, Duration in months, and number of credits.

- In the Student class, create another property for
Students called "Courses", which is a list of courses
that a student is enrolled in

-In Student class, write two functions, JoinCourse and
LeaveCourse to handle the enrollment

-Also write a function PrintAllcourses in Student

-Change the student class so the student can only have
*/
Student Elo = new Student("Elo", "16th June", "Nigerian");
Course SD419 = new Course("Wayo", 4, 3);
Course SD5000 = new Course("Something Something", 2, 2);
Elo.JoinClass(SD419);
Elo.JoinClass(SD5000);
Console.WriteLine(Elo.Courses[0].Name);
Console.WriteLine(Elo.Courses[1].Name);



class Student
{
    public string Name { get; set; }
    public string Birthdate { get; set; }
    public string Nationality { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();

    public Student(string name)
    {
        Name = name;

    }

    public Student(string name, string birthdate, string nationality)
    {
        Name = name;
        Birthdate = birthdate;
        Nationality = nationality;

            
    }

    public void JoinClass(Course course)
    {
        Courses.Add(course);

    }

    public void LeaveClass(Course course)
    {
        Courses.Remove(course);

    }
   
}


class Course
{
    public string Name { get; set; }
    public int Duration { get; set; }
    public int Credits { get; set; }

    public Course(string name, int duration, int credits)
    {
        Name = name;
        Duration = duration;
        Credits = credits;
    }
    }