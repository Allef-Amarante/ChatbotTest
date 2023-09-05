using ChatbotMaker.BDK.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatbotTest.Dialogs
{
    public class PegarNomeDialog :Dialog
    {
        public override async Task Execute()
        {       //condição quando é a primeira vez do usuario
            if (string.IsNullOrEmpty(Context.User.Name))
            {
                if (string.IsNullOrEmpty(Context.Message?.Text)) //lógica quando o nome nao esta sétado, que cairá na seguinte função...     
                {
                    await SendMessage()
                    .Text("Antes de iniciarmos, deixa eu te conhecer primeiro.")
                    .Send();

                    await SendMessage(3000)
                        .Text("Qual o seu nome?")
                        .Send();
                }
                else
                {   //condição para pegar o nome e ir para "AjudarDialog" 
                    Context.User.Name = Context.Message?.Text;
                    await SendMessage()
                        .Text($"Muito bom te conhecer {Context.User.Name}")
                        .Send();

                    await GoToDialog<AjudarDialog>(); //comando para sair do "PegarNome"
                }
            }
            else
            {   //caso não seja a primeira vez do User, ja tem o name no banco de dados..."context.user.name"
                await SendMessage()
                    .Text($"Que bom que voce voltou {Context.User.Name}")
                    .Send();
                await GoToDialog<AjudarDialog>();//comando para sair do "PegarNome"
            }
        }
    }
}
