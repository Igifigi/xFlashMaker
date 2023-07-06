using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace xFlashMaker
{
    internal class Flashcard
    {
        public string term { get; set; }
        public string definition { get; set; }

        public Flashcard(string term, string definition) {
            this.term = term;
            this.definition = definition;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", this.term, this.definition);
        }
    }
}
