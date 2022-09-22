namespace Security.Desktop
{
    public static class SessionInfo
    {
        public static int UserID { get; private set; }

        public static string UserName { get; private set; }

        public static int UserRolID { get; private set; }

        public static bool EstaLogeado { get; private set; }

        public static void SetInfo(int userID, string username, int userRolID)
        {
            UserID = userID;
            UserName = username;
            UserRolID = userRolID;
            EstaLogeado = true;
        }
    }
}
