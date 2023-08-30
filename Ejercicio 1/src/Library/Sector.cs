using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public string Name { get; }
        public List<Shelve> ShelvesInSector { get; } = new List<Shelve>();

        public Sector(string name)
        {
            Name = name;
        }

        public void AddShelveToSector(Shelve shelve)
        {
            ShelvesInSector.Add(shelve);
        }

        public void RemoveShelveFromSector(Shelve shelve)
        {
            ShelvesInSector.Remove(shelve);
        }
    }
}
