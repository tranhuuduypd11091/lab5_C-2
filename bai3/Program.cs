using bai3;
using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main()
    {
      
        List<UserAccount> userAccounts = new List<UserAccount>
        {
             new UserAccount { UserID = 1, UserName = "player1", WinRate = 10,Type = "A" },
            new UserAccount { UserID = 2, UserName = "player2", WinRate = 55,Type = "B" },
            new UserAccount { UserID = 3, UserName = "player3", WinRate = 60,Type = "A" },
            new UserAccount { UserID = 4, UserName = "player4", WinRate = 100,Type = "C" },
            new UserAccount { UserID = 5, UserName = "player5", WinRate = 70,Type = "B" }
        };

        
        var userAccountLookup = userAccounts.ToLookup(user => user.Type);

      
        Console.WriteLine("Danh sách UserAccount theo Type:");
        foreach (var group in userAccountLookup)
        {
            Console.WriteLine($"Type: {group.Key}, Count: {group.Count()}");
            foreach (var user in group)
            {
                Console.WriteLine($"  UserID: {user.UserID}, UserName: {user.UserName}, WinRate: {user.WinRate}");
            }
        }
    }
}