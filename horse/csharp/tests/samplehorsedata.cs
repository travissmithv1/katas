using System.Collections.Generic;

namespace HorseKata.Test
{
    public class SampleHorseData
    {
        /**
         * Sample Horse table headers which you could adapt for your tests.
         */
        public static List<string> GetSampleHeaders()
        {
            return new List<string>
            {
                "Breed", "Colour", "Height", "Age", "Shoes"
            };
        }

        /**
         * Sample Horse data which you could adapt for your tests. Horses
         * may have more or less parameters than this and there may be more or less rows
         * in the table.
         */
        public static List<List<string>> GetSampleTableData()
        {
            return new List<List<string>>
            {
                new List<string> {"Thoroughbred", "Bay", "1.6", "3", "true"},
                new List<string> {"Thoroughbred", "Grey", "1.55", "3", "true"},
                new List<string> {"Arabian horse", "Bay", "1.51", "5", "true"},
                new List<string> {"Shetland Pony", "Black", "1.01", "2", "false"},
                new List<string> {"Shire horse", "Black", "1.71", "4", "true"},
            };
        }

        /**
         * Sample filter metadata that filters on two fields
         * Breed must equal 'Thoroughbred' and age must equal 3
         */
        public static List<FilterMetadata> GetSampleFilters()
        {
            return new List<FilterMetadata>
            {
                new FilterMetadata("Breed", "Thoroughbred"),
                new FilterMetadata("Age", "3")
            };
        }

        /**
         * Sample sort metadata. You only ever sort on one field.
         * In this example you should sort by horse height ascending
         */
        public static SortMetadata GetSampleSortMetadata()
        {
            return new SortMetadata("Height", "Ascending");
        }

        /**
         * Sample pagination metadata. In this example, each page of data should have 3 rows and
         * the first record that should be shown on the page is the one at index 1.
         */
        public static PaginationMetadata GetSamplePaginationMetadata()
        {
            return new PaginationMetadata(1, 3);
        }
    }
}