using SecurityAPICommons.Commons;
using Sftp.GeneXusSftp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Sftp.GeneXusCommons
{
    [SecuritySafeCritical]
    public abstract class ISftpClientObject : SecurityAPIObject
    {
        public abstract bool Connect(SftpOptions options);
        public abstract bool Put(string localPath, string remoteDir);
#pragma warning disable CA1716 // Identifiers should not match keywords
		public abstract bool Get(string remoteFilePath, string localDir);
#pragma warning restore CA1716 // Identifiers should not match keywords
		public abstract void Disconnect();

        public abstract string GetWorkingDirectory();
    }
}
