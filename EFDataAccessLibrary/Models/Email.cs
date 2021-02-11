using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAccessLibrary.Models
{
    public class Email
    {
        [Key]
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        
        [ForeignKey(nameof(Person))] 
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}