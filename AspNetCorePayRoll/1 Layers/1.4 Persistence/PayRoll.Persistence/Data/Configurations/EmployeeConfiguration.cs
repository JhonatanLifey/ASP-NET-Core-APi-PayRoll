using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PayRoll.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Persistence.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("PayRoll_Employees"); //Name of the table in the data base.

            builder.HasKey(e => e.EmployeeId);

            builder.Property(e => e.EmployeeId).HasColumnName("employee_ID");

            builder.Property(e => e.AfpId).HasColumnName("afp_ID");

            builder.Property(e => e.CompanyId).HasColumnName("company_ID"); //Name of field in the database.

            builder.Property(e => e.EmployeeActive)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("employee_Active");

            builder.Property(e => e.EmployeeAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("employee_Address");

            builder.Property(e => e.EmployeeBirthDate)
                .HasColumnType("date")
                .HasColumnName("employee_BirthDate");

            builder.Property(e => e.EmployeeCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("employee_CODE");

            builder.Property(e => e.EmployeeCodePost)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("employee_CodePost");

            builder.Property(e => e.EmployeeDateEnd)
                .HasColumnType("date")
                .HasColumnName("employee_DateEnd");

            builder.Property(e => e.EmployeeDateStart)
                .HasColumnType("date")
                .HasColumnName("employee_DateStart");

            builder.Property(e => e.EmployeeIndAsigFamiliar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("employee_IndAsigFamiliar");

            builder.Property(e => e.EmployeeKindAfpsnp)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("employee_KindAFPSNP");

            builder.Property(e => e.EmployeeMiddle)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("employee_Middle");

            builder.Property(e => e.EmployeeName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("employee_Name");

            builder.Property(e => e.EmployeeNumberAfp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("employee_numberAFP");

            builder.Property(e => e.EmployeeSalary)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("employee_Salary");

            builder.Property(e => e.EmployeeState)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("employee_State");

            builder.Property(e => e.EmployeeSuburd)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("employee_Suburd");

            builder.Property(e => e.EmployeeSurname)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("employee_Surname");
            //

            builder.Property(e => e.Id)
                .HasColumnType("int");

            builder.Property(e => e.CreatedBy)
                .HasColumnType("nvarchar(max)");

            builder.Property(e => e.CreatedDate)
                .HasColumnType("datetime2");

            builder.Property(e => e.LastModifiedBy)
                .HasColumnType("nvarchar(max)");

            builder.Property(e => e.LastModifiedDate)
                .HasColumnType("datetime2");

            //


            builder.Property(e => e.PlaceId).HasColumnName("Place_ID");

            builder.Property(e => e.RolId).HasColumnName("Rol_Id");
        }
    }
}
