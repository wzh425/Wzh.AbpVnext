using EasyAbp.Abp.PhoneNumberLogin.EntityFrameworkCore;
using EasyAbp.FileManagement.EntityFrameworkCore;
using EasyAbp.NotificationService.EntityFrameworkCore;
using EasyAbp.WeChatManagement.MiniPrograms.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using EasyAbp.Abp.DataDictionary.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Wzh.AbpVnext.EntityFrameworkCore
{
    /* This DbContext is only used for database migrations.
     * It is not used on runtime. See AbpVnextDbContext for the runtime DbContext.
     * It is a unified model that includes configuration for
     * all used modules and your application.
     */
    public class AbpVnextMigrationsDbContext : AbpDbContext<AbpVnextMigrationsDbContext>
    {
        public AbpVnextMigrationsDbContext(DbContextOptions<AbpVnextMigrationsDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside the ConfigureAbpVnext method */

            builder.ConfigureAbpVnext();
            builder.ConfigureFileManagement();
            builder.ConfigureNotificationService();
            builder.ConfigurePhoneNumberLogin();
            builder.ConfigureWeChatManagementMiniPrograms();
            builder.ConfigureDataDictionary();
        }
    }
}
