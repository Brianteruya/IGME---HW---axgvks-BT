using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly_framework
{
    internal static class Utility
    {



        

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

      
        //list of players
        internal static List<object> player = new List<object>()
        {

        };

        //List of pieces
        internal static List<string> unused_Pieces = new List<string>()
        {
            "a pirate hat",
            "an eye patch",
            "the steering wheel",
            "the plank",
            "Jeffrey the parrot",
            "a treasure chest",
            "a cannon",
            "legally distinct jack sparrow with a bottle of a non alcoholic substance"
        };

        internal static List<string> used_Pieces = new List<string>()
        {

        };


        //Method to create 1 player


        //method to create multiple players - add to list


        //method to give money



        //method to select a player piece (2 lists: 1 for used and other for unused?)


        //method to show Title + rules


        //board setup
        //Spaces:

        //set pieces on start

        //card shuffle

        //Clearing the screen

        //changing text colors based on player

        //changing text background color based on player

        //Validation methods:
        //check user response string format

        internal static bool UserStringExists(string info)
        {
            bool answer = false;
            //if statement is null or empty
            if (string.IsNullOrEmpty(info))
            {
                answer = false;
            }
            else
            {
                answer = true;
            }

            return answer;
        }

        //check user response int format

        internal static bool UserIntExists(string info)
        {
            bool answer = false;
            if (int.TryParse(info, out int value))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }

        //specific colored message printer

        //error message for the catch method if it doesnt work
        /*  internal static string errorMsg (string msg)
          {
              Console.ForegroundColor = ConsoleColor.White;
              Console.BackgroundColor = ConsoleColor.Red;
              Console.WriteLine(msg);
              Console.ResetColor();

              return null;
          }*/
        //general message for anything system related
        internal static void systemmessage_printer (string message)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
