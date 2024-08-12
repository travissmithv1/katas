using System.Collections.Generic;

namespace HorseKata
{
    /**
     * instances of this class can be returned to the front end for display
     */
    public class PaginatedTable
    {
        /**
         * the headers for the table
         */
        public List<string> Headers { get; }
        
        /**
         * The data to show in the current page of the table
         */
        public int TotalRows { get; }
        
        /**
         * the total number of rows, including those rows not shown on the current page
         */
        public List<List<string>> TableData { get; }

        public PaginatedTable(List<string> headers, List<List<string>> tableData, int totalRows)
        {
            Headers = headers;
            TotalRows = totalRows;
            TableData = tableData;
        }
    }
}