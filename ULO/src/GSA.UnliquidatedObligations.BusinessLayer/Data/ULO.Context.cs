﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSA.UnliquidatedObligations.BusinessLayer.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ULODBEntities : DbContext
    {
        public ULODBEntities()
            : base("name=ULODBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<DocumentDocumentType> DocumentDocumentTypes { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<ReportDefinition> ReportDefinitions { get; set; }
        public virtual DbSet<RequestForReassignment> RequestForReassignments { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<UnliqudatedObjectsWorkflowQuestion> UnliqudatedObjectsWorkflowQuestions { get; set; }
        public virtual DbSet<UserUser> UserUsers { get; set; }
        public virtual DbSet<WorkflowDefinition> WorkflowDefinitions { get; set; }
        public virtual DbSet<WorkflowHistory> WorkflowHistories { get; set; }
        public virtual DbSet<Workflow> Workflows { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<Hash> Hashes { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobParameter> JobParameters { get; set; }
        public virtual DbSet<JobQueue> JobQueues { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Schema> Schemata { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<Set> Sets { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<AspnetUserApplicationPermissionClaim> AspnetUserApplicationPermissionClaims { get; set; }
        public virtual DbSet<AspnetUserSubjectCategoryClaim> AspnetUserSubjectCategoryClaims { get; set; }
        public virtual DbSet<ReviewStat> ReviewStats { get; set; }
        public virtual DbSet<UnliquidatedObligation> UnliquidatedObligations { get; set; }
    
        public virtual int CreateULOAndAssignWf(Nullable<int> reviewId, Nullable<int> workflowDefinitionId, Nullable<System.DateTime> reviewDate)
        {
            var reviewIdParameter = reviewId.HasValue ?
                new ObjectParameter("reviewId", reviewId) :
                new ObjectParameter("reviewId", typeof(int));
    
            var workflowDefinitionIdParameter = workflowDefinitionId.HasValue ?
                new ObjectParameter("workflowDefinitionId", workflowDefinitionId) :
                new ObjectParameter("workflowDefinitionId", typeof(int));
    
            var reviewDateParameter = reviewDate.HasValue ?
                new ObjectParameter("reviewDate", reviewDate) :
                new ObjectParameter("reviewDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateULOAndAssignWf", reviewIdParameter, workflowDefinitionIdParameter, reviewDateParameter);
        }
    
        public virtual ObjectResult<GetMyGroups_Result> GetMyGroups(string proposedOwnerId)
        {
            var proposedOwnerIdParameter = proposedOwnerId != null ?
                new ObjectParameter("proposedOwnerId", proposedOwnerId) :
                new ObjectParameter("proposedOwnerId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMyGroups_Result>("GetMyGroups", proposedOwnerIdParameter);
        }
    
        public virtual int GetNextLevelOwnerId(string proposedOwnerId, Nullable<int> workflowId, string nextActivityKey, string ownerProhibitedPreviousActivityNamesCsv, ObjectParameter nextOwnerId)
        {
            var proposedOwnerIdParameter = proposedOwnerId != null ?
                new ObjectParameter("proposedOwnerId", proposedOwnerId) :
                new ObjectParameter("proposedOwnerId", typeof(string));
    
            var workflowIdParameter = workflowId.HasValue ?
                new ObjectParameter("workflowId", workflowId) :
                new ObjectParameter("workflowId", typeof(int));
    
            var nextActivityKeyParameter = nextActivityKey != null ?
                new ObjectParameter("nextActivityKey", nextActivityKey) :
                new ObjectParameter("nextActivityKey", typeof(string));
    
            var ownerProhibitedPreviousActivityNamesCsvParameter = ownerProhibitedPreviousActivityNamesCsv != null ?
                new ObjectParameter("ownerProhibitedPreviousActivityNamesCsv", ownerProhibitedPreviousActivityNamesCsv) :
                new ObjectParameter("ownerProhibitedPreviousActivityNamesCsv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetNextLevelOwnerId", proposedOwnerIdParameter, workflowIdParameter, nextActivityKeyParameter, ownerProhibitedPreviousActivityNamesCsvParameter, nextOwnerId);
        }
    
        public virtual ObjectResult<GetUloSummariesByPdn_Result> GetUloSummariesByPdn(string pegasysDocumentNumber)
        {
            var pegasysDocumentNumberParameter = pegasysDocumentNumber != null ?
                new ObjectParameter("pegasysDocumentNumber", pegasysDocumentNumber) :
                new ObjectParameter("pegasysDocumentNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUloSummariesByPdn_Result>("GetUloSummariesByPdn", pegasysDocumentNumberParameter);
        }
    }
}
