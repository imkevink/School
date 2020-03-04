using System;

namespace Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public DateTime ReservationDateTime { get; set; }

        public Reservation(int id, Customer customer, Book book)
        {
            Id = id;
            Customer = customer;
            Book = book;
            ReservationDateTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Book} reserved by {Customer} at {ReservationDateTime}";
        }
    }
}
