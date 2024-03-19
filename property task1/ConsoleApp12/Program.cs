namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("orxan", "Musayev", -25, -90);
            student1.ShowInfo();
            
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 100)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("deyer uygun deyil");
                }
            }
        }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }

    public class Student : Person
    {
        public string StudentId { get; private set; }
        private int _point;
        public int Point
        {
            get { return _point; }
            set
            {
                if (value > 0 && value < 100)
                {
                    _point = value;
                }
                else
                {
                    Console.WriteLine("deyer yanlisdir");
                }
            }
        }

        public Student(string name, string surname, int age, int point) : base(name, surname, age)
        {
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, StudentId: {StudentId}, Point: {Point}");
        }
    }
}
