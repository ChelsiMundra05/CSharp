namespace Assignment2._2
{
    class PrimeMinister
    {
        public string name;
        public string year;
        const string format = "{0,-20},{1,-5}";

        public PrimeMinister(string name, string year)
        {
            this.name = name;
            this.year = year;
        }

        public override string ToString()
        {
            return string.Format(format,name,year);
        }

    }
}