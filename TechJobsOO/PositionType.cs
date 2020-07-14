using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        //Added custom Equals() method --CF
        //Added GetHashCode() method --CF  //Hashcodes used to compute into arrays which are indexed
        //Added ToString() method --CF

        public override bool Equals(object obj)
        {
            return obj is PositionType name &&
                Id == name.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
