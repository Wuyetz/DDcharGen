using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Fantasy character generator!");
            Console.ReadLine();

            int displayMenu = 1;
            while (displayMenu == 1)
            {
                displayMenu = MainMenu();
            }

        }

        public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Generate male character!");
            Console.WriteLine("2) Generate female character!");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            
            if (result == "1")
            {
                CharGen(1);
                return 1;                
            }
            else if (result == "2")
            {
                CharGen(2);
                return 2;
            }
            else if (result == "3")
            {                
                Environment.Exit(0);
                return 4;
            }

            else
            {
                MainMenu();
                return 3;
            }

        }


        public static void CharGen(int result)
        {

            string[] ddClasses = new string[] { "Cleric", "Fighter", "Rogue", "Wizard", "Barbarian", "Bard", "Druid", "Monk", "Paladin", "Ranger", "Sorcerer", "Warlock", "Necromancer", "Assassin", "Shaman", "Scout",
                "Berserker", "Knight", "Crusader", "Beast Master", "Hunter", "Thief", "Swashbuckler", "Conjurer", "Enchanter", "Evoker", "Illusionist", "Transmuter", "Zealot", "Arcane archer", "Mystic", "Psychic" };

            string[] ddRaces = new string[] { "Human", "Orc", "Half-elf", "Half-orc", "Dwarf", "Halfling", "Gnome", "Elf", "Lizard-folk", "Hobgoblin", "Kobold", "Dragonborn", "Goblin" };

            string[] ddAligns = new string[] { "Chaotic evil", "Chaotic good", "Chaotic neutral", "True evil", "True good", "True neutral", "Lawful evil", "Lawful good", "Lawful neutral" };

            string[] nameA = new string[] {
                "Ar", "Ag", "As", "At", "Al", "A", "Ae", "An", "Ai", "Ali", "Ale", "Ab",
                "Ber", "Bel", "Bur", "Bil", "Bos", "Bi", "Bor",
                "Ce", "Cer", "Celem", "Cel", "Cil", "Celim", "Cal",
                "Dem", "Dul", "De", "Don", "Dor", "Dol",
                "E", "Eli", "Elem", "Elim", "Eti", "Er", "Ern", "Eu", "El", "Es", "Eb",
                "Fin", "Fi", "Fili", "Fae", "Ful", "For",
                "Gul", "Grum", "Gol", "Gulf", "Ger", "Gar", "Grom", "Gru", "Gra",
                "Hel", "Her", "Har", "Heli", "Ho", "He", "Hur", "Hum", "Hen",
                "Isil", "Is", "Il", "Im", "I", "Ix", "Io", "Ien", "Iru", "Iri", "Ili", "Ilim", "Ilum",
                "Jur", "Jon", "Jo", "Jarl", "Jar", "Jol",
                "Kor", "Kil", "Kam", "Kal", "Kas", "Kun",
                "Lem", "Lai", "Le", "Lor",
                "Mor", "Me", "Ma", "Mas", "Man", "Mo", "Mun", "Mul", "Mer", "Me", "Mi",
                "Nol", "Nel", "Nei", "Nur", "Nor", "Nal", "Nos",
                "O", "Or", "Ol", "Ole", "Ore", "Ori", "Oru", "Os", "Osi",
                "Per", "Perse", "Pan", "Pul", "Pum", "Pale",
                "Qan", "Qul", "Quin", "Qin",
                "Re", "Rum", "Ras", "Ro", "Rus", "Rei", "Rai",
                "Si", "Sel", "Sor", "Sar", "Sep", "San", "Sur", "Sil", "Set", "Se", "Sul", "Sol", "Sam",
                "Tel", "Tul", "Tor", "Tir", "Tyr", "Ti", "Tu", "Tar", "Ten",
                "U", "Ul", "Urum", "Un", "Us", "Ub", "Uni",
                "Vil", "Ve", "Vae", "Vi", "Van", "Vor", "Var", "Vel", "Vun", "Von",
                "Wel", "Wul", "Wulf", "Wol", "Wen", "Wi", "Wor",
                "Xi", "Xai", "Xel", "Xer",
                "Y", "Yon", "Yul", "Yen",
                "Zul", "Ze", "Zer", "Zel"
            };

            string[] nameB = new string[] {
                "a","an","al","at","as",
                "bur","bor","bon","bom","be",
                "cem","cet","ce",
                "dor","dur","dem","dog","du","dum","din","dun",
                "e","el","em","ex","ele","ed",
                "fin","ful","fem","fal","fan",
                "gor","grum","ger","gar",
                "hele","hel","he","hu","hul","hot",
                "i","ilin","isil","is","in",
                "jol","jom","jan","jal",
                "kor","kud","ka",
                "len","les","leb","lo","lum","land",
                "mor","mur","mot","mon","m","mal",
                "ner","nel","neh","no","nul","nem",
                "o","op","ol","or","ost","ola",
                "pot","por","pan","p",
                "q","qen","qan",
                "ram","ren","rel","ro","ru",
                "sin","sul","sun","sol","sem",
                "tol","tud","tor","tek","tes",
                "u","ulm","ul","us",
                "vil","ve","vi","vet","vor","van","vele",
                "wul","wol","wal","wor","we","wil",
                "xan","xen","xil","xul",
                "yil","yar","yem","yol",
                "zol","zul","zur","zem",
                "´","´","´","´","´","´","´","´","´","´","-","-","-","-","-","-","-","-","-","-"
            };

            string[] nameCm = new string[] {
                "al", "as", "ast", "alm", "at", "aius", "ais", "aer", "arg",
                "bul", "bor", "borf", "ber", "bel", "bin", "bald", "bold",
                "cil", "cer",
                "dur", "dor", "der", "durf", "dum", "del", "dar",
                "el", "en", "eh", "es", "est", "edas", "edis",
                "fin", "fol", "fil", "fur", "fis",
                "gor", "gurm", "gol", "gul", "gen",
                "hur", "hul", "hel",
                "i", "is", "il", "ion", "is", "in", "id", "ieb", "iel", "ien", "iek", "ies", "irg",
                "jul", "jun",
                "kiel", "kael", "kal", "kul", "kor",
                "lan", "lur", "leh", "lis", "leas", "luas", "lun",
                "mor", "mer", "mur", "mun", "mund", "mear",
                "nun", "nian", "nias", "nur",
                "o", "or", "os", "om", "orm", "orn", "on", "orf", "ot", "ok", "oin", "oc", "org",
                "pur", "pas", "pis",
                "q", "qin", "qan", "qen", "qil",
                "ras", "ren", "rin", "rold", "rai", "ros",
                "sei", "sai", "sorn", "sar", "sul", "sol", "sil",
                "tai", "tel", "tor", "tur", "tas", "tulm", "tear",
                "u", "ulm", "ulf", "ur", "ul", "uras", "um", "urf", "ut", "us", "uk", "un", "urg",
                "vil", "var", "vul", "vos", "vin", "ven",
                "wur", "wurm", "wor", "wel", "wis", "wun", "win",
                "xor", "xer", "xul",
                "yel", "yur", "yas", "y",
                "zul", "zur", "zar"
            };

            string[] nameCf = new string[] {
                "a", "aia", "asa", "ana", "ala", "ara", "ae", "aria", "arya",
                "bea", "bia", "ba",
                "cia",
                "dia", "dea", "dora",
                "ele", "ela", "elia", "esa", "ena", "eya", "eyn", "eth", "ene", "enia", "era",
                "fia", "fula", "fa", "fae", "fei",
                "gia", "gula", "gora",
                "hia", "huria", "ha", "hea", "hya", "hi",
                "ia", "isa", "ina", "i", "ila", "ira", "iya", "inia", "ine", "ile", "ith", "ica", "ie",
                "ja",
                "kia", "ka", "kya",
                "lia", "lea", "lira", "lisa", "lua", "lora", "luna", "lya", "li", "lei", "lai",
                "mia", "ma", "mila", "misa", "mya", "me",
                "nia", "nea", "na", "nura", "nora", "nya", "ne",
                "oa", "osa", "otra", "ota", "oma",
                "pia", "pila", "pya",
                "qia",
                "ria", "rua", "rila", "rula", "rea", "roa", "rya",
                "sia", "sea", "sa", "sila", "sya", "sina",
                "tina", "tya", "tula", "tia", "tea",
                "ula", "uma", "una", "usa", "ue", "uth",
                "via", "vya", "vila", "vira", "vera", "vie", "ve",
                "wia", "wera", "wea",
                "xia", "xira",
                "ya", "yth", "yta", "yl",
                "zia", "zila"
            };

            string[] nameThe = new string[] {
                /*A*/"Average", "Attention-wench", "Ale´s nightmare",
                /*B*/"Bug-eyed", "Bastard", "Bird-legged", "Boneless", "Bear", "Beaver", "Bone collector",
                /*C*/"Chicken", "Chicken´s flight",
                /*D*/"Dragonbane", "Demon-hunter", "Death-breath", "Dull", "Dungbeetle", "Demon´s bane", "Devil´s servant", "Dead", "Devious", "Disgusting", "Dreamy", "Dreaded", "Dragon´s cleaver",
                "Defender of evil", "Defeated",
                /*E*/"Evoker of nightmares", "Evil",
                /*F*/"Furious", "Fourlegged", "Firebreather", "Faithless",
                /*G*/"Green-thumbed", "Godlike", "Goat-eye", "Glorious", "Gifted", "Giving", "Gruesome",
                /*H*/"Headless", "Hungry", "Horrendeous", "Horrible", "Honorable", "Hand collector", "Head collector", "Humongous", "Hysterical",
                /*I*/"Ironheaded", "Itchy", "Iron mouth", "Irresistable", "Incredible", "Irrelevant", "Injured",
                /*J*/"Joker", "Jester",
                /*K*/"Killable", "Kissless", "Kind", "Killer´s judgement",
                /*L*/"Lonely", "Lovely", "Loveable",
                /*M*/"Merciless", "Moist", "Monstrous", "Mouth",
                /*N*/"Nasty", "Nervous", "Northerner",
                /*O*/"One-eyed", "One-legged",
                /*P*/"Purple-eyed", "Philosopher", "Poisoned", "Protector of privileged", "Protector of weak",
                /*Q*/
                /*R*/"Rose petal",
                /*S*/"Seducer", "Slow", "Sweet", "Slimy", "Sorrow bringer", "Sharp", "Shield-bearer", "Sneaky-sneaky", "Serpent", "Sneaky", "Squishy", "Slightly evil", "Soulless", "Southerner", "Silly", "Skewered",
                "Sinner", "Serious", "Succulent", "Seduced",
                /*T*/"Tender", "Tedious", "Three-eyed", "Twice-boiled", "Tiny", "Tiny sword", "Twice-poisoned",
                /*U*/"Unwanted", "Unfortunate", "Unseemly",
                /*V*/"Void traveler", "Vicious", "Virgin", "Virgin´s nightmare", "Virginslayer", "Velvet", "Victorious", "Vile",
                /*W*/"Wrath of a mountain", "Widowmaker",
                /*X*/
                /*Y*/"Yeller",
                /*Z*/"Zealous"
        };

        
        

            int lenA = nameA.Length;
            int lenB = nameB.Length;
            int lenCm = nameCm.Length;
            int lenCf = nameCf.Length;
            int lenThe = nameThe.Length;
            int lenClasses = ddClasses.Length;
            int lenRaces = ddRaces.Length;
            int lenAligns = ddAligns.Length;

            Random rndmA = new Random();
            Random rndmB = new Random();
            Random rndmCm = new Random();
            Random rndmCf = new Random();
            Random rndmT = new Random();
            Random rndmClass = new Random();
            Random rndmRaces = new Random();
            Random rndmAligns = new Random();

            string nA = nameA[rndmA.Next(0, lenA)];
            string nB = nameB[rndmB.Next(0, lenB)];
            string nCm = nameCm[rndmCm.Next(0, lenCm)];
            string nCf = nameCf[rndmCf.Next(0, lenCf)];
            string nT = nameThe[rndmT.Next(0, lenThe)];
            string nCl = ddClasses[rndmClass.Next(0, lenClasses)];
            string nR = ddRaces[rndmRaces.Next(0, lenRaces)];
            string nAl = ddAligns[rndmAligns.Next(0, lenAligns)];


            if (result == 1)
            {
                Console.WriteLine(value: $"Your character´s name is: {nA}{nB}{nCm} the {nT}");
                Console.ReadLine();

                Console.WriteLine("He is a " + nAl + " " + nR + " " + nCl);
                Console.ReadLine();

                MainMenu();
            }
            else if (result == 2)
            {
                Console.WriteLine(value: $"Your character´s name is: {nA}{nB}{nCf} the {nT}");
                Console.ReadLine();

                Console.WriteLine("She is a " + nAl + " " + nR + " " + nCl);
                Console.ReadLine();

                MainMenu();
            }

   
            


        }
    }
}
