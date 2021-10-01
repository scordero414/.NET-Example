namespace Proy1.Shared.Entity
{
    public class Actor
    {
        public int ID {get; set;}
        [Required] public string Name {get; set;}
        [Required] public DateTime BirthDate {get; set;}
        public string Photo {get; set;}
        [Required] public string Biography {get; set;}
    }
}