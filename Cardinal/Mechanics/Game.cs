using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

namespace ConvictionRPG
{

    class Game
    {

        /* |+| /_______ ___________ ______ _ ________________________ _ _____ ___   _____ _____  _______________  ______ _\ |-| */

        /*				     		   __________ ____  ______ _ _ ___ __ __ _                          */

        /*				         	         |$|   Configuration    |$|		                            */

        CardinalMessage Message = new CardinalMessage();

        Character Character = new Character();

        #region List<Character> Slots

        List<Character> characterSlot1 = new List<Character>();
        List<Character> characterSlot2 = new List<Character>();
        List<Character> characterSlot3 = new List<Character>();
        List<Character> characterSlot4 = new List<Character>();

        #endregion

        #region Save Slots

        public string saveSlot1 { get; set; } = "saveSlot1.txt";
        public string saveSlot2 { get; set; } = "saveSlot2.txt";
        public string saveSlot3 { get; set; } = "saveSlot3.txt";
        public string saveSlot4 { get; set; } = "saveSlot4.txt";

        #endregion

        public static string newLine = "\n";

        /* |+| /_______ ___________ ______ _ ________________________ _ _____ ___   _____ _____  _______________  ______ _\ |-| */

        private int choice;

        public int createSlot_Choice;

        public int loadSlot_Choice;
        public bool playing { get; set; } = true;

        public int activeCharacter;
        public bool end { get; set; } = false;

        /* |+| /_______ ___________ ______ _ ________________________ _ _____ ___   _____ _____  _______________  ______ _\ |-| */

        #region Save Slot

        public void saveSlotGame()
        {

            #region Save Slot 1

            if (createSlot_Choice == 1)
            {

                if (File.Exists(saveSlot1))
                {

                    //This line will change to "loadCharacters();".

                    System.Console.WriteLine("The file exists.");

                    System.Console.ReadKey();
                    

                }
                else
                {

                    System.Console.WriteLine("File does not exist in the current directory!");

                    //This line will change to "createNewCharacter();".

                    if (!File.Exists(saveSlot1))
                    {

                        using (var tw = new StreamWriter(saveSlot1, true))
                        {
                            tw.Write("");
                        }
                    }

                    createNewCharacter();
                    saveCharacters();


                    System.Console.ReadKey();
                }

            }

            #endregion

            #region Save Slot 2

         else if (createSlot_Choice == 2)
            {

                if (File.Exists(saveSlot2))
                {

                    //This line will change to "loadCharacters();".

                    System.Console.WriteLine("The file exists.");

                    System.Console.ReadKey();

                }
                else
                {

                    System.Console.WriteLine("File does not exist in the current directory!");

                    //This line will change to "createNewCharacter();".

                    if (!File.Exists(saveSlot2))
                    {

                        using (var tw = new StreamWriter(saveSlot2, true))
                        {
                            tw.Write("");
                        }
                    }

                    createNewCharacter();
                    saveCharacters();


                    System.Console.ReadKey();
                }
            }

            #endregion

            #region Save Slot 3

           else if (createSlot_Choice == 3)
            {

                if (File.Exists(saveSlot3))
                {

                    //This line will change to "loadCharacters();".

                    System.Console.WriteLine("The file exists.");

                    System.Console.ReadKey();

                }
                else
                {

                    System.Console.WriteLine("File does not exist in the current directory!");

                    //This line will change to "createNewCharacter();".

                    if (!File.Exists(saveSlot3))
                    {

                        using (var tw = new StreamWriter(saveSlot3, true))
                        {
                            tw.Write("");
                        }
                    }

                    createNewCharacter();
                    saveCharacters();


                    System.Console.ReadKey();
                }
            }

            #endregion

            #region Save Slot 4

           else if (createSlot_Choice == 4)
            {

                if (File.Exists(saveSlot4))
                {

                    //This line will change to "loadCharacters();".

                    System.Console.WriteLine("The file exists.");

                    System.Console.ReadKey();

                }
                else
                {

                    System.Console.WriteLine("File does not exist in the current directory!");

                    //This line will change to "createNewCharacter();".

                    if (!File.Exists(saveSlot4))
                    {

                        using (var tw = new StreamWriter(saveSlot4, true))
                        {
                            tw.Write("");
                        }
                    }

                    createNewCharacter();
                    saveCharacters();


                    System.Console.ReadKey();
                }
            }

            #endregion

        }

        #endregion

        #region Load Slot

