using System.ComponentModel.DataAnnotations.Schema;

namespace CURDUsingAPIEx.Models
{
    public class UserToken
    {
        public Int64 UserTokenID { get; set; }
        public string Token { get; set; }
        public Int64 UserID { get; set; }
        public virtual User User { get; set; }
    }
}
