using ApiPost.Data;
using ApiPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApiPost.Repositories
{
    public class RepositoryCovid19
    {
        Covid19Context context;
        public RepositoryCovid19(Covid19Context context)
        {
            this.context = context;
        }


        public List<Trials> GetTrials()
        {

            var trial = (from d in context.trials

                         select new Trials
                         {
                             TrialID = d.TrialID,
                             PublicTitle = d.PublicTitle,
                             Acronym = d.Acronym,
                             DateRegistration = d.DateRegistration,
                             RecruitmentStatus = d.RecruitmentStatus,
                             Countries = d.Countries,
                         });

            var trials = trial.ToList();
            return trials;
        }
        public List<Covid19> GetTrialsRequest(String searchText, int limit, int page, string studyType, string condition, string gender, int targetSize, string recruitmentStatus, int inclusionAgemax, int inclusionAgemin)
        {

            var trial = (from b in context.covid19

                         select new Covid19
                         {
                             StudyType = studyType,
                             SearchText = searchText,
                             Condition = condition,
                             InclusionGender = gender,
                             TargetSize = targetSize,
                             RecruitmentStatus = recruitmentStatus,
                             InclusionAgemin = inclusionAgemin,
                             InclusionAgemax = inclusionAgemax,
                             PublicTitle = b.PublicTitle,
                             ScientificTitle = b.ScientificTitle,
                             PrimaryOutcome = b.PrimaryOutcome,
                             ContactAffiliation = b.ContactAffiliation,
                             InclusionCriteria = b.InclusionCriteria
                         });
            var trials = trial;
            return trials?.ToList();
        }
    }
}