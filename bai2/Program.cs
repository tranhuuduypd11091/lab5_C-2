using bai2;
using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main()
    {
        // Tạo dữ liệu mẫu
        List<UserAccount> userAccounts = new List<UserAccount>
        {
            new UserAccount { UserID = 1, UserName = "player1", WinRate = 10 },
            new UserAccount { UserID = 2, UserName = "player2", WinRate = 55 },
            new UserAccount { UserID = 3, UserName = "player3", WinRate = 60 },
            new UserAccount { UserID = 4, UserName = "player4", WinRate = 100 },
            new UserAccount { UserID = 5, UserName = "player5", WinRate = 70 }
        };

        
        var winRateAbove50 = userAccounts
            .OrderByDescending(user => user.WinRate)
            .SkipWhile(user => user.WinRate <= 50);

        Console.WriteLine("Danh sách các người có WinRate > 50:");
        foreach (var user in winRateAbove50)
        {
            Console.WriteLine($"UserID: {user.UserID}, UserName: {user.UserName}, WinRate: {user.WinRate}");
        }

       
        var highestWinRateUser = userAccounts.OrderByDescending(user => user.WinRate).FirstOrDefault();
        Console.WriteLine("\nNgười có WinRate cao nhất:");
        if (highestWinRateUser != null)
        {
            Console.WriteLine($"UserID: {highestWinRateUser.UserID}, UserName: {highestWinRateUser.UserName}, WinRate: {highestWinRateUser.WinRate}");
        }

        
        var totalAccounts = userAccounts.Count;
        Console.WriteLine($"\nSố lượng tài khoản trong danh sách UserAccount: {totalAccounts}");
    }
}