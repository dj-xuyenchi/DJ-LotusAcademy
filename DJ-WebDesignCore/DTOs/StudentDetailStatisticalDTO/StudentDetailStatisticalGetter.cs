using DJ_WebDesignCore.Entites.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.StudentDetailStatisticalDTO
{
    public class StudentDetailStatisticalGetter
    {
        public string? StudentName { get; set; }
        public string? Email { get; set; }
        public string? StudentSdt { get; set; }
        public string? DistrictCode { get; set; }
        public string? DistrictName { get; set; }
        public string? ProvinceCode { get; set; }
        public string? ProvinceName { get; set; }
        public string? Address { get; set; }
        public DateTime? StudentBirthday { get; set; }
        public int? GenderId { get; set; }
        public string? GenderName { get; set; }
        public int? StudentStatusId { get; set; }
        public string? StudentStatusName { get; set; }
        public int? StudentDatalogId { get; set; }
        public string? StudentDatalogName { get; set; }
        public string? ZaloUrl { get; set; }
        public string? FacebookUrl { get; set; }
    }
}
