namespace Lands.ViewModels
{
    class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }

        public LandsViewModel Lands
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instanace = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region PatronSingleton
        private static MainViewModel instanace;

        public static MainViewModel GetInstance()
        {
            if (instanace == null)
            {
                return new MainViewModel();
            }
            return instanace;
        }
        #endregion
    }
}
