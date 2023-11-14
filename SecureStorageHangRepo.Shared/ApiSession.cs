using Microsoft.Maui.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SecureStorageHangedRepo.Shared
{
    public class ApiSession
    {
        //Example property to access
        public string? SessionInfo { get; set; } = "Some arbitrary session data";

        //Restore session from disk (if available)
        public async Task RestoreFromDisk()
        {
            var sessionData = await SecureStorage.GetAsync("sessionData");
            if (sessionData == null)
                return;

            SessionInfo = sessionData;
        }

        public async Task StoreOnDisk()
        {
            await SecureStorage.SetAsync("sessionData", SessionInfo);
        }
    }
}
