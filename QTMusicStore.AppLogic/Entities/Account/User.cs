//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTMusicStore.AppLogic.Entities.Account
{
#if SQLITE_ON
    [Table("Users")]
#else
    [Table("Users", Schema = "account")]
#endif
    public partial class User : VersionObject
    {
        public IdType IdentityId { get; set; }
        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MaxLength(64)]
        public string LastName { get; set; } = string.Empty;
    }
}
#endif
//MdEnd
