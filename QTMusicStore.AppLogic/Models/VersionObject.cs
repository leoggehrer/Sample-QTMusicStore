//@CodeCopy
//MdStart
using QTMusicStore.AppLogic.Contracts;

namespace QTMusicStore.AppLogic.Models
{
    public abstract partial class VersionObject : ModelObject, IVersionable
    {
        new internal virtual Entities.VersionObject Source
        {
            get => (Entities.VersionObject)_source!;
            set => _source = value;
        }
#if ROWVERSION_ON
        private byte[]? _rowVersion;
        /// <summary>
        /// Row version of the entity.
        /// </summary>
        public virtual byte[]? RowVersion
        {
            get => Source?.RowVersion ?? _rowVersion;
            set
            {
                if (Source != null)
                    Source.RowVersion = value;
                else
                    _rowVersion = value;
            }
        }
#endif
    }
}
//MdEnd
