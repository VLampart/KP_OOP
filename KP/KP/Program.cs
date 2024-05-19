namespace KP
{
    internal static class Program
    {
        public static AuthenticationForm authenticationForm;
        public static CatalogForm CatalogForm;
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            authenticationForm = new AuthenticationForm();
            Application.Run(authenticationForm);
        }
    }
}