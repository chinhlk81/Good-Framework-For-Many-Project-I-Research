[assembly: WebActivator.PreApplicationStartMethod(typeof(MobiShop.WebUI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(MobiShop.WebUI.App_Start.NinjectWebCommon), "Stop")]

namespace MobiShop.WebUI.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    using MobiShop.Core.Model;
    using MobiShop.Core.Interface.Data;
    using MobiShop.Core.Interface.Service;

    using MobiShop.Data;
    using MobiShop.Data.Interface;

    using MobiShop.Service;
    using MobiShop.Service.Base;
    using MobiShop.Service.Admin;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            
            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            kernel.Bind<IDatabaseFactory>().To<DatabaseFactory>().InRequestScope();

            kernel.Bind<IRepository<Company>>().To<Repository<Company>>().InRequestScope();
            kernel.Bind<IRepository<Manufacture>>().To<Repository<Manufacture>>().InRequestScope();
            kernel.Bind<IRepository<OrderDetail>>().To<Repository<OrderDetail>>().InRequestScope();
            kernel.Bind<IRepository<Order>>().To<Repository<Order>>().InRequestScope();
            kernel.Bind<IRepository<OrderStatusChangedLog>>().To<Repository<OrderStatusChangedLog>>().InRequestScope();
            kernel.Bind<IRepository<OrderStatus>>().To<Repository<OrderStatus>>().InRequestScope();
            kernel.Bind<IRepository<ProductComment>>().To<Repository<ProductComment>>().InRequestScope();
            kernel.Bind<IRepository<Product>>().To<Repository<Product>>().InRequestScope();
            kernel.Bind<IRepository<Region>>().To<Repository<Region>>().InRequestScope();
            kernel.Bind<IRepository<UserProfile>>().To<Repository<UserProfile>>().InRequestScope();


            kernel.Bind<IAdminRepository<Company>>().To<AdminRepository<Company>>().InRequestScope();
            kernel.Bind<IAdminRepository<Manufacture>>().To<AdminRepository<Manufacture>>().InRequestScope();
            kernel.Bind<IAdminRepository<OrderDetail>>().To<AdminRepository<OrderDetail>>().InRequestScope();
            kernel.Bind<IAdminRepository<Order>>().To<AdminRepository<Order>>().InRequestScope();
            kernel.Bind<IAdminRepository<OrderStatusChangedLog>>().To<AdminRepository<OrderStatusChangedLog>>().InRequestScope();
            kernel.Bind<IAdminRepository<OrderStatus>>().To<AdminRepository<OrderStatus>>().InRequestScope();
            kernel.Bind<IAdminRepository<ProductComment>>().To<AdminRepository<ProductComment>>().InRequestScope();
            kernel.Bind<IAdminRepository<Product>>().To<AdminRepository<Product>>().InRequestScope();
            kernel.Bind<IAdminRepository<Region>>().To<AdminRepository<Region>>().InRequestScope();
            kernel.Bind<IAdminRepository<UserProfile>>().To<AdminRepository<UserProfile>>().InRequestScope();


            kernel.Bind<ICompanyService>().To<CompanyService>().InRequestScope();
            kernel.Bind<IManufactureService>().To<ManufactureService>().InRequestScope();
            kernel.Bind<IOrderDetailService>().To<OrderDetailService>().InRequestScope();
            kernel.Bind<IOrderService>().To<OrderService>().InRequestScope();
            kernel.Bind<IOrderStatusChangedLogService>().To<OrderStatusChangedLogService>().InRequestScope();
            kernel.Bind<IOrderStatusService>().To<OrderStatusService>().InRequestScope();
            kernel.Bind<IProductCommentService>().To<ProductCommentService>().InRequestScope();
            kernel.Bind<IProductService>().To<ProductService>().InRequestScope();
            kernel.Bind<IRegionService>().To<RegionService>().InRequestScope();
            kernel.Bind<IUserProfileService>().To<UserProfileService>().InRequestScope();


            kernel.Bind<IAdminCompanyService>().To<AdminCompanyService>().InRequestScope();
            kernel.Bind<IAdminManufactureService>().To<AdminManufactureService>().InRequestScope();
            kernel.Bind<IAdminOrderDetailService>().To<AdminOrderDetailService>().InRequestScope();
            kernel.Bind<IAdminOrderService>().To<AdminOrderService>().InRequestScope();
            kernel.Bind<IAdminOrderStatusChangedLogService>().To<AdminOrderStatusChangedLogService>().InRequestScope();
            kernel.Bind<IAdminOrderStatusService>().To<AdminOrderStatusService>().InRequestScope();
            kernel.Bind<IAdminProductCommentService>().To<AdminProductCommentService>().InRequestScope();
            kernel.Bind<IAdminProductService>().To<AdminProductService>().InRequestScope();
            kernel.Bind<IAdminRegionService>().To<AdminRegionService>().InRequestScope();
            kernel.Bind<IAdminUserProfileService>().To<AdminUserProfileService>().InRequestScope();
        }        
    }
}
