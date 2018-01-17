using IAGrim.Database.Interfaces;

namespace IAGrim.Database.Synchronizer
{
    class BuddySubscriptionRepo : BasicSynchronizer<BuddySubscription>, IBuddySubscriptionDao {
        private readonly IBuddySubscriptionDao repo;
        public BuddySubscriptionRepo(ThreadExecuter threadExecuter, ISessionCreator sessionCreator) : base(threadExecuter, sessionCreator) {
            repo = new BuddySubscriptionDaoImpl(sessionCreator);
            this.BaseRepo = repo;
        }

    }
}
