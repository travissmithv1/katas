namespace HorseKata
{
    /**
     * the front end provides this data about the requested sort order
     */
    public class SortMetadata
    {
        public string ColumnHeader { get; }
        public string SortOrder { get; }

        public SortMetadata(string columnHeader, string sortOrder)
        {
            ColumnHeader = columnHeader;
            SortOrder = sortOrder;
        }
    }
}