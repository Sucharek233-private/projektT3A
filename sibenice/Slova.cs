using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace sibenice {
    internal class Slova {
        private Dictionary<string, List<string>> wordlist;
        public List<string> temata;

        public void LoadWords() {
            String sWordlist = File.ReadAllText("wordlist.json", Encoding.UTF8);
            wordlist = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(sWordlist) ?? [];
            temata = wordlist.Keys.ToList();
        }
    }
}
