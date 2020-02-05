using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.NullableReference
{
    public class Individual
    {
        public string Name { get; set; }
        
        public DateTime Birthday { get; set; }

        public List<Address> Addresses { get; set; }

        /// <summary>
        /// When we have a construct that initialize the propertys don't appears warning
        /// </summary>
        public Individual(string name, List<Address> addresses)
        {
            Name = name;
            Addresses = addresses;
        }

    }
}
