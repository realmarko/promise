using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Property
    {
        public Guid Id { get; set; }
        public string PropertyType { get; set; }
        public string Street { get; set; }
        public string ExternalNumber { get; set; }
        public string ZipCode { get; set; }
        public string OperationType { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public int M2Terreno { get; set; }
        public int M2Construccion { get; set; }
        public int Rooms { get; set; }
        public int Baths { get; set; }
    }
}