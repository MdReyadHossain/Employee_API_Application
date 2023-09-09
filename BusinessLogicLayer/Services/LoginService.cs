using AutoMapper;
using BusinessLogicLayer.DTOs;
using DataAccessLayer;
using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class LoginService
    {
        public static TokenDTO Login(string id, string pass)
        {
            var user = DataAccessFactory.AuthData().Authenticate(id, pass);
            if (user != null)
            {
                var token = new Token
                {
                    TokenKey = Guid.NewGuid().ToString(),
                    EmployeeId = user.EmployeeId,
                    CreatedAt = DateTime.Now,
                    ExpiredAt = null
                };

                var tk = DataAccessFactory.TokensData().Add(token);
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Token, TokenDTO>();
                });

                var mapper = new Mapper(config);
                var data = mapper.Map<TokenDTO>(tk);
                return data;
            }
            return null;
        }
        public static bool IsTokenValid(string token)
        {
            var tk = (from t in DataAccessFactory.TokensData().Get()
                      where t.TokenKey.Equals(token)
                      && t.ExpiredAt == null
                      select t).SingleOrDefault();
            if (tk != null)
            {
                return true;
            }
            return false;
        }
    }
}
