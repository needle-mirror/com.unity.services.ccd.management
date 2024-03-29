using System;
namespace Unity.Services.Ccd.Management
{
    /// <summary>
    /// Status information for the content of an entry.
    /// </summary>
    public class ContentStatus
    {
        /// <summary>
        /// Upload hash of the content.
        /// </summary>
        public string UploadHash { get; }
        /// <summary>
        /// Size of the content in bytes.
        /// </summary>
        public long UploadLength { get; }
        /// <summary>
        /// Upload offset of the content in bytes.
        /// </summary>
        public long UploadOffset { get; }

        ///<summary>
        /// Constructor for ContentStatus
        ///</summary>
        ///<param name="uploadHash">ContentHash</param>
        ///<param name="uploadLength">ContentLength</param>
        ///<param name="uploadOffset">UploadOffset</param>
        public ContentStatus(string uploadHash, long uploadLength, long uploadOffset)
        {
            UploadHash = uploadHash;
            UploadLength = uploadLength;
            UploadOffset = uploadOffset;
        }
    }
}
