using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using sharwapi.Contracts.Core;

namespace sharwapi.Plugin.apimgr;

public class apimgrPlugin : IApiPlugin
{
    // 插件名称
    public string Name => "sharwapi.apimgr";
    // 插件显示名称
    public string DisplayName => "API Manager";
    // 插件版本
    public string Version => "0.1.0";
    // 禁用自动路由前缀
    public bool UseAutoRoutePrefix => false;
    // 插件注册服务方法 (此插件不需要注册服务，使用默认函数)
    public void RegisterServices(IServiceCollection services, IConfiguration configuration) { }
    // 插件中间件配置方法 (此插件不需要配置中间件，使用默认函数)
    public void Configure(WebApplication app) { }

    // 插件路由注册方法
    public void RegisterRoutes(IEndpointRouteBuilder app, IConfiguration configuration)
    {
        // 获取全部已加载的插件
        var allPlugins = app.ServiceProvider.GetRequiredService<List<IApiPlugin>>();
        // 定义路由组
        var group = app.MapGroup("/admin");

        // 定义获取已加载插件列表的端点
        group.MapGet("/plugins", () =>
        {
            return allPlugins.Select(p => new
            {
                p.DisplayName,
                p.Name,
                p.Version
            });
        });

        // 为每个插件注册管理端点
        foreach (var plugin in allPlugins)
        {
            var pluginAdminGroup = group.MapGroup($"/plugin/{plugin.Name}");

            plugin.RegisterManagementEndpoints(pluginAdminGroup);
        }

    }
}