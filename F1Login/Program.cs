using Abstraction.IRepository;
using Abstraction.IService;
using BusinessLogic.Services;
using F1Login.F2AdminChildForms;
using F1Login.F3UserChildForms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Models;
using Repository.Repository;

namespace F1Login
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1(new LoginService(new LoginSqlRepository()), new CustomerService(new CustomerRepository()),
                //new FavorService(new FavorRepository()), new RequestService(new RequestRepository())));


            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }


        public static IServiceProvider ServiceProvider { get; private set; }


        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {

                //REPOSITORIES
                services.AddSingleton<ICustomerRepository, CustomerRepository>();
                services.AddSingleton<IFavorRepository, FavorRepository>();
                services.AddSingleton<ILoginRepository, LoginSqlRepository>();
                services.AddSingleton<IRequestRepository, RequestRepository>();
                services.AddSingleton<IFavorLineRepository, FavorLineRepositoy>();
                services.AddSingleton<IAdminRepository, AdminRepository>();

                //BUISNESS LOGICS
                services.AddSingleton<ICustomerService, CustomerService>();
                services.AddSingleton<IFavorService, FavorService>();
                services.AddSingleton<ILoginService, LoginService>();
                services.AddSingleton<IRequestService, RequestService>();
                services.AddSingleton<IFavorLineService, FavorLineService>();
                services.AddSingleton<IAdminService, AdminService>();

                //FORM LOGIN
                services.AddTransient<Form1>();
                services.AddTransient<Form4CreateAccount>();

                //ADMIN FORMS AND CHILD FORMS
                services.AddTransient<F2Admin>();
                services.AddTransient<CustomerFormForAdmins>();
                services.AddTransient<RequestFormForAdmins>();
                services.AddTransient<ServicesEditionByAdminForm>();
                services.AddTransient<ShowFavorLinesFormForAdmin>();
                //DIRECTOR
                services.AddTransient<AdminForm>();
                //INSPECTOR
                services.AddTransient<InspectorFormForAdmin>();
                services.AddTransient<InspectorShowFavorLinesForm>();


                //USER FORMS AND CHILD FORMS
                services.AddTransient<F3User>();
                services.AddTransient<CartForm>();
                services.AddTransient<ContactForm>();
                services.AddTransient<CustomerForm>();
                services.AddTransient<ServicesForm>();


            });
        }
    }
}