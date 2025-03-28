using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyRPG
{
    public class GameLevel
    {
        int room;
        Hardness dif;
        public GameLevel(int room, Hardness dif)
        {
            this.room = room;
            this.dif = dif;
        }
        public int GetRoom()
        {
            return room;
        }
    }
}