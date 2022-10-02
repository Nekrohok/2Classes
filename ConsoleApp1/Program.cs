using Employees;
using Products;
using Factories;

namespace main
{
    class Program
    {
        public static CategoryType getCategory(string? category)
        {
            if (category!.ToLower() == "Food")
                return CategoryType.Food;
            else
            {
                if (category!.ToLower() == "Furniture")
                    return CategoryType.Furniture;
                else
                {
                    if (category!.ToLower() == "Instruments")
                        return CategoryType.Instruments;
                    else { return CategoryType.Default; }
                }
            }

        }
        internal static void Main()
        {
            Console.Write("Назва пiдприємства: ");
            string? factoryName = Console.ReadLine();

            Console.Write("Кількість працівників: ");
            string? EmpCount = Console.ReadLine();
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < Convert.ToInt32(EmpCount); i++)
            {
                Console.Write($"Працiвник {i + 1}:\nПрiзвище: ");
                string? surname = Console.ReadLine();

                Console.Write("Ім'я: ");
                string? name = Console.ReadLine();

                Console.Write("Дата народження: ");
                DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("ЗП: ");
                decimal? salary = Convert.ToDecimal(Console.ReadLine());

                Employee employee = new Employee(name, surname, birthDate, salary);
                employees.Add(employee);

                Console.WriteLine();
            }

            Console.Write("Кількість продуктів: ");
            string? ProdCount = Console.ReadLine();
            List<Product> products = new List<Product>();
            for (int i = 0; i < Convert.ToInt32(ProdCount); i++)
            {
                Console.Write($"Товар {i + 1}:\nНазва: ");
                string? name = Console.ReadLine();

                Console.Write("Категорія (Food/Furniture/Instruments): ");
                getCategory(Console.ReadLine());

                Console.Write("Ціна: ");
                decimal? price = Convert.ToDecimal(Console.ReadLine());

                Product product = new Product(name, CategoryType.Default, price);
                products.Add(product);

                Console.WriteLine();
            }
            Factory factory = new Factory(factoryName, employees, products);
            Console.WriteLine();

            employees.ForEach((i) => { Console.WriteLine(i.ToString()); Console.WriteLine(); });
            Console.WriteLine();

            products.ForEach((i) => { Console.WriteLine(i.ToString()); Console.WriteLine(); });
            Console.WriteLine();

            Console.WriteLine(factory.ToString());
        }
    }
}