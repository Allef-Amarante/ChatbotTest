using ChatbotMaker.BDK.Dialogs;
using System.Threading.Tasks;

namespace ChatbotTest.Dialogs
{
    public class AlgoMais : Dialog
    {
        public override async Task Execute()
        {
            if(string.IsNullOrEmpty(Context.Message?.Text))
            {
                await SendMessage()
                    .Text("Algo a mais?")
                    .Send();

                
            }
            else
            {   //e quando se tem a possibilidade de mais perguntar ainda
                if(Context.Message?.Text == "sim")
                {   
                    await SendMessage()
                    .Text("Agora é só esperar a galinha por de novo, one second!")
                    .Send();
                    await Task.Delay(1000);
                    await SendMessage()
                   .Text("Até a proxima")
                   .Send();                   
                    await SendMessage()
                        .Text("===== FIM =====")
                        .Send();
                    await Task.Delay(2000);


                    await GoToDialog<WelcomeDialog>();

                    
                }if (Context.Message?.Text == "nao")
                {
                    //datetime, posso habilitar ele para quando for uma data especifica do ano, e pre-definir uma msg de acordo com a data comemorativa daquela regiaão/país?
                    //mas talvez pra isso teria que joga-lo em uma variavel e determinar frases para aquelea determinada data comemorativa 
                    Context.User.Name = null;
                    await SendMessage()
                        .Text("Muito bem, ja esta guardando espaço na barriga para as festas juninas")
                        .Send();
                    await Task.Delay(1000);
                    await SendMessage()
                   .Text("Adios")
                   .Send();
                    await SendMessage()
                        .Text("===== FIM =====")
                        .Send();
                    await Task.Delay(2000);


                    await GoToDialog<WelcomeDialog>();
                }
            }
        }
    }
}
