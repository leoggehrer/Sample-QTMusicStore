﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTMusicStore.AspMvc.Models.Account
{
    using AppLogic.Modules.Common;

    public partial class Identity : VersionModel
    {
        public IdentityRole[] IdentityRoleList { get; set; } = Array.Empty<IdentityRole>();
        public IdentityRole[] AddIdentityRoleList
        {
            get
            {
                IdentityRole[] result;

                if (IdentityRoleList != null)
                {
                    result = IdentityRoleList.Where(e => IdentityRoles.Any(m => m.Id == e.Id) == false).ToArray();
                }
                else
                {
                    result = Array.Empty<IdentityRole>();
                }
                return result;
            }
        }
        /// <summary>
        /// Gets or sets the guid.
        /// </summary>
        public Guid Guid { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int TimeOutInMinutes { get; set; } = 30;
        public int AccessFailedCount { get; set; }
        public State State { get; set; } = State.Active;

        public IdentityRole[] IdentityRoles { get; private set; } = Array.Empty<IdentityRole>();
        public static Identity Create(AppLogic.Models.Account.Identity source)
        {
            var result = new Identity();

            result.CopyFrom(source);
            result.IdentityRoles = source.Roles.Select(e => IdentityRole.Create(e)).ToArray();
            return result;
        }
    }
}
#endif
//MdEnd
