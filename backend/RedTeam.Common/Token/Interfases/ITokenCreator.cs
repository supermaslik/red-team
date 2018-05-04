﻿using Microsoft.IdentityModel.Tokens;
using RedTeam.SurveyMaster.Repositories.Models;

namespace RedTeam.Common.Token.Interfases
{
    public interface ITokenCreator
    {
        SecurityToken CreateSecurityToken(string userName, Role userRole);

        string SerializeToken(SecurityToken token);
    }
}
