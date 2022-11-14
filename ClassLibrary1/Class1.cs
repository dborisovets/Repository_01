namespace ClassLibrary_Employee
{

    public class Employee
    {
        public string name;
        public string last_name;
        private string gender;
        private int age;
        private string position;

        public Employee(string name, string last_name, string gender, int age, string position)
        {
            this.name = name;
            this.last_name = last_name;
            this.gender = gender;
            this.age = age;
            this.position = position;
        }

        public Employee(string name, string last_name) { this.name = name; this.last_name = last_name; }

        public Employee() { }

        public string Gender { get => gender; set => gender = value; }

        public int Age { get => age; set => age = value; }

        public string Position { get => position; set => position = value; }

        public void Work() { Console.WriteLine($"{name} is working"); }

        public void Print_Short_Info() => Console.WriteLine($"Name: {name} age: {age}");

        public void Print_Full_Info() => Console
            .WriteLine($"Name: {name} last_name: {last_name} gender:{gender} age: {age} position: {position}");
    }

}
