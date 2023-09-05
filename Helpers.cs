using System;

namespace ChatbotTest
{
    public static class Helpers
    {   //no bot da fortes esta na paste de service(ate pq é um auxilo)
        public static string GreetingTime(DateTime dateTime)
        {
            if (dateTime.Hour >= 0 && dateTime.Hour < 12)
                return "bom dia";
            else if (dateTime.Hour >= 12 && dateTime.Hour < 18)
                return "boa tarde";
            else
                return "boa noite";
        }
    }
}
