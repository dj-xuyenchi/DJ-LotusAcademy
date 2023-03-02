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
        public string? studentLAName { get; set; }
        public string? email { get; set; }
        public string? studentLASdt { get; set; }
        public string? DistrictCode { get; set; }
        public string? DistrictName { get; set; }
        public string? ProvinceCode { get; set; }
        public string? ProvinceName { get; set; }
        public string? addressDetail { get; set; }
        public DateTime? birthDay { get; set; }
        public int? GenderId { get; set; }
        public string? gender { get; set; }
        public int? StudentStatusId { get; set; }
        public string? status { get; set; }
        public int? StudentDatalogId { get; set; }
        public string? job { get; set; }
        public string? zaloUrl { get; set; }
        public string? facebookUrl { get; set; }
    }
}
