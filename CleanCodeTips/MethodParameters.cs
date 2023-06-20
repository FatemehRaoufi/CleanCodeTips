//#Methods shouldn’t have too many parameters
namespace CleanCodeTips
{
    public class MethodParameters
    {
        public void SaveHomeAddress(string name, string homeAddress, string country, string email, string fileLocation)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(homeAddress)
        || string.IsNullOrEmpty(fileLocation))
            {
                Console.WriteLine("Input parameters are empty");
            }
            else
            {
                using FileStream fileStream = new FileStream(fileLocation, FileMode.Append);
                using StreamWriter writer = new StreamWriter(fileStream);
                List<string> aPersonRecord = new List<string>
        {
            name,
            homeAddress,
            country,
            email
        };
                writer.WriteLine(aPersonRecord);
            }
        }
        //CleanCode Method is:
        //public void SaveHomeAddress(AddressDetails addressDetails)
        //Therefor:
        //We start with creating a new class, called AddressDetails:
        public class AddressDetails
        {
            public string Name { get; set; }
            public string HomeAddress { get; set; }
            public string Country { get; set; }
            public string Email { get; set; }
            public string FileLocation { get; set; }
        }
        // The next step is to add a new parameter to the SaveHomeAddress method , we use new name: CleanCodeSaveHomeAddress :

        public void NewSaveHomeAddress(string name,
                            string homeAddress,
                            string country,
                            string email,
                            string fileLocation,
                            AddressDetails addressDetails)
        {



            if (string.IsNullOrEmpty(addressDetails.Name) || string.IsNullOrEmpty(homeAddress)
            || string.IsNullOrEmpty(fileLocation))
            {
                Console.WriteLine("Input parameters are empty");
            }
            else
            {
                using FileStream fileStream = new FileStream(fileLocation, FileMode.Append);
                using StreamWriter writer = new StreamWriter(fileStream);
                List<string> aPersonRecord = new List<string>
        {
            addressDetails.Name,
            homeAddress,
            country,
            email
        };
                writer.WriteLine(aPersonRecord);
            }
        }

        //And update the calls to the method with null value as the last parameter.



        public void CleanCodeSaveHomeAddress(AddressDetails addressDetails)
        {

            if (string.IsNullOrEmpty(addressDetails.Name) || string.IsNullOrEmpty(addressDetails.HomeAddress)
                || string.IsNullOrEmpty(addressDetails.FileLocation))
            {
                Console.WriteLine("Input parameters are empty");
            }
            else
            {
                using FileStream fileStream = new FileStream(addressDetails.FileLocation, FileMode.Append);
                using StreamWriter writer = new StreamWriter(fileStream);
                List<string> aPersonRecord = new List<string>
        {
            addressDetails.Name,
            addressDetails.HomeAddress,
            addressDetails.Country,
            addressDetails.Email
        };
                writer.WriteLine(aPersonRecord);
            }
        }
        //Calling Method:
        //NewSaveHomeAddress("John",
        //       "New York",
        //       "USA",
        //       "john@methodpoet.com",
        //       "C:\\temp",
        //       null);

        //var addressDetsils = new AddressDetails
        //{
        //    Name = "John",
        //    HomeAddress = "New York",
        //    Country = "USA",
        //    Email = "john@methodpoet.com",
        //    FileLocation = "C:\\temp"
        //};
        //CleanCodeSaveHomeAddress("John",
        //    "New York",
        //    "USA",
        //    "john@methodpoet.com",
        //    "C:\\temp",
        //    addressDetsils);

    }
}


//https://methodpoet.com/clean-code/
//https://methodpoet.com/reduce-number-of-method-parameters/