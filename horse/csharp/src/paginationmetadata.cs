namespace HorseKata
{
    /**
     * The front end provides this data about the requested pagination
     */
    public class PaginationMetadata
    {
        /**
         * the current page of data to be shown
         */
        public int PageNumber { get; }
        
        /**
         * the number of rows to show in this page
         */
        public int PageSize { get; }

        public PaginationMetadata(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}