        public void loadSlotGame()
        {

            #region Loat Slot 1

            if (loadSlot_Choice == 1)
            {

                characterSlot1.Clear();

                string profile = "";
                string name = "";
                int distanceTravelled = 0;
                int gold = 0;
                int level = 0;
                int exp = 0;
                int strength = 0;
                int vitality = 0;
                int dexterity = 0;
                int intelligence = 0;
                int hp = 0;
                int stamina = 0;
                int statPoints = 0;

                //Item
                int itemType = 0;
                int defence = 0;
                int type = 0;
                int damageMin = 0;
                int damageMax = 0;
                int buyValue = 0;
                int sellValue = 0;
                int rarity = 0;


                using (StreamReader readtext = new StreamReader(saveSlot1))
                {

                    Character temp = new Character();
                    bool secondCharacter = false;

                    while ((profile = readtext.ReadLine()) != null)
                    {
                        end = false;
                        List<string> itemsList = new List<string>();

                        itemsList = profile.Split(' ').ToList();
                        if (itemsList[0] == "")
                        {
                            break;
                        }

                        if (Convert.ToInt32(itemsList[0]) == 3)
                        {
                            if (secondCharacter)
                            {
                                characterSlot1.Add(temp);
                            }

                            if (profile != null)
                            {
                                name = itemsList[1];
                                int.TryParse(itemsList[2], out distanceTravelled);
                                int.TryParse(itemsList[3], out gold);
                                int.TryParse(itemsList[4], out level);
                                int.TryParse(itemsList[5], out exp);
                                int.TryParse(itemsList[6], out strength);
                                int.TryParse(itemsList[7], out vitality);
                                int.TryParse(itemsList[8], out dexterity);
                                int.TryParse(itemsList[9], out intelligence);
                                int.TryParse(itemsList[10], out hp);
                                int.TryParse(itemsList[11], out stamina);
                                int.TryParse(itemsList[12], out statPoints);

                                temp = new Character
                                {
                                    name = name,
                                    distanceTravelled = distanceTravelled,
                                    gold = gold,
                                    level = level,
                                    exp = exp,
                                    strength = strength,
                                    vitality = vitality,
                                    dexterity = dexterity,
                                    intelligence = intelligence,
                                    hp = hp,
                                    stamina = stamina,
                                    statPoints = statPoints
                                };

                                temp.updateStats(); //updating formulas/statistics

                                bool whil = true;
                                int actualPosition = 13;


                                while (whil)
                                {
                                    if (Convert.ToInt32(itemsList[actualPosition]) == 0)
                                    {
                                        //Weapon
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out damageMin);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out damageMax);

                                        Weapon weapon = new Weapon(level, rarity) { damageMin = damageMin, damageMax = damageMax, name = name, itemType = itemType, buyValue = buyValue, sellValue = sellValue };
                                        temp.weapon = weapon;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 0)
                                    {
                                        //Armors head
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_head = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_head = armor_head;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 1)
                                    {
                                        //armors chest
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_chest = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_chest = armor_chest;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 2)
                                    {
                                        //armors arms
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_arms = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_arms = armor_arms;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 3)
                                    {
                                        //armors legs
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_legs = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_legs = armor_legs;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == -1 && actualPosition == 12)
                                    {
                                        actualPosition += 7;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == -1)
                                    {
                                        actualPosition += 7;
                                    }


                                    actualPosition++;
                                    if (actualPosition + 1 == itemsList.Count)
                                        whil = false;
                                }
                                Console.WriteLine($"Character {temp.name} loaded!");
                                secondCharacter = true;
                            }
                        }
                        else if (Convert.ToInt32(itemsList[0]) == 0 || Convert.ToInt32(itemsList[0]) == 1)
                        {
                            int h = 0;
                            int position = 0;
                            while (end == false)
                            {
                                if (itemsList.Count == 1)
                                    end = true;
                                for (int i = position; i < itemsList.Count - 2; i++)
                                {
                                    int.TryParse(itemsList[h], out itemType);
                                    h++;
                                    if (itemType == 0)
                                    {
                                        name = itemsList[h];
                                        h++;
                                        int.TryParse(itemsList[h], out level);
                                        h++;
                                        int.TryParse(itemsList[h], out rarity);
                                        h++;
                                        int.TryParse(itemsList[h], out buyValue);
                                        h++;
                                        int.TryParse(itemsList[h], out sellValue);
                                        h++;
                                        int.TryParse(itemsList[h], out damageMin);
                                        h++;
                                        int.TryParse(itemsList[h], out damageMax);
                                        h++;

                                        temp.addItem(new Weapon(level, rarity) { damageMin = damageMin, damageMax = damageMax, name = name, buyValue = buyValue, sellValue = sellValue });
                                    }

                                    else if (itemType == 1)
                                    {

                                        name = itemsList[h];
                                        h++;
                                        int.TryParse(itemsList[h], out level);
                                        h++;
                                        int.TryParse(itemsList[h], out rarity);
                                        h++;
                                        int.TryParse(itemsList[h], out buyValue);
                                        h++;
                                        int.TryParse(itemsList[h], out sellValue);
                                        h++;
                                        int.TryParse(itemsList[h], out defence);
                                        h++;
                                        int.TryParse(itemsList[h], out type);
                                        h++;

                                        temp.addItem(new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue });

                                    }

                                    i = i + 7;

                                    if (h == (itemsList.Count - 1))
                                        end = true;
                                }
                            }

                            characterSlot1.Add(temp);
                            secondCharacter = false;
                            temp = null;
                        }

                    }

