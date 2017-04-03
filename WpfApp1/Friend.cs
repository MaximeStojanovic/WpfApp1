using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    public class Friend
    {
        public string steamid { get; set; }
        public string relationship { get; set; }
        public int friend_since { get; set; }
    }

    public class Friendslist
    {
        public List<RootObject> friends { get; set; }
    }

    public class RootObject
    {
        public Friendslist friendslist { get; set; }
    }

}
