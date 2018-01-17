using System;
using System.IO;

namespace IAGrim.Utilities
{
    public class TempFile : IDisposable {
        public readonly string filename;

        public TempFile() {
            this.filename = Path.GetTempFileName();
        }

        public void Dispose() {
            try {
                File.Delete(filename);
            }
            catch (IOException) {
                /* Oh well.. */
            }
        }
    }
}
