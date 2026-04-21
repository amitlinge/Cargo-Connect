using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.DTOs.Tracking
{
    public class GetTrackingDTO
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public DateTime Timestamp { get; set; }
    }
}

