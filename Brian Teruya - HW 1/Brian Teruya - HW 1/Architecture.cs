using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Brian_Teruya___HW_1
{
    internal class Architecture
    {

        /*
* Project: Architecture
* Developer: Brian Teruya
* Purpose: create architecture for homework assignments
* last modified: 1/15/2026
* last modification: finalized additions to comments
*/

        //==============================
        //Homework 1
        //==============================
        /*
            * Battleship Architecture Plan
            * 1. Players
                * a.Get Player Names – need to store them.
                * For this to work we would need a player class to hold the name.
                * I’ll have to open a new parent class called player.
                * this is where I can make variables that will be substitutes for everything we need.
                * things like a string for the name and arrays for the coordinates and ships present
                *
                * b. Get Player Piece Type
                    *
                    * i.Maybe allow other piece types?
                       * there will be different types of ships with different amounts of health
                       * ship type:
                       *  1. Destroyer – 2 health
                       * 2. Submarine – 3 health
                       * 3. Cruiser – 3 health
                       *  4. Battleship – 4 health
                       * 5. Carrier – 5 health
                       * these will be ints and will be used to calculate how much each ship has during each 
                       *  turn

                    * ii. Provide options
                       *  play against CPU (or another player if that's remotely possible for the scope of this*
                       * project
                       * only focus is CPU though
                       * the CPU will have a random number and letter generator (im wondering how I can 
                       * get
                       * that letter gen to work though…)
                       * if they overlap coordinates, the generator will have to run until a good coordinate is 
                       * placed.
                    * iii. Get player option
                       * players will input their ship choices via console input 
                       * same for their coordinates for when they place down their ships.
                       *
                       * 
                    * iv. Save to player for game use.
                       * these will be inputted into the player 1 child class


                       *  That's all I'm able to think of for now...
            * 2. Pieces
                       * ship type:
                       *  1. Destroyer – 2 Cord spaces
                       * 2. Submarine – 3 Cord spaces               
                       * 3. Cruiser – 3 Cord spaces
                       *  4. Battleship – 4 Cord spaces
                       * 5. Carrier – 5 Cord spaces
               * also comes with 2 types of missiles, white missiles for misses and red for hits

            * 3. Board Setup
                * 2 sides and 2 grids per side.
                * a grid where pieces can be placed, but not seen by the other player.
                * (can also be used to track how many hits a player has taken)
                * and another grid that tracks hits and misses.
                * y axis A-J
                * x axis 1-10
                * pieces can be placed anywhere on the grid (if they fit of course)
                *(no part of your ship should be off grid or overlapping coordinates with another ship)
            * 4. Game Title/Intro/Rules
                * BATTLESHIP
                    * intro:
                        * in the heat of battle, 2 commanders(you the players!) will face off in blind 1 on 1 naval
                        * combat
                        * guess the right coordinates to sink all of the opponents ships before you succumb to the 
                        *depths!

                    *rules: 
                        * (in basic english) all players must place down their pieces wherever they want in order to 
                        *start the game.
                        * ask a player for their piece of choice to place down
                        * after that is done, ask for the exact coordinates they want their ships to be in. make sure 
                        * that they fit in the exact coordinates.Otherwise, ask again.

                    * game start:
                        * Ask the player to enter their coordinates through a letter/number format. If invalid, they
                        * have to try again.If they already hit that spot, they have to try again
                        * these coordinates will be stored in another grid that tracks the hits and misses
                        * if a player hits an empty coordinate, it is a miss, and no damage is done.
                        * however if the player hits a coordinate with an enemy piece, it is a hit
                        * certain pieces have a set amount of health by int. When it reaches 0, the ship is sunken.
                        * The game ends when a player's entire fleet is blown to the sea down under.
            * 5. ...................... 
                * english or spanish?
                */
        





    }
}
