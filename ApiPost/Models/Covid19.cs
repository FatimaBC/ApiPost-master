using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPost.Models
{
    [Table("Covid19")]
    public class Covid19
    {
        [Key]
        [Column(Order = 0)]
        public int? TrialID { get; set; }
        public string? SearchText { get; set; }
        public String? StudyType { get; set; }
        public String? Condition { get; set; }
        public String? InclusionGender { get; set; }
        public int? TargetSize { get; set; }
        public String? RecruitmentStatus { get; set; }
        public int? InclusionAgemin { get; set; }
        public int? InclusionAgemax { get; set; }
        public String? PublicTitle { get; set; }
        public String? ScientificTitle { get; set; }
        public String? PrimaryOutcome { get; set; }
        public String? ContactAffiliation { get; set; }
        public String? InclusionCriteria { get; set; }
    }
}
