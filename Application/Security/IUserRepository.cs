﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Security
{
  public interface IUserRepository
  {
    User GetExistingUser(string userName);
  }
}