                    if (secondCharacter = true && temp != null)
                    {
                        characterSlot1.Add(temp);
                    }

                    else
                    {
                        if (characterSlot1.Count <= 0)
                            Console.WriteLine("No chracters found!");
                    }

                    characterMenu();
                }
            }

            #endregion

            #region Loat Slot 2

            if (loadSlot_Choice == 2)
            {

                characterSlot2.Clear();

                string profile = "";
                string name = "";
                int distanceTravelled = 0;
                int gold = 0;
                int level = 0;
                int exp = 0;
                int strength = 0;
                int vitality = 0;
                int dexterity = 0;
                int intelligence = 0;
                int hp = 0;
                int stamina = 0;
                int statPoints = 0;

                //Item
                int itemType = 0;
                int defence = 0;
                int type = 0;
                int damageMin = 0;
                int damageMax = 0;
                int buyValue = 0;
                int sellValue = 0;
                int rarity = 0;


                using (StreamReader readtext = new StreamReader(saveSlot2))
                {

                    Character temp = new Character();
                    bool secondCharacter = false;

                    while ((profile = readtext.ReadLine()) != null)
                    {
                        end = false;
                        List<string> itemsList = new List<string>();

                        itemsList = profile.Split(' ').ToList();
                        if (itemsList[0] == "")
                        {
                            break;
                        }

                        if (Convert.ToInt32(itemsList[0]) == 3)
                        {
                            if (secondCharacter)
                            {
                                characterSlot2.Add(temp);
                            }

                            if (profile != null)
                            {
                                name = itemsList[1];
                                int.TryParse(itemsList[2], out distanceTravelled);
                                int.TryParse(itemsList[3], out gold);
                                int.TryParse(itemsList[4], out level);
                                int.TryParse(itemsList[5], out exp);
                                int.TryParse(itemsList[6], out strength);
                                int.TryParse(itemsList[7], out vitality);
                                int.TryParse(itemsList[8], out dexterity);
                                int.TryParse(itemsList[9], out intelligence);
                                int.TryParse(itemsList[10], out hp);
                                int.TryParse(itemsList[11], out stamina);
                                int.TryParse(itemsList[12], out statPoints);

                                temp = new Character
                                {
                                    name = name,
                                    distanceTravelled = distanceTravelled,
                                    gold = gold,
                                    level = level,
                                    exp = exp,
                                    strength = strength,
                                    vitality = vitality,
                                    dexterity = dexterity,
                                    intelligence = intelligence,
                                    hp = hp,
                                    stamina = stamina,
                                    statPoints = statPoints
                                };

                                temp.updateStats(); //updating formulas/statistics

                                bool whil = true;
                                int actualPosition = 13;


                                while (whil)
                                {
                                    if (Convert.ToInt32(itemsList[actualPosition]) == 0)
                                    {
                                        //Weapon
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out damageMin);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out damageMax);

                                        Weapon weapon = new Weapon(level, rarity) { damageMin = damageMin, damageMax = damageMax, name = name, itemType = itemType, buyValue = buyValue, sellValue = sellValue };
                                        temp.weapon = weapon;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 0)
                                    {
                                        //Armors head
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_head = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_head = armor_head;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 1)
                                    {
                                        //armors chest
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_chest = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_chest = armor_chest;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 2)
                                    {
                                        //armors arms
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_arms = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_arms = armor_arms;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 3)
                                    {
                                        //armors legs
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_legs = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_legs = armor_legs;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == -1 && actualPosition == 12)
                                    {
                                        actualPosition += 7;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == -1)
                                    {
                                        actualPosition += 7;
                                    }


                                    actualPosition++;
                                    if (actualPosition + 1 == itemsList.Count)
                                        whil = false;
                                }
                                Console.WriteLine($"Character {temp.name} loaded!");
                                secondCharacter = true;
                            }
                        }
                        else if (Convert.ToInt32(itemsList[0]) == 0 || Convert.ToInt32(itemsList[0]) == 1)
                        {
                            int h = 0;
                            int position = 0;
                            while (end == false)
                            {
                                if (itemsList.Count == 1)
                                    end = true;
                                for (int i = position; i < itemsList.Count - 2; i++)
                                {
                                    int.TryParse(itemsList[h], out itemType);
                                    h++;
                                    if (itemType == 0)
                                    {
                                        name = itemsList[h];
                                        h++;
                                        int.TryParse(itemsList[h], out level);
                                        h++;
                                        int.TryParse(itemsList[h], out rarity);
                                        h++;
                                        int.TryParse(itemsList[h], out buyValue);
                                        h++;
                                        int.TryParse(itemsList[h], out sellValue);
                                        h++;
                                        int.TryParse(itemsList[h], out damageMin);
                                        h++;
                                        int.TryParse(itemsList[h], out damageMax);
                                        h++;

                                        temp.addItem(new Weapon(level, rarity) { damageMin = damageMin, damageMax = damageMax, name = name, buyValue = buyValue, sellValue = sellValue });
                                    }

                                    else if (itemType == 1)
                                    {

                                        name = itemsList[h];
                                        h++;
                                        int.TryParse(itemsList[h], out level);
                                        h++;
                                        int.TryParse(itemsList[h], out rarity);
                                        h++;
                                        int.TryParse(itemsList[h], out buyValue);
                                        h++;
                                        int.TryParse(itemsList[h], out sellValue);
                                        h++;
                                        int.TryParse(itemsList[h], out defence);
                                        h++;
                                        int.TryParse(itemsList[h], out type);
                                        h++;

                                        temp.addItem(new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue });

                                    }

                                    i = i + 7;

                                    if (h == (itemsList.Count - 1))
                                        end = true;
                                }
                            }

                            characterSlot2.Add(temp);
                            secondCharacter = false;
                            temp = null;
                        }

                    }

                    if (secondCharacter = true && temp != null)
                    {
                        characterSlot2.Add(temp);
                    }

                    else
                    {
                        if (characterSlot2.Count <= 0)
                            Console.WriteLine("No chracters found!");
                    }
                }
            }

            #endregion

            #region Loat Slot 3

            if (loadSlot_Choice == 3)
            {

                characterSlot3.Clear();

                string profile = "";
                string name = "";
                int distanceTravelled = 0;
                int gold = 0;
                int level = 0;
                int exp = 0;
                int strength = 0;
                int vitality = 0;
                int dexterity = 0;
                int intelligence = 0;
                int hp = 0;
                int stamina = 0;
                int statPoints = 0;

                //Item
                int itemType = 0;
                int defence = 0;
                int type = 0;
                int damageMin = 0;
                int damageMax = 0;
                int buyValue = 0;
                int sellValue = 0;
                int rarity = 0;


                using (StreamReader readtext = new StreamReader(saveSlot3))
                {

                    Character temp = new Character();
                    bool secondCharacter = false;

                    while ((profile = readtext.ReadLine()) != null)
                    {
                        end = false;
                        List<string> itemsList = new List<string>();

                        itemsList = profile.Split(' ').ToList();
                        if (itemsList[0] == "")
                        {
                            break;
                        }

                        if (Convert.ToInt32(itemsList[0]) == 3)
                        {
                            if (secondCharacter)
                            {
                                characterSlot3.Add(temp);
                            }

                            if (profile != null)
                            {
                                name = itemsList[1];
                                int.TryParse(itemsList[2], out distanceTravelled);
                                int.TryParse(itemsList[3], out gold);
                                int.TryParse(itemsList[4], out level);
                                int.TryParse(itemsList[5], out exp);
                                int.TryParse(itemsList[6], out strength);
                                int.TryParse(itemsList[7], out vitality);
                                int.TryParse(itemsList[8], out dexterity);
                                int.TryParse(itemsList[9], out intelligence);
                                int.TryParse(itemsList[10], out hp);
                                int.TryParse(itemsList[11], out stamina);
                                int.TryParse(itemsList[12], out statPoints);

                                temp = new Character
                                {
                                    name = name,
                                    distanceTravelled = distanceTravelled,
                                    gold = gold,
                                    level = level,
                                    exp = exp,
                                    strength = strength,
                                    vitality = vitality,
                                    dexterity = dexterity,
                                    intelligence = intelligence,
                                    hp = hp,
                                    stamina = stamina,
                                    statPoints = statPoints
                                };

                                temp.updateStats(); //updating formulas/statistics

                                bool whil = true;
                                int actualPosition = 13;


                                while (whil)
                                {
                                    if (Convert.ToInt32(itemsList[actualPosition]) == 0)
                                    {
                                        //Weapon
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out damageMin);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out damageMax);

                                        Weapon weapon = new Weapon(level, rarity) { damageMin = damageMin, damageMax = damageMax, name = name, itemType = itemType, buyValue = buyValue, sellValue = sellValue };
                                        temp.weapon = weapon;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 0)
                                    {
                                        //Armors head
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_head = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_head = armor_head;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 1)
                                    {
                                        //armors chest
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_chest = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_chest = armor_chest;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 2)
                                    {
                                        //armors arms
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_arms = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_arms = armor_arms;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 3)
                                    {
                                        //armors legs
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_legs = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_legs = armor_legs;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == -1 && actualPosition == 12)
                                    {
                                        actualPosition += 7;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == -1)
                                    {
                                        actualPosition += 7;
                                    }


                                    actualPosition++;
                                    if (actualPosition + 1 == itemsList.Count)
                                        whil = false;
                                }
                                Console.WriteLine($"Character {temp.name} loaded!");
                                secondCharacter = true;
                            }
                        }
                        else if (Convert.ToInt32(itemsList[0]) == 0 || Convert.ToInt32(itemsList[0]) == 1)
                        {
                            int h = 0;
                            int position = 0;
                            while (end == false)
                            {
                                if (itemsList.Count == 1)
                                    end = true;
                                for (int i = position; i < itemsList.Count - 2; i++)
                                {
                                    int.TryParse(itemsList[h], out itemType);
                                    h++;
                                    if (itemType == 0)
                                    {
                                        name = itemsList[h];
                                        h++;
                                        int.TryParse(itemsList[h], out level);
                                        h++;
                                        int.TryParse(itemsList[h], out rarity);
                                        h++;
                                        int.TryParse(itemsList[h], out buyValue);
                                        h++;
                                        int.TryParse(itemsList[h], out sellValue);
                                        h++;
                                        int.TryParse(itemsList[h], out damageMin);
                                        h++;
                                        int.TryParse(itemsList[h], out damageMax);
                                        h++;

                                        temp.addItem(new Weapon(level, rarity) { damageMin = damageMin, damageMax = damageMax, name = name, buyValue = buyValue, sellValue = sellValue });
                                    }

                                    else if (itemType == 1)
                                    {

                                        name = itemsList[h];
                                        h++;
                                        int.TryParse(itemsList[h], out level);
                                        h++;
                                        int.TryParse(itemsList[h], out rarity);
                                        h++;
                                        int.TryParse(itemsList[h], out buyValue);
                                        h++;
                                        int.TryParse(itemsList[h], out sellValue);
                                        h++;
                                        int.TryParse(itemsList[h], out defence);
                                        h++;
                                        int.TryParse(itemsList[h], out type);
                                        h++;

                                        temp.addItem(new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue });

                                    }

                                    i = i + 7;

                                    if (h == (itemsList.Count - 1))
                                        end = true;
                                }
                            }

                            characterSlot3.Add(temp);
                            secondCharacter = false;
                            temp = null;
                        }

                    }

                    if (secondCharacter = true && temp != null)
                    {
                        characterSlot3.Add(temp);
                    }

                    else
                    {
                        if (characterSlot3.Count <= 0)
                            Console.WriteLine("No chracters found!");
                    }
                }
            }

            #endregion

            #region Loat Slot 4

            if (loadSlot_Choice == 4)
            {

                characterSlot4.Clear();

                string profile = "";
                string name = "";
                int distanceTravelled = 0;
                int gold = 0;
                int level = 0;
                int exp = 0;
                int strength = 0;
                int vitality = 0;
                int dexterity = 0;
                int intelligence = 0;
                int hp = 0;
                int stamina = 0;
                int statPoints = 0;

                //Item
                int itemType = 0;
                int defence = 0;
                int type = 0;
                int damageMin = 0;
                int damageMax = 0;
                int buyValue = 0;
                int sellValue = 0;
                int rarity = 0;


                using (StreamReader readtext = new StreamReader(saveSlot4))
                {

                    Character temp = new Character();
                    bool secondCharacter = false;

                    while ((profile = readtext.ReadLine()) != null)
                    {
                        end = false;
                        List<string> itemsList = new List<string>();

                        itemsList = profile.Split(' ').ToList();
                        if (itemsList[0] == "")
                        {
                            break;
                        }

                        if (Convert.ToInt32(itemsList[0]) == 3)
                        {
                            if (secondCharacter)
                            {
                                characterSlot4.Add(temp);
                            }

                            if (profile != null)
                            {
                                name = itemsList[1];
                                int.TryParse(itemsList[2], out distanceTravelled);
                                int.TryParse(itemsList[3], out gold);
                                int.TryParse(itemsList[4], out level);
                                int.TryParse(itemsList[5], out exp);
                                int.TryParse(itemsList[6], out strength);
                                int.TryParse(itemsList[7], out vitality);
                                int.TryParse(itemsList[8], out dexterity);
                                int.TryParse(itemsList[9], out intelligence);
                                int.TryParse(itemsList[10], out hp);
                                int.TryParse(itemsList[11], out stamina);
                                int.TryParse(itemsList[12], out statPoints);

                                temp = new Character
                                {
                                    name = name,
                                    distanceTravelled = distanceTravelled,
                                    gold = gold,
                                    level = level,
                                    exp = exp,
                                    strength = strength,
                                    vitality = vitality,
                                    dexterity = dexterity,
                                    intelligence = intelligence,
                                    hp = hp,
                                    stamina = stamina,
                                    statPoints = statPoints
                                };

                                temp.updateStats(); //updating formulas/statistics

                                bool whil = true;
                                int actualPosition = 13;


                                while (whil)
                                {
                                    if (Convert.ToInt32(itemsList[actualPosition]) == 0)
                                    {
                                        //Weapon
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out damageMin);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out damageMax);

                                        Weapon weapon = new Weapon(level, rarity) { damageMin = damageMin, damageMax = damageMax, name = name, itemType = itemType, buyValue = buyValue, sellValue = sellValue };
                                        temp.weapon = weapon;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 0)
                                    {
                                        //Armors head
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_head = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_head = armor_head;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 1)
                                    {
                                        //armors chest
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_chest = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_chest = armor_chest;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 2)
                                    {
                                        //armors arms
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_arms = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_arms = armor_arms;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == 1 && Convert.ToInt32(itemsList[actualPosition + 7]) == 3)
                                    {
                                        //armors legs
                                        int.TryParse(itemsList[actualPosition], out itemType);
                                        actualPosition++;
                                        name = itemsList[actualPosition];
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out level);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out rarity);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out buyValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out sellValue);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out defence);
                                        actualPosition++;
                                        int.TryParse(itemsList[actualPosition], out type);

                                        Armor armor_legs = new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue };
                                        temp.armor_legs = armor_legs;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == -1 && actualPosition == 12)
                                    {
                                        actualPosition += 7;
                                    }

                                    else if (Convert.ToInt32(itemsList[actualPosition]) == -1)
                                    {
                                        actualPosition += 7;
                                    }


                                    actualPosition++;
                                    if (actualPosition + 1 == itemsList.Count)
                                        whil = false;
                                }
                                Console.WriteLine($"Character {temp.name} loaded!");
                                secondCharacter = true;
                            }
                        }
                        else if (Convert.ToInt32(itemsList[0]) == 0 || Convert.ToInt32(itemsList[0]) == 1)
                        {
                            int h = 0;
                            int position = 0;
                            while (end == false)
                            {
                                if (itemsList.Count == 1)
                                    end = true;
                                for (int i = position; i < itemsList.Count - 2; i++)
                                {
                                    int.TryParse(itemsList[h], out itemType);
                                    h++;
                                    if (itemType == 0)
                                    {
                                        name = itemsList[h];
                                        h++;
                                        int.TryParse(itemsList[h], out level);
                                        h++;
                                        int.TryParse(itemsList[h], out rarity);
                                        h++;
                                        int.TryParse(itemsList[h], out buyValue);
                                        h++;
                                        int.TryParse(itemsList[h], out sellValue);
                                        h++;
                                        int.TryParse(itemsList[h], out damageMin);
                                        h++;
                                        int.TryParse(itemsList[h], out damageMax);
                                        h++;

                                        temp.addItem(new Weapon(level, rarity) { damageMin = damageMin, damageMax = damageMax, name = name, buyValue = buyValue, sellValue = sellValue });
                                    }

                                    else if (itemType == 1)
                                    {

                                        name = itemsList[h];
                                        h++;
                                        int.TryParse(itemsList[h], out level);
                                        h++;
                                        int.TryParse(itemsList[h], out rarity);
                                        h++;
                                        int.TryParse(itemsList[h], out buyValue);
                                        h++;
                                        int.TryParse(itemsList[h], out sellValue);
                                        h++;
                                        int.TryParse(itemsList[h], out defence);
                                        h++;
                                        int.TryParse(itemsList[h], out type);
                                        h++;

                                        temp.addItem(new Armor(level, rarity, type) { defence = defence, name = name, buyValue = buyValue, sellValue = sellValue });

                                    }

                                    i = i + 7;

                                    if (h == (itemsList.Count - 1))
                                        end = true;
                                }
                            }

                            characterSlot4.Add(temp);
                            secondCharacter = false;
                            temp = null;
                        }

                    }

                    if (secondCharacter = true && temp != null)
                    {
                        characterSlot4.Add(temp);
                    }

                    else
                    {
                        if (characterSlot4.Count <= 0)
                            Console.WriteLine("No chracters found!");
                    }
                }
            }

            #endregion
        }


        #endregion

        #region Get Playing

        public bool getPlaying()
        {
            return this.playing;
        }

        #endregion

        /* |+| /_______ ___________ ______ _ ________________________ _ _____ ___   _____ _____  _______________  ______ _\ |-| */

        #region Create New Character

        public void createNewCharacter()
        {
            #region Create New Character (Slot 1)

            if (createSlot_Choice == 1)
            {

                Console.Write("Enter character name: ");
                string name = Console.ReadLine();

                for (int i = 0; i < characterSlot1.Count; i++)
                {
                    if (name == characterSlot1[i].name)
                    {
                        i = -1;
                        Console.Write("Error! Character already exists!");
                        Console.Write("\nEnter character name: ");
                        name = Console.ReadLine();
                    }
                }

                characterSlot1.Add(new Character());
                activeCharacter = characterSlot1.Count - 1;
                characterSlot1[activeCharacter].initialize(name);
            }

            #endregion

            #region Create New Character (Slot 2)

            if (createSlot_Choice == 2)
            {

                Console.Write("Enter character name: ");
                string name = Console.ReadLine();

                for (int i = 0; i < characterSlot2.Count; i++)
                {
                    if (name == characterSlot2[i].name)
                    {
                        i = -1;
                        Console.Write("Error! Character already exists!");
                        Console.Write("\nEnter character name: ");
                        name = Console.ReadLine();
                    }
                }

                characterSlot2.Add(new Character());
                activeCharacter = characterSlot2.Count - 1;
                characterSlot2[activeCharacter].initialize(name);
            }

            #endregion

            #region Create New Character (Slot 3)

            if (createSlot_Choice == 3)
            {

                Console.Write("Enter character name: ");
                string name = Console.ReadLine();

                for (int i = 0; i < characterSlot3.Count; i++)
                {
                    if (name == characterSlot3[i].name)
                    {
                        i = -1;
                        Console.Write("Error! Character already exists!");
                        Console.Write("\nEnter character name: ");
                        name = Console.ReadLine();
                    }
                }

                characterSlot3.Add(new Character());
                activeCharacter = characterSlot3.Count - 1;
                characterSlot3[activeCharacter].initialize(name);
            }

            #endregion

            #region Create New Character (Slot 4)

            if (createSlot_Choice == 4)
            {

                Console.Write("Enter character name: ");
                string name = Console.ReadLine();

                for (int i = 0; i < characterSlot4.Count; i++)
                {
                    if (name == characterSlot4[i].name)
                    {
                        i = -1;
                        Console.Write("Error! Character already exists!");
                        Console.Write("\nEnter character name: ");
                        name = Console.ReadLine();
                    }
                }

                characterSlot4.Add(new Character());
                activeCharacter = characterSlot4.Count - 1;
                characterSlot4[activeCharacter].initialize(name);
            }

            #endregion
        }

        #endregion

        #region Save Character

        public void saveCharacters()
        {

            #region Save Slot 1

            if (createSlot_Choice == 1)
            {
                using (StreamWriter writetext = new StreamWriter(saveSlot1))
                {
                    for (int i = 0; i < characterSlot1.Count; i++)
                    {
                        writetext.WriteLine($"3 {characterSlot1[i].getAsString()}");
                        if (characterSlot1[i].getInvAsStringSave() != "")
                        {
                            writetext.WriteLine($"{characterSlot1[i].getInvAsStringSave()}");
                        }
                    }
                }
            }

            #endregion

            #region Save Slot 2

            if (createSlot_Choice == 2)
            {
                using (StreamWriter writetext = new StreamWriter(saveSlot2))
                {
                    for (int i = 0; i < characterSlot2.Count; i++)
                    {
                        writetext.WriteLine($"3 {characterSlot2[i].getAsString()}");
                        if (characterSlot2[i].getInvAsStringSave() != "")
                        {
                            writetext.WriteLine($"{characterSlot2[i].getInvAsStringSave()}");
                        }
                    }
                }
            }

            #endregion

            #region Save Slot 3

            if (createSlot_Choice == 3)
            {
                using (StreamWriter writetext = new StreamWriter(saveSlot3))
                {
                    for (int i = 0; i < characterSlot3.Count; i++)
                    {
                        writetext.WriteLine($"3 {characterSlot3[i].getAsString()}");
                        if (characterSlot3[i].getInvAsStringSave() != "")
                        {
                            writetext.WriteLine($"{characterSlot3[i].getInvAsStringSave()}");
                        }
                    }
                }
            }

            #endregion

            #region Save Slot 4

            if (createSlot_Choice == 4)
            {
                using (StreamWriter writetext = new StreamWriter(saveSlot4))
                {
                    for (int i = 0; i < characterSlot4.Count; i++)
                    {
                        writetext.WriteLine($"3 {characterSlot4[i].getAsString()}");
                        if (characterSlot4[i].getInvAsStringSave() != "")
                        {
                            writetext.WriteLine($"{characterSlot4[i].getInvAsStringSave()}");
                        }
                    }
                }
            }

            #endregion

        }

        #endregion


        /* |+| /_______ ___________ ______ _ ________________________ _ _____ ___   _____ _____  _______________  ______ _\ |-| */

        #region Start Menu

        public void startMenu()
        {

            Message.welcomeMessage();

                Console.Write("\n= Conviction = \n");
                Console.WriteLine("\n0: Quit Game ");
                Console.WriteLine("1: Start New Game ");
                Console.WriteLine("2: Continue Game ");
                Console.WriteLine("3: Controls ");
                Console.WriteLine("4: About ");

            Console.Write("\nChoice: ");

                //choice get & check loop
                do
                {
                    string strchoice = Console.ReadLine();
                    bool success = Int32.TryParse(strchoice, out choice);
                    if (success && Enumerable.Range(0, 5).Contains(choice))
                        break;
                    else
                        Console.Write("\nWrong choice. Please enter new choice (0-4): ");
                }
                while (true);

                switch (choice)
                {
                    case 0: //quit
                        playing = false;
                        Message.exitMessage();
                        break;
                    case 1: // Start New Game
                        createSlot();
                        break;
                    case 2: // Continue Game
                        loadSlot();
                        break;
                    case 3: // Controls
                        Console.WriteLine("");
                        break;
                    case 4: // About
                        Console.WriteLine("");
                        break;
                    default:
                        break;
                }
            }

        #endregion

        #region Save Slot Functions

        public void createSlot()
        {
                Console.Clear();

            Message.MainMenu_Border();


                Console.Write("\n= Slot Menu = \n");
                Console.WriteLine("\n0: Quit Game ");
                Console.WriteLine("1: Save Slot 1 ");
                Console.WriteLine("2: Save Slot 2 ");
                Console.WriteLine("3: Save Slot 3 ");
                Console.WriteLine("4: Save Slot 4 ");

                Console.Write("\nChoice: ");

                //choice get & check loop

                do
                {
                    string strchoice = Console.ReadLine();
                    bool success = Int32.TryParse(strchoice, out createSlot_Choice);
                    if (success && Enumerable.Range(0, 5).Contains(createSlot_Choice))
                        break;
                    else
                        Console.Write("\nWrong choice. Please enter new choice (0-4): ");
                }

                while (true);

                switch (createSlot_Choice)
                {
                    case 0: //quit
                        playing = false;
                        Message.exitMessage();
                        break;
                    case 1: // Save Slot 1
                        saveSlotGame();
                        break;
                    case 2: // Save Slot 2
                        saveSlotGame();
                        break;
                    case 3: // Save Slot 3
                        saveSlotGame();
                        break;
                    case 4: // Save Slot 4
                        saveSlotGame();
                        break;
                    default:
                        break;
                }
            }

        #endregion

        #region Load Slot Functions

        public void loadSlot()
        {
            Console.Clear();

            Message.MainMenu_Border();


            Console.Write("\n= Slot Menu = \n");
            Console.WriteLine("\n0: Quit Game ");
            Console.WriteLine("1: Load Slot 1 ");
            Console.WriteLine("2: Load Slot 2 ");
            Console.WriteLine("3: Load Slot 3 ");
            Console.WriteLine("4: Load Slot 4 ");

            Console.Write("\nChoice: ");

            //choice get & check loop

            do
            {
                string strchoice = Console.ReadLine();
                bool success = Int32.TryParse(strchoice, out loadSlot_Choice);
                if (success && Enumerable.Range(0, 5).Contains(loadSlot_Choice))
                    break;
                else
                    Console.Write("\nWrong choice. Please enter new choice (0-4): ");
            }

            while (true);

            switch (loadSlot_Choice)
            {
                case 0: //quit
                    playing = false;
                    Message.exitMessage();
                    break;
                case 1: // Save Slot 1
                    loadSlotGame();
                    break;
                case 2: // Save Slot 2
                    loadSlotGame();
                    break;
                case 3: // Save Slot 3
                    loadSlotGame();
                    break;
                case 4: // Save Slot 4
                    loadSlotGame();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Character Menu
        public void characterMenu()
        {
            do
            {
                if (loadSlot_Choice == 1) //print stats from main menu
                {
                    characterSlot1[activeCharacter].printStats();
                }

                Console.WriteLine("Enter to continue...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("= CHARACTER MENU =\n\n");

                Console.WriteLine("0: Back to main menu");
                Console.WriteLine("1: Print inventory");
                Console.WriteLine("2: Equip item");

                Console.Write("Your choice: ");
                do
                {
                    string strchoice = Console.ReadLine();
                    bool success = Int32.TryParse(strchoice, out choice);
                    if (success && Enumerable.Range(0, 3).Contains(choice))
                        break;
                    else
                        Console.Write("\nWrong choice. Please enter new choice (0-2): ");
                }
                while (true);

                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine(characterSlot1[activeCharacter].getInvAsString());
                        break;
                    case 2:
                        Console.WriteLine(characterSlot1[activeCharacter].getInvAsString());

                        Console.WriteLine("Item index");


                        Console.Write("Your choice: ");
                        do
                        {
                            string strchoice = Console.ReadLine();
                            bool success = Int32.TryParse(strchoice, out choice);
                            if (success && Enumerable.Range(0, characterSlot1[activeCharacter].getInventorySize()).Contains(choice))
                                break;
                            else
                                Console.Write("\nWrong choice. Please enter new choice (0-1): ");
                        }
                        while (true);

                        characterSlot1[activeCharacter].equipItem(choice);
                        break;
                    default:
                        break;
                }
            }
            while (choice != 0);

        }

        #endregion

    }
}
