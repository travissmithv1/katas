using System;
using System.Collections.Generic;

namespace HorseKata
{
    /**
     * This method is called by the front end when it wants to display a page of horse data.
     */
    public class Horse
    {
        public static PaginatedTable FilterSortPaginateTable(List<string> headers, List<List<string>> tableData,
            List<FilterMetadata> filters, SortMetadata sortMetadata, PaginationMetadata paginationMetadata)
        {
            // TODO: filter horse table using filters

            // TODO: sort horse table using sortMetadata

            // TODO: paginate horse table using paginationMetadata
            throw new NotImplementedException();
        }
    }
}