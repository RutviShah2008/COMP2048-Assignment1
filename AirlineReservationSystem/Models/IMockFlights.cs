﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models
{
    public interface IMockFlights
    {
        IQueryable<Flight> Flights { get; }
        IQueryable<Jet> Jets { get; }
        Flight Save(Flight flight);
        void Delete(Flight flight);
        void Dispose();
    }
}
