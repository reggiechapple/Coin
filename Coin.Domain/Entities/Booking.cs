using System.Collections.Generic;
using Coin.Domain.Identity;

namespace Coin.Domain.Entities
{
    public class Booking : Entity
    {
        public string Name { get; set; }

        public string ShortDesc { get; set; }

        public string LongDesc { get; set; }

        public decimal FlatPrice { get; set; }

        public decimal Duration { get; set; }

        public bool Avaliable { get; set; }

        public bool PayByHour { get; set; }

        public decimal HourRate { get; set; }

        public long SpecialistId { get; set; }
        public Specialist Specialist { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}