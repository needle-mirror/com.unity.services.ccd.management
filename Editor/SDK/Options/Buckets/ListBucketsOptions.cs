namespace Unity.Services.Ccd.Management
{
    /// <summary>
    /// Parameters for listing buckets.
    /// </summary>
    public class ListBucketsOptions
    {
        /// <summary>
        /// Name of buckets to list.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Description of buckets to list.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// List buckets sorted by.
        /// Valid values are name and created.
        /// </summary>
        public string SortBy { get; set; } = string.Empty;
        /// <summary>
        /// List buckets in sorted order.
        /// Valid values are asc and desc.
        /// </summary>
        public string SortOrder { get; set; } = string.Empty;
    }
}
