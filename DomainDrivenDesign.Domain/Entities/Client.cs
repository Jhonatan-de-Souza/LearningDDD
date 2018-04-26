using System;
using System.Collections.Generic;

namespace DomainDrivenDesign.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }

        //Creating a model that depends on a condition to set itself
        public bool SpecialClient(Client client)
        {
            return client.Active && DateTime.Now.Year - client.RegistrationDate.Year >= 5;
        }
    }
}
