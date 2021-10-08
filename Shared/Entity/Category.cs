using System.ComponentModel.DataAnnotations;
namespace Proy1.Shared.Entity
{
    public class Category
    {
        public int Id { get; set;}
        [Required(ErrorMessage="El {0} es requerido")] public string Name {get; set;}

    }
}