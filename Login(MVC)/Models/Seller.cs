using System.Collections.Generic;
using System.Data.SqlClient;

namespace Login_MVC_.Models
{
    public class Seller
    {
        public Seller()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Client> Clients { get; set; }
    }
}