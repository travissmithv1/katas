using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace HorseKata.Test
{
    public class HorseTests
    {
        [Fact]
        public void FilterSortPaginate()
        {
            var headers = SampleHorseData.GetSampleHeaders();
            var tableData = SampleHorseData.GetSampleTableData();
            var filters = SampleHorseData.GetSampleFilters();
            var sortMetadata = SampleHorseData.GetSampleSortMetadata();
            var paginationMetadata = SampleHorseData.GetSamplePaginationMetadata();
            
            var table = Horse.FilterSortPaginateTable(headers, tableData, filters, sortMetadata, paginationMetadata);

            table.Headers.Should().BeEquivalentTo(headers);
            table.TotalRows.Should().Be(2);
            table.TableData.Should().BeEquivalentTo(new List<List<string>>
            {
                new List<string> {"Thoroughbred", "Bay", "1.6", "3", "true"},
                new List<string> {"Thoroughbred", "Grey", "1.55", "3", "true"},
            });
        }
    }
}