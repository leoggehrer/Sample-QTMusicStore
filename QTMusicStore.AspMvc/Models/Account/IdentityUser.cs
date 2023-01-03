﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTMusicStore.AspMvc.Models.Account
{
    public partial class IdentityUser : VersionModel
    {
        public Identity[]? IdentityList { get; set; }

        public string IdentityEmail { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the identity id.
        /// </summary>
        public IdType IdentityId { get; set; }
        /// <summary>
        /// Gets and sets the user first name.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// Gets and sets the user last name.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Creates an instance of Identity and copies the properties of the same name from the object parameter. 
        /// </summary>
        /// <param name="source">The object to copy.</param>
        /// <returns></returns>
        public static IdentityUser Create(object source)
        {
            var result = new IdentityUser();

            result.CopyFrom(source);
            return result;
        }
    }
}
#endif
//MdEnd
