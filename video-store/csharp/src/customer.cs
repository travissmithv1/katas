using System.Collections;

namespace VideoStore
{
    public class Customer
    {
        public Customer (string name) {
            Name = name;
        }

        public void AddRental (Rental rental) {
            _rentals.Add(rental);
        }

        public string Statement () {
            double 				totalAmount 			= 0;
            int					frequentRenterPoints 	= 0;
            IEnumerator rentals 				= _rentals.GetEnumerator();
            string 				result 					= "Rental Record for " + Name + "\n";

            while (rentals.MoveNext()) {
                double 		thisAmount = 0;
                Rental 		each = (Rental)rentals.Current;

                // determines the amount for each line
                switch (each.Movie.PriceCode) {
                    case Movie.REGULAR:
                        thisAmount += 2;
                        if (each.DaysRented > 2)
                            thisAmount += (each.DaysRented - 2) * 1.5;
                        break;
                    case Movie.NEW_RELEASE:
                        thisAmount += each.DaysRented * 3;
                        break;
                    case Movie.CHILDRENS:
                        thisAmount += 1.5;
                        if (each.DaysRented > 3)
                            thisAmount += (each.DaysRented - 3) * 1.5;
                        break;
                }

                frequentRenterPoints++;

                if (each.Movie.PriceCode == Movie.NEW_RELEASE
                    && each.DaysRented > 1)
                    frequentRenterPoints++;

                result += "\t" + each.Movie.Title + "\t"
                          + thisAmount.ToString("0.0") + "\n";
                totalAmount += thisAmount;

            }

            result += "You owed " + totalAmount.ToString("0.0") + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";


            return result;
        }


        public string Name { get; }
        private readonly ArrayList _rentals = new ArrayList();
    }
}