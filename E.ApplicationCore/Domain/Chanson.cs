using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace E.ApplicationCore.Domain
{
    public enum EnumStyleMusical
    {
        Classique,
        Pop,
        Rap,
        Rock

    }
    public class Chanson
    {

        public int ChansonId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateSortie { get; set; }

        public int duree { get; set; }
        public EnumStyleMusical StyleMusical { get; set; }
        [Range(3,12 )]
        public string Titre { get; set; }

        public int VuesYoutube { get; set; }

        public int ArtisteFK { get; set; }

    }
}
