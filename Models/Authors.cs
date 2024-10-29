namespace Coser_Fabiana_Lab2.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AuthorName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
      
    }
}
