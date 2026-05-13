namespace TheoryExam
{
    public class Person
    {
        // PLEASE DO NOT MODIFY THIS CODE
        private string firstName;
        private string lastName;
        private int age;

        // Write your answer for task 1.1 here
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // Write your answer for task 1.2 here
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} {age}";
        }
    
    }
}
