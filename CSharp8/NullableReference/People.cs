#nullable enable  
//Active the warning for nullable things
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.NullableReference
{
    public class People
    {
        public string Name { get; set; }
        
        public DateTime Birthday { get; set; }

        public List<Address> Addresses { get; set; }

    }
}
#nullable restore
// Restore the nullable for original context. That is disable warning in compiler. 