﻿using System;
using Chame.Caching;
using Chame.ContentLoaders.JsAndCssFiles.Models;

namespace Chame.ContentLoaders.JsAndCssFiles
{
    public class JsAndCssFileLoaderOptions
    {
        public JsAndCssFileLoaderOptions()
        {
            UseContentSchemaFile = true;
            ContentSchemaFile = @"\JsAndCssFileLoader.json";
            CachingMode = CachingModes.EnabledButDisabledOnDev;
            CacheAbsoluteExpirationRelativeToNow = new TimeSpan(0, 0, 1, 0);
        }

        /// <summary>
        /// A path to the content schema file. The default value is '\JsAndCssFileLoader.json' under wwwroot.
        /// </summary>
        public string ContentSchemaFile { get; set; }

        /// <summary>
        /// Should we use the content schema file? The default value is true.
        /// </summary>
        public bool UseContentSchemaFile { get; set; }

        /// <summary>
        /// A function for loading <see cref="IContentModel"/> objects. This will be invoked if <see cref="UseContentSchemaFile"/> is false.
        /// </summary>
        public Func<ContentLoadingContext, ContentSchema> ContentSchemaResolver { get; set; }

        /// <summary>
        /// Caching mode, the default value is <see cref="CachingModes.EnabledButDisabledOnDev"/>.
        /// </summary>
        public CachingModes CachingMode { get; set; }

        /// <summary>
        /// An absolute expiration time for caching, relative to now. The default value is 1 minute.
        /// </summary>
        public TimeSpan CacheAbsoluteExpirationRelativeToNow { get; set; }
    }
}