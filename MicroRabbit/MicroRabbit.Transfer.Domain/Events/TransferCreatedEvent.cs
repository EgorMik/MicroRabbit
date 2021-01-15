﻿using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }

        public int Amount { get; set; }
        public TransferCreatedEvent(int from, int to, int amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}