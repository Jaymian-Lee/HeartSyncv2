using HeartSync.Abstractions;
using HeartSync.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartSync.Models
{
    internal class Member: TableData
    {

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public List<Interest> interests { get; set; }
        public List<MusicTaste> musicTastes { get; set; }

    }
}
