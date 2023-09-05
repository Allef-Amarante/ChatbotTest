using ChatbotMaker.BDK.Dialogs;
using System.Threading.Tasks;

namespace ChatbotTest.Dialogs
{
    public class ToComFome : Dialog
    {
        public override async Task Execute()
        {
            if (string.IsNullOrEmpty(Context.Message?.Text))
            {
                await SendMessage()
                    .Text("Quer um ovo frito?")
                    .Send();
            }
            else
            {
                if(Context.Message?.Text == "sim")
                {

                    await SendMessage()
                        .Text("Saindo uma hamburguer de Picanha em...")
                        .Send();
                    await Task.Delay(1000);
                    await SendMessage()
                        .Text(" 3,")
                        .Send();
                    await Task.Delay (1000);
                    await SendMessage()
                        .Text(" 2,")
                        .Send();
                    await Task.Delay(1000);
                    await SendMessage()
                        .Text(" 1...")
                        .Send();
                    await Task.Delay(1500);
                    await SendMessage()
                        .Text($"😃👍")
                        .Send();

                    await GoToDialog<AlgoMais>();
                }
                if(Context.Message?.Text == "nao")
                {
                    Context.User.Name = null;
                    await SendMessage()
                        .Text("huum, desculpa awe, socialista de Iphoone")
                        .Send();
                    await Task.Delay(2000);
                    await SendMessage()
                        .Text("Adios... ")
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
