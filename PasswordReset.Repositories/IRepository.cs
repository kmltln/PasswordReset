using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PasswordReset.DomainClasses.Model;
using PasswordReset.DomainClasses.DbContext;

namespace PasswordReset.Repositories
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }

}
