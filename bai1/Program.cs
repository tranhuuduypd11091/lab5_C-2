using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Program
    {
        static void Main(string[] args)
        {
            List<UserAccount> list = new List<UserAccount>();
            list.Add(new UserAccount("Truy kich", 50, 80.5f, "Game",50));
            list.Add(new UserAccount("Son Tung", 54, 5, "Ca Si",10));
            list.Add(new UserAccount("BaTanVlog", 100, 60.5f, "Am Thuc",23));
            list.Add(new UserAccount("Do mixi", 99, 50f, "Streammer",45));
            list.Add(new UserAccount("LienQuan", 30, 8, "Game",97));
            list.Add(new UserAccount("FiFa", 5, 25f, "Game",37));
            list.Add(new UserAccount("CSGO", 10, 33f, "Game",22));
            list.Add(new UserAccount("AnCungBaTuyet", 56, 56f, "Game",61));
            list.Add(new UserAccount("Rambo", 100, 65f, "Game",11));
            list.Add(new UserAccount("NTN", 55, 80, "VLog",88));

            foreach(var player in list)
            {
                Console.WriteLine($"Ten : {player.name} , Rank : {player.rank}, Skin : {player.skin}");
            }
            Console.WriteLine("-----------------------");
            //
            var sorted1 = list.OrderBy(x => x.rank);

            foreach (var player in sorted1)
            {
                Console.WriteLine($"Ten : {player.name} , Rank : {player.rank}, Skin : {player.skin}");
            }
            Console.WriteLine("-----------------------");
            //
            var sorted2 = list.OrderBy(x => x.name).ThenBy(x=>x.skin);
            foreach (var player in sorted2)
            {
                Console.WriteLine($"Ten : {player.name} , Rank : {player.rank}, Skin : {player.skin}");
            }
            Console.WriteLine("-----------------------");

        var usersStartingWithB = list.Where(user => user.name.StartsWith("B"));

        Console.WriteLine("\nDanh sách các người chơi có username bắt đầu bằng chữ 'B':");
        foreach (var user in usersStartingWithB)
        {
            Console.WriteLine($"UserID: {user.name}, WinRate: {user.winRate}");
        }


    }
    }

