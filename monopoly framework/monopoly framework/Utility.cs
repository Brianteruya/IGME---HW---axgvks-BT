using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly_framework
{
    internal static class Utility
    {
        
        
        // check user response


        //check user response string format

        internal static bool UserStringExists(string info)
        {
            bool answer = false;
            //if statement is null or empty

            return answer;
        }

        //format User Data
        internal static string UserDataFormat(string playerinfo,char stringamount)
            {
            return playerinfo;
            }

        internal static string UserDataFormat(string playerinfo)

        {
            return playerinfo;
        }

        internal static string UserDataFormat(string playerinfo, string textcase)
        {
            return playerinfo;
        }

        //catch method
        internal static int StringToIntConvert (string playerinfo)
        {
            return 1;
        }

        //error message for the catch method if it doesnt work
        internal static string errorMsg (string msg)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();

            return null;
        }
        //list of players

        //List of pieces



        //Method to create 1 player


        //method to create multiple players - add to list


        //method to give money



        //method to select a player piece (2 lists: 1 for used and other for unused?)
    
    
        //method to show Title + rules


        //board setup
        //Spaces:

        //set pieces on start

        //card shuffle
    }
}
