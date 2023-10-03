namespace PhoneNumberAPI.DTOs
{
    public class CountryDto
    {
        public string CountryCode { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string CountryIso { get; set; } = default!;
        public List<CountryDetailDto> CountryDetails { get; set; } = default!;
    }
}
