Calendar myCalendar = new Calendar();

Date halloween = new Date("Halloween", 31);
myCalendar.Dates.Add(halloween);
Console.WriteLine(myCalendar.Dates.First().Title);


class Calendar
{
    public string Name { get; set; }
    public int year { get; set; }   
    public List<Date> Dates { get; set; }

    public Calendar()
    {
        Name = "Year 2000";
        year = 2000;
        Dates = new List<Date>();
    }

    //Overload

    public Calendar(string name, int year)
    {
        Name = name;
        year = year;
        Dates = new List<Date>();
    }
}



class Date
{
    public string Title { get; set; }
    private int _dayOfMonth { get; set; }

    public int DayOfMonth
    {
        get { return _dayOfMonth; }
        set
        {
            if(value > 0 && value <= 31)
            {
                _dayOfMonth = value;
            }
        }
       
    }

    public Date(string title, int day)
    {
        Title = title;
        DayOfMonth = day;
    }

}