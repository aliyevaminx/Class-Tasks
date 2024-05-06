/////////////////////////////////////////////////////////////////////////////TASK1

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Animal animal1 = new Animal("ItinAdi", "ItinCinsi", "ItinRengi", 12);
//        animal1.GetDetails();

//    }
//}

//internal class Animal
//{
//    public string name;
//    public string breed;
//    public string color;
//    public int age;

//    public Animal(string name, string breed, string color, int age)
//    {
//        this.name = name;
//        this.breed = breed;
//        this.color = color;
//        this.age = age;
//    }

//    public void GetDetails()
//    {
//        Console.WriteLine($"{name}, {breed}, {color}, {age}");
//    }
//}


/////////////////////////////////////////////////////////////////////////////TASK2

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Building building1 = new Building("Code Academy", 200, 400, "Binanin adresi");
//        building1.GetDetails();
//    }
//}

//public class Building
//{
//    public string name;
//    public int height;
//    public int area;
//    public string address;

//    public Building(string name, int height, int area, string address)
//    {
//        this.name = name;
//        this.height = height;
//        this.area = area;
//        this.address = address;
//    }

//    public int GetVolume()
//    {

//        return height * area;
//    }
//    public void GetDetails()
//    {
//        Console.WriteLine($"{name}, {height}, {area}, {address}, Hecm: {GetVolume()}");
//    }
//}

