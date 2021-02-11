using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAccessLibrary.Models
{
    public class Address
    {
        [Key] public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [ForeignKey(nameof(Person))] 
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}