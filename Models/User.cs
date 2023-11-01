using System.ComponentModel.DataAnnotations;

namespace appBodega.Models
{
    public class User
    {
        public int IdUser { get; set; }
        
        public string UserMail { get; set; }
        
        public string UserPassword { get; set; }

       
    }
}
