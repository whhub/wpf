using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XamlAttribute
{
    [TypeConverter(typeof(StringToHumanTypeConverter))]
    class Human
    {
        public string Name { get; set; }
        public Human Child { get; set; }
    }
}
