namespace Security.Desktop
{
    public sealed class SessionInfo
    {
        private readonly static SessionInfo _instancia = new SessionInfo();

        private SessionInfo()
        {
        }

        public static SessionInfo Instance
        {
            get
            {
                return _instancia;
            }
        }

        public int? UserID { get; private set; }

        public string UserName { get; private set; }

        public int? UserRolID { get; private set; }

        public bool EstaLogeado { get; private set; }

        public void SetInfo(int userID, string username, int userRolID)
        {
            this.UserID = userID;
            this.UserName = username;
            this.UserRolID = userRolID;
            this.EstaLogeado = true;
        }

        public void LimpiarSession()
        {
            this.UserID = null;
            this.UserName = string.Empty;
            this.UserRolID = null;
            this.EstaLogeado = false;
        }
    }
}
