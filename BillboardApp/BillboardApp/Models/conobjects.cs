using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conobjects
    {
        [Key]
        public int objectId { get; set; }
        [StringLength(50)]
        public string objectCode { get; set; }
        public int level { get; set; }
        public int parentObjectId { get; set; }
        public int isreport { get; set; }
        public int isgraph { get; set; }
        public int isbuttonselect { get; set; }
        public int isbuttonselectwithmenu { get; set; }
        public int hasnotification { get; set; }
        public int hasreportsubmenu { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime? createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime writedt { get; set; }
        [StringLength(50)]
        public string objectName { get; set; }
    }
}