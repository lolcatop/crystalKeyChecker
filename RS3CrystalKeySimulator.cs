/* Made by iMossyS with some help from Saradomin, much love sir :)
 * If you use this in some sort of video, please do credit me in the description. 
 * YT: https://www.youtube.com/c/MossyRS
 * This took me a ton of time, so I'd appreciate a sub or a like on the video :)
 * Enjoy it! DM me on discord with questions: mossy#0639
 */

using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Threading;

namespace Examples.System.Net
{
    public class RS3CrystalKeySimulator
    {
        const int dragonstoneKey = 6800;
        const int possibility1Key = 59;
        const int possibility2Key = 151;
        const int possibility3Key = 244;
        const int possibility4Key = 333;
        const int possibility5Key = 424;
        const int possibility6Key = 514;
        const int possibility7Key = 605;
        const int possibility8Key = 695;
        const int possibility9Key = 772;
        const int possibility10Key = 847;
        const int possibility11Key = 908;
        const int possibility12Key = 1000;

        const int possibility1KeyPrif = 72;
        const int possibility2KeyPrif = 148;
        const int possibility3KeyPrif = 193;
        const int possibility4KeyPrif = 269;
        const int possibility5KeyPrif = 332;
        const int possibility6KeyPrif = 439;
        const int possibility7KeyPrif = 531;
        const int possibility8KeyPrif = 622;
        const int possibility9KeyPrif = 713;
        const int possibility10KeyPrif = 805;
        const int possibility11KeyPrif = 894;
        const int possibility12KeyPrif = 1000;

        public struct Taverley
        {
            public string nameOfItem { get; set; }
            public int valueOfItem { get; set; }
            public int totalOfItem { get; set; }
        }
        public static Taverley CreateTaverley(string nameOfItem, int valueOfItem, int totalOfItem)
        {
            var Taverley = new Taverley
            {
                nameOfItem = nameOfItem,
                valueOfItem = valueOfItem,
                totalOfItem = totalOfItem
            };

            return Taverley;
        }
        public struct Prifdinnas
        {
            public string nameOfItem { get; set; }
            public int valueOfItem { get; set; }
            public int totalOfItem { get; set; }
        }
        public static Prifdinnas CreatePrifdinnas(string nameOfItem, int valueOfItem, int totalOfItem)
        {
            var Prifdinnas = new Prifdinnas
            {
                nameOfItem = nameOfItem,
                valueOfItem = valueOfItem,
                totalOfItem = totalOfItem
            };

            return Prifdinnas;
        }

