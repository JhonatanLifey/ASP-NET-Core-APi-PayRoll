using System;

namespace PayRoll.Domain.Entities
{
    public class Employee
    {

        public int company_ID { get; set; }
        public int afp_ID { get; set; }
        public int employee_ID { get; set; }
        public int Rol_Id { get; set; }
        public int KindPayRoll { get; set; }
        public int Place_ID { get; set; }


        public string employee_CODE { get; set; }
        public string employee_Active { get; set; }
        public string employee_Name { get; set; }
        public string employee_Middle { get; set; }
        public string employee_Surname { get; set; }


        public DateTime employee_DateStart { get; set; }
        public DateTime employee_DateEnd { get; set; }
        public DateTime employee_BirthDate { get; set; }


        public string employee_Address { get; set; }
        public string employee_Suburd { get; set; }
        public string employee_State { get; set; }
        public string employee_CodePost { get; set; }

        
        public decimal employee_Salary { get; set; }
        public string employee_KindAFPSNP { get; set; }
        public string employee_numberAFP { get; set; }
        public string employee_IndAsigFamiliar { get; set; }


    }
}
