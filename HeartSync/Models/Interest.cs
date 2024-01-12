using HeartSync.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartSync.Models
{
    internal class Interest: TableData
    {

        public int Id { get; set; }
        public string InterestKind { get; set; }

    }
}
