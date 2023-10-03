namespace PhoneNumberAPI.DTOs
{
    public class PhoneNumberDto
    {
        public string Number { get; set; } = default!;
        public CountryDto Country { get; set; } = default!;
    }
}
