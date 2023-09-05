using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatbotTest.Dialogs
{
    public class AjudarDialog : ChatbotMaker.BDK.Dialogs.Dialog
    {
        public override async Task Execute()
        {
            if (string.IsNullOrEmpty(Context.Message?.Text))
            {
                await SendMessage()
                    .Text("Como posso te ajudar?")
                    .Send();
                
            }
            else
            {
                if (Context.Message?.Text == "/reset")
                {
                    Context.User.Name = null;
                    await SendMessage()
                   .Text("Resetando em...")
                   .Send();
                    await Task.Delay(1000);
                    await SendMessage()
                   .Text(" 3,")
                   .Send();
                    await Task.Delay(1000);
                    await SendMessage()
                   .Text(" 2,")
                   .Send();
                    await Task.Delay(1000);
                    await SendMessage()
                   .Text(" 1...")
                   .Send();

                    await GoToDialog<WelcomeDialog>(); //comando para sair do "AjudarDialog", voltando para "WelcomeDialog".
                }

                if (Context.Message?.Text == "to com fome")
                {
                    await GoToDialog<ToComFome>(); //comando para sair do "AjudarDialog", voltando para "WelcomeDialog".
                }
            }
            
        }
    }
}
