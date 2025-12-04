using Domain.ValueObjects;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public Cpf Cpf { get; private set; }
        private User(Guid id, string name, string email, string passwordHash, Cpf cpf)
        {
            Id = id;
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            Cpf = cpf;
        }
    }
}
