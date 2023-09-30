using System.ComponentModel.DataAnnotations;

namespace LivrariaCrud.Models
{
    public class EmprestimoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Dite o nome do Recebedor!")]
        public string Recebedor { get; set; }
        [Required(ErrorMessage = "Dite o nome do Fornecedor!")]
        public string Fornecedor { get; set; }
        [Required(ErrorMessage = "Dite o nome do Livro!")]
        public string LivroEmprestado { get; set; }
        public DateTime DataEmprestimo { get; set; } = DateTime.Now;

    }
}
