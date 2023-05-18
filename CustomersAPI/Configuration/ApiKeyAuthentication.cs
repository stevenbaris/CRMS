namespace CustomersAPI.Configuration
{
    public class ApiKeyAuthentication
    {
        private readonly RequestDelegate _next;
        private const string ApiKey = "ApiKey";

        public ApiKeyAuthentication(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext context)
        {
            // Extract the ApiKey from the request header
            if (!context.Request.Headers.TryGetValue(ApiKey, out var extractedKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("ApiKey is not found in the request");
                return;
            }
            // Validate the extracted API Key from the header

            // Get the default ApiKey value
            var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();
            var CustomerAPIKey = appSettings.GetValue<string>(ApiKey);
            
            // COMPARE the request header ApiKey to the  default ApiKey
            if (!CustomerAPIKey.Equals(extractedKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("UNAUHTORIZED: ApiKey is not valid");
                return;
            }

            await _next(context);
        }

    }
}
