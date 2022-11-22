using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(40, ErrorMessage = "Il nome non può avere più di 40 caratteri")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(200, ErrorMessage = "La descrizione non può avere più di 200 caratteri")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string? Image { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(1, 999, ErrorMessage = "La pizza deve avere un prezzo valido")]
        public double? Prezzo { get; set; }


        public Pizza() {
        }

        public Pizza(string name, string description, string image, double prezzo) {

            this.Name = name;
            this.Description = description;
            this.Image= image;
            this.Prezzo= prezzo;
}
    }







}
