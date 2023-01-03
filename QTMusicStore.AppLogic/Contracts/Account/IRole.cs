//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTMusicStore.AppLogic.Contracts.Account
{
    public partial interface IRole
    {
        IdType Id { get; }
        Guid Guid { get; }
        string Designation { get; }
        string? Description { get; }
    }
}
#endif
//MdEnd
