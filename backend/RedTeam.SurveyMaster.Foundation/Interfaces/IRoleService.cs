﻿using System.Threading.Tasks;
using RedTeam.SurveyMaster.Repositories.Models;

namespace RedTeam.SurveyMaster.Foundation.Interfaces
{
    public interface IRoleService
    {
        Task<Role> GetByIdAsync(int id);
    }
}
