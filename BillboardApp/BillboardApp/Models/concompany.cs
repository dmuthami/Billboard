using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class concompany
    {
        [Key]
        public int companyId { get; set; }
        [StringLength(100)]
        public string logo { get; set; }
        public DateTime regDate { get; set; }
        [StringLength(15)]
        public string companyNo { get; set; }
        public DateTime? startDate { get; set; }
        [StringLength(100)]
        public string companyName { get; set; }
        [StringLength(40)]
        public string companyInitials { get; set; }
        [StringLength(50)]
        public string taxpinNo { get; set; }
        [StringLength(3)]
        public string branches { get; set; }
        [StringLength(200)]
        public string memo { get; set; }
        public int age { get; set; }
        public int countryId { get; set; }
        public int industryId { get; set; }
        [StringLength(50)]
        public string physicalAddress { get; set; }
        [StringLength(50)]
        public string primaryMobileNo { get; set; }
        [StringLength(50)]
        public string otherMobileNo { get; set; }
        [StringLength(50)]
        public string primaryLandline { get; set; }
        [StringLength(50)]
        public string otherLandline { get; set; }
        [StringLength(50)]
        public string primaryEmail { get; set; }
        [StringLength(50)]
        public string otherEmail { get; set; }
        [StringLength(50)]
        public string boxAddress { get; set; }
        [StringLength(10)]
        public string boxAddressCode { get; set; }
        [StringLength(50)]
        public string boxAddressTown { get; set; }
        [StringLength(50)]
        public string websiteUrl { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime? createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime? writedt { get; set; }   
    }
}