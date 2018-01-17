namespace IAGrim.Database
{
    /// <summary>
    /// Represents a deleted player item which has an online-presence.
    /// Used to delete items from the online backup.
    /// </summary>
    public class DeletedPlayerItem {
        public virtual long OID { get; set; }

        public override string ToString() {
            return OID.ToString();
        }
    }
}