        public static void Main()
        {
            int tavCoins = 0;

            var generator = new RandomGenerator();
            Console.WriteLine("This program takes roughly 1 minute to retrieve the prices from the Runescape GE, so please be patient!");
            Console.WriteLine("Also, do not spam open and close this program and recheck the prices, Jagex only allows so many calls a minute.");
            Console.WriteLine("Retreiving real-time GE prices...");



            // need coins

            Taverley crystalKey = CreateTaverley("Crystal Key", itemValue(989), 0); // holds value of a crystal key

            Taverley uncutDragonstone = CreateTaverley("Uncut Dragonstone", itemValue(1631), 0);
            Taverley calquatTreeSeed = CreateTaverley("Calquat Seed", itemValue(5290), 0);
            Taverley papayaTreeSeed = CreateTaverley("Papaya Seed", itemValue(5288), 0);
            Taverley palmTreeSeed = CreateTaverley("Palm Seed", itemValue(5289), 0);
            Taverley lantadymeSeed = CreateTaverley("Lantadyme Seed", itemValue(5302), 0);
            Taverley grimyTorstol = CreateTaverley("Grimy Torstol", itemValue(219), 0);
            Taverley lawRune = CreateTaverley("Law Rune", itemValue(563), 0);
            Taverley chaosRune = CreateTaverley("Chaos Rune", itemValue(562), 0);
            Taverley cosmicRune = CreateTaverley("Cosmic Rune", itemValue(564), 0);
            Taverley deathRune = CreateTaverley("Death Rune", itemValue(560), 0);
            Taverley natureRune = CreateTaverley("Nature Rune", itemValue(561), 0);
            Taverley bodyRune = CreateTaverley("Body Rune", itemValue(559), 0);
            Taverley mindRune = CreateTaverley("Mind Rune", itemValue(558), 0);
            Taverley earthRune = CreateTaverley("Earth Rune", itemValue(557), 0);
            Taverley airRune = CreateTaverley("Air Rune", itemValue(556), 0);
            Taverley waterRune = CreateTaverley("Water Rune", itemValue(555), 0);
            Taverley fireRune = CreateTaverley("Fire Rune", itemValue(554), 0);
            Taverley ironStoneSpirit = CreateTaverley("Iron Spirit", itemValue(44801), 0);
            Taverley coalStoneSpirit = CreateTaverley("Coal Spirit", itemValue(44804), 0);
            Taverley runiteStoneSpirit = CreateTaverley("Runite Spirit", itemValue(44808), 0);
            Taverley uncutDiamond = CreateTaverley("Uncut Diamond", itemValue(1617), 0);
            Taverley uncutRuby = CreateTaverley("Uncut Ruby", itemValue(1619), 0);
            Taverley loopHalfOfKey = CreateTaverley("Loop Halves", itemValue(987), 0);
            Taverley toothHalfOfKey = CreateTaverley("Tooth Halves", itemValue(985), 0);
            Taverley hugePlatedRuneSalvage = CreateTaverley("Huge Salvage", itemValue(47314), 0);
            Taverley largePlatedRuneSalvage = CreateTaverley("Large Salvage", itemValue(47312), 0);
            Taverley dragonstoneHelm = CreateTaverley("Dragonstone Helm", itemValue(28541), 0);
            Taverley dragonstoneHauberk = CreateTaverley("Dragonstone Hauberk", itemValue(28539), 0);
            Taverley dragonstoneGreaves = CreateTaverley("Dragonstone Greaves", itemValue(28543), 0);
            Taverley dragonstoneGauntlets = CreateTaverley("Dragonstone Gauntlets", itemValue(28537), 0);
            Taverley dragonstoneBoots = CreateTaverley("Dragonstone Boots", itemValue(28541), 0);

            Taverley[] taverleyObjects = { uncutDragonstone, calquatTreeSeed, papayaTreeSeed, palmTreeSeed, lantadymeSeed, grimyTorstol, lawRune, chaosRune,
            cosmicRune, deathRune, natureRune, bodyRune, mindRune, earthRune, airRune, waterRune, fireRune, ironStoneSpirit, coalStoneSpirit, runiteStoneSpirit, 
            uncutDiamond, uncutRuby, loopHalfOfKey, toothHalfOfKey, hugePlatedRuneSalvage, largePlatedRuneSalvage, dragonstoneHelm, dragonstoneHauberk, dragonstoneGreaves,
            dragonstoneGauntlets, dragonstoneBoots};

            

            // need crystal tree blossom
            // corrupted Ore
            // crystal motherlode shard
            Prifdinnas uncutDragonstonePrif = CreatePrifdinnas("Uncut Dragonstone", taverleyObjects[0].valueOfItem, 0);
            Prifdinnas yewSeed = CreatePrifdinnas("Yew Seeds", itemValue(5315), 0);
            Prifdinnas papayaSeed = CreatePrifdinnas("Papaya Seeds", itemValue(5288), 0);
            Prifdinnas elderSeed = CreatePrifdinnas("Elder Seeds", itemValue(31437), 0);
            Prifdinnas dwarfWeedSeed = CreatePrifdinnas("Dwarf Weed Seeds", itemValue(5303), 0);
            Prifdinnas torstolSeed = CreatePrifdinnas("Torstol Seeds", itemValue(5304), 0);
            Prifdinnas grimyLantadyme = CreatePrifdinnas("Grimy Lantadyme", itemValue(2485), 0);
            Prifdinnas fireTalisman = CreatePrifdinnas("Fire Talisman", itemValue(1442), 0);
            Prifdinnas waterTalisman = CreatePrifdinnas("Water Talisman", itemValue(1444), 0);
            Prifdinnas hugeBladedSalvage = CreatePrifdinnas("Huge Bladed Salvage", itemValue(47284), 0);
            Prifdinnas orichalciteSpirit = CreatePrifdinnas("Orichalcite Spirit", itemValue(44809), 0);
            Prifdinnas drakolithSpirit = CreatePrifdinnas("Drakolith Spirit", itemValue(44810), 0);
            Prifdinnas runiteSpirit = CreatePrifdinnas("Runite Spirit", runiteStoneSpirit.valueOfItem, 0);
            Prifdinnas uncutDiamondPrif = CreatePrifdinnas("Uncut Diamond", uncutDiamond.valueOfItem, 0);
            Prifdinnas uncutRubyPrif = CreatePrifdinnas("Uncut Ruby", uncutRuby.valueOfItem, 0);
            Prifdinnas loopHalfPrif = CreatePrifdinnas("Loop Halves", loopHalfOfKey.valueOfItem, 0);
            Prifdinnas toothHalfPrif = CreatePrifdinnas("Tooth Halves", toothHalfOfKey.valueOfItem, 0);
            Prifdinnas mediumSalvage = CreatePrifdinnas("Medium Salvage", itemValue(47310), 0);
            Prifdinnas largePlatedSalvage = CreatePrifdinnas("Large Salvage", largePlatedRuneSalvage.valueOfItem, 0);
            Prifdinnas dragonstoneHelmPrif = CreatePrifdinnas("Dragonstone Helm", dragonstoneHelm.valueOfItem, 0);
            Prifdinnas dragonstoneHauberkPrif = CreatePrifdinnas("Dragonstone Hauberk", dragonstoneHauberk.valueOfItem, 0);
            Prifdinnas dragonstoneGreavesPrif = CreatePrifdinnas("Dragonstone Greaves", dragonstoneGreaves.valueOfItem, 0);
            Prifdinnas dragonstoneGauntletsPrif = CreatePrifdinnas("Dragonstone Gauntlets", dragonstoneGauntlets.valueOfItem, 0);
            Prifdinnas dragonstoneBootsPrif = CreatePrifdinnas("Dragonstone Boots", dragonstoneBoots.valueOfItem, 0);

            Prifdinnas[] prifdinnasObjects = {uncutDragonstonePrif, yewSeed, papayaSeed, elderSeed, dwarfWeedSeed, torstolSeed, grimyLantadyme, fireTalisman, waterTalisman,
            hugeBladedSalvage, orichalciteSpirit, drakolithSpirit, runiteSpirit, uncutDiamondPrif, uncutRubyPrif, loopHalfPrif,toothHalfPrif, mediumSalvage, largePlatedSalvage,
            dragonstoneHelmPrif, dragonstoneHauberkPrif, dragonstoneGreavesPrif, dragonstoneGauntletsPrif, dragonstoneBootsPrif};
            Console.WriteLine("Data retrieved.");
            Console.WriteLine("How many keys would you like to open?");
            int keys = Convert.ToInt32(Console.ReadLine());
            int crystalTreeBlossoms = 0;
            int corruptedOre = 0;
            int crystalShards = 0;
            int taverleyTotal = 0;
            int prifdinnasTotal = 0;
            bool flag = true;
            while (flag)
            {
                for (int x = 0; x < keys; x++)
                {


                    int dropKeyTaverley = generator.RandomNumber(1, 1001);
                    int dragonstoneDrop = generator.RandomNumber(1, 6801);
                    int dropKeyPrifdinnas = generator.RandomNumber(1, 1001);
                    int dragonStoneDropPrif = generator.RandomNumber(1, 6801);


                    if (dragonstoneDrop == dragonstoneKey)
                    {

                        int dragonstonePick = generator.RandomNumber(1, 6);
                        taverleyObjects[0].totalOfItem += 1; // dragonstone == array[0]
                        if (dragonstonePick == 1)
                        {
                            taverleyObjects[26].totalOfItem += 1; // dstone helm

                        }
                        else if (dragonstonePick == 2)
                        {
                            taverleyObjects[27].totalOfItem += 1; // dstone hauberk
                        }
                        else if (dragonstonePick == 3)
                        {
                            taverleyObjects[28].totalOfItem += 1; // dstone greaves
                        }
                        else if (dragonstonePick == 4)
                        {
                            taverleyObjects[29].totalOfItem += 1; // dstone gauntlets
                        }
                        else if (dragonstonePick == 5)
                        {
                            taverleyObjects[30].totalOfItem += 1; // dstone boots
                        }
                    }
                    else if (dropKeyTaverley <= possibility1Key)
                    {
                        int seedPicker = generator.RandomNumber(1, 12);
                        taverleyObjects[0].totalOfItem += 1;
                        if (seedPicker <= 5)
                        {
                            taverleyObjects[1].totalOfItem += 1; // calquat
                        }
                        else if (seedPicker > 5 & seedPicker < 11)
                        {
                            taverleyObjects[2].totalOfItem += 1; // papaya
                        }
                        else
                        {
                            taverleyObjects[3].totalOfItem += 1; // palm
                        }

                    }
                    else if (dropKeyTaverley > possibility1Key && dropKeyTaverley <= possibility2Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[4].totalOfItem += 2; // lantadyme
                    }
                    else if (dropKeyTaverley > possibility2Key && dropKeyTaverley <= possibility3Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[5].totalOfItem += 2; // torstol
                    }
                    else if (dropKeyTaverley > possibility3Key && dropKeyTaverley <= possibility4Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[6].totalOfItem += 50; //law
                        taverleyObjects[7].totalOfItem += 50; // chaos
                        taverleyObjects[8].totalOfItem += 50; // cosmic
                        taverleyObjects[9].totalOfItem += 50; // death
                        taverleyObjects[10].totalOfItem += 50; // nature
                        taverleyObjects[11].totalOfItem += 200; // body
                        taverleyObjects[12].totalOfItem += 200; // mind
                        taverleyObjects[13].totalOfItem += 200; // earth
                        taverleyObjects[14].totalOfItem += 200; // air
                        taverleyObjects[15].totalOfItem += 200; // water
                        taverleyObjects[16].totalOfItem += 200; // fire
                    }
                    else if (dropKeyTaverley > possibility4Key && dropKeyTaverley <= possibility5Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[17].totalOfItem += 200; // iron stone spirit
                    }
                    else if (dropKeyTaverley > possibility5Key && dropKeyTaverley <= possibility6Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[18].totalOfItem += 150; // coal stone spirit
                    }
                    else if (dropKeyTaverley > possibility6Key && dropKeyTaverley <= possibility7Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[19].totalOfItem += 3; // runite
                    }
                    else if (dropKeyTaverley > possibility7Key && dropKeyTaverley <= possibility8Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[20].totalOfItem += 3; // diamond
                        taverleyObjects[21].totalOfItem += 3; // ruby
                    }
                    else if (dropKeyTaverley > possibility8Key && dropKeyTaverley <= possibility9Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[22].totalOfItem += 1; // loop half
                        tavCoins += 15000;
                    }
                    else if (dropKeyTaverley > possibility9Key && dropKeyTaverley <= possibility10Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[23].totalOfItem += 1; //tooth
                        tavCoins += 15000;
                    }
                    else if (dropKeyTaverley > possibility10Key && dropKeyTaverley <= possibility11Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[24].totalOfItem += 1; // huge salvage
                    }
                    else if (dropKeyTaverley > possibility11Key && dropKeyTaverley <= possibility12Key)
                    {
                        taverleyObjects[0].totalOfItem += 1;
                        taverleyObjects[25].totalOfItem += 1; // large rune
                    }


                    // PRIFDINNAS KEY SIMUlATION


                    if (dragonStoneDropPrif == dragonstoneKey)
                    {
                        int dragonstonePick = generator.RandomNumber(1, 6);
                        prifdinnasObjects[0].totalOfItem += 1;
                        if (dragonstonePick == 1)
                        {
                            prifdinnasObjects[20].totalOfItem += 1; // dstone helm
                        }
                        else if (dragonstonePick == 2)
                        {
                            prifdinnasObjects[21].totalOfItem += 1; // dstone hauberk0
                        }
                        else if (dragonstonePick == 3)
                        {
                            dragonstoneGreavesPrif.totalOfItem += 1;
                        }
                        else if (dragonstonePick == 4)
                        {
                            dragonstoneGauntletsPrif.totalOfItem += 1;
                        }
                        else if (dragonstonePick == 5)
                        {
                            dragonstoneBootsPrif.totalOfItem += 1;
                        }

                    }
                    else if (dropKeyPrifdinnas <= possibility1KeyPrif)
                    {
                        int seedPicker = generator.RandomNumber(1, 12);
                        prifdinnasObjects[0].totalOfItem += 1;
                        if (seedPicker <= 5)
                        {
                            prifdinnasObjects[1].totalOfItem += 1;
                        }
                        else if (seedPicker > 5 & seedPicker < 11)
                        {
                            prifdinnasObjects[2].totalOfItem += 1;
                        }
                        else
                        {
                            prifdinnasObjects[3].totalOfItem += 1;
                        }

                    }
                    else if (dropKeyPrifdinnas > possibility1KeyPrif && dropKeyPrifdinnas <= possibility2KeyPrif)
                    {
                        int seedPicker = generator.RandomNumber(1, 3);
                        prifdinnasObjects[0].totalOfItem += 1;
                        if (seedPicker == 1)
                        {
                            prifdinnasObjects[4].totalOfItem += 1;
                        }
                        else if (seedPicker == 2)
                        {
                            prifdinnasObjects[5].totalOfItem += 2;
                        }

                    }
                    else if (dropKeyPrifdinnas > possibility2KeyPrif && dropKeyPrifdinnas <= possibility3KeyPrif)
                    {
                        prifdinnasObjects[0].totalOfItem += 1;
                        prifdinnasObjects[6].totalOfItem += 5;
                        crystalTreeBlossoms += 1;
                    }
                    else if (dropKeyPrifdinnas > possibility3KeyPrif && dropKeyPrifdinnas <= possibility4KeyPrif)
                    {
                        prifdinnasObjects[0].totalOfItem += 1;
                        prifdinnasObjects[7].totalOfItem += 5;
                        prifdinnasObjects[8].totalOfItem += 2;
                    }
                    else if (dropKeyPrifdinnas > possibility4KeyPrif && dropKeyPrifdinnas <= possibility5KeyPrif)
                    {
                        prifdinnasObjects[0].totalOfItem += 1;
                        prifdinnasObjects[9].totalOfItem += 2;
                    }
                    else if (dropKeyPrifdinnas > possibility5KeyPrif && dropKeyPrifdinnas <= possibility6KeyPrif)
                    {
                        prifdinnasObjects[0].totalOfItem += 1;
                        prifdinnasObjects[10].totalOfItem += 3; // orci 10
                        prifdinnasObjects[11].totalOfItem += 3;
                        corruptedOre += 50;
                    }
                    else if (dropKeyPrifdinnas > possibility6KeyPrif && dropKeyPrifdinnas <= possibility7KeyPrif)
                    {
                        prifdinnasObjects[0].totalOfItem += 1;
                        prifdinnasObjects[12].totalOfItem += 5;
                    }
                    else if (dropKeyPrifdinnas > possibility7KeyPrif && dropKeyPrifdinnas <= possibility8KeyPrif)
                    {
                        prifdinnasObjects[0].totalOfItem += 1;
                        prifdinnasObjects[13].totalOfItem += 3;
                        prifdinnasObjects[14].totalOfItem += 3; // 14
                    }
                    else if (dropKeyPrifdinnas > possibility8KeyPrif && dropKeyPrifdinnas <= possibility9KeyPrif)
                    {
                        int picker = generator.RandomNumber(1, 101);
                        prifdinnasObjects[0].totalOfItem += 1;
                        prifdinnasObjects[15].totalOfItem += 1;
                        if (picker < 18)
                        {
                            crystalShards += 10;
                        }
                    }
                    else if (dropKeyPrifdinnas > possibility9KeyPrif && dropKeyPrifdinnas <= possibility10KeyPrif)
                    {
                        int picker = generator.RandomNumber(1, 1010);
                        prifdinnasObjects[0].totalOfItem += 1;
                        prifdinnasObjects[16].totalOfItem += 1; // tooth
                        if (picker < 18)
                        {
                            crystalShards += 10;
                        }
                    }
                    else if (dropKeyPrifdinnas > possibility10KeyPrif && dropKeyPrifdinnas <= possibility11KeyPrif)
                    {
                        prifdinnasObjects[0].totalOfItem += 1;
                        prifdinnasObjects[17].totalOfItem += 1;
                        prifdinnasObjects[18].totalOfItem += 1;
                    }
                    else if (dropKeyPrifdinnas > possibility11KeyPrif && dropKeyPrifdinnas <= possibility12KeyPrif)
                    {
                        prifdinnasObjects[0].totalOfItem += 1;
                        prifdinnasObjects[18].totalOfItem += 1;
                    }






                }


                int costsForKeys = crystalKey.valueOfItem * keys;
                int profitTaverleyNoUniques = 0;
                int profitPrifdinnasNoUniques = 0;
                int totalTaverleyNoUniques = 0;
                int totalPrifdinnasNoUniques = 0;



                for (int k = 0; k < taverleyObjects.Length; k++)
                {
                    taverleyTotal += (taverleyObjects[k].totalOfItem * taverleyObjects[k].valueOfItem);
                    Console.WriteLine($"{taverleyObjects[k].nameOfItem}: {taverleyObjects[k].totalOfItem}\nVALUE: {taverleyObjects[k].totalOfItem * taverleyObjects[k].valueOfItem:C}\n");
                }
                taverleyTotal += tavCoins;
                for (int k = 0; k < taverleyObjects.Length-5; k++)
                {
                    profitTaverleyNoUniques += (taverleyObjects[k].totalOfItem * taverleyObjects[k].valueOfItem);
                    totalTaverleyNoUniques += (taverleyObjects[k].totalOfItem * taverleyObjects[k].valueOfItem);



                }
                profitTaverleyNoUniques += tavCoins;
                for (int a = 0; a < prifdinnasObjects.Length-5; a++)
                {
                    profitPrifdinnasNoUniques += (prifdinnasObjects[a].totalOfItem * prifdinnasObjects[a].valueOfItem);
                    totalPrifdinnasNoUniques += (prifdinnasObjects[a].totalOfItem * prifdinnasObjects[a].valueOfItem);

                }

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                for (int a = 0; a < prifdinnasObjects.Length; a++)
                {
                    prifdinnasTotal += (prifdinnasObjects[a].totalOfItem * prifdinnasObjects[a].valueOfItem);

                    Console.WriteLine($"{prifdinnasObjects[a].nameOfItem}: {prifdinnasObjects[a].totalOfItem}\nVALUE:{prifdinnasObjects[a].totalOfItem * prifdinnasObjects[a].valueOfItem:C}\n");

                }
                profitTaverleyNoUniques -= costsForKeys;
                profitPrifdinnasNoUniques -= costsForKeys;

                int profitTaverley = taverleyTotal - costsForKeys;
                int profitPrifdinnas = prifdinnasTotal - costsForKeys;
                Console.WriteLine($"Crystal Shards: {crystalShards}");
                Console.WriteLine($"Crystal Blossoms: {crystalTreeBlossoms}");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"The cost for a single crystal key was: {crystalKey.valueOfItem:C}");
                Console.WriteLine($"Your total costs were: {costsForKeys:C}");
                Console.WriteLine($"The total value of TAVERLEY: {taverleyTotal:C}");
                Console.WriteLine($"The total value of PRIFDINNAS: {prifdinnasTotal:C}");
                Console.WriteLine($"The average GP/Key for Taverley was: {(taverleyTotal/keys):C}");
                Console.WriteLine($"The average GP/Key for Prifdinnas was: {(prifdinnasTotal/keys):C}");
                Console.WriteLine($"The average profit/Key for Taverley was: {(profitTaverley)/keys:C}");
                Console.WriteLine($"The average profit/Key for Prifdinnas was: {profitPrifdinnas/keys:C}");
                Console.WriteLine($"Your profit with no uniques from Taverley was: {profitTaverleyNoUniques:C}");
                Console.WriteLine($"Your profit with no uniques from Prifdinnas was: {profitPrifdinnasNoUniques:C}");
                Console.WriteLine($"Your profit/key for Taverley with no uniques was: {(profitTaverleyNoUniques / keys):C}");
                Console.WriteLine($"Your profit/key for Prifdinnas with no uniques was: {(profitPrifdinnasNoUniques / keys):C}");
                Console.WriteLine($"The total GP earned from Taverley with no uniques was: {totalTaverleyNoUniques:C}");
                Console.WriteLine($"The total GP earned from Prifdinnas with no uniques was: {totalPrifdinnasNoUniques:C}");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                Console.WriteLine("Simulate Again? (Y/N)");
                string answer = Console.ReadLine();
                
                if (answer.ToLower().Equals("y") || answer.ToLower().Equals("yes"))
                {
                    for (int k = 0; k < taverleyObjects.Length; k++)
                    {
                        taverleyTotal = 0;
                        taverleyObjects[k].totalOfItem = 0;
                    }
                    for (int k = 0; k < prifdinnasObjects.Length; k++)
                    {
                        prifdinnasTotal = 0;
                        prifdinnasObjects[k].totalOfItem = 0;
                    }
                    Console.WriteLine("How many keys?");
                    keys = Convert.ToInt32(Console.ReadLine());
                    profitPrifdinnas = 0;
                    profitTaverley = 0;
                    totalTaverleyNoUniques = 0;
                    totalPrifdinnasNoUniques = 0;
                    profitPrifdinnasNoUniques = 0;
                    profitTaverleyNoUniques = 0;
                    tavCoins = 0;

                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye! Sub to MossyRS :)");
                    break;
                }
            }

        }
        public static int itemValue(int itemId)
        {


            WebRequest request = WebRequest.Create("https://secure.runescape.com/m=itemdb_rs/api/catalogue/detail.json?item=" + itemId);

            request.Credentials = CredentialCache.DefaultCredentials;
            if (itemId == 44801)
            {

                Thread.Sleep(TimeSpan.FromSeconds(30));

            }


            try 
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            
                Stream dataStream = response.GetResponseStream();

             StreamReader reader = new StreamReader(dataStream);

             string responseFromServer = reader.ReadToEnd();
    
            using JsonDocument doc = JsonDocument.Parse(responseFromServer);
    
            JsonElement root = doc.RootElement;
                

                string output = (root.GetProperty("item").GetProperty("current").GetProperty("price").ToString());
                output = output.Replace(",", "");
                string value1 = output;
                bool charContain = false;
                if (value1.Contains('m'))
                {
                    charContain = true;
                    int removeChar = value1.IndexOf("m");
                    string value2 = value1.Remove(removeChar);
                    double doubleOutput = Convert.ToDouble(value2);
                    doubleOutput = (doubleOutput * Math.Pow(10, 6));
                    int doubleConverted = (int)doubleOutput;
                    return doubleConverted;
                }
                else if(value1.Contains('k'))
                {
                charContain = true;
                int removeChar = value1.IndexOf("k");
                string value2 = value1.Remove(removeChar);
                double doubleOutput = Convert.ToDouble(value2);
                doubleOutput = (doubleOutput * Math.Pow(10, 3));
                int doubleConverted = (int)doubleOutput;
                reader.Close();
                dataStream.Close();
                response.Close();
                return doubleConverted;
                }
                

                if (charContain == false)
                {
                    int outputConverted = Convert.ToInt32(output);
                reader.Close();
                dataStream.Close();
                response.Close();
                return outputConverted;
                
                }
            }
            catch
            {
                Console.WriteLine("Trying again in 30 seconds, Jagex API limited the total requests...");
                Thread.Sleep(TimeSpan.FromSeconds(30));
                itemValue(itemId);
                
            }
            Console.WriteLine("IF YOU'RE READING THIS, SOMETHING WENT WRONG, TRY AGAIN IN 5 MINUTES");
            return 1;
        }
    }




                
  
    public class RandomGenerator
    {
        private readonly Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
