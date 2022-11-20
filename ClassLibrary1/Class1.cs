namespace ClassLibrary_Human
{

    public class Human
    {
        private string name;
        private string lastName;
        private string gender; 
        private int age;
        private string dateOfBirth;
        private string marriageStatus;
        private string numberOfChildren;
        private string education;

        public Human(string name, string lastName, string gender, int age, 
            string dateOfBirth, string marriageStatus, string numberOfChildren, string education)
        {
            this.name = name;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.dateOfBirth = dateOfBirth;
            this.marriageStatus = marriageStatus;
            this.numberOfChildren = numberOfChildren;
            this.education = education;
        }

        public Human(string name)
        {
            this.name = name;
        }

        public Human() { }

        public Human(string name, string lastName, string gender, int age)
        {
            Name = name;
            LastName = lastName;
            Gender = gender;
            Age = age;
        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string DateOfBirth { get; set; }

        public string MarriageStatus { get; set; }

        public string NumberOfChildren { get; set; } 

        public string Education { get; set; }

        public virtual void PrintShortInfo() => Console.WriteLine($"Name: {name} age: {age}");

        public void PrintFullInfo() => Console
            .WriteLine($"Name: {name} lastName: {lastName} gender:{gender} age: {age} ");

    }

}
