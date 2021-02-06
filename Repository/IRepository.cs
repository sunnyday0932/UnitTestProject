using ProductFunction;

namespace Repository
{
    public interface IRepository
    {
        /// <summary>
        /// 取得帳號
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        AccountModel GetAccount(string account);

        /// <summary>
        /// 新增帳號
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InsertAccount(AccountModel model);
    }
}
