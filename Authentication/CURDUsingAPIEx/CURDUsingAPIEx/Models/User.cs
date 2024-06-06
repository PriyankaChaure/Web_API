namespace CURDUsingAPIEx.Models
{
    public class User
    {
        public Int64 UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EmailID { get; set; }
        public virtual List<UserToken> UserTokens { get; set; }
    }
}
