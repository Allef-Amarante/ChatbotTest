using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatbotTest.Dialogs
{
    public class DefaultDialog : ChatbotMaker.BDK.Dialogs.DefaultDialog
    {
        public override async Task Execute()
        {
            var context = Context;
            await GoToDialog<WelcomeDialog>(true);
        }
    }
}
