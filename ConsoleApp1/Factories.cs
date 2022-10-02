using Products;
using Employees;

namespace Factories
{
    class Factory
    {
        public string? Name;
        public List<Employee> Employees;
        public List<Product> Products;
        public Factory(string? name, List<Employee> employees, List<Product> products)
        {
            Name = name;
            Employees = employees;
            Products = products;
        }
        public decimal? AvgSalary
        {
            get
            {
                decimal? result = 0;
                Employees.ForEach((i) => { result += i.Salary; });
                return result / Employees.Count;
            }
        }
        public decimal? TotalSalary
        {
            get
            {
                decimal? result = 0;
                Employees.ForEach((i) => { result += i.Salary; });
                return result;
            }
        }
        public decimal? GDP
        {
            get
            {
                decimal? productTotalCost = 0;
                decimal? totalSalary = 0;

                Products.ForEach((i) => { productTotalCost += i.Price; });
                Employees.ForEach((i) => { totalSalary += i.Salary; });

                return productTotalCost / totalSalary;
            }
        }
        public int EmpCount { get { return Employees.Count; } }
        public override string ToString()
        {
            return $"Average salary:{AvgSalary}\nTotal salary: {TotalSalary}\nGDP: {GDP}\nEmployees count: {EmpCount}";
        }
    }
}

