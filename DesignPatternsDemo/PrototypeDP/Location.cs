namespace DesignPatternsDemo.PrototypeDP
{
    public class Location :IPrototype<Location>
    {
        public string? Warehouse { get; set; }
        public string? Shelf { get; set; }
        public Location Clone()
        {
            return (Location)this.MemberwiseClone();
        }
    }
}
