namespace Cars
{
    public interface ICar
    {
        public string Model { get; set; }

        public string Color { get; set; }

        string Start();

        string Stop();
    }
}
