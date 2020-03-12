namespace Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}";  }
        }

        public Customer(int id, string firstName, string lastName, string emailAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        public override string ToString()
        {
            return $"{FullName} ({EmailAddress})";
        }
    }
}
