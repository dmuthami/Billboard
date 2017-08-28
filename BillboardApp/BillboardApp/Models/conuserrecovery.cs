using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conuserrecovery
    {
        [Key]
        public int userRecoveryId { get; set; }
        public int userId { get; set; }
        public int userRecoveryTypeId { get; set; }
        [StringLength(50)]
        public string recoveryCode { get; set; }
        public DateTime? expiryDateTime { get; set; }
        public int isRecovered { get; set; }
        public DateTime dateTimeRecovered { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime writedt { get; set; }
        public int companyId { get; set; }

    }
}