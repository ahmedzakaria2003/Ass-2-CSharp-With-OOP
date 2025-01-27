using System.Security.Cryptography.X509Certificates;

namespace Ass2_CSharp_with_oop
{
    #region MyRegion 1
    //struct Person
    //{
    //    public int Id;
    //    public string Name;



    //    public Person(string? name, int id)
    //    {

    //        this.Name = name;
    //        this.Id = id;

    //    }
}
#endregion

#region MyRegion 2
//struct Point
//{
//    public double X;
//    public double Y;

//    public Point(double x, double y)
//    {
//        this.X = x;
//        this.Y = y;

//    }

//    public double Distance(Point p)
//    {
//        {
//            return Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2));

//        }

//    }
//}
#endregion

#region MyRegion 3
//enum SecurityLevel
//{
//    guest,
//    Developer,
//    secretary,
//    DBA

//}

//struct HiringDate
//{
//    public int day;
//    public int month;
//    public int year;

//    public override string ToString()
//    {
//        return $"{day:D2}/{month:D2}/{year}";
//    }
//}

class Employee
{

    #region Attribute
    //public int Id { get; set; }
    //public string? Name { get; set; }
    //public SecurityLevel securityLevel { get; set; }
    //public HiringDate hiringDate { get; set; }
    //public decimal Salary { get; set; }
    //public char gender;
    #endregion

    #region Proberty
    //public char Gender
    //{
    //    get { return gender; }
    //    set
    //    {
    //        if (value == 'F' || value == 'M')
    //            gender = value;
    //        else
    //        {
    //            throw new ArgumentException("Gender must be one of Male or Female (M/F)");
    //        }

    //    }


    //}
    #endregion

    #region Constructor

    //public Employee(int id, string? name, SecurityLevel securityLevel, HiringDate hiringDate, decimal Salary, char gender)
    //{
    //    this.Id = id;
    //    this.Name = name;
    //    this.securityLevel = securityLevel;
    //    this.hiringDate = hiringDate;
    //    this.Salary = Salary;
    //    this.Gender = gender;

    //}

    #endregion

    #region Method
    //public override string ToString()
    //{
    //    return $"Id={Id}, Name{Name} , Gender{gender} , Salary {Salary} , HiringDate{hiringDate} ";
    //}


    //public static int CompareHiaringDate(Employee e1, Employee e2)
    //{
    //    DateTime date1 = new DateTime(e1.hiringDate.year, e1.hiringDate.month, e1.hiringDate.day);
    //    DateTime date2 = new DateTime(e2.hiringDate.year, e2.hiringDate.month, e2.hiringDate.day);
    //    return date1.CompareTo(date2);
    //}

    #endregion
}
#endregion


internal class Program
{
    static void Main(string[] args)
    {

        #region MyRegion 1
        //Person[] person = new Person[3];
        //person[0] = new Person { Id = 1, Name = "Ahmed" };
        //person[1] = new Person { Id = 2, Name = "Abdo" };
        //person[2] = new Person { Id = 3, Name = "zeko" };


        //foreach (var p in person)
        //{

        //    Console.WriteLine($"Name= {p.Name}\nId={p.Id} ");
        //}
        #endregion

        #region MyRegion 2
        //Console.WriteLine("Enter point 1");

        //Point p = new Point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        //Console.WriteLine("Enter point 2 ");
        //Point p2 = new Point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

        //Console.WriteLine($" {p.Distance(p2)}");

        #endregion

        #region MyRegion 3
        //Person[] newPerson = new Person[3];
        //for (int i = 0; i < newPerson.Length; i++)
        //{
        //    Console.WriteLine($"Enter NAME {i + 1} ");
        //    string? name = Console.ReadLine();
        //    Console.WriteLine($"Enter  ID {i + 1} ");
        //    int id;
        //    while (!int.TryParse(Console.ReadLine(), out id) || id <= 0)
        //    {

        //        Console.WriteLine("Enter Avalid Id");
        //    }

        //    newPerson[i] = new Person { Name = name!, Id = id };
        //}
        //Person Oldest = newPerson[0];
        //foreach (Person person in newPerson)
        //{
        //    if (person.Id > Oldest.Id)
        //    {
        //        Oldest = person;

        //    }
        //}
        //Console.WriteLine($"The Oldest Person is {Oldest.Name}");

        #endregion

        #region MyRegion 4 
        //Employee[] employee = new Employee[3];

        //employee[0] = new Employee(1, "AHMED",SecurityLevel.DBA ,new HiringDate {day =1 ,month=12 , year = 2025} , 5000 , 'M' );
        //employee[1] = new Employee(2, "ALI", SecurityLevel.Developer, new HiringDate { day = 1, month = 12, year = 2024 }, 6000, 'M');
        //employee[2] = new Employee(3, "MOSTAFA", SecurityLevel.guest, new HiringDate { day = 1, month = 12, year = 2023 }, 7000, 'M');

        //foreach (Employee emp in employee) {
        //    Console.WriteLine(emp);

        //}

        //Console.WriteLine("\n After Sorted");
        //Array.Sort(employee ,Employee.CompareHiaringDate);
        //foreach (Employee emp in employee)
        //{
        //    Console.WriteLine(emp);

        //}

        //int boxingCount = 0;    
        //foreach (Employee emp in employee) {

        //    object obj = emp; //Boxing
        //    Employee Unboxed = (Employee) obj; //Unboxing 
        //    boxingCount++;  

        //}
        //Console.WriteLine($"Boxing/Unboxing Occured {boxingCount} Times  ");

        #endregion
    }
}
