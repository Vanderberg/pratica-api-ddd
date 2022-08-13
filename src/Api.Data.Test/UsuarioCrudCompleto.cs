using System;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Api.Data.Test
{
    public class UsuarioCrudCompleto : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvider;

        public UsuarioCrudCompleto(DbTeste dbTeste)
        {
            _serviceProvider = dbTeste.ServiceProvider;
        }
        
        [Fact(DisplayName = "CRUD de Usuário")]
        [Trait("CRUD", "UserEntity")]
        public async Task E_Possivel_Realizar_CRUD_Usuario()
        {
            using (var context = _serviceProvider.GetService<MyContext>())
            {
                UserImplementation _reposotorio = new UserImplementation(context);
                UserEntity _entity = new UserEntity
                {
                    Email = Faker.Internet.Email(),
                    Nome = Faker.Name.FullName()
                };

                var _registroCriado = await _reposotorio.InsertAsync(_entity);
                Assert.NotNull(_registroCriado);
                Assert.Equal(_entity.Email, _registroCriado.Email);
                Assert.Equal(_entity.Nome, _registroCriado.Nome);
                Assert.False(_registroCriado.Id == Guid.Empty);


                _entity.Nome = Faker.Name.First();
                var _RegistroAtualizado = await _reposotorio.UpdateAsync(_entity);
                Assert.NotNull(_RegistroAtualizado);
                Assert.Equal(_entity.Email, _RegistroAtualizado.Email);
                Assert.Equal(_entity.Nome, _RegistroAtualizado.Nome);

                var _registroExiste = await _reposotorio.ExistAsync(_entity.Id);

                var _registroSelecionado = await _reposotorio.SelectAsync(_entity.Id);
                Assert.NotNull(_registroSelecionado);
                Assert.Equal(_RegistroAtualizado.Email, _registroSelecionado.Email);
                Assert.Equal(_RegistroAtualizado.Nome, _registroSelecionado.Nome);

                var _todosRegistros = await _reposotorio.SelectAsync();
                Assert.NotNull(_todosRegistros);
                Assert.True(_todosRegistros.Count() > 0);
            }
        }
    }
}