using System.ComponentModel;

namespace BloodBank.API.Models
{
    public class CreateDonorModel
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }
        
        public string Genero { get; set;}

        public double Peso { get; set; }

        public string TipoSanguineo { get; set; }

        public string FatorRh { get; set; }

       // public Donations (List<Donations>) { get; set; }
    }
    
}
