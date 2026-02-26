using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_REDUX
{
    internal class architecture
    {
        /*
* Project: Architecture
* Developer: Brian Teruya
* Purpose: create architecture for homework assignments
* last modified: 2/23/2026
* last modification: HW 3 architecture retry
*/

        //==============================
        //HW 3 RETRY (Arch. for entire game structure)
        //==============================
        /*
         * Classes needed (properties and variables needed)
         * 
         * SETUP
         * - welcome
         *      - state in console: 
         *      - "WELCOME TO PIRATE MONOPOLY"
         *      
         * - rules
         *      - state in console:
         *      "The boards are set, and the pirates are ready!!! heed this message and plunder them all!!!
         *      \nRULES-----------------
         *      \n1.THE BOARD SHALL BE SET UP!!!!
         *      \n1.each player starts at the "GO!", positioned at the beginning of the board
         *      \n2.each player must roll 2 die to determine player order from greatest to least
         *      \n3.if a player lands on owned property, they shall be charged with rent.
         *      \n4.if a player lands on the "walk the plank" space, without a "get off of the plank free" card, THEY SHALL WALK THE PLANK (place your piece to the plank space)
         *      \n5.if a player on the plank rolls a double or pays the 50 treasure buck fine, he shall be freed.
         *      \n6.if a player lands on a chance/community chest space, they MUST take a card of the following and do WHATEVER SHALL BE WRITTEN UPON IT!!! NO REFUSALS!!!
         *      \n7.if a player lands on unowned property, they shall have the choice to buy the property.
         *      \n8.if a player lands on his own property, rent SHALL BE DOUBLE
         *      \n9.if a player lands on the GO! position after a full lap around the board, He shall collect 200 treasure bucks
         *      \n10.if a player SHALL REFUSE PAYING RENT OR ANY OF THE ABOVE, HE IS TO BE PUT IN A DUEL WITH THE BANKER, where they shall roll dice.
         *      \n11.if the banker wins in this dice roll, THE SCALLYWAG MUST PAY UP DOUBLE OR WALK THE PLANK
         *      \n12.if the player wins in this dice roll, He shall get another roll
         *      \n13. if a player shall go bankrupt, the scallywag immediately loses.
         *      "
         *      
         *      
         * - players
         *      - Create Players
         *          (instantiate within main after data inputs from console)
         *              - piece to use
         *                      - state in console asking the player for their choice of piece.
         *                      - list out every piece, and request a number as a choice.
         *                      - check to see if the answer is valid using a method. if not ask again.
         *                      
         *              - money balance/add/subtract/Lose
         *                      - make the money variable internal (anything but private or public)
         *                      -adjacent to the rules and instruction of game aspects. make it make sense.
         *              - properties
         *                      - when a player buys a property, add it to their list of properties using a method within the player class
         *                      - a string variable carrying the name of the property
         *                      - a boolean variable to toggle the ownage of that property, especially if they sell it later on.
         * - Board and spaces
         *      - spaces
         *              - Description/bio
         *                      - string variable with the name and nformation about the space
         *              - Group/type
         *                      - string variable with the group of the property (color group, utility, railroad, etc)
         *              - Cost
         *                      - integer variable with the cost of the property
         *              - Color
         *                      - console color change?
         *              - Owned?
         *                      - boolean variable to determine if the property is owned or not
         *      - pieces moved on board
         *              - spaces are numbered 1-40 (or 0-39) in a list. the player position is determined by the number of spaces they have moved from the start.
         *              - the dice roller value will determine how many spaces they move, and the position will be determined by the value of the dice roller + current position.
         *      - Idetify space landed on
         *              - when the player moves, the game will identify the space they have landed on using the position variable and the list of spaces.
         *      - Actions to take
         *              - if the space is owned, pay rent
         * - banker/money
         *      - (position handled by game automatically)
         *              - when a player passes go, they get 200 treasure bucks
         *      - Holds unclaimed properties
         *              - when a player lands on an unowned property, the game will ask if they want to buy it. 
         *              - if they do, the property is removed from the banker's list of unclaimed properties and added to the player's list of properties.
         *      - gives money
         *              - when a player passes go, they get 200 treasure bucks
         *              - math or variable in method to add this money.
         *      - makes change
         *              - you have leftover debt?
         *              - if you owe money, you must pay it. if you can't pay it, you must sell properties. if you can't sell properties, you are bankrupt and lose.
         *              -use properties that equal or are greater than amount owed. if there is nothing to sell, bankrupt immediately.
         * - Cards
         *      - Get Random Card
         *          - find some way to randomize the list of cards
         *      - Card info
         *          - string based on the card drawn
         *      - Community Chest
         *              - set up a list of community chest cards
         *              - needs to use that card randomizer
         *      - Chance
         *              - set up a list of chance cards
         *              - needs to use that card randomizer
         * - 1 player turn
         *      - identify 1st player
         *              - each player rolls 2 die to determine player order from greatest to least. 
         *              the player with the highest roll goes first, and then it goes in descending order from there. 
         *              if there is a tie, those players will roll again until the tie is broken.
         *      - player turn
         *              - Roll dice
         *                      - 2 number gens from 1-6.
         *                      - total added together to determine how many spaces to move.
         *                      - doubles get another turn
         *                      - 3rd double: go to jail
         *              - get value from dice
         *              - move piece
         *              - what did we land on
         *                      - is it owned?
         *                              - buy or not buy
         *                                      - prompt within console
         *                                      - ask if the player wants to buy the property.
         *                                      - if so, use a method to add the property to the player's list of properties, and remove it from the banker's list of unclaimed properties. 
         *                                      - also another method to deduct the cost from the player's money.
         *                              - pay rent
         *                                      - prompt within console
         *                                      - use a method to subtract the rent from the player's money, and add it to the owner's money.
         *                                      - if not enough check to see if there areany properties they can sell.
         *                      - Taxes
         *                              - pay up
         *                                      - prompt within console
         *                                      - use a method to find out if player has enough to pay
         *                              - how much?
         *                                      - prompt within console
         *                                      - use variable or math to subtract amount from player money.
         *                              - can the player pay?   
         *                                      - yes = deduct
         *                                      - no (even unable to sell property) = lose
         *                                              - lose method use a boolean.
         *                      - OTHER Properties
         *                              - will it take us to jail?
         *                                      -boolean variable to determine if the player is in jail or not. method to handle going to jail and getting out of jail.
         *                              - must we pick up a card
         *                                      - community
         *                                              - draw card
         *                                                  -remove from undrawn cards list and add to drawn cards list method
         *                                                  -if all cards drawn, reset and reshuffle methods
         *                                              - look and apply that card
         *                                                  -prompt within console with the card information
         *                                                      - Add $
         *                                                              - add money to player method
         *                                                      - Take money
         *                                                              - subtract money from player method
         *                                                          - can pay
         *                                                              - if not enough money, check to see if they can sell properties. if not, bankrupt immediately.
         *                                      - chance
         *                                              draw card
         *                                                  -remove from undrawn cards list and add to drawn cards list method
         *                                                  -if all cards drawn, reset and reshuffle methods
         *                                              - look and apply that card
         *                                                  -prompt within console with the card information
         *                                                      - Add $
         *                                                          - either make a new variable to add money or use an operation
         *                                                          - in any case it MUST be a method that adds money to the player
         *                                                      - Take money
         *                                                          - can pay
         *                                                              - a method that checks if the player has enough.\
         *                                                              - if not they MUST sell something
         *                                                              - if (player#.money < amounttopay)
         *                                                              - { (ask the player to sell something of equal or more value)
         *                                                              -    (check the property values. if there isn't anything of worth to sell, bankrupt IMMEDIATELY}
         *                                                              - else
         *                                                              - { player#.money = player#.money - amount to pay}
         *                                                              
         *                      - Go to jail method
         *                          - (call the method from the object in main whenever the player lands on the go to jail space, recieves a jail card, or rolls 3 doubles)
         *                          - if (outjailfree == false)
         *                          -   {
         *                          -       protected in_jail = true;
         *                          -       if dice1value == dice2value
         *                          -       {
         *                          -           in_jail = false;
         *                          -       } 
         *                          -   }
         *                          - else
         *                          -       protected in_jail = false
         * - end of turn
         *      - do they get another turn?
         *      - any players left? are they bankrupt? 
         *              - method to check status of player
         *                  - if (money = 0 && properties owned = 0)
         *                  -   {   
         *                  -       bankrupt = true;
         *                  -   }
         *                      
         */

        //==============================
        //actual variables to be used
        //==============================
        /* 
         * We need to start making constructors and variables for our architecture.
         * thats the point of this homework
         */
        /*
        //Player data information
        //player piece
        //this determines what the player will be using as a piece
        1->  protected string pieceType = "";
          //our player will choose from one of these pieces
          protected List<string> pieces = new List<string>()
          {
              "a pirate hat",
              "an eye patch",
              "the steering wheel",
              "the plank",
              "Jeffrey the parrot",
              "a treasure chest",
              "a cannon",
              "legally distinct jack sparrow with a bottle of a non alcoholic substance"
          };\

          //player name
          private string playerName = "";//stored here when received

          //Games won/lost ratio
          //I decided doing a win loss ratio would be more effective for this game
          private int gamesWon = 0;
          private int gamesLost = 0;
          //a method will include these two when needed to be displayed
          //player action items
          //player money
          protected int pMoney = 1500; //starting money
          protected int pMoneydebt = 0;//if money is owed. value will change as the game continues


          //game engine actions
          //game setup
          protected List<string> property_names = new List<string>()
          {
              "Da Bob",
              "Davy Jones's Locker",
              "Tortuga",
              "Skull Island",
              "Shipwreck Cove",
              "Port Royal",
              "Blackbeard's Castle",
              "The Kraken's Lair",
          };//this is the list of properties we can buy
          protected List<string> advanceship_names = new List<string>()
          {
              "the crow's nest",
              "the galley",
              "the brig",
              "the captain's quarters",
              "the hold",
              "the deck",
              "the forecastle",
              "the poop deck"
          };//this is the list of locations we can advance to when we get certain cards
            //chance and community chest cards
          protected List<string> Chancecards = new List<string>()
          {
              "advance to the start landlubber! (collect 200 treasure bucks)", //1
              "yer sharp eyes are needed! advance to the crow's nest immediately!", //2
              "advance to the Tortuga! An adventure awaits", //3
              "advance to the galley! maybe ye can grab some (200) treasure bucks if you pass go!", //4
              "take a ride to the captain's quarters! snag 200 treasure bucks if you pass go!", //5
              "advance to the nearest island location or ship location! if owned, pay the owner twice the rental! if not, buy it and snag territory!!!", //6
              " advance to the nearest ship location! if owned, throw the dice and pay the owner 10 times that amount! if unowned claim it!!!", //7
              "turn back 3 spaces I left some treasure!!!", //8
              "for yer honest work, I'll give ye 50 treasure bucks", //9
              "ye have a gambling win! collect 150 treasure bucks", //10
              "pay the bank 15 treasure bucks", //11
              "you lost the worst bet and now have to clean the poop deck! pay each landlubber (player) 50 trasure bucks", //12
              "ye have ta help yer people!!! pay 20 treasure bucks for each crewmember", //13
              "I DONT CARE MATEY JUST WALK THE PLANK!", //14
              "I care matey! get off of the plank free when needed!", //15
              "Ships aren't free! pay 40 treasure bucks for each pirate ship you own." //16
          };//16 total cards
          protected List<string> Communitychestcards = new List<string>()
          {
              "advance to the start landlubber! (collect 200 treasure bucks)", //1
              "yer life insurance matures! collect 100 treasure bucks", //2
              "ye have a birthday! collect 10 treasure bucks", //3
              "yer tax refund came in the sea mail! collect 200 treasure bucks", //4
              "even a pirate has stocks to hold! collect 45 treasure bucks", //5
              "small treasure is still treasure! collect 20 treasure bucks", //6
              "for yer troubles! 25 treasure bucks to yer name", //7
              "yer father was a famous pirate?!? have 100 treasure bucks!!!", //8
              "merry christmas! collect 100 treasure bucks", //9
              "THE MASTER PLUNDERER!!! Collect 50 treasure bucks from every landlubber (player) here!!!", //10
              "ye have a gambling win! collect 50 treasure bucks", //11
              "how did ye lose yer treasure scallywag?!? lose 100 treasure bucks", //12
              "ye have a gambling loss! lose 150 treasure bucks", //13
              "crewmates aren't free! pay 20 treasure bucks per crewmember on your territories", //14
              "I DONT CARE MATEY JUST WALK THE PLANK!", //15
              "I care matey! get off of the plank free when needed!" //16

          };//16 total cards

          //determine winner/loser/ties
          protected bool playerwin; //determines winner
          protected bool playerloss; //determines loser(s)
                                     //validate player choices


          //turns and prompting
          protected bool Turn;//true = it is your turn
          //false = not your turn anymore.
          protected Random diceroller = new Random(); //our dice roller.
          //goes from 2 - 12
        */
    }

}
