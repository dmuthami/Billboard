using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class connotifications
    {
        [Key]
        public int notificationsId { get; set; }
        public int objectId { get; set; }
        [StringLength(50)]
        public string notifTableName { get; set; }
        [StringLength(50)]
        public string notifColumnName { get; set; }
        public string notifCriteria { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime? createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime? writedt { get; set; }
    }
}