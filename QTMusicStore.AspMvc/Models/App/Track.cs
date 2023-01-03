﻿//@GeneratedCode
namespace QTMusicStore.AspMvc.Models.App
{
    using System;
    ///
    /// Generated by the generator
    ///
    
    public partial class Track
    {
        ///
        /// Generated by the generator
        ///
        static Track()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public Track()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        
        public IdType AlbumId { get; set; }
        ///
        /// Generated by the generator
        ///
        
        public IdType GenerId { get; set; }
        ///
        /// Generated by the generator
        ///
        
        public System.String Title { get; set; } = string.Empty;
        ///
        /// Generated by the generator
        ///
        
        public System.String? Composer { get; set; }
        ///
        /// Generated by the generator
        ///
        
        public System.Int64 Millisconds { get; set; }
        ///
        /// Generated by the generator
        ///
        
        public System.Int64 Bytes { get; set; }
        ///
        /// Generated by the generator
        ///
        
        public System.Decimal UnitPrice { get; set; }
        ///
        /// Generated by the generator
        ///
        
        public QTMusicStore.AspMvc.Models.App.Album? Album { get; set; }
        ///
        /// Generated by the generator
        ///
        
        public QTMusicStore.AspMvc.Models.App.Genre? Genre { get; set; }
        ///
        /// Generated by the generator
        ///
        public static QTMusicStore.AspMvc.Models.App.Track Create()
        {
            BeforeCreate();
            var result = new QTMusicStore.AspMvc.Models.App.Track();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTMusicStore.AspMvc.Models.App.Track Create(object other)
        {
            BeforeCreate(other);
            var result = new QTMusicStore.AspMvc.Models.App.Track();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTMusicStore.AspMvc.Models.App.Track instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTMusicStore.AspMvc.Models.App.Track instance, object other);
        ///
        /// Generated by the generator
        ///
        public static QTMusicStore.AspMvc.Models.App.Track Create(QTMusicStore.AppLogic.Models.App.Track other)
        {
            BeforeCreate(other);
            var result = new QTMusicStore.AspMvc.Models.App.Track();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate(QTMusicStore.AppLogic.Models.App.Track other);
        static partial void AfterCreate(QTMusicStore.AspMvc.Models.App.Track instance, QTMusicStore.AppLogic.Models.App.Track other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTMusicStore.AppLogic.Models.App.Track other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                AlbumId = other.AlbumId;
                GenerId = other.GenerId;
                Title = other.Title;
                Composer = other.Composer;
                Millisconds = other.Millisconds;
                Bytes = other.Bytes;
                UnitPrice = other.UnitPrice;
                Album = other.Album != null ? QTMusicStore.AspMvc.Models.App.Album.Create((object)other.Album) : null;
                Genre = other.Genre != null ? QTMusicStore.AspMvc.Models.App.Genre.Create((object)other.Genre) : null;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTMusicStore.AppLogic.Models.App.Track other, ref bool handled);
        partial void AfterCopyProperties(QTMusicStore.AppLogic.Models.App.Track other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTMusicStore.AspMvc.Models.App.Track other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                AlbumId = other.AlbumId;
                GenerId = other.GenerId;
                Title = other.Title;
                Composer = other.Composer;
                Millisconds = other.Millisconds;
                Bytes = other.Bytes;
                UnitPrice = other.UnitPrice;
                Album = other.Album != null ? QTMusicStore.AspMvc.Models.App.Album.Create((object)other.Album) : null;
                Genre = other.Genre != null ? QTMusicStore.AspMvc.Models.App.Genre.Create((object)other.Genre) : null;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTMusicStore.AspMvc.Models.App.Track other, ref bool handled);
        partial void AfterCopyProperties(QTMusicStore.AspMvc.Models.App.Track other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.App.Track other)
            {
                result = Id == other.Id;
            }
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public override int GetHashCode()
        {
            return HashCode.Combine(AlbumId, GenerId, Title, Composer, Millisconds, Bytes, HashCode.Combine(UnitPrice, Album, Genre, Id));
        }
    }
}