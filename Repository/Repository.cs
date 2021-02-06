using ProductFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class Repository : IRepository
    {
        public AccountModel GetAccount(string account)
        {
            var data = new List<AccountModel>
            {
                new AccountModel
                {
                    Account = "123",
                    UserName = "Sian"
                },
                new AccountModel
                {
                    Account = "456",
                    UserName = "Tom"
                }
            };

            return data.Where(x => x.Account == account).FirstOrDefault();
        }

        public bool InsertAccount(AccountModel model)
        {
            return true;
        }
    }
}
