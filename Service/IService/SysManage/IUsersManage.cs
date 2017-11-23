using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IUsersManage:IRepository<Users>
    {
        bool Add(Users user);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        Users Login(string loginName, string pwd);

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Users GetUserById(int id);
    }
}
