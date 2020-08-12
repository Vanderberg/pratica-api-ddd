using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDtoUpdate
    {
        [Required(ErrorMessage = "Id é campo obrigarorio para Login")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é campo obrigarorio para Login")]
        [StringLength(60, ErrorMessage = "E-mail deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "E-mail é campo obrigarorio para Login")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        [StringLength(100, ErrorMessage = "E-mail deve ter no máximo {1} caracteres")]
        public string email { get; set; }
    }
}