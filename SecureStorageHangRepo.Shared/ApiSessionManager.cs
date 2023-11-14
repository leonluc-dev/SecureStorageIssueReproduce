namespace SecureStorageHangedRepo.Shared
{
    public static class ApiSessionManager
    {
        public static ApiSession CurrentSession
        {
            get
            {
                return currentSession.Value;
            }
        }

        private static Lazy<ApiSession> currentSession = new Lazy<ApiSession>(() =>
        {
            var currentSession = new ApiSession();
            currentSession.RestoreFromDisk().GetAwaiter().GetResult();
            return currentSession;
        });
    }
}
