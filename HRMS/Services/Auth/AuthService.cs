﻿using HRMS.Interfaces;
using HRMS.Model;
using HRMS.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace HRMS.Services
{
    public class AuthService : IAuthService
    {
        private readonly HRMS_Context Context;
        private readonly IConfiguration Configuration;

        public AuthService(HRMS_Context context, IConfiguration configuration)
        {
            Context = context;
            Configuration = configuration;
        }

        public string Login(Login login)
        {
            var user = Context
                .Employees
                .FirstOrDefault(x =>
                    x.Email == login.Email);

            if (user is null) return "Wrong credentials!";

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetValue<string>("JWT:Secret")));

            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: Configuration.GetValue<string>("JWT:Issuer"),
                audience: Configuration.GetValue<string>("JWT:Audience"),
                claims: new List<Claim>(),
                expires: DateTime.Now.AddHours(1),
                signingCredentials: signingCredentials
            );

            var tokenJson = new JwtSecurityTokenHandler()
                .WriteToken(token);

            return tokenJson;
        }
    }
}