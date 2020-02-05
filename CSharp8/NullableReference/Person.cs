using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.NullableReference
{
    public class Person
    {
        /// <summary>
        /// When add nullable ? the warning disappear
        /// </summary>
        public string? Name { get; set; }
        
        public DateTime Birthday { get; set; }

        /// <summary>
        /// When add nullable ? the warning disappear
        /// </summary>
        public List<Address>? Addresses { get; set; }

        public Person()
        {

        }

    }
}
