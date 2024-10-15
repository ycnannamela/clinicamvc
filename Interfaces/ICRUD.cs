﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICRUD<T>
    {
        bool Create(T entidad);
        T? Read(object Id);
        List<T> ReadAll();
        bool Update(T entidad);
        bool Delete(T entidad);
    }
}
