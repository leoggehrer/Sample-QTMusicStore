//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTMusicStore.AppLogic.Contracts.Account
{
    using QTMusicStore.AppLogic.Entities.Account;
    public partial interface IIdentityXRole
    {
        IdType IdentityId { get; set; }
        Role? Role { get; set; }
        IdType RoleId { get; set; }
    }
}
#endif
//MdEnd
