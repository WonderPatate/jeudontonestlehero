using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestlehero.Core.data.Models
{
    public class Questions
    {
        public int Id { get; set; }

        public string Titre { get; set; }

        public List<Questions> MesReponses { get; set; }
    }
}
