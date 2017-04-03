using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Players
    {
        string steamid;
        string communityvisibilitystate;
        string profilestate;
        string personaname;
        string lastlogoff;
        string profileur1;
        string avatar;
        string avatarmedium;
        string avatarfull;
        string personastate;
        string realname;
        string primaryclanid;
        string timecreated;
        string personastateflags;
        string loccountrycode;
        string locstatecode;
        string loccityid;

        public Players(string steamid, string communityvisibilitystate, string profilestate, string personaname, string lastlogoff, string profileur1, string avatar, string avatarmedium, string avatarfull, string personastate, string realname, string primaryclanid, string timecreated, string personastateflags, string loccountrycode, string locstatecode, string loccityid)
        {
            this.steamid = steamid;
            this.communityvisibilitystate = communityvisibilitystate;
            this.profilestate = profilestate;
            this.personaname = personaname;
            this.lastlogoff = lastlogoff;
            this.profileur1 = profileur1;
            this.avatar = avatar;
            this.avatarmedium = avatarmedium;
            this.avatarfull = avatarfull;
            this.personastate = personastate;
            this.realname = realname;
            this.primaryclanid = primaryclanid;
            this.timecreated = timecreated;
            this.personastateflags = personastateflags;
            this.loccountrycode = loccountrycode;
            this.locstatecode = locstatecode;
            this.loccityid = loccityid;
        }
    }
}
