using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using ClubManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace ClubManagement.Infrastructure.Data;

public class ClubManagmentContext : DbContext
{
    public DbSet<Anomalie> Anomalies { get; set; }
    public DbSet<AnomalieGroup> AnomalieGroups { get; set; }
    public DbSet<BodyType> BodyTypes { get; set; }
    public DbSet<BodyTypeProperty> BodyTypeProperties { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<CorrectiveAction> CorrectiveActions { get; set; }
    public DbSet<CorrectiveActionGroup> CorrectiveActionGroups { get; set; }
    public DbSet<Examination> Examinations { get; set; }
    public DbSet<ExaminationAnomalie> ExaminationAnomalies { get; set; }
    public DbSet<HealthInfo> HealthInfos { get; set; }
    public DbSet<IntroductionMethod> IntroductionMethods { get; set; }
    public DbSet<PersonalInfo> PersonalInfos { get; set; }
    public DbSet<Referred> Referreds { get; set; }
    public DbSet<ReferredDiseased> ReferredDiseaseds { get; set; }
    public DbSet<SpecialDisease> SpecialDiseases { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserType> UserTypes { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<SessionGroup> SessionGroups { get; set; }
    public DbSet<VitalSign> VitalSigns { get; set; }
    public DbSet<VitalSignsResult> VitalSignsResults { get; set; }
    public DbSet<CurrectionalProgramMaster> CurrectionalProgramMaster { get; set; }
    public DbSet<CurrectionalProgramDetail> CurrectionalProgramDetail { get; set; }
    public DbSet<MovementInterference> MovementInterferences { get; set; }
    public DbSet<Package> Packages { get; set; }

    //public DbSet<Device> Devices { get; set; }
    //public DbSet<DeviceOutput> DeviceOutputs { get; set; }
    //public DbSet<Parameter> Parameters { get; set; }
    //public DbSet<ParameterValue> ParameterValues { get; set; }

    //public DbSet<AttendanceSchedule> AttendanceSchedules { get; set; }
    //public DbSet<Service> Services { get; set; }
    //public DbSet<ServicesGroup> ServicesGroups { get; set; }
    //public DbSet<Shift> Shifts { get; set; }



    public ClubManagmentContext()
    {
    }

    public ClubManagmentContext(DbContextOptions<ClubManagmentContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CurrectionalProgramDetail>().HasOne(e => e.CurrectionalProgramMaster).WithMany().HasForeignKey(e => e.CurrectionalProgramMasterId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<CurrectionalProgramDetail>().HasOne(e => e.CorrectiveAction).WithMany().HasForeignKey(e => e.CorrectiveActionId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<CurrectionalProgramDetail>().HasOne(e => e.ExaminationAnomalie).WithMany().HasForeignKey(e => e.ExaminationAnomalieId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<CurrectionalProgramDetail>().HasOne(e => e.Unit).WithMany().HasForeignKey(e => e.UnitId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Package>().HasOne(e => e.SessionGroup).WithMany().HasForeignKey(e => e.SessionGroupId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        //modelBuilder.Entity<Examination>().HasOne(e => e.Package).WithMany().HasForeignKey(e => e.PackageId).IsRequired().OnDelete(DeleteBehavior.Restrict);
    }

}
