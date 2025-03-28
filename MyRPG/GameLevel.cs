using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {
        int room;
        Hardness dif;
        Enemy name;
        int enemycounter = 0;
        public GameLevel(int room, Hardness dif)
        {
            this.room = room;
            this.dif = dif;
        }
        public int GetNumRooms()
        {
            return room;
        }

        public object GetHardness()
        {
            return dif;
        }

        public int GetNumEnemies()
        {
            return enemycounter;
        }

        public void SetEnemyInRoom(int room, Enemy name)
        {
            Console.WriteLine($"Room {room.ToRoman()} : {this.name}");
            enemycounter++;
        }

        public void PrintEnemies()
        {
            Console.WriteLine($" ");
        }
    }
}