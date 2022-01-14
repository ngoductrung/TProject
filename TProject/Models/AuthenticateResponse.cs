using TProject.Entities;

namespace TProject.Models
{
    public class AuthenticateResponse
    {
        public string Id { get; set; }
        public string Account { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Addr { get; set; }
        public string Management { get; set; }
        public bool Active { get; set; }
        public string Pass { get; set; }

        public string Token { get; set; }


        public AuthenticateResponse(Users user, string token)
        {
            Id = user.Id;
            Account = user.Account;
            FullName = user.FullName;
            Email = user.Email;
            Addr = user.Addr;
            Management = user.Management;
            Active = user.Active;
            Pass = user.Pass;

            Token = token;
        }
    }
}