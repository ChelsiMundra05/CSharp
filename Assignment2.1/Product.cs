namespace Assignment2._1
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        public string Type;
        public string format="{0,-12},{1,-10},{2,-4},{3,-10}";
        
        public Product(string Name, double Price, int Quantity, string Type)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Type = Type;
        }

        public override string ToString()
        {
            return string.Format(format, Name, Price+"RS", Quantity, Type);
        }
    }
}