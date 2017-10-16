﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Chame.Models
{
    public class ContentFileThemes
    {
        /// <summary>
        /// Common CSS files for all themes
        /// </summary>
        [JsonProperty("cssFiles")]
        public virtual List<ContentFile> CssFiles { get; set; } = new List<ContentFile>();

        /// <summary>
        /// Common JavaScript files for all themes
        /// </summary>
        [JsonProperty("jsFiles")]
        public virtual List<ContentFile> JsFiles { get; set; } = new List<ContentFile>();

        /// <summary>
        /// All themes
        /// </summary>
        [JsonProperty("themes")]
        public virtual List<ContentFileTheme> Themes { get; set; } = new List<ContentFileTheme>();
    }
}
