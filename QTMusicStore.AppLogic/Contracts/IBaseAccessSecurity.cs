//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTMusicStore.AppLogic.Contracts
{
    partial interface IBaseAccess<T>
    {
        /// <summary>
        /// Sets the authorization token.
        /// </summary>
        string SessionToken { set; }
    }
}
#endif
//MdEnd
