﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(eLearningSystem.WebApi.Startup))]

namespace eLearningSystem.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}