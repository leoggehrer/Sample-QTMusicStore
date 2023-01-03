﻿//@GeneratedCode
namespace QTMusicStore.AspMvc.Models.App
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class TrackFilter : Models.View.IFilterModel
    {
        ///
        /// Generated by the generator
        ///
        static TrackFilter()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public TrackFilter()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        
        ///
        /// Generated by the generator
        ///
        public IdType? AlbumId
        { get; set; }
        
        ///
        /// Generated by the generator
        ///
        public IdType? GenerId
        { get; set; }
        
        ///
        /// Generated by the generator
        ///
        public System.String? Title
        { get; set; }
        
        ///
        /// Generated by the generator
        ///
        public System.String? Composer
        { get; set; }
        
        ///
        /// Generated by the generator
        ///
        public System.Int64? Millisconds
        { get; set; }
        
        ///
        /// Generated by the generator
        ///
        public System.Int64? Bytes
        { get; set; }
        
        ///
        /// Generated by the generator
        ///
        public System.Decimal? UnitPrice
        { get; set; }
        ///
        /// Generated by the generator
        ///
        public bool HasEntityValue => AlbumId != null || GenerId != null || Title != null || Composer != null || Millisconds != null || Bytes != null || UnitPrice != null;
        private bool show = true;
        ///
        /// Generated by the generator
        ///
        public bool Show => show;
        ///
        /// Generated by the generator
        ///
        public string CreateEntityPredicate()
        {
            var result = new System.Text.StringBuilder();
            
            if (AlbumId != null)
            {
                if (result.Length > 0)
                {
                    result.Append(" || ");
                }
                result.Append($"(AlbumId != null && AlbumId == {AlbumId})");
            }
            if (GenerId != null)
            {
                if (result.Length > 0)
                {
                    result.Append(" || ");
                }
                result.Append($"(GenerId != null && GenerId == {GenerId})");
            }
            if (Title != null)
            {
                if (result.Length > 0)
                {
                    result.Append(" || ");
                }
                result.Append($"(Title != null && Title.Contains(\"{Title}\"))");
            }
            if (Composer != null)
            {
                if (result.Length > 0)
                {
                    result.Append(" || ");
                }
                result.Append($"(Composer != null && Composer.Contains(\"{Composer}\"))");
            }
            if (Millisconds != null)
            {
                if (result.Length > 0)
                {
                    result.Append(" || ");
                }
                result.Append($"(Millisconds != null && Millisconds == {Millisconds})");
            }
            if (Bytes != null)
            {
                if (result.Length > 0)
                {
                    result.Append(" || ");
                }
                result.Append($"(Bytes != null && Bytes == {Bytes})");
            }
            if (UnitPrice != null)
            {
                if (result.Length > 0)
                {
                    result.Append(" || ");
                }
                result.Append($"(UnitPrice != null && UnitPrice == {UnitPrice})");
            }
            return result.ToString();
        }
        ///
        /// Generated by the generator
        ///
        public override string ToString()
        {
            System.Text.StringBuilder sb = new();
            if (AlbumId != null)
{
sb.Append($"AlbumId: {AlbumId} ");
}
if (GenerId != null)
{
sb.Append($"GenerId: {GenerId} ");
}
if (string.IsNullOrEmpty(Title) == false)
{
sb.Append($"Title: {Title} ");
}
if (string.IsNullOrEmpty(Composer) == false)
{
sb.Append($"Composer: {Composer} ");
}
if (Millisconds != null)
{
sb.Append($"Millisconds: {Millisconds} ");
}
if (Bytes != null)
{
sb.Append($"Bytes: {Bytes} ");
}
if (UnitPrice != null)
{
sb.Append($"UnitPrice: {UnitPrice} ");
}
            return sb.ToString();
        }
    }
}
