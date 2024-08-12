using FluentAssertions;
using Xunit;

namespace VideoStore.Test
{
    public class VideoStoreTests
    {
        private readonly Customer _customer = new Customer("Fred");

        [Fact]
        public void SingleNewReleaseStatement()
        {
            _customer.AddRental (new Rental (new Movie ("The Cell", Movie.NEW_RELEASE), 3));

            _customer.Statement().Should().Be("Rental Record for Fred\n\tThe Cell\t9.0\nYou owed 9.0\nYou earned 2 frequent renter points\n");
        }

        [Fact]
        public void DualNewReleaseStatement()
        {
            _customer.AddRental (new Rental (new Movie ("The Cell", Movie.NEW_RELEASE), 3));
            _customer.AddRental (new Rental (new Movie ("The Tigger Movie", Movie.NEW_RELEASE), 3));
            _customer.Statement ().Should().Be("Rental Record for Fred\n\tThe Cell\t9.0\n\tThe Tigger Movie\t9.0\nYou owed 18.0\nYou earned 4 frequent renter points\n");
        }

        [Fact]
        public void SingleChildrensStatement()
        {
            _customer.AddRental (new Rental (new Movie ("The Tigger Movie", Movie.CHILDRENS), 3));
            _customer.Statement ().Should().Be("Rental Record for Fred\n\tThe Tigger Movie\t1.5\nYou owed 1.5\nYou earned 1 frequent renter points\n");
        }

        [Fact]
        public void DualChildrensStatement()
        {
            _customer.AddRental (new Rental (new Movie ("The Tigger Movie", Movie.CHILDRENS), 3));
            _customer.AddRental (new Rental (new Movie ("Zootopia", Movie.CHILDRENS), 4));
            _customer.Statement().Should().Be("Rental Record for Fred\n\tThe Tigger Movie\t1.5\n\tZootopia\t3.0\nYou owed 4.5\nYou earned 2 frequent renter points\n");
        }

        [Fact]
        public void MultipleRegularStatement()
        {
            _customer.AddRental (new Rental (new Movie ("Plan 9 from Outer Space", Movie.REGULAR), 1));
            _customer.AddRental (new Rental (new Movie ("8 1/2", Movie.REGULAR), 2));
            _customer.AddRental (new Rental (new Movie ("Eraserhead", Movie.REGULAR), 3));

            _customer.Statement().Should().Be("Rental Record for Fred\n\tPlan 9 from Outer Space\t2.0\n\t8 1/2\t2.0\n\tEraserhead\t3.5\nYou owed 7.5\nYou earned 3 frequent renter points\n");
        }
    }
}