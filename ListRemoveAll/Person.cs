namespace ListRemoveAll
{
    class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Person(string id, string name)
        {
            Id = id;
            Name = name;
        }


        protected bool Equals(Person other)
        {
            return string.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person) obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }

        //protected bool Equals(Person other)
        //{
        //    return string.Equals(Id, other.Id) && string.Equals(Name, other.Name);
        //}

        //public override bool Equals(object obj)
        //{
        //    if (ReferenceEquals(null, obj)) return false;
        //    if (ReferenceEquals(this, obj)) return true;
        //    if (obj.GetType() != this.GetType()) return false;
        //    return Equals((Person) obj);
        //}

        //public override int GetHashCode()
        //{
        //    unchecked
        //    {
        //        return ((Id != null ? Id.GetHashCode() : 0)*397) ^ (Name != null ? Name.GetHashCode() : 0);
        //    }
        //}

        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}", Id, Name);
        }
    }
}
