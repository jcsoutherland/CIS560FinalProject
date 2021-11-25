﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    public class Tickets : Table
    {
        public string type = "Tickets";
        public int MovieId { get; set; }
        public int TicketPrice { get; set; }
        public int GlobalTicketSales { get; set; }
        public bool IsRemoved { get; set; }

        public string FullInfo
        {
            get
            {
                return $"Movie Id: {MovieId} | Ticket Price: {TicketPrice} | GlobalTicketSales: {GlobalTicketSales} | Box Office: ${(TicketPrice*GlobalTicketSales)} {IsRemoved}";
            }
        }

    }
}