/////////////////////////////////////////////////////////////////////////////TASK3

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Student student1 = new Student(
//            "Amin",
//            "Aliyev",
//            18,
//            new[] { 100, 94, 89, 99, 90, 78 },
//            new[] { 100, 89, 90, 95, 90, 88 },
//            new[] { 97, 93, 90, 100 },
//            100,
//            new[] { true, true, true, true, true, true, true }
//            );

//        student1.GetResultGrade();
//    }
//}

//class Student
//{
//    public string name;
//    public string surname;
//    public int age;
//    public int[] homeWorkGrades;
//    public int[] projectkGrades;
//    public int[] quizGrades;
//    public int finalGrade;
//    public bool[] continuity;

//    public Student(string name, string surname, int age, int[] homeWorkGrades, int[] projectkGrades, int[] quizGrades, int finalGrade, bool[] continuity)
//    {
//        this.name = name;
//        this.surname = surname;
//        this.age = age;
//        this.homeWorkGrades = homeWorkGrades;
//        this.projectkGrades = projectkGrades;
//        this.quizGrades = quizGrades;
//        this.finalGrade = finalGrade;
//        this.continuity = continuity;
//    }

//    public int GetAverageGrade(int[] grades)
//    {
//        int totalGrade = 0;

//        foreach (int grade in grades)
//        {
//            totalGrade += grade;
//        }

//        return totalGrade / grades.Length;
//    }

//    public int GetContinuityPoint(bool[] continuity)
//    {
//        int count = 0;

//        foreach (var isParticipate in continuity)
//        {
//            if (isParticipate)
//            {
//                count++;
//            }
//        }

//        return (count / continuity.Length) * 100;
//    }

//    public void GetResultGrade()
//    {
//        int homeWorkGrade = GetAverageGrade(homeWorkGrades);
//        int projectkGrade = GetAverageGrade(projectkGrades);
//        int quizGrade = GetAverageGrade(quizGrades);
//        int continuityPoint = GetContinuityPoint(continuity);

//        int result = (homeWorkGrade * 20) / 100 +
//                     (projectkGrade * 20) / 100 +
//                     (quizGrade * 20) / 100 +
//                     (finalGrade * 30) / 100 +
//                     (continuityPoint * 10) / 100;

//        if (result >= 95)
//        {
//            Console.WriteLine($"{result} - High Honour Degree");
//        }
//        else if (result >= 85)
//        {
//            Console.WriteLine($"{result} - Honour Degree");
//        }
//        else if (result >= 65)
//        {
//            Console.WriteLine($"{result} - Normal Degree");
//        }
//        else
//        {
//            Console.WriteLine($"{result} - Fail");
//        }
//    }
//}

/////////////////////////////////////////////////////////////////////////////TASK4

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Gun gun1 = new Gun("AK-47", 31, "assault");
//        Gun gun2 = new Gun("SVD", 20, "sniper");

//        InitialLine:  Console.WriteLine("Choose a gun type: Assault (A) / Sniper (S)");
//        System.ConsoleKeyInfo gunType = Console.ReadKey();
//        Console.WriteLine();

//        if (gunType.Key.ToString() == "A")
//        {
//            gun1.GetDetails();
//            gun1.ChooseAction();
//        } 
//        else if (gunType.Key.ToString() == "S")
//        {
//            gun2.GetDetails();
//            gun2.ChooseAction();
//        } else
//        {
//            Console.WriteLine("Choose right gun type...");
//            goto InitialLine;
//        }

//    }
//}

//public class Gun
//{
//    public string name;
//    public int maxCapacity;
//    public int currentBullet;
//    public int totalBullet;
//    public string type;

//    public Gun(string name, int maxCapacity, string type)
//    {
//        this.name = name;
//        this.maxCapacity = maxCapacity;
//        this.type = type;
//    }

//    public void Fire()
//    {
//        if (type == "assault")
//            currentBullet = 0;

//        else if (type == "sniper")
//            currentBullet -= 1;

//        ShowDetails();

//    }

//    public void ReloadMagazine()
//    {
//        if (totalBullet - (maxCapacity - currentBullet) > 0)
//        {

//            totalBullet = totalBullet - (maxCapacity - currentBullet);
//            int reloadedMagazine = currentBullet + (maxCapacity - currentBullet);
//            currentBullet = reloadedMagazine;
//        }
//        else
//        {
//            currentBullet += totalBullet;
//            totalBullet = 0;
//        }

//        ShowDetails();
//    }

//    public void GetDetails()
//    {

//        Console.WriteLine("Getting information...");

//        do
//        {

//            Console.WriteLine("Enter current bullet: ");
//            currentBullet = Convert.ToInt32(Console.ReadLine());

//            if (currentBullet > maxCapacity)
//                Console.WriteLine("Capacity is not enough");

//        } while (currentBullet > maxCapacity);


//        Console.WriteLine("Enter total bullet: ");
//        totalBullet = Convert.ToInt32(Console.ReadLine());

//        ShowDetails();
//    }

//    public void ShowDetails()
//    {

//        Console.WriteLine($"Name: {name}, " +
//                          $"Max Capacity: {maxCapacity}, " +
//                          $"CurrentBullet: {currentBullet}, " +
//                          $"Total Bullet: {totalBullet}, " +
//                          $"Gun Type: {type} ");
//    }

//    public void ChooseAction()
//    {
//        bool isChoosed = true;

//        while (isChoosed)
//        {
//            Console.WriteLine("Choose action: Fire(F) / Reload(R) / Exit(E)");
//            System.ConsoleKeyInfo choosedAction = Console.ReadKey();
//            Console.WriteLine();

//            if (choosedAction.Key.ToString() == "F")
//                Fire();
//            else if (choosedAction.Key.ToString() == "R")
//                ReloadMagazine();
//            else if (choosedAction.Key.ToString() == "E")
//                isChoosed = false;
//            else
//            {
//                Console.WriteLine("Choose right action...");
//            }
//        }

//    }
//}


/////////////////////////////////////////////////////////////////////////////TASK5

//class Calculator
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("1. Reqemi daxil edin: ");
//        double number1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("2. Reqemi daxil edin: ");
//        double number2 = Convert.ToInt32(Console.ReadLine());
//        InitialLine:  Console.WriteLine("Yerine yetirmek istediyiniz emeli secin: +, -, *, /");
//        string action = Console.ReadLine();

//        switch (action)
//        {
//            case "+":
//                Add(number1, number2);
//                break;
//            case "-":
//                Substract(number1, number2);
//                break;
//            case "*":
//                Multiply(number1, number2);
//                break;
//            case "/":
//                Divide(number1, number2);
//                break;
//            default:
//                goto InitialLine;
//        }


//    }

//    public static void Add(double number1, double number2)
//    {
//        Console.WriteLine($"Netice: {number1 + number2}");
//    } 
//    public static void Substract(double number1, double number2)
//    {
//        Console.WriteLine($"Netice: {number1 - number2}");
//    } 
//    public static void Multiply(double number1, double number2)
//    {
//        Console.WriteLine($"Netice: {number1 * number2}");
//    } 
//    public static void Divide(double number1, double number2)
//    {
//      Console.WriteLine($"Netice: {number1 / number2}");
//    }
//}