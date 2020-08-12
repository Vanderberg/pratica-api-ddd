using System;

namespace Api.Domain.Models.User
{
    public class UserModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        private DateTime _CreateAt;
        public DateTime CreateAt
        {
            get { return _CreateAt; }
            set
            {
                _CreateAt = value == null ? DateTime.UtcNow : value;
            }
        }

        private DateTime _updateAt;
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }

    }
}