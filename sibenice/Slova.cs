using System.Text;
using System.Text.Json;

namespace sibenice {
    internal class Slova {
        private Dictionary<string, List<string>> wordlist;
        private Dictionary<string, List<string>> fallbackWordlist = new Dictionary<string, List<string>> {
            {
            "Zvířata", 
                new List<string> {
                    "pes", "kočka", "kůň", "tygr", "slon"
                }
            },
            {
            "Města",
                new List<string> {
                "praha", "brno", "ostrava", "plzeň"
                }
            },
            {
            "Jídlo",
                new List<string> {
                    "pizza", "sýr", "guláš", "řízek"
                }
            },
            {
            "Filmy",
                new List<string> {
                    "matrix", "terminátor", "titanic", "shrek"
                }
            },
            {
            "Povolání",
                new List<string> {
                    "lékař", "učitel", "programátor", "hasič"
                }
            },
            {
            "Příroda",
                new List<string> {
                    "strom", "řeka", "hora", "les"
                }
            },
            {
            "Sporty",
                new List<string> {
                    "fotbal", "hokej", "tenis", "plavání"
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
            var rnd = new Random();
            return words[rnd.Next(words.Count)];
        }
    }
}