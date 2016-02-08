using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordReset.DomainClasses.DbContext;
using PasswordReset.DomainClasses.Model;

namespace PasswordReset.Repositories
{
    public class UserRepository : IRepository<KBAD_USERS_DB>
    {
        private DBModel _userContext;

        public UserRepository()
        {
            _userContext = new DBModel();

        }

        public IEnumerable<KBAD_USERS_DB> List => _userContext.KBAD_USERS_DB;


        public void Add(KBAD_USERS_DB entity)
        {
            _userContext.KBAD_USERS_DB.Add(entity);
            _userContext.SaveChanges();
        }

        public void Delete(KBAD_USERS_DB entity)
        {
            _userContext.KBAD_USERS_DB.Remove(entity);
            _userContext.SaveChanges();
        }

        public void Update(KBAD_USERS_DB entity)
        {
            _userContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _userContext.SaveChanges();

        }

        IEnumerable<KBAD_USERS_DB> IRepository<KBAD_USERS_DB>.List { get; }

        public KBAD_USERS_DB FindById(Guid id)
        {
            var result = (from r in _userContext.KBAD_USERS_DB where r.Id == id select r).FirstOrDefault();
            return result;
        }
    }
}
