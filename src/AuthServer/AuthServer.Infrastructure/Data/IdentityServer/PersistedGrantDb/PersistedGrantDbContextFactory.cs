﻿using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AuthServer.Infrastructure.Data.IdentityServer.PersistedGrantDb
{
    public class PersistedGrantDbContextFactory : IDesignTimeDbContextFactory<PersistedGrantDbContext>
    {
        public PersistedGrantDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersistedGrantDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PasswordManager_AuthServer;Trusted_Connection=True;MultipleActiveResultSets=true",
                sql => sql.MigrationsAssembly(typeof(PersistedGrantDbContextFactory).GetTypeInfo().Assembly.GetName().Name));
            return new PersistedGrantDbContext(optionsBuilder.Options, new OperationalStoreOptions());
        }
    }
}
