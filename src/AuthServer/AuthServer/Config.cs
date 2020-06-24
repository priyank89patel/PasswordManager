﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace AuthServer
{
    public class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("resourceapi", "Resource API")
                {
                    Scopes = {"api.read"}
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {
                new Client
                {
                    RequireConsent = false,
                    ClientId = "password_manager_spa",
                    ClientName = "Password Manager SPA",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce=true,
                    RequireClientSecret=false,
                    AllowedScopes = { "openid", "profile", "email", "api.read" },
                    RedirectUris ={"http://localhost:4200/auth-callback","http://localhost:4200/assets/silent_refresh.html"},
                    PostLogoutRedirectUris ={"http://localhost:4200"},
                    AllowedCorsOrigins = {"http://localhost:4200"},
                    AccessTokenLifetime = 3600
                }
            };
        }
    }
}
