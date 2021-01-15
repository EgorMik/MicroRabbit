using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Presentation.Models
{
    public class TransferViewModel
    {
        public string TransferNotes { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public int TransferAmount { get; set; }
    }
}
