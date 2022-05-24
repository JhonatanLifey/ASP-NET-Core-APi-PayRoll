using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PayRoll.Domain.Entities;

#nullable disable

namespace PayRoll.Persistence.Data
{
    public partial class DB_PayRollContext : DbContext
    {
        public DB_PayRollContext()
        {
        }

        public DB_PayRollContext(DbContextOptions<DB_PayRollContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BudgetCcosto> BudgetCcostos { get; set; }
        public virtual DbSet<MasterCompany> MasterCompanies { get; set; }
        public virtual DbSet<PayRollAfp> PayRollAfps { get; set; }
        public virtual DbSet<PayRollAfpdetail> PayRollAfpdetails { get; set; }
        public virtual DbSet<PayRollCalculate> PayRollCalculates { get; set; }
        public virtual DbSet<PayRollCloseFrequency> PayRollCloseFrequencies { get; set; }
        public virtual DbSet<PayRollCloseMonthly> PayRollCloseMonthlies { get; set; }
        public virtual DbSet<PayRollEmployee> PayRollEmployees { get; set; }
        public virtual DbSet<PayRollFormula> PayRollFormulas { get; set; }
        public virtual DbSet<PayRollFormulaDetail> PayRollFormulaDetails { get; set; }
        public virtual DbSet<PayRollHoliday> PayRollHolidays { get; set; }
        public virtual DbSet<PayRollKindPayroll> PayRollKindPayrolls { get; set; }
        public virtual DbSet<PayRollPayroll> PayRollPayrolls { get; set; }
        public virtual DbSet<PayRollPayrollConcept> PayRollPayrollConcepts { get; set; }
        public virtual DbSet<PayRollPlace> PayRollPlaces { get; set; }
        public virtual DbSet<PayRollProvisionBonuse> PayRollProvisionBonuses { get; set; }
        public virtual DbSet<PayRollProvisionCt> PayRollProvisionCts { get; set; }
        public virtual DbSet<PayRollProvisionHoliday> PayRollProvisionHolidays { get; set; }
        public virtual DbSet<PayRollRol> PayRollRols { get; set; }
        public virtual DbSet<Tabla> Tablas { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BudgetCcosto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Budget_Ccostos");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(10)
                    .HasColumnName("company_ID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MasterCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK_CompanyID");

                entity.ToTable("masterCompany");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNumberTax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyStreet)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanySuburb)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayRollAfp>(entity =>
            {
                entity.HasKey(e => e.AfpId);

                entity.ToTable("PayRoll_AFP");

                entity.Property(e => e.AfpId).HasColumnName("afp_ID");

                entity.Property(e => e.AfpIdRtps)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("afp_ID_RTPS");

                entity.Property(e => e.AfpName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("afp_Name");

                entity.Property(e => e.AfpStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("afp_Status");
            });

            modelBuilder.Entity<PayRollAfpdetail>(entity =>
            {
                entity.HasKey(e => new { e.AfpId, e.AfpYear, e.AfpMonth });

                entity.ToTable("PayRoll_AFPDetails");

                entity.Property(e => e.AfpId).HasColumnName("afp_ID");

                entity.Property(e => e.AfpYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("afp_year");

                entity.Property(e => e.AfpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("afp_month");

                entity.Property(e => e.AfpRate)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("afp_rate");
            });

            modelBuilder.Entity<PayRollCalculate>(entity =>
            {
                entity.HasKey(e => e.CalculateId);

                entity.ToTable("PayRoll_Calculate");

                entity.Property(e => e.CalculateId)
                    .ValueGeneratedNever()
                    .HasColumnName("calculate_ID");

                entity.Property(e => e.CalculateCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("calculate_Code");

                entity.Property(e => e.CalculateDetail)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("calculate_detail");

                entity.Property(e => e.CalculateGroup)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("calculate_group")
                    .HasComment("gruop income");

                entity.Property(e => e.CalculateIndCts)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("calculate_IndCTS");

                entity.Property(e => e.CalculateIndGratificacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("calculate_IndGratificacion");

                entity.Property(e => e.CalculateIndHoliday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("calculate_IndHoliday");

                entity.Property(e => e.CalculateIndUtilidades)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("calculate_IndUtilidades");

                entity.Property(e => e.CalculateName)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("calculate_Name");

                entity.Property(e => e.CalculateType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("calculate_type")
                    .HasComment("Income, aporte, expenses");

                entity.Property(e => e.CompanyId).HasColumnName("company_ID");

                entity.Property(e => e.FormulaId).HasColumnName("Formula_ID");
            });

            modelBuilder.Entity<PayRollCloseFrequency>(entity =>
            {
                entity.HasKey(e => new { e.CloseOYear, e.CloseOMonth, e.CloseOFrequency, e.KindPayrollId });

                entity.ToTable("PayRoll_CloseFrequency");

                entity.Property(e => e.CloseOYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CloseO_Year")
                    .HasComment("Table for help to know close weekly or fortnightly");

                entity.Property(e => e.CloseOMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CloseO_Month");

                entity.Property(e => e.CloseOFrequency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CloseO_Frequency");

                entity.Property(e => e.KindPayrollId).HasColumnName("KindPayroll_ID");

                entity.Property(e => e.CloseOStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CloseO_Status");
            });

            modelBuilder.Entity<PayRollCloseMonthly>(entity =>
            {
                entity.HasKey(e => new { e.CloseMYear, e.CloseMMonth, e.KindPayrollId });

                entity.ToTable("PayRoll_CloseMonthly");

                entity.Property(e => e.CloseMYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CloseM_Year");

                entity.Property(e => e.CloseMMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CloseM_Month");

                entity.Property(e => e.KindPayrollId).HasColumnName("KindPayroll_ID");

                entity.Property(e => e.CloseMStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CloseM_Status");
            });

            modelBuilder.Entity<PayRollEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("PayRoll_Employees");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_ID");

                entity.Property(e => e.AfpId).HasColumnName("afp_ID");

                entity.Property(e => e.CompanyId).HasColumnName("company_ID");

                entity.Property(e => e.EmployeeActive)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("employee_Active");

                entity.Property(e => e.EmployeeAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("employee_Address");

                entity.Property(e => e.EmployeeBirthDate)
                    .HasColumnType("date")
                    .HasColumnName("employee_BirthDate");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("employee_CODE");

                entity.Property(e => e.EmployeeCodePost)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("employee_CodePost");

                entity.Property(e => e.EmployeeDateEnd)
                    .HasColumnType("date")
                    .HasColumnName("employee_DateEnd");

                entity.Property(e => e.EmployeeDateStart)
                    .HasColumnType("date")
                    .HasColumnName("employee_DateStart");

                entity.Property(e => e.EmployeeIndAsigFamiliar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("employee_IndAsigFamiliar");

                entity.Property(e => e.EmployeeKindAfpsnp)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("employee_KindAFPSNP");

                entity.Property(e => e.EmployeeMiddle)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("employee_Middle");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employee_Name");

                entity.Property(e => e.EmployeeNumberAfp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_numberAFP");

                entity.Property(e => e.EmployeeSalary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("employee_Salary");

                entity.Property(e => e.EmployeeState)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("employee_State");

                entity.Property(e => e.EmployeeSuburd)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("employee_Suburd");

                entity.Property(e => e.EmployeeSurname)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("employee_Surname");

                entity.Property(e => e.PlaceId).HasColumnName("Place_ID");

                entity.Property(e => e.RolId).HasColumnName("Rol_Id");
            });

            modelBuilder.Entity<PayRollFormula>(entity =>
            {
                entity.HasKey(e => e.FormulaId);

                entity.ToTable("PayRoll_Formula");

                entity.Property(e => e.FormulaId).HasColumnName("FormulaID");

                entity.Property(e => e.CompanyId).HasColumnName("company_ID");

                entity.Property(e => e.Formula)
                    .HasMaxLength(1250)
                    .IsUnicode(false);

                entity.Property(e => e.FormulaDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FormulaStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayRollFormulaDetail>(entity =>
            {
                entity.HasKey(e => e.FormulaItem);

                entity.ToTable("PayRoll_FormulaDetails");

                entity.Property(e => e.FormulaItem).HasColumnName("Formula_Item");

                entity.Property(e => e.CompanyId).HasColumnName("company_ID");

                entity.Property(e => e.FormulaId).HasColumnName("Formula_ID");

                entity.Property(e => e.FormulaVariable)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Formula_Variable")
                    .HasComment("Puede ser el Calculate_Id o un valor en duro como 5 o 4, ");

                entity.Property(e => e.FormulaVariableType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Formula_VariableType")
                    .HasComment("Puede ser el Calculate_Id o un valor en duro como 5 o 4, valor o resultado");
            });

            modelBuilder.Entity<PayRollHoliday>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PayRoll_Holiday");

                entity.Property(e => e.CompanyId).HasColumnName("company_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_ID");

                entity.Property(e => e.HolidayDateEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Holiday_DateEnd");

                entity.Property(e => e.HolidayDateStart)
                    .HasColumnType("datetime")
                    .HasColumnName("Holiday_DateStart");

                entity.Property(e => e.HolidayDays).HasColumnName("Holiday_Days");

                entity.Property(e => e.HolidayId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Holiday_ID");

                entity.Property(e => e.HolidayMonth)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Holiday_Month");

                entity.Property(e => e.HolidayYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Holiday_Year");

                entity.Property(e => e.HolidayYearProcess)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Holiday_Year_process");
            });

            modelBuilder.Entity<PayRollKindPayroll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PayRoll_KindPayroll");

                entity.Property(e => e.CompanyId).HasColumnName("company_ID");

                entity.Property(e => e.KindPayrollFrecuency)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KindPayroll_Frecuency");

                entity.Property(e => e.KindPayrollId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("KindPayroll_ID");

                entity.Property(e => e.KindPayrollIndBonus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KindPayroll_IndBonus");

                entity.Property(e => e.KindPayrollIndCts)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KindPayroll_IndCTS");

                entity.Property(e => e.KindPayrollIndHoliday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KindPayroll_IndHoliday");

                entity.Property(e => e.KindPayrollName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("KindPayroll_Name");
            });

            modelBuilder.Entity<PayRollPayroll>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("PayRoll_Payroll");

                entity.Property(e => e.PaymentId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("payment_ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("company_ID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employee_ID");

                entity.Property(e => e.PaymentAmountCalc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("payment_amount_calc");

                entity.Property(e => e.PaymentAmountInput)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("payment_amount_input");

                entity.Property(e => e.PaymentIndInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("payment_ind_input")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PaymentMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("payment_month");

                entity.Property(e => e.PaymentYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("payment_year");

                entity.Property(e => e.PayrollConceptId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("payrollConcept_ID");
            });

            modelBuilder.Entity<PayRollPayrollConcept>(entity =>
            {
                entity.HasKey(e => e.PayrollConceptId)
                    .HasName("PK_PayRoll_payrollConcept");

                entity.ToTable("PayRoll_PayrollConcept");

                entity.Property(e => e.PayrollConceptId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("payrollConcept_ID");

                entity.Property(e => e.CalculateId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("calculate_ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("company_ID");

                entity.Property(e => e.PayrollConceptIndInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("payrollConcept_ind_input");

                entity.Property(e => e.PayrollConceptName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("payrollConcept_Name");
            });

            modelBuilder.Entity<PayRollPlace>(entity =>
            {
                entity.HasKey(e => e.PlaceId);

                entity.ToTable("PayRoll_Place");

                entity.Property(e => e.PlaceId).HasColumnName("Place_ID");

                entity.Property(e => e.CompanyId).HasColumnName("company_ID");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Place_Name");
            });

            modelBuilder.Entity<PayRollProvisionBonuse>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId, e.ProcessMonth, e.ProcessYear });

                entity.ToTable("PayRoll_ProvisionBonuses");

                entity.Property(e => e.CompanyId).HasColumnName("Company_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_ID");

                entity.Property(e => e.ProcessMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Process_Month");

                entity.Property(e => e.ProcessYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Process_Year");

                entity.Property(e => e.ProcessAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Process_Amount");
            });

            modelBuilder.Entity<PayRollProvisionCt>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId, e.ProcessMonth, e.ProcessYear });

                entity.ToTable("PayRoll_ProvisionCTS");

                entity.Property(e => e.CompanyId).HasColumnName("Company_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_ID");

                entity.Property(e => e.ProcessMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Process_Month");

                entity.Property(e => e.ProcessYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Process_Year");

                entity.Property(e => e.ProcessAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Process_Amount");
            });

            modelBuilder.Entity<PayRollProvisionHoliday>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.EmployeeId, e.ProcessMonth, e.ProcessYear });

                entity.ToTable("PayRoll_ProvisionHoliday");

                entity.Property(e => e.CompanyId).HasColumnName("Company_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_ID");

                entity.Property(e => e.ProcessMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Process_Month");

                entity.Property(e => e.ProcessYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Process_Year");

                entity.Property(e => e.ProcessAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Process_Amount");
            });

            modelBuilder.Entity<PayRollRol>(entity =>
            {
                entity.HasKey(e => e.RolId);

                entity.ToTable("PayRoll_Rols");

                entity.Property(e => e.RolId).HasColumnName("Rol_Id");

                entity.Property(e => e.CompanyId).HasColumnName("company_ID");

                entity.Property(e => e.RolCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Rol_Code");

                entity.Property(e => e.RolDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Rol_Descripcion");

                entity.Property(e => e.RolStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Rol_Status");
            });

            modelBuilder.Entity<Tabla>(entity =>
            {
                entity.HasKey(e => new { e.T1, e.T2, e.T3 });

                entity.ToTable("tabla");

                entity.Property(e => e.T1)
                    .HasMaxLength(10)
                    .HasColumnName("t1")
                    .IsFixedLength(true);

                entity.Property(e => e.T2)
                    .HasMaxLength(10)
                    .HasColumnName("t2")
                    .IsFixedLength(true);

                entity.Property(e => e.T3)
                    .HasMaxLength(10)
                    .HasColumnName("t3")
                    .IsFixedLength(true);

                entity.Property(e => e.T4)
                    .HasMaxLength(10)
                    .HasColumnName("t4")
                    .IsFixedLength(true);
            });
            
        }

    }
}
