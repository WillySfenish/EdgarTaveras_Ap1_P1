using System.ComponentModel.DataAnnotations;

namespace EdgarTaveras_Ap1_P1.Models
{
    public class Registros
    {
        [Key]
        public int RegistroId { get; set; }

        public string? RegistroName { get; set; }
    }
}
