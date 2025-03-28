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
        public GameLevel(int room, Hardness dif)
        {
            this.room[] = new int [room];
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

        public object GetNumEnemies()
        {
            return enemy;
        }

        public void SetEnemyInRoom(int room, Enemy enemy)
        {
            [room] = enemy;
        }

        public void PrintEnemies()
        {
            Console.WriteLine($"Room: {room.ToRoman()} : {enemy}");
        }
    }
}