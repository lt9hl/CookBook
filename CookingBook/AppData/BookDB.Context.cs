﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CookingBook.AppData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookEntitiesNw : DbContext
    {
        public BookEntitiesNw()
            : base("name=BookEntitiesNw")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CookingSetps> CookingSetps { get; set; }
        public virtual DbSet<Ingridients> Ingridients { get; set; }
        public virtual DbSet<RecipeIngridients> RecipeIngridients { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }
        public virtual DbSet<RecipeTags> RecipeTags { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Tags1> Tags1 { get; set; }
    }
}
