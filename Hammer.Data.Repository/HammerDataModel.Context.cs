﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hammer.Data.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;

    public partial class HammerEntities : DbContext
    {
        public HammerEntities()
            : base("name=HammerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Hammer> Hammers { get; set; }
        public DbSet<HammerType> HammerTypes { get; set; }
    
        public virtual int DeleteHammer(Nullable<int> hammerId)
        {
            var hammerIdParameter = hammerId.HasValue ?
                new ObjectParameter("HammerId", hammerId) :
                new ObjectParameter("HammerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteHammer", hammerIdParameter);
        }
    
        public virtual int DeleteHammerType(Nullable<int> typeId)
        {
            var typeIdParameter = typeId.HasValue ?
                new ObjectParameter("TypeId", typeId) :
                new ObjectParameter("TypeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteHammerType", typeIdParameter);
        }
    
        public virtual ObjectResult<GetHammers_Result> GetHammers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetHammers_Result>("GetHammers");
        }
    
        public virtual ObjectResult<string> InsertUpdateHammer(Nullable<int> hammerId, string name, string desc, Nullable<int> typeId, string createdBy)
        {
            var hammerIdParameter = hammerId.HasValue ?
                new ObjectParameter("HammerId", hammerId) :
                new ObjectParameter("HammerId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descParameter = desc != null ?
                new ObjectParameter("Desc", desc) :
                new ObjectParameter("Desc", typeof(string));
    
            var typeIdParameter = typeId.HasValue ?
                new ObjectParameter("TypeId", typeId) :
                new ObjectParameter("TypeId", typeof(int));
    
            var createdByParameter = createdBy != null ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("InsertUpdateHammer", hammerIdParameter, nameParameter, descParameter, typeIdParameter, createdByParameter);
        }
    
        public virtual ObjectResult<string> InsertUpdateHammerType(Nullable<int> typeId, string typeName, string typeDesc, string createdBy)
        {
            var typeIdParameter = typeId.HasValue ?
                new ObjectParameter("TypeId", typeId) :
                new ObjectParameter("TypeId", typeof(int));
    
            var typeNameParameter = typeName != null ?
                new ObjectParameter("TypeName", typeName) :
                new ObjectParameter("TypeName", typeof(string));
    
            var typeDescParameter = typeDesc != null ?
                new ObjectParameter("TypeDesc", typeDesc) :
                new ObjectParameter("TypeDesc", typeof(string));
    
            var createdByParameter = createdBy != null ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("InsertUpdateHammerType", typeIdParameter, typeNameParameter, typeDescParameter, createdByParameter);
        }
    }
}
