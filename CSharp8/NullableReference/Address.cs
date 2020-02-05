using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.NullableReference
{
    public class Address
    {
        /// <summary>
        /// When type is set to Nullable don't apper warning.
        /// But the location where will be used this property will apper warning see the 
        /// </summary>
        public string? Street { get; set; }
        public int Number { get; set; }
    }
}
