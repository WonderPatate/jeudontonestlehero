using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestlehero.Core.data.Models
{
    public class Paragraphe
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public Questions maQuestion { get; set; }
    }
}
