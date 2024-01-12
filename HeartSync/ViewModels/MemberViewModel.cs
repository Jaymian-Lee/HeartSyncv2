using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeartSync.Models;



namespace HeartSync.ViewModels
{
    public class MemberViewModel
    {
        public List<Member>? Members { get; set; }
        public MemberViewModel()
        {
            
        }
        private void Refresh()
        {
            Members = App.MemberRepo.GetEntities();
        }
    }
}
