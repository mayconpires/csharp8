using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.NullableReference
{
    public class Staff
    {
        public string Name { get; set; }
        
        public DateTime Birthday { get; set; }

        public List<Address> Addresses { get; set; }

        /// <summary>
        /// When we have a construct that don't initialize the propertys appears warning on constructor about propertys 
        /// </summary>
        //public Staff()
        //{
        //}

    }
}
