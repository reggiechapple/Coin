using System;
using Coin.Domain.Identity;

namespace Coin.Domain.Entities
{
    public class Appointment : Entity
    {
        public DateTime AppointmentTime { get; set; }
        public bool TravellingOut { get; set; }
        public string Message { get; set; }
        public long BookingId { get; set; }
        public Booking Booking { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public long DestinationId { get; set; }
        public Address Destination { get; set; }
    }
}