using System;
using OOP;

class mainprogram
{
        public static void Main()
        {
        OOP.Manageproduct obj = new OOP.Manageproduct();

        Console.WriteLine("Enter product name");
        string productName = Console.ReadLine();
        Console.WriteLine("Enter product description");
        string productDescription = Console.ReadLine();
        Console.WriteLine("Enter product price");
        int productPrice = Convert.ToInt32(Console.ReadLine());
        //InsertNewProduct conn = new connection();
        //bool isValid = conn.InsertData(productName, productDescription, productPrice);
        Console.WriteLine(@" ____  ____  _____  ____    _  _      ____  _____ ____  _____  _____ ____    ____  _     ____  ____  _____ ____  ____  _____ _     _     _    ___  _
/  _ \/  _ \/__ __\/  _ \  / \/ \  /|/ ___\/  __//  __\/__ __\/  __//  _ \  / ___\/ \ /\/   _\/   _\/  __// ___\/ ___\/    // \ /\/ \   / \   \  \//
| | \|| / \|  / \  | / \|  | || |\ |||    \|  \  |  \/|  / \  |  \  | | \|  |    \| | |||  /  |  /  |  \  |    \|    \|  __\| | ||| |   | |    \  / 
| |_/|| |-||  | |  | |-||  | || | \||\___ ||  /_ |    /  | |  |  /_ | |_/|  \___ || \_/||  \_ |  \_ |  /_ \___ |\___ || |   | \_/|| |_/\| |_/\ / /  
\____/\_/ \|  \_/  \_/ \|  \_/\_/  \|\____/\____\\_/\_\  \_/  \____\\____/  \____/\____/\____/\____/\____\\____/\____/\_/   \____/\____/\____//_/   
                                                                                                                                                    ");
    }
}