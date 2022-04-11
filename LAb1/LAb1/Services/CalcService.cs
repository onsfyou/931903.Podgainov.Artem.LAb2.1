namespace LAb1.Services
{
    public class CalcService
    {
        Random rnd = new Random();
        public int GetInt()
        {
            return rnd.Next(0, 10);
        }
        public string Add(int a, int b)
        {
            return (a + b).ToString();
        }
        public string Sub(int a, int b)
        {
            return (a - b).ToString();
        }
        public string Mult(int a, int b)
        {
            return (a * b).ToString();
        }
        public string Div(int a, int b)
        {
            if (b == 0)
                return "Infinity";
            else
                return (a / b).ToString();
        }
    }
    public static class ServiceProviderExtansions
    {
        public static void AddCalcService(this IServiceCollection services)
        {
            services.AddTransient<CalcService>();
        }
    }
}
