﻿using System;
using Chame.Middlewares;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// IApplicationBuilder extension methods
    /// </summary>
    public static class IApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseThemes(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }
          
            app.UseMiddleware<ContentLoaderMiddleware>();

            return app;
        }
    }
}
