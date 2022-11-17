namespace ClassLibrary_Employee
{

    public class Employee
    {
        public string name;
        public string lastName;
        private string gender;
        private int age;
        private string position;

        public Employee(string name, string lastName, string gender, int age, string position)
        {
            this.name = name;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.position = position;
        }

        public Employee(string name, string last_name) { this.name = name; this.lastName = last_name; }

        public Employee() { }

        public string Gender { get => gender; set => gender = value; }

        public int Age { get => age; set => age = value; }

        public string Position { get => position; set => position = value; }

        public void Work() { Console.WriteLine($"{name} is working"); }

        public void PrintShortInfo() => Console.WriteLine($"Name: {name} age: {age}");

        public void PrintFullInfo() => Console
            .WriteLine($"Name: {name} last_name: {lastName} gender:{gender} age: {age} position: {position}");
    }

}
