using ChatbotMaker.BDK.Models;
using ChatbotMaker.BDK.Services.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatbotTest.Services
{
    public class WidgetsService : IWidgetsService
    {
        public async Task<List<WidgetPanel>> Load(WidgetsContext context)
        {
            return new List<WidgetPanel>();
        }
    }
}
