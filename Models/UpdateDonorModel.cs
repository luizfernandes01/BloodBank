namespace BloodBank.API.Models
{
    public class UpdateDonorModel
    {
        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Genero { get; set; }

        public double Peso { get; set; }

        public string TipoSanguineo { get; set; }

        public string FatorRh { get; set; }
    }
}
