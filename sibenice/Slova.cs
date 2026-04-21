using System.Text;
using System.Text.Json;

namespace sibenice {
    internal class Slova {
        private Dictionary<string, List<string>> wordlist;
        private Dictionary<string, List<string>> fallbackWordlist = new() {
            {
            "Zvířata", 
                new List<string> {
                    "nosorožec", "orangutan", "chameleon", "antilopa", "lenochod"
                }
            },
            {
            "Města",
                new List<string> {
                    "bratislava", "třebíč", "chomutov", "karviná", "liberec"
                }
            },
            {
            "Jídlo",
                new List<string> {
                    "svíčková", "bramborák", "palačinka", "čokoláda", "lasagne"
                }
            },
            {
            "Filmy",
                new List<string> {
                    "interstellar", "gladiátor", "terminátor", "predátor", "avatar"
                }
            },
            {
            "Povolání",
                new List<string> {
                    "programátor", "elektrikář", "mechanik", "architekt", "psycholog"
                }
            },
            {
            "Příroda",
                new List<string> {
                    "vodopád", "pobřeží", "zemětřesení", "vichřice", "prales"
                }
            },
            {
            "Sporty",
                new List<string> {
                    "rychlobruslení", "gymnastika", "lukostřelba", "cyklistika", "plavání"
                }
            }
        };
        
        public List<string> temata;
        public string errorMessage = "";

        public Slova() {
            wordlist = LoadWordlist();
            temata = wordlist.Keys.ToList();
        }

        private Dictionary<string, List<string>> LoadWordlist() {
            try {
                if (File.Exists("wordlist.json")) {
                    string sWordlist = File.ReadAllText("wordlist.json", Encoding.UTF8);
                    var data = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(sWordlist);

                    if (data != null && data.Count > 0)
                        return data;

                    errorMessage = "Soubor wordlist.json je prázdný nebo neplatný.";
                }
                errorMessage = "Soubor wordlist.json nebyl nalezen.";
            } catch {
                errorMessage = "Chyba při parsování wordlist.json.";
            }

            return fallbackWordlist;
        }

        public string GetWordForTema(string tema) {
            var words = wordlist[tema];
            Random rnd = new();
            return words[rnd.Next(words.Count)];
        }
    }
}