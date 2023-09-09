﻿using DataAccessLayer.Interfaces;
using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class TokenRepo : Repo, IRepo<Token, int, Token>
    {
        public Token Add(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }

        public Token Get(int id)
        {
            throw new NotImplementedException();
        }

        public Token Update(Token obj)
        {
            throw new NotImplementedException();
        }
    }
}
