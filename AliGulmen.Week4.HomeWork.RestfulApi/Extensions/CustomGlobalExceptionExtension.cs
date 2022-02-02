namespace AliGulmen.Week4.HomeWork.RestfulApi.Middlewares
{
    using Microsoft.AspNetCore.Builder;

    public static class CustomGlobalExceptionExtension
    {
     
        public static IApplicationBuilder UseCustomGlobalException(this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<CustomGlobalException>();
        }
    }


}




