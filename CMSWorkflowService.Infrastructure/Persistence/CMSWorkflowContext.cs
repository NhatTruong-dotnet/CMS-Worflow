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
            entity.ToTable("WorkflowStatusDetail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DescriptionLabel).HasMaxLength(255);
            entity.Property(e => e.TemplateFileName).HasMaxLength(255);
            entity.Property(e => e.TemplateUrl).HasMaxLength(255);

            entity.HasOne(d => d.WorkflowStatus).WithMany(p => p.WorkflowStatusDetails)
                .HasForeignKey(d => d.WorkflowStatusId)
                .HasConstraintName("FK_WorkflowStatusDetail_WorkflowStatus");
        });

        modelBuilder.Entity<WorkflowStatusEmail>(entity =>
        {
            entity.ToTable("WorkflowStatusEmail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.WorkflowStatusId).HasColumnName("WorkflowStatusID");

            entity.HasOne(d => d.WorkflowStatus).WithMany(p => p.WorkflowStatusEmails)
                .HasForeignKey(d => d.WorkflowStatusId)
                .HasConstraintName("FK_WorkflowStatusEmail_WorkflowStatus");
        });

        modelBuilder.Entity<WorkflowStatusEmailReceiver>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WorkflowStatusEmailReceiver");

            entity.Property(e => e.DisplayName).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);

            entity.HasOne(d => d.IdNavigation).WithMany()
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_WorkflowStatusEmailReceiver_WorkflowStatusEmail");
        });

        modelBuilder.Entity<WorkflowStatusRole>(entity =>
        {
            entity.ToTable("WorkflowStatusRole");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.WorkflowStatus).WithMany(p => p.WorkflowStatusRoles)
                .HasForeignKey(d => d.WorkflowStatusId)
                .HasConstraintName("FK_WorkflowStatusRole_WorkflowStatus");
        });

        modelBuilder.Entity<WorkflowStatusTransaction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.WorkflowStatusTo).WithMany(p => p.WorkflowStatusTransactions)
                .HasForeignKey(d => d.WorkflowStatusToId)
                .HasConstraintName("FK_WorkflowStatusTransactions_WorkflowStatus");
        });

        modelBuilder.Entity<WorkflowStatusUser>(entity =>
        {
            entity.ToTable("WorkflowStatusUser");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.WorkflowStatus).WithMany(p => p.WorkflowStatusUsers)
                .HasForeignKey(d => d.WorkflowStatusId)
                .HasConstraintName("FK_WorkflowStatusUser_WorkflowStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
