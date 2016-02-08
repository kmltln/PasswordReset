using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordReset.DomainClasses.DbContext;
using PasswordReset.DomainClasses.Model;

namespace PasswordReset.Repositories
{
    public class UserAdRepository : IRepository<KBAD_USERS_AD>
    {
        private DBModel _userContext;

        public UserAdRepository()
        {
            _userContext = new DBModel();

        }

        public IEnumerable<KBAD_USERS_AD> List => _userContext.KBAD_USERS_AD;


        public void Add(KBAD_USERS_AD entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(KBAD_USERS_AD entity)
        {
            throw new NotImplementedException();
        }

        public void Update(KBAD_USERS_AD entity)
        {
            throw new NotImplementedException();
        }
    }
}
