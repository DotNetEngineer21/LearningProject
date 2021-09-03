using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreOSR.Employees.Dto
{
    public class EmployeeListDto : EntityDto<long>
    {
        public string FullName { get; set; }

        public string Position { get; set; }

        public String TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Region { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
        public String HomePhone { get; set; }
        public String Extension { get; set; }
        public String Photo { get; set; }
        public String Notes { get; set; }
        public int ReportsTo { get; set; }
    }
}
