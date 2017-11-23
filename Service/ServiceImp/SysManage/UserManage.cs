using Domain;
using Service.IService;
using System;

namespace Service.ServiceImp
{
    public class UserManage : RepositoryBase<Users>, IUsersManage
    {
        public bool Add(Users user)
        {
            return base.Save(user);
        }
        public Users GetUserById(int id)
        {
            return this.Get(x => x.Id == id);
        }

        public Users Login(string loginName, string pwd)
        {
            throw new NotImplementedException();
        }
    }
}
