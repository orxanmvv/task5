namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("orxan", "msuayev", "kisi", "urek hekimi", -15, -36);
            doctor1.ShowInfo();



        }
    }

    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
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
                    Console.WriteLine("Age yanlis daxil edilib");
                }
            }
        }
        public Human(string name, string surname, string gender, int age)
        {

            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;


        }
        public string GetInfo()
        {
            return $"Name: {Name}, Surname: {Surname}, Gender: {Gender}, Age: {Age}";
        }

        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }

    public class Doctor : Human
    {  



        public string Speciality { get; set; }
        private int _experience;
        public int Experience
        {
            get { return _experience; }
            set
            {
                if (value >= 0)
                {
                    _experience = value;
                }
                else
                {
                    Console.WriteLine("Experience yanlis daxil edilib");
                }
            }
        }
        public Doctor( string name, string surname, string gender,string speciality, int experience, int age):base(name,surname,gender,age)
        {
            Speciality = speciality;
            Experience = experience;
            
        }   

        public  string GetInfo()
        {
            return $"Name: {Name}, Surname: {Surname}, Gender: {Gender} , Speciality:{Speciality}";
        }

        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }

}
