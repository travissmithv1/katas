namespace HorseKata
{
    /**
     * The front end provides a list of these specifying the requested filters
     */
    public class FilterMetadata
    {
        public string ColumnHeader { get; }
        public string Value { get; }

        public FilterMetadata(string columnHeader, string value)
        {
            ColumnHeader = columnHeader;
            Value = value;
        }
    }
}