using System;

namespace Api.Domain.Dtos.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public DateTime CreateAt { get; set; }
    }
}