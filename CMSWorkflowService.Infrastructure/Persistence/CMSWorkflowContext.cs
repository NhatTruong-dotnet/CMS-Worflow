using CMSWorkflowService.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CMSWorkflowService.Infrastructure.Persistence;

public partial class CMSWorkflowContext : DbContext
{
    public CMSWorkflowContext()
    {
    }

    public CMSWorkflowContext(DbContextOptions<CMSWorkflowContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WorkflowStatus> WorkflowStatuses { get; set; }

    public virtual DbSet<WorkflowStatusDetail> WorkflowStatusDetails { get; set; }

    public virtual DbSet<WorkflowStatusEmail> WorkflowStatusEmails { get; set; }

    public virtual DbSet<WorkflowStatusEmailReceiver> WorkflowStatusEmailReceivers { get; set; }

    public virtual DbSet<WorkflowStatusRole> WorkflowStatusRoles { get; set; }

    public virtual DbSet<WorkflowStatusTransaction> WorkflowStatusTransactions { get; set; }

    public virtual DbSet<WorkflowStatusUser> WorkflowStatusUsers { get; set; }
  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkflowStatus>(entity =>
        {
            entity.ToTable("WorkflowStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<WorkflowStatusDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WorkflowStatusDetail");

            entity.Property(e => e.DescriptionLabel).HasMaxLength(255);
            entity.Property(e => e.TemplateFileName).HasMaxLength(255);
            entity.Property(e => e.TemplateUrl).HasMaxLength(255);
        });

        modelBuilder.Entity<WorkflowStatusEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WorkflowStatusEmail");

            entity.Property(e => e.WorkflowStatusId).HasColumnName("WorkflowStatusID");
        });

        modelBuilder.Entity<WorkflowStatusEmailReceiver>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WorkflowStatusEmailReceiver");

            entity.Property(e => e.DisplayName).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
        });

        modelBuilder.Entity<WorkflowStatusRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WorkflowStatusRole");
        });

        modelBuilder.Entity<WorkflowStatusTransaction>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<WorkflowStatusUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WorkflowStatusUser");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
