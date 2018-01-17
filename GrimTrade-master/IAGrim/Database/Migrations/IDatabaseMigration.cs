namespace IAGrim.Database.Migrations
{
    interface IDatabaseMigration {
        void Migrate(ISessionCreator sessionCreator);
    }
}
