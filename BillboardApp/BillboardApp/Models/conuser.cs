using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conuser
    {
        [Key]
        public int userId { get; set; }
        public string surname { get; set; }
        public string otherName { get; set; }
        public string recoveryphone { get; set; }
        public string recoveryemail { get; set; }
        public int profileId { get; set; }
        public int status { get; set; }
        public int companyId { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime? createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime? writedt { get; set; }

    }
}