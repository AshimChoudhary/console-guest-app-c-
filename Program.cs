using System;
using System.Collections.Generic;
using System.Linq;

class p {
    static void Main(){
        bool isValidSize;
        int totalMembers = 0;
        string continueLooping;
        int sizeParty;
        bool counting;
        List<string> guests = new List<string>();
       
       Console.WriteLine("Welcome to the Party Fellas!");
       Console.WriteLine("****************************");
       Console.WriteLine("");
       
       
       
       do{
        do{
            Console.WriteLine("What is your Party/ Group Name! - ");
            string outPut = Console.ReadLine();
            guests.Add(outPut);
            Console.WriteLine("How many of you are in total - ");
            string sizePr = Console.ReadLine();
            isValidSize = int.TryParse(sizePr,out sizeParty);
           
         }while(!isValidSize);
       
       totalMembers += sizeParty;
       
       Console.WriteLine("Are there more guests coming (y/n): ");
       continueLooping = Console.ReadLine();
       counting = (continueLooping.ToLower() =="y");
       
           
       }while(counting);
       
       foreach(string guest in guests){
           Console.WriteLine(guest);
       }
       
       Console.WriteLine("Thanks for Joining us!");
       Console.WriteLine($"The total guest counts were {totalMembers}");
       
       
       
       
    }
    
}
