namespace BloodBank.API.Models
{
    public class CreateDonationModel
    {
        public int ID { get; set; }

        public int DonorId { get; set; }
               
        public DateTime DataDonation { get; set;}

        public int QuantidadeMl  { get; set;}

        public CreateDonorModel  Donor  { get; set; }
    }
}
