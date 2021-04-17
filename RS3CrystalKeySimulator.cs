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
            int prifCoins = 0;
            var generator = new RandomGenerator();
            Console.WriteLine("This program takes roughly 1 minute to retrieve the prices from the Runescape GE, so please be patient!");
            Console.WriteLine("Also, do not spam open and close this program and recheck the prices, Jagex only allows so many calls a minute.");
            Console.WriteLine("Retreiving real-time GE prices...");
            


            // need coins
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
            Taverley fireRune = CreateTaverley("Fire Rune", itemValue(5289), 0);
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
            Prifdinnas fireTalisman = CreatePrifdinnas("Fire Talisman", itemValue(2485), 0);
            Prifdinnas waterTalisman = CreatePrifdinnas("Water Talisman", itemValue(1444), 0);
            Prifdinnas hugeBladedSalvage = CreatePrifdinnas("Huge Bladed Salvage", itemValue(47284), 0);
            Prifdinnas orichalciteSpirit = CreatePrifdinnas("Orichalcite Spirit", itemValue(44809), 0);
            Prifdinnas drakolithSpirit = CreatePrifdinnas("Drakolith Spirit", itemValue(44810), 0);
            Prifdinnas runiteSpirit = CreatePrifdinnas("Runite Spirit", runiteStoneSpirit.valueOfItem, 0);
            Prifdinnas uncutDiamondPrif = CreatePrifdinnas("Uncut Diamond", uncutDiamond.valueOfItem, 0);
            Prifdinnas uncutRubyPrif = CreatePrifdinnas("Uncut Diamond", uncutRuby.valueOfItem, 0);
            Prifdinnas loopHalfPrif = CreatePrifdinnas("Loop Halves", loopHalfOfKey.valueOfItem, 0);
            Prifdinnas toothHalfPrif = CreatePrifdinnas("Tooth Halves", toothHalfOfKey.valueOfItem, 0);
            Prifdinnas mediumSalvage = CreatePrifdinnas("Medium Salvage", itemValue(47310), 0);
            Prifdinnas largePlatedSalvage = CreatePrifdinnas("Large Salvage", largePlatedRuneSalvage.valueOfItem, 0);
            Prifdinnas dragonstoneHelmPrif = CreatePrifdinnas("Dragonstone Helm", dragonstoneHelm.valueOfItem, 0);
            Prifdinnas dragonstoneHauberkPrif = CreatePrifdinnas("Dragonstone Hauberk", dragonstoneHauberk.valueOfItem, 0);
            Prifdinnas dragonstoneGreavesPrif = CreatePrifdinnas("Dragonstone Greaves", dragonstoneGreaves.valueOfItem, 0);
            Prifdinnas dragonstoneGauntletsPrif = CreatePrifdinnas("Dragonstone Gauntlets", dragonstoneGauntlets.valueOfItem, 0);
            Prifdinnas dragonstoneBootsPrif = CreatePrifdinnas("Dragonstone Boots", dragonstoneBoots.valueOfItem, 0);

            Prifdinnas[] prifdinnasObjects = {uncutDragonstonePrif, yewSeed, papayaSeed, elderSeed, dwarfWeedSeed, torstolSeed, fireTalisman, waterTalisman,
            hugeBladedSalvage, orichalciteSpirit, drakolithSpirit, runiteSpirit, uncutDiamondPrif, uncutRubyPrif, loopHalfPrif,toothHalfPrif, mediumSalvage, largePlatedSalvage,
            dragonstoneHelmPrif, dragonstoneHauberkPrif, dragonstoneGreavesPrif, dragonstoneGauntletsPrif, dragonstoneBootsPrif};
            Console.WriteLine("Data retrieved.");
            Console.WriteLine("How many keys would you like to open?");
            int keys = Convert.ToInt32(Console.ReadLine());
            int crystalTreeBlossoms = 0;
            int corruptedOre = 0;
            int crystalShards = 0;
            for (int x = 0; x < keys; x++)
            {
                

                int dropKeyTaverley = generator.RandomNumber(1, 1001);
                int dragonstoneDrop = generator.RandomNumber(1, 6801);
                int dropKeyPrifdinnas = generator.RandomNumber(1, 1001);
                int dragonStoneDropPrif = generator.RandomNumber(1, 6801);
                

                if(dragonstoneDrop == dragonstoneKey)
                {
                    
                    int dragonstonePick = generator.RandomNumber(1, 6);
                    taverleyObjects[0].totalOfItem += 1;
                    if(dragonstonePick == 1)
                    {
                        taverleyObjects[26].totalOfItem += 1;
                    }
                    else if (dragonstonePick == 2)
                    {
                        taverleyObjects[27].totalOfItem += 1;
                    }
                    else if (dragonstonePick == 3)
                    {
                        taverleyObjects[28].totalOfItem += 1;
                    }
                    else if (dragonstonePick == 4)
                    {
                        taverleyObjects[29].totalOfItem += 1;
                    }
                    else if (dragonstonePick == 5)
                    {
                        taverleyObjects[30].totalOfItem += 1;
                    }
                }
                else if(dropKeyTaverley <= possibility1Key)
                {
                    int seedPicker = generator.RandomNumber(1, 12);
                    taverleyObjects[0].totalOfItem += 1;
                    if (seedPicker <= 5)
                    {
                        taverleyObjects[1].totalOfItem += 1;
                    }
                    else if (seedPicker >5 & seedPicker <11)
                    {
                        taverleyObjects[2].totalOfItem += 1;
                    }
                    else
                    {
                        taverleyObjects[3].totalOfItem += 1;
                    }
                    
                }
                else if (dropKeyTaverley > possibility1Key && dropKeyTaverley <= possibility2Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[4].totalOfItem += 2;
                }
                else if (dropKeyTaverley > possibility2Key && dropKeyTaverley <= possibility3Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[5].totalOfItem += 2;
                }
                else if (dropKeyTaverley > possibility3Key && dropKeyTaverley <= possibility4Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[6].totalOfItem += 50;
                    taverleyObjects[7].totalOfItem += 50;
                    taverleyObjects[8].totalOfItem += 50;
                    taverleyObjects[9].totalOfItem += 50;
                    taverleyObjects[10].totalOfItem += 50;
                    taverleyObjects[11].totalOfItem += 200;
                    taverleyObjects[12].totalOfItem += 200;
                    taverleyObjects[13].totalOfItem += 200;
                    taverleyObjects[14].totalOfItem += 200;
                    taverleyObjects[15].totalOfItem += 200;
                    taverleyObjects[16].totalOfItem += 200;
                }
                else if (dropKeyTaverley > possibility4Key && dropKeyTaverley <= possibility5Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[17].totalOfItem += 200;
                }
                else if (dropKeyTaverley > possibility5Key && dropKeyTaverley <= possibility6Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[18].totalOfItem += 150;
                }
                else if (dropKeyTaverley > possibility6Key && dropKeyTaverley <= possibility7Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[19].totalOfItem += 3; // runite
                }
                else if (dropKeyTaverley > possibility7Key && dropKeyTaverley <= possibility8Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[20].totalOfItem += 3;
                    taverleyObjects[21].totalOfItem += 3;
                }
                else if (dropKeyTaverley > possibility8Key && dropKeyTaverley <= possibility9Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[22].totalOfItem += 1;
                    tavCoins += 15000;
                }
                else if (dropKeyTaverley > possibility9Key && dropKeyTaverley <= possibility10Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[23].totalOfItem += 1;
                    tavCoins += 15000;
                }
                else if (dropKeyTaverley > possibility10Key && dropKeyTaverley < possibility11Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[24].totalOfItem +=1;
                }
                else if (dropKeyTaverley > possibility11Key && dropKeyTaverley <= possibility12Key)
                {
                    taverleyObjects[0].totalOfItem += 1;
                    taverleyObjects[25].totalOfItem += 1;
                }


                // PRIFDINNAS KEY SIMUA
                

                if(dragonStoneDropPrif == dragonstoneKey)
                {
                    int dragonstonePick = generator.RandomNumber(1, 6);
                    uncutDragonstonePrif.totalOfItem += 1;
                    if (dragonstonePick == 1)
                    {
                        dragonstoneHelmPrif.totalOfItem += 1;
                    }
                    else if (dragonstonePick == 2)
                    {
                        dragonstoneHauberkPrif.totalOfItem += 1;
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
                    uncutDragonstonePrif.totalOfItem += 1;
                    if (seedPicker <= 5)
                    {
                        yewSeed.totalOfItem += 1;
                    }
                    else if (seedPicker > 5 & seedPicker < 11)
                    {
                        papayaTreeSeed.totalOfItem += 1;
                    }
                    else
                    {
                        elderSeed.totalOfItem += 1;
                    }

                }
                else if (dropKeyPrifdinnas > possibility1KeyPrif && dropKeyPrifdinnas <= possibility2KeyPrif)
                {
                    int seedPicker = generator.RandomNumber(1, 3);
                    uncutDragonstonePrif.totalOfItem += 1;
                    if(seedPicker ==1)
                    {
                        dwarfWeedSeed.totalOfItem += 1; 
                    }
                    else
                    {
                        torstolSeed.totalOfItem += 2;
                    }
                }
                else if (dropKeyPrifdinnas > possibility2KeyPrif && dropKeyPrifdinnas <= possibility3KeyPrif)
                {
                    Console.WriteLine("p2p3");
                    uncutDragonstonePrif.totalOfItem += 1;
                    grimyLantadyme.totalOfItem += 5;
                    crystalTreeBlossoms += 1;
                }
                else if (dropKeyPrifdinnas > possibility3KeyPrif && dropKeyPrifdinnas <= possibility4KeyPrif)
                {
                    uncutDragonstonePrif.totalOfItem += 1;
                    fireTalisman.totalOfItem += 5;
                    waterTalisman.totalOfItem += 2;
                }
                else if (dropKeyPrifdinnas > possibility4KeyPrif && dropKeyPrifdinnas <= possibility5KeyPrif)
                {
                    uncutDragonstonePrif.totalOfItem += 1;
                    hugeBladedSalvage.totalOfItem += 2;
                }
                else if (dropKeyPrifdinnas > possibility5KeyPrif && dropKeyPrifdinnas <= possibility6KeyPrif)
                {
                    uncutDragonstonePrif.totalOfItem += 1;
                    orichalciteSpirit.totalOfItem += 3;
                    drakolithSpirit.totalOfItem += 3;
                    corruptedOre += 50;
                }
                else if (dropKeyPrifdinnas > possibility6KeyPrif && dropKeyPrifdinnas <= possibility7KeyPrif)
                {
                    uncutDragonstonePrif.totalOfItem += 1;
                    runiteSpirit.totalOfItem += 5;
                }
                else if (dropKeyPrifdinnas > possibility7KeyPrif && dropKeyPrifdinnas <= possibility8KeyPrif)
                {
                    uncutDragonstonePrif.totalOfItem += 1;
                    uncutDiamondPrif.totalOfItem += 3;
                    uncutRubyPrif.totalOfItem += 3;
                }
                else if (dropKeyPrifdinnas > possibility8KeyPrif && dropKeyPrifdinnas <= possibility9KeyPrif)
                {
                    int picker = generator.RandomNumber(1, 101);
                    uncutDragonstonePrif.totalOfItem += 1;
                    loopHalfPrif.totalOfItem += 1;
                    if (picker < 18)
                    {
                        crystalShards += 10;
                    }
                }
                else if (dropKeyPrifdinnas > possibility9KeyPrif && dropKeyPrifdinnas <= possibility10KeyPrif)
                {
                    int picker = generator.RandomNumber(1, 1010);
                    uncutDragonstonePrif.totalOfItem += 1;
                    toothHalfPrif.totalOfItem += 1;
                    if (picker < 18)
                    {
                        crystalShards += 10;
                    }
                }
                else if (dropKeyPrifdinnas > possibility10KeyPrif && dropKeyPrifdinnas < possibility11KeyPrif)
                {
                    uncutDragonstonePrif.totalOfItem += 1;
                    mediumSalvage.totalOfItem += 1;
                    largePlatedSalvage.totalOfItem += 1;
                }
                else if (dropKeyPrifdinnas > possibility11KeyPrif && dropKeyPrifdinnas <= possibility12KeyPrif)
                {
                    uncutDragonstonePrif.totalOfItem += 1;
                    largePlatedSalvage.totalOfItem += 1;
                }






            }




            
            for (int k = 0; k < taverleyObjects.Length; k++)
            {
                Console.WriteLine($"{taverleyObjects[k].nameOfItem}: {taverleyObjects[k].totalOfItem} = {taverleyObjects[k].totalOfItem * taverleyObjects[k].valueOfItem}");
            }
            for (int a = 0; a < prifdinnasObjects.Length; a++)
            {
                Console.WriteLine($"{prifdinnasObjects[a].nameOfItem}: {prifdinnasObjects[a].totalOfItem} = {prifdinnasObjects[a].totalOfItem * prifdinnasObjects[a].valueOfItem}");
                
            }
            Console.WriteLine($"Crystal Shards: {crystalShards}");
            Console.WriteLine($"Crystal Blossoms: {crystalTreeBlossoms}");



        }
        public static int itemValue(int itemId)
        {
                
            
                WebRequest request = WebRequest.Create("https://secure.runescape.com/m=itemdb_rs/api/catalogue/detail.json?item=" + itemId);

                request.Credentials = CredentialCache.DefaultCredentials;
            if (itemId == 44801)
            {
           
                Thread.Sleep(TimeSpan.FromSeconds(15));
                
            }
            
      
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


                
                Console.WriteLine("IM HERE");
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
