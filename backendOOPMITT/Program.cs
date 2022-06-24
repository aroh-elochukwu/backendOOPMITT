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

class Student
{
    public string Name { get; set; }
    public string Birthdate { get; set; }
    public string Nationality { get; set; }
    public List<Course> Courses { get; set; }

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
}

class Course
{
    public string Name { get; set; }
    public int Duration { get; set; }
    public int Credits { get; set; }


}