using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* |+| /_______ ___________ ______ _ ________________________ _ _____ ___   _____ _____  _______________  ______ _\ |-| */

/*.                                                    .								_____________________________
    .$"                                    $o.      $o.  _o"							|		 Yakup Şevik		|
   .o$$o.    .o$o.    .o$o.    .o$o.   .o$$$$$  .o$$$$$ $$P `4$$$$P'   .o$o.			|							|
  .$$| $$$  $$' $$$  $$' $$$  $$' $$$ $$$| $$$ $$$| $$$ ($o $$$: $$$  $$' $$$			|							|
  """  """ """  """ """  """ """  """ """  """ """  """  "  """  """ """  """			|							|
.oOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOo.			|							|
  ooo_ ooo ooo. ... ooo. ... ooo.  .. `4ooo.  .`4ooo.   ooo.ooo. ooo ooo.  ..			|							|
  $$$"$$$$ $$$| ... $$$| ... $$$$$$ ..    "$$o     "$$o $$$|$$$| $$$ $$$|   .			|							|
  $$$| $$$ $$$|     $$$|     $$$|     $$$: $$$ $$$: $$$ $$$|$$$| $$$ $$$|				|							|
  $$$| $$$ $$$| $o. $$$| $o. $$$| $o. $$$| $$$ $$$| $$$ $$$|$$$| $$$ $$$| $.			|							|
  $$$| $$$ $$$| $$$ $$$| $$$ $$$| $$$ $$$| $$$ $$$| $$$ $$$|$$$| $$$ $$$| $o.			|							|
  $$$| $$$ $$$| $$$ $$$| $$$ $$$| $$$ $$$| $$$ $$$| $$$ $$$|$$$| $$$ $$$| $$$			|							|
  $$$| $$$  $$. $$$  $$. $$$  $$. $$$ $$$| $$$ $$$| $$$ $$$|$$$| $$$  $$. $$$			|	  						|
  $$$: $P'  `4$$$Ü'__`4$$$Ü'  `4$$$Ü' $$$$$P'  $$$$$P'  $$$|$$$: $P' __`4$$$Ü'			| 	  24.04 | Since 2019	|
 _ _______/∖______/  ∖______/∖______________/|________ "$P' _______/  ∖_____ _			|___________________________|
                                                        i"  	Yakup Şevik
                                                        |
/* /_______ ___________ ______ _ ________________________ _ ________ _____  _\	*/

/*				     		   __________ ____  ______ _ _ ___ __ __ _                          */

/*				         	        |$|		[Conviction]		|$|						        */

/* |+| /_______ ___________ ______ _ ________________________ _ _____ ___   _____ _____  _______________  ______ _\ |-| */

namespace ConvictionRPG {

    class Program {

        static void Main(string[] args) {

/* |+| /_______ ___________ ______ _ ________________________ _ _____ ___   _____ _____  _______________  ______ _\ |-| */

            /* File Object */

            Game game = new Game();

            //Load Character Logs

            game.loadSlotGame();

            //If we've disable it, this (line 35) won't work.

            game.playing = true;

            //Our Active Character.

            game.activeCharacter = 0;

            // Character Logs

            game.saveSlot1 = "saveSlot1.txt";
            game.saveSlot2 = "saveSlot2.txt";
            game.saveSlot3 = "saveSlot3.txt";
            game.saveSlot4 = "saveSlot4.txt";


            //If the (game.playing == true), run the "game.mainMenu" function.

            while (game.playing == true) { game.startMenu(); }

/* |+| /_______ ___________ ______ _ ________________________ _ _____ ___   _____ _____  _______________  ______ _\ |-| */

        }
    }
}

/* |+| /_______ ___________ ______ _ ________________________ _ _____ ___   _____ _____  _______________  ______ _\ |-| */
