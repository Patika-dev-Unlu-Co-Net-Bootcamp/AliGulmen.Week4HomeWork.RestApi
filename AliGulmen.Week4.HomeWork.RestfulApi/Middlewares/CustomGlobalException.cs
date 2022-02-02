﻿namespace AliGulmen.Week4.HomeWork.RestfulApi.Middlewares
{
    using AliGulmen.Week4.HomeWork.RestfulApi.Services.LoggerService;
    using Microsoft.AspNetCore.Http;
    using Newtonsoft.Json;
    using System;
    using System.Net;
    using System.Threading.Tasks;


    // This middleware will be used for global exception
    public class CustomGlobalException
    {

        private readonly RequestDelegate _next;
        private readonly ILoggerService _loggerService;

        public CustomGlobalException(RequestDelegate next, ILoggerService loggerService)
        {
            _next = next;
            _loggerService = loggerService;
        }

        public async Task Invoke(HttpContext context)
        {
            //instead of using seperate handlers on controller, we can write a try catch block for global exception here..
            try
            {
                await _next(context);

            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }


        //global exception
        private Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            switch (ex)
            {
                case InvalidOperationException:
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest; //400 if unexpected
                    break;
                default:
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; //500 if unexpected
                    break;
            }


           
            string message = "[ERROR] HTTP "
                + context.Request.Method
                + " - "
                + context.Response.StatusCode
                + " Error Message " + ex.Message;
            _loggerService.Log(message);
            //Use Newtonsoft to serialize ex.Message to json and return to client
            var result = JsonConvert.SerializeObject(new { error = ex.Message }, Formatting.None);
            return context.Response.WriteAsync(result);
        }



    }


}




