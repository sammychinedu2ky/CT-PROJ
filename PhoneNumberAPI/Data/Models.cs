namespace PhoneNumberAPI.Data
{
    public class Models
    {
        public class Country
        {
            public int Id { get; set; }
            public string CountryCode { get; set; } = default!;
            public string Name { get; set; } = default!;
            public string CountryIso { get; set; } = default!;
            public virtual ICollection<CountryDetail> CountryDetails { get; set; } = default!;
        }

        public class CountryDetail
        {
            public int Id { get; set; }
            public int CountryId { get; set; }
            public string OperatorCode { get; set; } = default!;
            public string Operator { get; set; } = default!;
            public virtual Country Country { get; set; } = default!;
        }

    }
}
