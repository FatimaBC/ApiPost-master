using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPost.Models
{
    [Table("Covid19")]
    public class Trials
    {
        
        
        public String? PublicTitle { get; set; } [Key]
        public String? Acronym { get; set; }
        public String? DateRegistration { get; set; }
        public String? Countries { get; set; }
        public String? RecruitmentStatus { get; set; }
       
        [ForeignKey("TrialID")]
        public int? TrialID { get; set; }
    }
}
