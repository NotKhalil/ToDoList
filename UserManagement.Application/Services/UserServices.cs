using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Domain.Models;
using UserManagement.Infrastructure.Context;

namespace UserManagement.Application.Services
{
    public class UserServices
    {
        private AppDbContext _context;
        public UserServices(AppDbContext context)
        {
            _context = context;
        }
        public User ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> ObterTodos() 
        { 
            throw new NotImplementedException();
        }

        public void Inserir(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Editar(int id, User user) 
        {
            throw new NotImplementedException();
        }

        public void Remover(int id) 
        {
            throw new NotImplementedException();
        }
    }
}
