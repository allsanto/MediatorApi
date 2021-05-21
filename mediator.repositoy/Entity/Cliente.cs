using System.ComponentModel.DataAnnotations;

namespace mediator.repositoy.Entity
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}
