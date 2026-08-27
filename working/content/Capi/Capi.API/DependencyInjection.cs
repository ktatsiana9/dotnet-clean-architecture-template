namespace Capi.API;

public static class DependencyInjection
{
  public static IServiceCollection AddApiServices(
    this IServiceCollection services,
    IConfiguration configuration)
  {
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();

    return services;
  }

  public static WebApplication UseApiServices(this WebApplication webApplication)
  {
    if (webApplication.Environment.IsDevelopment())
    {
      webApplication.UseSwagger();
      webApplication.UseSwaggerUI();
    }

    webApplication.MapGet("/", () => "Hello World!");

    return webApplication;
  }
}