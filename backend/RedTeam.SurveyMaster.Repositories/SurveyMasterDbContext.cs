﻿using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using RedTeam.Repositories.Interfaces;
using RedTeam.SurveyMaster.Repositories.Models;

namespace RedTeam.SurveyMaster.Repositories
{
    public class SurveyMasterDbContext : IdentityDbContext<User>, IDbContext
    {
        private const string ConnectionStringName = "SurveyRepository";


        public DbSet<Survey> Surveys { get; set; }


        public SurveyMasterDbContext()
            : base(ConnectionStringName)
        {
            Configuration.LazyLoadingEnabled = false;
        }
    }
}