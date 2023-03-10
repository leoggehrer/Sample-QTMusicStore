//@CodeCopy
//MdStart

using QTMusicStore.AppLogic.Contracts;

namespace QTMusicStore.AppLogic.ServiceModels
{
    public abstract partial class VersionService : IdentityService, IVersionable
    {
        /// <summary>
        /// Row version of the entity.
        /// </summary>
        public byte[]? RowVersion { get; set; }
    }
}
//MdEnd
