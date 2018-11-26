namespace MyQueueGeneric
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

        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}", Id, Name);
        }
    }
}
