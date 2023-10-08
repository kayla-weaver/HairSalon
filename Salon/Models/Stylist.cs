using System.Collections.Generic;

namespace Salon.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Client> Clients { get; set; }

        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }
    }
}