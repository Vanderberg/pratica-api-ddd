using System;
using System.Collections.Generic;
using Api.Domain.Dtos.User;

namespace Api.Service.Test.Usuario
{
    public class UsuarioTestes
    {
        public static string NomeUsuario { get; set; }
        public static string EmailUsuario { get; set; }
        public static string NomeUsuarioAlterado { get; set; }
        public static string EmailUsuarioAlterado { get; set; }
        public static Guid IdUsuario { get; set; }

        public List<UserDto> ListaUserDto = new List<UserDto>();
        public UserDto UserDto;
        public UserDtoCreate userDtoCreate;
        public UserDtoCreateResult userDtoCreateResult;
        public UserDtoUpdate userDtoUpdate;
        public UserDtoUpdateResult userDtoUpdateResult;

        public UsuarioTestes()
        {
            IdUsuario = Guid.NewGuid();
            NomeUsuario = Faker.Name.FullName();
            EmailUsuario = Faker.Internet.Email();
            NomeUsuarioAlterado = Faker.Name.FullName();
            EmailUsuarioAlterado = Faker.Internet.Email();

            for (int i = 0; i < 10; i++)
            {
                var dto = new UserDto()
                {
                    Id = new Guid(),
                    Nome = Faker.Name.FullName(),
                    email = Faker.Internet.Email()
                };
                ListaUserDto.Add(dto);
            }

            UserDto = new UserDto()
            {
                Id = IdUsuario,
                Nome = NomeUsuario,
                email = EmailUsuario
            };

            userDtoCreate = new UserDtoCreate()
            {
                Nome = NomeUsuario,
                email = EmailUsuario
            };
            
            userDtoCreateResult = new UserDtoCreateResult()
            {
                Id = IdUsuario,
                Nome = NomeUsuario,
                email = EmailUsuario,
                CreateAt = DateTime.UtcNow 
            };
            
            userDtoUpdate = new UserDtoUpdate()
            {
                Id = IdUsuario,
                Nome = NomeUsuario,
                email = EmailUsuario
            };
            
                        
            userDtoUpdateResult = new UserDtoUpdateResult()
            {
                Id = IdUsuario,
                Nome = NomeUsuario,
                email = EmailUsuario,
                UpdateAt = DateTime.UtcNow
            };
        }
    }
}