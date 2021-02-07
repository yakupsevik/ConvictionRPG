using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvictionRPG
{
    class Character
    {
        Inventory inventory = new Inventory();
        Random random = new Random();
        public Weapon weapon { get; set; } = new Weapon();
        public Armor armor_head { get; set; } = new Armor();
        public Armor armor_chest { get; set; } = new Armor();
        public Armor armor_arms { get; set; } = new Armor();
        public Armor armor_legs { get; set; } = new Armor();

        public string name { get; set; }
        public double level { get; set; }
        public double exp { get; set; }
        public double expNext { get; set; }
        public int gold { get; set; }

        public int hpMax { get; set; }
        public int hp { get; set; }
        public int stamina { get; set; }
        public int staminaMax { get; set; }
        public int damageMin { get; set; }
        public int damageMax { get; set; }
        public int defence { get; set; }
        public int accuracy { get; set; }
        public int luck { get; set; }

        public int strength { get; set; }
        public int vitality { get; set; }
        public int dexterity { get; set; }
        public int intelligence { get; set; }
        public int statPoints { get; set; }
        public int distanceTravelled { get; set; }

        public void initialize(string name)
        {
            distanceTravelled = 0;

            gold = 100;

            this.name = name;
            level = 1;
            exp = 20;
            hp = 50;

            strength = 5;
            vitality = 5;
            dexterity = 5;
            intelligence = 5;

            statPoints = 0;
            

            updateStats();
        }

        public void printStats()
        {
            Console.WriteLine($"= Character Sheet =");
            Console.WriteLine($"= Name: {name}");
            Console.WriteLine($"= Level: {level}");
            Console.WriteLine($"= Exp: {exp}");
            Console.WriteLine($"= Exp to next level: {expNext}\n");
            Console.WriteLine($"= Statpoints: {statPoints}\n");
            Console.WriteLine($"= Strength: {strength}");
            Console.WriteLine($"= Vitality: {vitality}");
            Console.WriteLine($"= Dexterity: {dexterity}");
            Console.WriteLine($"= Intelligence: {intelligence}\n");
            Console.WriteLine($"= HP: {hp}/{hpMax}");
            Console.WriteLine($"= Stamina: {stamina}/{staminaMax}");
            Console.WriteLine($"= Damage: {damageMin} (+ {weapon.damageMin}) /{damageMax} (+ {weapon.damageMin})");
            Console.WriteLine($"= Defence: {defence} + ({getAddedDefence().ToString()})");
            Console.WriteLine($"= Accuracy: {accuracy}");
            Console.WriteLine($"= Luck: {luck} \n");
            Console.WriteLine($"= Distance Travelled: {distanceTravelled}");
            Console.WriteLine($"= Gold: {gold} \n");
            Console.WriteLine($"= Weapon: {weapon.name} " +
                $"Lvl: {weapon.level} " +
                $"Dam {weapon.damageMin} - {weapon.damageMax}");

            Console.WriteLine($"= Armor (head) : {armor_head.name} " +
                $"Lvl: {armor_head.level} " +
                $"Def: {armor_head.defence}");

            Console.WriteLine($"= Armor (chest): {armor_chest.name} " +
                $"Lvl: {armor_chest.level} " +
                $"Def: {armor_chest.defence}");

            Console.WriteLine($"= Armor (arms) : {armor_arms.name} " +
                $"Lvl: {armor_arms.level} " +
                $"Def: {armor_arms.defence}");

            Console.WriteLine($"= Armor (legs) : {armor_legs.name} " +
                $"Lvl: {armor_legs.level} " +
                $"Def: {armor_legs.defence}\n");
        }

        public void updateStats()
        {
            expNext = ((50 / 3) * ((Math.Pow(level, 3) - 6 * Math.Pow(level, 2)) + 17 * level - 12)) + 100; //formula for harder next levels

            hpMax = (int)((vitality * 5) + (strength) + (level * 5));
            staminaMax = vitality + strength / 2 + dexterity / 3;
            stamina = staminaMax;
            damageMin = strength;
            damageMax = strength + 2;
            defence = dexterity + intelligence / 2;
            accuracy = dexterity / 2 + intelligence;
            luck = intelligence;

            hp = hpMax;
        }

        public void levelUp()
        {
            if(exp >= expNext)
            {
                exp -= expNext;
                level++;
                expNext = ((50 / 3) * ((Math.Pow(level, 3) - 6 * Math.Pow(level, 2)) + 17 * level - 12)) + 100;

                statPoints++;

                updateStats();

                Console.WriteLine("Your level was upgraded to : " + level);
            }
            else
                Console.WriteLine("You don't have enough exp to level up!");
        }

        public void gainExp(int exp)
        {
            this.exp += exp;
        }

        public void gainGold(int gold)
        {
            this.gold += gold;
        }

        public int getInventorySize()
        {
            return inventory.size();
        }

        public string getAsString()
        {
            return name + " "
                + distanceTravelled.ToString() + " "
                + gold.ToString() + " "
                + level.ToString() + " "
                + exp.ToString() + " "
                + strength.ToString() + " "
                + vitality.ToString() + " "
                + dexterity.ToString() + " "
                + intelligence.ToString() + " "
                + hp.ToString() + " "
                + stamina.ToString() + " "
                + statPoints.ToString() + " "
                + weapon.toStringSave()
                + armor_head.toStringSave()
                + armor_chest.toStringSave()
                + armor_arms.toStringSave()
                + armor_legs.toStringSave();
        }

        public string getInvAsString(bool shop = false)
        {
            string inv = null;

            if (shop)
            {
                for (int i = 0; i < inventory.size(); i++)
                {
                    inv += i.ToString() + ": " + inventory[i].toString() + " |Sell value: " + inventory[i].sellValue + "\n";
                }
                return inv;
            }
            else
            {
                for (int i = 0; i < inventory.size(); i++)
                {
                    inv += i.ToString() + ": " + inventory[i].toString() + "\n";
                }
                return inv;
            }
        }

        public string getInvAsStringSave()
        {
            string inv = "";

            for (int i = 0; i < inventory.size(); i++)
            {
                if (inventory[i].itemType == 0)
                    inv += inventory[i].toStringSave();
            }

            for (int i = 0; i < inventory.size(); i++)
            {
                if (inventory[i].itemType == 1)
                    inv += inventory[i].toStringSave();
            }
            return inv;
        }

        public void addToStat(int stat, int value)
        {
            if (statPoints < value)
                Console.WriteLine("Error! Not enough stat points!");
            else
            {
                switch (stat)
                {
                    case 0:
                        strength += value;
                        Console.WriteLine("Strength increased!");
                        break;
                    case 1:
                        vitality += value;
                        Console.WriteLine("Vitality increased!");
                        break;
                    case 2:
                        dexterity += value;
                        Console.WriteLine("Dexterity increased!");
                        break;
                    case 3:
                        intelligence += value;
                        Console.WriteLine("Intelligence increased!");
                        break;
                    default:
                        break;
                }

                statPoints -= value;

                updateStats();
            }
        }

        public void resetHP()
        {
            hp = hpMax;
        }

        public void payGold(int gold)
        {
            this.gold -= gold;
        }

        public void takeDamage(int damage)
        {
            hp -= damage;

            if(hp <= 0)
            {
                hp = 0;
            }
        }

        public int getDamage()
        {
            return random.Next(damageMin + weapon.damageMin, damageMax + weapon.damageMax);
        }

        public bool isAlive()
        {
            return hp > 0;
        }

        public int getAddedDefence()
        {
            return armor_head.defence + armor_chest.defence + armor_arms.defence + armor_legs.defence;
        }

        public void addItem(Item item)
        {
            inventory.addItem(item);
        }

        public void removeItem(int index)
        {
            if (index < 0 || index >= inventory.size())
            {
                Console.WriteLine("Error. No such item (removeItem).");
            }
            else
            {
                inventory.removeItem(index);
            }
        }

        public Item getItem(int index)
        {
            if (index < 0 || index >= inventory.size())
                Console.WriteLine("Error. No such item (getItem).");

            return inventory[index];
        }

        public void equipItem(int index)
        {
            if (index < 0 || index >= inventory.size())
            {
                Console.WriteLine("No valid item selected!\n\n");
            }

            else
            {
                var type = inventory[index].GetType();

                
                

                //is weapon
                if (type.Equals(typeof(Weapon)))
                {
                    Weapon w = (Weapon)inventory[index];
                    if (weapon.rarity >= 0)
                        inventory.addItem(weapon);
                    weapon = w;
                    inventory.removeItem(index);
                }
                else if (type.Equals(typeof(Armor)))
                {
                    Armor a = (Armor)inventory[index];
                    switch (a.typeStr)
                    {
                        case "Head":
                            if (armor_head.rarity >= 0)
                                inventory.addItem(armor_head);
                            armor_head = a;
                            inventory.removeItem(index);
                            break;
                        case "Chest":
                            if (armor_chest.rarity >= 0)
                                inventory.addItem(armor_chest);
                            armor_chest = a;
                            inventory.removeItem(index);
                            break;
                        case "Arms":
                            if (armor_arms.rarity >= 0)
                                inventory.addItem(armor_arms);
                            armor_arms = a;
                            inventory.removeItem(index);
                            break;
                        case "Legs":
                            if (armor_legs.rarity >= 0)
                                inventory.addItem(armor_legs);
                            armor_legs = a;
                            inventory.removeItem(index);
                            break;
                        default:
                            Console.WriteLine("Error! Armor type invalid!");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Error! Equip item is not armor or weapon!");
                }
            }
        }
    }
}
