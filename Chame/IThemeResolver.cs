﻿namespace Chame
{
    public interface IThemeResolver
    {
        /// <summary>
        /// Resolves a theme that should be used when loading content files.
        /// </summary>
        /// <param name="context">context</param>
        /// <returns>theme name</returns>
        string ResolveTheme(ContentFileThemeResolveContext context);

        /// <summary>
        /// Resolves a theme that should be used when loading Razor views.
        /// </summary>
        /// <param name="context">context</param>
        /// <returns>theme name</returns>
        string ResolveTheme(RazorThemeResolveContext context);
    }
}
