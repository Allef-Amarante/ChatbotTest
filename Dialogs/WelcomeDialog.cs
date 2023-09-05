using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatbotTest.Dialogs
{
    public class WelcomeDialog : ChatbotMaker.BDK.Dialogs.WelcomeDialog
    {
        public override async Task Execute()
        {       //interpolation(inperpolação = $" text, {}"
               //e nesse caso
            await SendMessage()
                .Text($"{Helpers.GreetingTime(DateTime.Now)}, eu sou o ChatBurguer.")
                .Send();

            await GoToDialog<PegarNomeDialog>();//commando para poder sair do "GreetingTime" e ir para "PegarNomeDialog"

            //var context = Context;
            //if (!string.IsNullOrEmpty(Context.Message?.Text)) 
            //    await SendMessage()
            //        .Text($"Eu sou um papagaio: {Context.Message.Text}")
            //        .Send();

            //await SendMessage().List("Título", "Corpo da lista", "Botão de título")
            //    .AddSection("Título da seção", "Subtítulo da seção")
            //        .AddGoToDialogOption<DefaultDialog>("Diálogo default", "Descrição do diálogo")
            //        .AddGoToDialogOption<WelcomeDialog>("Diálogo welcome", "Descrição do diálogo 2")
            //        .Send();

            //await SendMessage()
            //    .QuickReplyText("Texto do quick reply")
            //    .AddGoToDialogOption<DefaultDialog>("Ir para default")
            //    .AddGoToDialogOption<WelcomeDialog>("Ficar aqui")
            //    .Send();

            //await SendMessage()
            //    .Template(
            //        templateId: "confirmacao_pedido",
            //        bodyParameters: new List<string> { "Zd" },
            //        buttonsParameters: new List<string> { "pedido" }
            //    ).Send();
        }
    }
}
