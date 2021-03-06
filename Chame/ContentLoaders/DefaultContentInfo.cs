namespace Chame.ContentLoaders
{
    public class DefaultContentInfo : IContentInfo
    {
        public DefaultContentInfo(string mimeType, string extension, bool allowBundling)
        {
            MimeType = mimeType;
            Extension = extension;
            AllowBundling = allowBundling;
        }

        /// <summary>
        /// MIME Type
        /// </summary>
        public string MimeType { get; }

        /// <summary>
        /// File extension for the MIME type
        /// </summary>
        public string Extension { get; }

        /// <summary>
        /// Allow bundling for this content?
        /// 
        /// Example:
        /// JavaScript and CSS files can be bundled - you known ..but you cannot bundle multiple JPGs.
        /// </summary>
        public bool AllowBundling { get; }
    }
}