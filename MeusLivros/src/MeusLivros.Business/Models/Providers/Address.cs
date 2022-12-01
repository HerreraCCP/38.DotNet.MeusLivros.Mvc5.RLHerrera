using MeusLivros.Business.Core.Models;

namespace MeusLivros.Business.Models.Providers
{
    public class Address : Entity
    {
        public string Publicspace { get; set; } // Logradouro

        public string Number { get; set; }
        
        public string Complement { get; set; }
        
        public string Zipcode { get; set; }
        
        public string Neighborhood { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }

        /* EF Relations */
        public Provider Provider { get; set; }
    }
}