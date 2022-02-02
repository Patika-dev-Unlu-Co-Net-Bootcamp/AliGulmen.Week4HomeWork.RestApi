namespace AliGulmen.Week4.HomeWork.RestfulApi.Middlewares
{
    using Microsoft.AspNetCore.Builder;

    public static class CustomGlobalExceptionExtension
    {
        // to use in start.cs : app.UseCustomGlobalException() instead of app.UseMiddleware<CustomGlobalException>();
        public static IApplicationBuilder UseCustomGlobalException(this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<CustomGlobalException>();
        }
    }


}




