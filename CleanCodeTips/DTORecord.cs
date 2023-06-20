
namespace CleanCodeTips
{
    public class DTORecord
    {
        
       public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
          

        }

        //Instead of above using 'Record' key:
        public record NewEmployeeMethod
        (
            int Id,
            string Name,
            string Description 

        );


    }

}
