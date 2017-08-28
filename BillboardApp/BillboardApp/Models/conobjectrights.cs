using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conobjectrights
    {
        [Key]
        public int objectRightsId { get; set; }
        public int profileId { get; set; }
        public int objectId { get; set; }
        public int canview { get; set; }
        public int canadd { get; set; }
        public int canedit { get; set; }
        public int candel { get; set; }
        public int canauthorize { get; set; }
        public int canapprove { get; set; }
        public int canexport { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime? writedt { get; set; }
    }
}