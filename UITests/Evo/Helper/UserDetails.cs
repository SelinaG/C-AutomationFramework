
namespace UITests.Evo.Helper
{
    public class UserDetails
    {
        public class EvoPersonalInfo
        {
             public string Email { get; set; }               
             public string Password { get; set; }

             public string ComfirmPassword { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Gender { get; set; }

            public string MonthOfBirth { get; set; }

            public string DateOfBirth { get; set; }

            public string YearOfBirth { get; set; }

            public string HomeAddress { get; set; }

            public string City { get; set; }

            public string Country { get; set; }

            public string PostalCode { get; set; }

            public string Province { get; set; }

            public string PhoneNumber { get; set; }

            public string DriverLicense { get; set; }
            public string MonthOfExpire { get; set; }

            public string DateOfExpire { get; set; }

            public string YearOfExpire { get; set; }

            public string IssuedProvince { get; set; }

            public string IssuedCountry { get; set; }
        }

        public class EvoPaymentInfo
        {
            public string CardHolderName { get; set; }
            public string CardNumber { get; set; }
            public string MonthOfExpire { get; set; }
            public string YearOfExpire { get; set; }
            public string CvvCode { get; set; }            
        }

        public static EvoPersonalInfo evoUser = new EvoPersonalInfo()
        {
            Email = "evo@gmail.com",
            Password = "Bcaa1234",
            ComfirmPassword = "Bcaa1234",
            FirstName = "evoTest",
            LastName = "evoTest",
            Gender = "Male",
            MonthOfBirth = "2",
            DateOfBirth = "27",
            YearOfBirth = "1985",
            HomeAddress = "4567 Canada Way, Burnaby",            
            City = "Burnaby",
            Country = "Canada",
            PostalCode = "V5G 4T1",
            Province = "British Columbia",
            PhoneNumber = "6042685500",
            DriverLicense = "evotestlicense",
            MonthOfExpire = "3",
            DateOfExpire = "4",
            YearOfExpire = "2046",
            IssuedProvince = "British Columbia",
            IssuedCountry = "Canada"            
        };

    public EvoPaymentInfo evoPayment = new EvoPaymentInfo()
        {
            CardHolderName = "evo Test",
            CardNumber = "4502285070000007",
            MonthOfExpire = "4",
            YearOfExpire = "2036",
            CvvCode = "123"
        };


    }
}
