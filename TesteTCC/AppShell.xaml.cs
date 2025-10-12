namespace TesteTCC
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("cadastrar", typeof(Cadastrar));
            Routing.RegisterRoute("login", typeof(Login));
        }
    }
}
