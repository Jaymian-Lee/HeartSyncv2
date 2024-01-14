using HeartSync.Repositories;
using HeartSync.Models;

namespace HeartSync
{
    public partial class App : Application
    {
       // public static BaseRepository<Member>? MemberRepo { get; private set; }
        //public App(BaseRepository<Member> memberRepo)
        public App()
        {
            InitializeComponent();
           // MemberRepo = memberRepo;
            MainPage = new AppShell();
        }
    }
}
