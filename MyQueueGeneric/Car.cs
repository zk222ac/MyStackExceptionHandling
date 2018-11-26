using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueGeneric
{
    class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public Car(int id, string model)
        {
            Id = id;
            Model = model;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Model: {1}", Id, Model);
        }
    }
}
