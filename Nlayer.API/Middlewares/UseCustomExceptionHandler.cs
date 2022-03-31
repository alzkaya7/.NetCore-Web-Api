using Microsoft.AspNetCore.Diagnostics;
using Nlayer.Core.DTOs;
using NLayer.Service.Exceptions;
using System.Text.Json;

namespace Nlayer.API.Middlewares
{
    public static class UseCustomExceptionHandler //Extension method için classım static olmak zorunda ..
    {

        public static void UserCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>


            {
                config.Run(async context =>

                {
                    context.Response.ContentType = "application/json";

                    var exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();//Bu interface sayesinde uygulamadan  fırlatılan hatayı alıyorum ..


                    var statuscode = exceptionFeature.Error switch
                    {
                        ClientSideException => 400,
                        _ => 500

                    };

                    context.Response.StatusCode = statuscode;

                    var response = CustomResponseDto<NoContentDto>.Fail(statuscode, exceptionFeature.Error.Message);

                    await context.Response.WriteAsync(JsonSerializer.Serialize(response)); //Jsonserialize newtonsoft  kullanmıuorum ..

                });


            });

        }

    }
}
