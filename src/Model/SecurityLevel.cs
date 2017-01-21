using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SecurityLevel
    {
        private Dictionary<string, int> _dictionary = new Dictionary<string, int>()
        {
            {"Administrator", 1},
            {"Manager", 2},
            {"User", 3}
        };

        public SecurityLevel()
        { }

        public Dictionary<string, int> Dictionary
        {
            get
            { return _dictionary; }
        }
    }
}
