﻿using EFCoreProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //eager loading
            //await new EagerLoading().load();
            //await new ExplicitLoading().load();
            new LazyLoading().load();
        }
    }
}
