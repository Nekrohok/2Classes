namespace Employees
{
    class Employee
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal? Salary { get; set; }
        public Employee(string? name, string? surname, DateTime birthdate, decimal? salary)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Product: {Name}\nSurname: {Surname}\nBirth date: {BirthDate}\nSalary: {Salary}";
        }
    }
}