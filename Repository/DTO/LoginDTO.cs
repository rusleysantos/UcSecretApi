using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
    public class LoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int idUser { get; set; }
        public bool AuthorizationStatus { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }



        public LoginDTO() { }

        public LoginDTO(string token, int idUser, bool authorizationStatus, string email, string nome)
        {
            this.Token = token;
            this.idUser = idUser;
            this.AuthorizationStatus = authorizationStatus;
            this.Email = email;
            this.Nome = nome;
        }
    }
}
