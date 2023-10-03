using Microsoft.AspNetCore.Mvc;
using PhoneNumberAPI.DTOs;
using PhoneNumberAPI.UnitOfWork;
using System.Text.RegularExpressions;

[Route("api/[controller]")]
[ApiController]
public class PhoneNumberDetailsController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public PhoneNumberDetailsController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet("{phoneNumber}")]
    public ActionResult<PhoneNumberDto> GetPhoneNumberDetails(string phoneNumber)
    {
        try
        {
            if (!IsAPhoneNumber(phoneNumber))
            {
                return BadRequest("Invalid phone number");
            }

            string countryCode = phoneNumber.Substring(0, 3);

            var country = _unitOfWork.CountryRepository.GetCountryByCode(countryCode);

            if (country == null)
            {
                return NotFound();
            }

            var countryDetails = _unitOfWork.CountryDetailRepository.GetDetailsByCountryId(country.Id);

            var phoneNumberDto = new PhoneNumberDto
            {
                Number = phoneNumber,
                Country = new CountryDto
                {
                    CountryCode = country.CountryCode,
                    Name = country.Name,
                    CountryIso = country.CountryIso,
                    CountryDetails = countryDetails.Select(cd => new CountryDetailDto
                    {
                        Operator = cd.Operator,
                        OperatorCode = cd.OperatorCode
                    }).ToList()
                }
            };

            return Ok(phoneNumberDto);
        }
        catch (Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }

    private bool IsAPhoneNumber(string input)
    {
        string pattern = @"^\d{13}$";
        return Regex.IsMatch(input, pattern);
    }
}
