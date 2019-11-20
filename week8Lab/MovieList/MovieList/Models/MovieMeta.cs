using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{

    [MetadataType(typeof(MovieMeta))]

    public partial class Movie
    {

    }
    public class MovieMeta
    {
        [DisplayName("Date Released")]
        public System.DateTime DateReleased { get; set; }

    }
}