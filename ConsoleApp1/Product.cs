namespace Products
{
    public enum CategoryType { Food, Instruments, Furniture, Default }

    class Product
    {
        public string? Name { get; set; }
        public readonly DateTime? ManufactureDate;
        public CategoryType Category { get; set; }
        public decimal? Price { get; set; }
        public Product(string? name, CategoryType category, decimal? price)
        {
            Name = name;
            ManufactureDate = DateTime.Now;
            Category = category;
            Price = price;
        }
        public override string ToString()
        {
            return $"Product: {Name}\nManufacture Date: {ManufactureDate}\nCategory: {Category}\nPrice: {Price}";
        }

    }
}
