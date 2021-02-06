using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductFunction
{
    public class Service : IService
    {
        private readonly IRepository _repository;

        private readonly ILog _log;

        public Service(
            IRepository repository,
            ILog log)
        {
            this._repository = repository;
            this._log = log;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool Check(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                this._log.SaveLog("text 不可為空!");
                return false;
            }
            return true;
        }

        public AccountModel GetAccount(string account)
        {
            if (string.IsNullOrWhiteSpace(account))
            {
                throw new ArgumentNullException();
            }

            var data = this._repository.GetAccount(account);

            return data;
        }

        public bool InserAccount(AccountModel model)
        {
            var result = this._repository.InsertAccount(model);

            return result;
        }
    }
}
