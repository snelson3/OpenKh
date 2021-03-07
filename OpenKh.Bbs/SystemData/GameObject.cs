using System;
using System.Collections.Generic;
using System.Text;

namespace OpenKh.Bbs.SystemData
{
    public class GameObject
    {
        public static Dictionary<string, string> SpawnObjectList = new Dictionary<string, string>()
        {
            {"b01cd00", "Symphony Master (Boss!)"},
            {"b02cd00", "Trumpet (Boss!)"},
            {"b03cd00", "Violin (Boss!)"},
            {"b04cd00", "Drum (Boss!)"},
            {"b05cd00", "Unknown (CD) (Boss!)"},
            {"b10cd00", "Cursed Carriage (Boss!)"},
            {"b20cd00", "Lucifer (Boss!)"},

            {"b01dc00", "Captain Dark (Invincible) (No AI) (Boss!)"},
            {"b02dc00", "Captain Dark (Untargettable)"},
            {"b03dc00", "Captain Justice (Untargettable)"},
            {"b10dc00", "Chip (Untargettable)"},
            {"b20dc00", "Dale (Untargettable)"},

            {"b01he00", "Hades (Boss!)"},
            {"b10he00", "Ice Titan (Boss!)"},
            {"b20he00", "Hercules (Ally!) (T-Stance)"},
            {"b21he00", "Hercules (Boss!) (T-Stance)"},
            {"b30he00", "Zack (Helmet) (Boss!)"},
            {"b40he00", "Zack (Helmetless) (Boss!)"},

            {"b01ex00", "Mysterious Figure (Boss!)"},
            {"b02ex00", "Red Eyes (Boss!)"},
            {"b10ex00", "Vanitas (Boss!)"},
            {"b10ex01", "Vanitas (Low AI) (Boss!)"},
            {"b10ex02", "Vanitas (Final Battle) (Boss!)"},
            {"b11ex00", "Vanitas (Unmasked) (Boss!)"},
            {"b12ex00", "Vanitas Lingering Spirit (Boss!)"},
            {"b12ex01", "Vanitas Lingering Spirit Clone"},
            {"b20ex00", "Eraqus (Boss!)"},
            {"b30ex00", "Braig (Scarred) (Boss!)"},
            {"b31ex00", "Braig Bullets"},
            {"b32ex00", "Braig (Boss!)"},
            {"b40ex00", "Master Xehanort (Boss!)"},
            {"b50ex00", "Terra-Xehanort (Boss!)"},
            {"b51ex00", "Terra-Xehanort 2 (Boss!)"},
            {"b52ex00", "Terra-Xehanort + Guardian (Boss!)"},
            {"b53ex00", "Terra-Xehanort's No Name"},
            {"b54ex00", "Terra-Xehanort's No Name Keychain"},
            {"b55ex00", "Terra-Xehanort's Ultima Cannon"},
            {"b56ex00", "Terra-Xehanort's Guardian"},
            {"b60ex00", "Ventus (Boss!)"},
            {"b61ex00", "Ventus Weapon"},
            {"b62ex00", "Armor Ventus (Boss!)"},
            {"b63ex00", "Ventus=Vanitas (Boss!)"},
            {"b64ex00", "Ventus (Invincible) (Boss!)"},
            {"b68ex00", "Ventus 1 (Ally!)"},
            {"b69ex00", "Ventus 2 (Ally!)"},
            {"b70ex00", "Terra (Boss!)"},

            {"b01ls00", "Metamorphosis (Space Version) (Boss!)"},
            {"b02ls00", "Metamorphosis (Boss!)"},
            {"b10ls00", "Gantu (Boss!)"},
            {"b20ls00", "Sparky (Boss!)"},
            {"b21ls00", "Sparky's trail"},
            {"b22ls00", "Galactic Gun (Left) (Boss!)"},
            {"b23ls00", "Galactic Gun (Right) (Boss!)"},

            {"b01pp00", "Captain Hook (Boss!)"},
            {"b02pp00", "Crocodile"},
            {"b20pp00", "Peter Pan (Boss!)"},

            {"b01rg00", "Trinity Armor (Head) (Boss)"},
            {"b02rg00", "Trinity Armor (Propeller Hands) (Invincible) (Boss!)"},
            {"b03rg00", "Trinity Armor (Compressed Legs) (Invincible) (Boss!)"},
            {"b04rg00", "Trinity Armor (Propeller Hans) (Boss!)"},
            {"b05rg00", "Trinity Armor (Compressed Legs) (Boss!)"},
            {"b06rg00", "Trinity Armor (Right Hand) (Boss!)"},
            {"b07rg00", "Trinity Armor (Left Hand) (Boss!)"},
            {"b08rg00", "Trinity Armor (Legs) (Boss!)"},

            {"b01sb00", "Maleficent (Boss!)"},
            {"b03sb00", "Maleficent Dragon (Boss!)"},
            {"b10sb00", "Wheel Master (Boss!)"},
            {"b11sb00", "Wheel Master Spinner (Boss!)"},
            {"b12sb00", "Hittable Component"},

            {"b01sw00", "Mad Treant (Boss!)"},
            {"b02sw00", "Poisoned Apples"},
            {"b03sw00", "Rockets"},
            {"b10sw00", "Spirit of the Magic Mirror (Boss!)"},
            {"b11sw00", "Magic Mirror Face (No Collision)"},

            {"b01vs00", "Mimic Master (Boss)"},
            {"b02vs00", "Mimic Master Card (Boss)"},
            {"b03vs00", "Mimic Master Player Card (Boss)"},
            {"b10vs00", "Iron Imprisoner I (Boss!)"},
            {"b11vs00", "Iron Imprisoner II (Boss!)"},
            {"b12vs00", "Iron Imprisoner III (Boss!)"},
            {"b13vs00", "Iron Imprisoner IV (Boss!)"},
            {"b14vs00", "Iron Imprisoner Jail (Boss!)"},
            {"b40vs00", "Cursed Carriage (VS) (Boss!)"},
            {"b50vs00", "Wheel Master (VS) (Boss!)"},
            {"b60vs00", "Zack (Dark version) (VS) (Boss!)"},
            {"b61vs00", "Mirage Arena Piece 1"},
            {"b62vs00", "Mirage Arena Piece 2"},
            {"b63vs00", "Mirage Arena Piece 3"},
            {"b64vs00", "Mirage Arena Piece 4"},
            {"b65vs00", "Mirage Arena Piece 5"},
            {"b66vs00", "Mirage Arena Piece 6"},
            {"b67vs00", "Mirage Arena Piece 7"},
            {"b68vs00", "Mirage Arena Piece 8"},
            {"b71vs00", "Trinity Armor (Head) (VS) (Boss)"},
            {"b72vs00", "Trinity Armor (Propeller Hands) (VS) (Invincible) (Boss!)"},
            {"b73vs00", "Trinity Armor (Compressed Legs) (VS) (Invincible) (Boss!)"},
            {"b74vs00", "Trinity Armor (Propeller Hans) (VS) (Boss!)"},
            {"b75vs00", "Trinity Armor (Compressed Legs) (VS) (Boss!)"},
            {"b76vs00", "Trinity Armor (Right Hand) (VS) (Boss!)"},
            {"b77vs00", "Trinity Armor (Left Hand) (VS) (Boss!)"},
            {"b78vs00", "Trinity Armor (Legs) (VS) (Boss!)"},
            {"b80vs00", "Hades (VS) (Boss!)"},
            {"b81vs00", "Armor of Eraqus (Boss!)"},
            {"b82vs00", "b82vs00"},
            {"b83vs00", "Monstro (Boss!)"},
            {"b84vs00", "No Name Handle"},
            {"b85vs00", "No Heart (Boss!)"},
            {"b86vs00", "No Heart Wall (Boss!)"},
            {"b87vs00", "No Heart's No Name"},
            {"b88vs00", "No Heart's No Name's Keychain"},
            {"b90vs00", "Ice Titan (VS) (Boss!)"},
            {"b91vs00", "No Heart's Keyblade Transformation 1"},
            {"b92vs00", "No Heart's Keyblade Transformation 2"},
            {"b93vs00", "No Heart's Keyblade Transformation 3"},
            {"b94vs00", "No Heart's Keyblade Handle"},

            {"g01cd00", "Small Chest (CD)"},
            {"g02cd00", "Large Chest (CD)"},
            {"g03cd00", "Large Chest EXTRA (CD)"},
            {"g10cd00", "Fork (CD)"},
            {"g11cd00", "Yarn Ball (Red) (CD)"},
            {"g12cd00", "Match Box (CD)"},
            {"g14cd00", "Cheese (CD)"},
            {"g15cd00", "White Lace (CD)"},
            {"g16cd00", "Button (CD)"},
            {"g17cd00", "Pink Fabric (CD)"},
            {"g18cd00", "White Sash (CD)"},
            {"g19cd00", "Pink Thread (CD)"},
            {"g20cd00", "Spider Web (CD)"},
            {"g21cd00", "g21cd00 (CD)"},
            {"g23cd00", "Cinderella Dress (CD)"},
            {"g24cd00", "Prince Charming (Dancing) (CD)"},
            {"g25cd00", "g25cd00 (CD)"},
            {"g50cd00", "Dress Stand (CD)"},
            {"g51cd00", "Pink Dress (CD)"},
            {"g52cd00", "Pumpkin Patch (CD)"},
            {"g53cd00", "g53cd00 (CD)"},

            {"g01dc00", "Small Chest (DC)"},
            {"g02dc00", "Large Chest (DC)"},

            {"g01dp00", "Small Chest (DP)"},
            {"g02dp00", "Large Chest (DP)"},

            {"g01ex00", "Savepoint"},
            {"g02ex00", "Examine Actor (To place on static object)"},
            {"g03ex00", "Crown (Puzzle)"},
            {"g04ex00", "Jellyshade Swam"},
            {"g05ex00", "Unversed Portal"},
            {"g10ex00", "Invisible Wall 10"},
            {"g17ex00", "Invisible Wall 17"},
            {"g18ex00", "Invisible Wall 18"},
            {"g20ex00", "g20ex00"},

            {"g01jb00", "Small Chest (JB)"},
            {"g02jb00", "Large Chest (JB)"},
            {"g03jb00", "Large Chest (Debug)"},
            {"g10jb00", "Plume of Darkness"},
            {"g11jb00", "Sphere of Darkness"},
            {"g12jb00", "g12jb00"},
            {"g13jb00", "g13jb00"},
            {"g14jb00", "g14jb00"},
            {"g15jb00", "g15jb00"},
            {"g16jb00", "g16jb00"},
            {"g17jb00", "g17jb00"},
            {"g18jb00", "g18jb00"},
            {"g19jb00", "g19jb00"},
            {"g20jb00", "g20jb00"},
            {"g21jb00", "g21jb00"},
            {"g22jb00", "g22jb00"},
            {"g23jb00", "g23jb00"},

            {"g01kg00", "Small Chest (KG)"},
            {"g02kg00", "Large Chest (KG)"},
            {"g10kg00", "Tornado (KG)"},
            {"g11kg00", "Tornado Base (KG)"},
            {"g12kg00", "Vanitas Lingering Sentiment Portal"},
            {"g13kg00", "g13kg00 (KG)"},

            {"g01ls00", "Small Chest (LS)"},
            {"g02ls00", "Large Chest (LS)"},

            {"g01pp00", "Small Chest (PP)"},
            {"g02pp00", "Large Chest (PP)"},
            {"g20pp00", "g20pp00"},

            {"g01rg00", "Small Chest (RG)"},
            {"g02rg00", "Large Chest (RG)"},

            {"g01sb00", "Small Chest (SB)"},
            {"g02sb00", "Large Chest (SB)"},
            {"g03sb00", "Large Chest EXTRA (SB)"},
            {"g11sb00", "Labyrinth Wall 11 (SB)"},
            {"g12sb00", "Wheel 1 (SB)"},
            {"g14sb00", "Unknown Collision 14 (SB)"},
            {"g15sb00", "g15sb00 (SB)"},
            {"g16sb00", "g16sb00 (SB)"},
            {"g17sb00", "g17sb00 (SB)"},
            {"g18sb00", "Breakable Wall 1 (SB)"},
            {"g19sb00", "Breakable Wall 2 (SB)"},
            {"g20sb00", "Labyrinth Wall 20 (SB)"},
            {"g21sb00", "Labyrinth Wall 21 (SB)"},
            {"g22sb00", "Arched Window (SB)"},
            {"g23sb00", "Wheel 2 (SB)"},
            {"g24sb00", "Gate (SB)"},
            {"g25sb00", "Unknown Collision 25 (SB)"},
            {"g26sb00", "Unknown Collision 26 (SB)"},
            {"g29sb00", "g29sb00 (SB)"},
            {"g32sb00", "Unversed Portal (SB)"},
            {"g33sb00", "Teleporter 33 (SB)"},
            {"g36sb00", "g36sb00 (SB)"},
            {"g38sb00", "Unknown Collision 38 (SB)"},
            {"g39sb00", "g39sb00 (SB)"},
            {"g40sb00", "Unknown Collision 40 (With EPD) (SB)"},
            {"g41sb00", "g41sb00 (SB)"},
            {"g50sb00", "g50sb00 (SB)"},
            {"g51sb00", "Darkness Semisphere 51 (SB)"},
            {"g54sb00", "Bush (SB)"},
            {"g55sb00", "Darkness Semisphere 55 (SB)"},
            {"g58sb00", "Unknown Collision 58 (SB)"},
            {"g59sb00", "Unknown Collision 59 (SB)"},

            {"g01sw00", "Small Chest (SW)"},
            {"g02sw00", "Large Chest (SW)"},

            {"g01vs00", "Untextured Triangle (VS)"},
            {"g10vs00", "Arena Entrance Device (VS)" },
            {"g11vs00", "Arena Mission Place (Working) (VS)" },
            {"g12vs00", "Arena Machine (Can pick missions) (VS)" },
            {"g15vs00", "Command Prize (VS)" },
            {"g16vs00", "Keyblade Graveyard Tornado (VS)" },
            {"g17vs00", "Disney Town Spring (VS)" },
            {"g18vs00", "Cinderella Wool Ball (VS)" },
            {"g19vs00", "Deep Space Platform (VS)" },
            {"g20vs00", "Deep Space Platform Effect (VS)" },
            {"g22vs00", "Disney Town Left Flipper (VS)" },
            {"g23vs00", "Disney Town Right Flipper (VS)" },
            {"g26vs00", "Disney Town Bumper (VS)" },

            {"g01wm00", "Land of Departure (WM)" },
            {"g02wm00", "Dwarf Woodlands (WM)" },
            {"g03wm00", "Castle of Dreams (WM)" },
            {"g04wm00", "Enchanted Dominion (WM)" },
            {"g05wm00", "Yen Sid's Tower (WM)" },
            {"g06wm00", "Radiant Garden (WM)" },
            {"g08wm00", "Olympus Coliseum (WM)" },
            {"g09wm00", "Deep Space (WM)" },
            {"g10wm00", "g10wm00 (WM)" },
            {"g11wm00", "Neverland (WM)" },
            {"g12wm00", "Disney Town (WM)" },
            {"g13wm00", "Mysterious Badlands (WM)" },
            {"g15wm00", "Mirage Arena (WM)" },
            {"g16wm00", "Keyblade Graveyard (WM)" },

            {"m03dc00", "Bruiser (No Collision) (Non-FM)"},
            {"m07dc00", "Shoegazer (Jumping motion)"},

            {"m01ex00", "Flood"},
            {"m02ex00", "Scrapper"},
            {"m03ex00", "Bruiser"},
            {"m04ex00", "Red Hot Chili"},
            {"m05ex00", "Monotrucker"},
            {"m06ex00", "Thornbite"},
            {"m07ex00", "Shoegazer"},
            {"m08ex00", "Spiderchest"},
            {"m09ex00", "Archraven"},
            {"m10ex00", "Hareraiser"},
            {"m11ex00", "Jellyshade 1"},
            {"m12ex00", "Tank Toppler"},
            {"m13ex00", "Vile Phial"},
            {"m14ex00", "Sonic Blaster"},
            {"m15ex00", "Triple Wrecker"},
            {"m16ex00", "Wild Bruiser"},
            {"m17ex00", "Blue Sea Salt"},
            {"m18ex00", "Yellow Mustard"},
            {"m19ex00", "Mandrake"},
            {"m20ex00", "Buckle Bruiser"},
            {"m21ex00", "Chrono Twister"},
            {"m22ex00", "Axe Flapper"},
            {"m23ex00", "Prize Pod 1"},
            {"m24ex00", "Glidewinder (Red)"},
            {"m24ex01", "Glidewinder (Blue)"},
            {"m24ex02", "Glidewinder (Yellow)"},
            {"m25ex00", "Blobmob"},
            {"m26ex00", "Orbs of Light"},
            {"m27ex00", "Jellyshade 2"},
            {"m28ex00", "Jellyshade 3"},
            {"m29ex00", "Sand inside Chrono Twister"},
            {"m30ex00", "m30ex00"},
            {"m32ex00", "Jellyshade (Generic)"},
            {"m32ex01", "Jellyshade (Yellow 2)"},
            {"m32ex02", "Jellyshade (Yellow & Blue)"},
            {"m32ex03", "Jellyshade (Azure)"},
            {"m32ex04", "Jellyshade (Red 2)"},
            {"m40ex00", "Shadow"},
            {"m41ex00", "Neoshadow"},
            {"m42ex00", "Darkball"},
            {"m50ex00", "Survival Bottle"},
            {"m51ex00", "Flame Box"},
            {"m52ex00", "Lost Runner"},
            {"m53ex00", "Diet Tank"},
            {"m54ex00", "Launching Plant"},
            {"m55ex00", "Ringer Pot 1"},
            {"m56ex00", "Jelly Glee Tea"},
            {"m57ex00", "Element Cluster"},
            {"m58ex00", "Ringer Pot 2"},
            {"m59ex00", "Prize Pod 2"},
            {"m60ex00", "Unknown m60ex00"},

            {"m01vs00", "Flood (VS)"},
            {"m02vs00", "Scrapper (VS)"},
            {"m03vs00", "Bruiser (VS)"},
            {"m04vs00", "Red Hot Chili (VS)"},
            {"m05vs00", "Monotrucker (VS)"},
            {"m06vs00", "Thornbite (VS)"},
            {"m07vs00", "Shoegazer (VS)"},
            {"m08vs00", "Spiderchest (VS)"},
            {"m09vs00", "Archraven (VS)"},
            {"m10vs00", "Hareraiser (VS)"},
            {"m11vs00", "Jellyshade 1 (VS)"},
            {"m12vs00", "Tank Toppler (VS)"},
            {"m13vs00", "Vile Phial (VS)"},
            {"m14vs00", "Sonic Blaster (VS)"},
            {"m15vs00", "Triple Wrecker (VS)"},
            {"m16vs00", "Wild Bruiser (VS)"},
            {"m17vs00", "Blue Sea Salt (VS)"},
            {"m18vs00", "Yellow Mustard (VS)"},
            {"m19vs00", "Mandrake (VS)"},
            {"m20vs00", "Buckle Bruiser (VS)"},
            {"m21vs00", "Chrono Twister (VS)"},
            {"m22vs00", "Axe Flapper (VS)"},
            {"m23vs00", "Prize Pod 1 (VS)"},
            {"m25vs00", "m25vs00 (VS)"},
            {"m32vs00", "Jellyshade (Red) (VS)"},
            {"m32vs01", "Jellyshade (Yellow) (VS)"},
            {"m32vs02", "Jellyshade (White) (VS)"},
            {"m51vs00", "Maleficent's Minion (VS)"},
            {"m52vs00", "m52vs00 (VS)"},

            {"m01sb00", "Pork Minion (SB)"},
            {"m02sb00", "Eagle Minion (SB)"},
            {"m03sb00", "Boulder (SB)"},
            {"m10sb00", "Unknown Enemy m10sb00 (SB)"},

            {"n01bd00", "Fairy Godmother (NPC) (BD)"},
            {"n05bd00", "Chip (Running) (BD)"},
            {"n06bd00", "Fireworks (Moving) (BD)"},
            {"n10bd00", "n10bd00 (BD)"},
            {"n13bd00", "Honey Pot (BD)"},
            {"n17bd00", "Dice (BD)"},
            {"n18bd00", "n18bd00 (BD)"},
            {"n19bd00", "Water Layer with Caustics (BD)"},
            {"n20bd00", "Experiment 212 (Moving) (BD)"},
            {"n21bd00", "Rabbit (Moving) (BD)"},
            {"n24bd00", "Winnie the Pooh Board (BD)"},

            {"n05cd00", "Fairy Godmother (NPC) (CD)"},
            {"n09cd00", "Jaq (NPC) (CD)"},
            {"n11cd00", "Grand Duke (NPC) (CD)"},

            {"n01he00", "Hercules (NPC) (HE)"},
            {"n30he00", "Zack (Hair and Helmet) (NPC) (HE)"},

            {"n01ex00", "Flood (NPC) (EX)"},
            {"n10ex00", "Moogle Shop 1 (NPC) (EX)"},
            {"n11ex00", "Moogle Shop 2 (NPC) (EX)"},
            {"n12ex00", "Moogle Shop 3 (NPC) (EX)"},
            {"n13ex00", "Moogle Shop 4 (NPC) (EX)"},
            {"n32ex00", "Yellowshade (Red) (NPC) (EX)"},

            {"n01ls00", "Stitch (T-Stance) (NPC) (LS)"},

            {"n01sb01", "Aurora (NPC) (SB)"},

            {"n01sw00", "Snowwhite (NPC) (SW)"},
            {"n01sw01", "Snowwhite (T-Stance) (NPC) (SW)"},

            {"n01yt00", "Yen Sid (NPC) (YT)"},

            {"p00jb00", "Sora (PC)"},
            {"p01ex00", "Ventus (PC)"},
            {"p02ex00", "Aqua (PC)"},
            {"p03ex00", "Terra (PC)"},
            {"p11ex00", "Ventus Armor (PC)"},
            {"p12ex00", "Aqua Armor (PC)"},
            {"p13ex00", "Terra Armor (PC)"},
            {"p41ex00", "Ventus Armor Helmetless (PC)"},
            {"p42ex00", "Aqua Armor Helmetless (PC)"},
            {"p43ex00", "Terra Armor Helmetless (PC)"},


        };
    }
}
