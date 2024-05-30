namespace BloodBank.API.Models
{
    public class UpdateDonationModel
    {
        public int DonorId { get; set; }

        public DateTime DataDonation { get; set; }

        public int QuantidadeMl { get; set; }

        public CreateDonorModel Donor { get; set; }
    }
}
