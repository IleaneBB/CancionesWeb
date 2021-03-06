using System.ComponentModel.DataAnnotations;

namespace CancionesWeb.Models
{
    public class Canciones
    {
        [Key]
        public string CancionID { get; set; }
       // [Required]
       // [Display(Name="Nombre de la canción")]
        //public string Name { get; set; }
        [Display(Name = "Autor Principal")]
        public string Author { get; set; }
        [Display(Name = "Letra de la canción")]
        public string Lyrics { get; set; }
        [Display(Name = "Enlace de youtube")]
        public string URL { get; set; }

    }
}
