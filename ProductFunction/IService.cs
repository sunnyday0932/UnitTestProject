namespace ProductFunction
{
    public interface IService
    {
        /// <summary>
        /// 取得帳號
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        AccountModel GetAccount(string account);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        bool Check(string text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InserAccount(AccountModel model);

    }
}
