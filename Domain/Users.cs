using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   //[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class Users: DbContext
    {
        public Users()
            : base("name=AuthMySqlCon")
        {
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Pwd { get; set; }

        public string EnterpriseId { get; set; }

        public string LoginName { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

    }
}
