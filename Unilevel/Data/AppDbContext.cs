﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Unilevel.Models;

public class AppDbContext : IdentityDbContext<User, Role, string>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Area> Area { get; set; }
    public DbSet<Permission> Permission { get; set; }
    public DbSet<GroupRole> GroupRole { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    public DbSet<SaleStaff> SaleStaff { get; set; }
    public DbSet<Distributor> Distributor { get; set; }
    public DbSet<VisitCalendar> VisitCalendar { get; set; }
    public DbSet<Unilevel.Models.JobForVisitation> JobForVisitation { get; set; }
    public DbSet<Visitor> Visitors { get; set; }
    public DbSet<ImplementationDate> ImplementationDate { get; set; }
    public DbSet<JobDetail> JobDetail { get; set; }
    public DbSet<CommentForJob> CommentForJob { get; set; }
    public DbSet<SaleDistributor> SaleDistributor { get; set; }
    public DbSet<Media> Media { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Survey> Surveys { get; set; }
    public DbSet<Question> Questions {  get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<SurveyRequest> SurveyRequest { get; set; }
    public DbSet<SurveyReceiver> SurveyReceiver { get; set; }
    public DbSet<SurveyResponse> SurveyResponse { get; set; }
    public DbSet<Notification> Notification { get; set; }
    public DbSet<NotifyReceiver> NotifyReceiver { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<SaleDistributor>()
            .ToTable("SaleDistributors");

        builder.Entity<User>()
            .HasOne(u => u.Areas)
            .WithMany()
            .HasForeignKey(u => u.AreaId);

        builder.Entity<SaleStaff>()
            .HasKey(d => d.UserId);
        // Quan hệ 1-1 giữa User và SaleStaff

        builder.Entity<SaleStaff>()
            .HasOne(s => s.User)
            .WithOne()
            .HasForeignKey<SaleStaff>(s => s.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Distributor>()
            .HasKey(d => d.UserId);

        // Quan hệ 1-1 giữa User và Distributor
        builder.Entity<Distributor>()
            .HasOne(d => d.User)
            .WithOne()
            .HasForeignKey<Distributor>(d => d.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        // Configure UserPermission composite key
        builder.Entity<RolePermission>()
            .HasKey(up => new { up.RoleId, up.PermissionId });

        builder.Entity<RolePermission>()
            .HasOne(up => up.Role)
            .WithMany(r => r.RolePermissions)
            .HasForeignKey(up => up.RoleId);

        builder.Entity<RolePermission>()
            .HasOne(up => up.Permission)
            .WithMany()
            .HasForeignKey(up => up.PermissionId);

        // Default value for NormalizedName
        builder.Entity<Role>()
            .Property(r => r.NormalizedName)
            .HasDefaultValue("Unknown");

        // Configure relationship between Role and GroupRole
        builder.Entity<Role>()
            .HasOne(r => r.GroupRole)  // Role có một GroupRole
            .WithMany()  // GroupRole có nhiều Role
            .HasForeignKey(r => r.GroupRoleId)  // Chỉ rõ khóa ngoại
            .OnDelete(DeleteBehavior.Restrict); // Hành vi xóa, có thể tùy chỉnh

        builder.Entity<Visitor>()
            .HasKey(v => new {v.VisitorId , v.VisitCalendarId});

        builder.Entity<Visitor>()
            .HasOne(v => v.User)
            .WithMany()
            .HasForeignKey(v => v.VisitorId);

        builder.Entity<Visitor>()
            .HasOne(v => v.VisitCalendar)
            .WithMany()
            .HasForeignKey(v => v.VisitCalendarId);

        builder.Entity<VisitCalendar>()
            .HasOne(v => v.Distributor)
            .WithMany()
            .HasForeignKey(v => v.DistributorId);

        builder.Entity<VisitCalendar>()
            .Property(v => v.ImplementationTime)
            .HasConversion<string>();

        builder.Entity<JobForVisitation>()
            .HasOne(j => j.VisitCalendar)
            .WithMany()
            .HasForeignKey(j => j.VisitCalendarId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<SaleDistributor>()
            .HasKey(sd => new {sd.DistributorId ,sd.SaleStaffId } );

        builder.Entity<SaleDistributor>()
            .HasOne(v => v.Distributor)
            .WithMany(s => s.SaleDistributors)
            .HasForeignKey(v => v.DistributorId)
            .IsRequired();

        builder.Entity<SaleDistributor>()
            .HasOne(v => v.SaleStaff)
            .WithMany(s => s.SaleDistributors)
            .HasForeignKey(v => v.SaleStaffId)
            .IsRequired();

        builder.Entity<VisitCalendar>()
            .HasOne(v => v.User)
            .WithMany()
            .HasForeignKey(v => v.CalendarCreatorId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<ImplementationDate>()
            .HasOne(i => i.VisitCalendar)
            .WithMany()
            .HasForeignKey(i => i.VisitCalendarId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<VisitCalendar>()
        .HasMany(vc => vc.Visitors)
        .WithOne(v => v.VisitCalendar)
        .HasForeignKey(v => v.VisitCalendarId);


        //de y
        builder.Entity<ImplementationDate>()
        .HasOne(i => i.VisitCalendar) 
        .WithMany(vc => vc.ImplementationDates)  
        .HasForeignKey(i => i.VisitCalendarId)  
        .OnDelete(DeleteBehavior.Cascade);

       builder.Entity<Unilevel.Models.JobForVisitation>()
        .HasOne(j => j.JobDetail)
        .WithOne()
        .HasForeignKey<JobDetail>(d => d.Id);


        builder.Entity<CommentForJob>()
       .HasOne(c => c.JobDetail)
       .WithMany(j => j.CommentForJob)
       .HasForeignKey(c => c.JobId);

        builder.Entity<Survey>()
        .HasMany(s => s.Questions)
        .WithOne(q => q.Survey)
        .HasForeignKey(q => q.SurveyId)
        .OnDelete(DeleteBehavior.Cascade); 

        builder.Entity<Question>()
            .HasMany(q => q.Answers)
            .WithOne(a => a.Question)
            .HasForeignKey(a => a.QuestionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<SurveyRequest>()
               .HasOne(s => s.Survey)
               .WithMany()
               .HasForeignKey(s => s.SurveyId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<SurveyRequest>()
               .HasMany(sr => sr.SurveyReceiver)
               .WithOne()
               .HasForeignKey(sr => sr.SurveyRequestId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<SurveyReceiver>()
            .HasKey(s => new { s.SurveyRequestId , s.UserId, s.SurveyId });

        builder.Entity<SurveyResponse>()
                  .HasOne<Survey>()
                  .WithMany()
                  .HasForeignKey(sr => sr.SurveyId)
                  .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<NotifyReceiver>()
                .HasKey(nr => new { nr.UserId, nr.NotificationId });

        builder.Entity<NotifyReceiver>()
            .HasOne(nr => nr.Notification)
            .WithMany(n => n.NotifyReceiver)
            .HasForeignKey(nr => nr.NotificationId)
            .OnDelete(DeleteBehavior.Cascade);


        // Seeding GroupRole data
        builder.Entity<GroupRole>().HasData(
            new GroupRole { GroupRoleId = 1, GroupRoleName = "SystemUser" },
            new GroupRole { GroupRoleId = 2, GroupRoleName = "Sale" },
            new GroupRole { GroupRoleId = 3, GroupRoleName = "Distributor" },
            new GroupRole { GroupRoleId = 4, GroupRoleName = "Guest" }
        );


        // Seeding Role data
        builder.Entity<Role>().HasData(
         new Role { Id = "00000000-0000-0000-0000-000000000001", Name = "Owner", NormalizedName = "OWNER", GroupRoleId = 1 },
         new Role { Id = "00000000-0000-0000-0000-000000000002", Name = "Administrator", NormalizedName = "ADMINISTRATOR", GroupRoleId = 1 },
         new Role { Id = "00000000-0000-0000-0000-000000000003", Name = "VPCD", NormalizedName = "VPCD", GroupRoleId = 2 },
         new Role { Id = "00000000-0000-0000-0000-000000000004", Name = "BM", NormalizedName = "BM", GroupRoleId = 2 },
         new Role { Id = "00000000-0000-0000-0000-000000000005", Name = "channelActivationHead", NormalizedName = "CHANNELACTIVATIONHEAD", GroupRoleId = 2 },
         new Role { Id = "00000000-0000-0000-0000-000000000006", Name = "ASM", NormalizedName = "ASM", GroupRoleId = 2 },
         new Role { Id = "00000000-0000-0000-0000-000000000007", Name = "BAM", NormalizedName = "BAM", GroupRoleId = 2 },
         new Role { Id = "00000000-0000-0000-0000-000000000008", Name = "CE", NormalizedName = "CE", GroupRoleId = 2 },
         new Role { Id = "00000000-0000-0000-0000-000000000009", Name = "SaleSUP", NormalizedName = "SALESUP", GroupRoleId = 2 },
         new Role { Id = "00000000-0000-0000-0000-000000000010", Name = "distributorOMTL", NormalizedName = "DISTRIBUTOROMTL", GroupRoleId = 3 },
         new Role { Id = "00000000-0000-0000-0000-000000000011", Name = "otherDepartment", NormalizedName = "OTHERDEPARTMENT", GroupRoleId = 4 },
         new Role { Id = "00000000-0000-0000-0000-000000000012", Name = "Guest", NormalizedName = "GUEST", GroupRoleId = 4 }
 );

    }
}
