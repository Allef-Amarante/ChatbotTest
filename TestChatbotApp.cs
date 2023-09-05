using ChatbotMaker.BDK;
using ChatbotMaker.BDK.Services;
using ChatbotMaker.BDK.Services.FileSettings;
using ChatbotMaker.BDK.Services.Jobs;
using ChatbotMaker.BDK.Services.Templates;
using System;
using System.Threading.Tasks;

namespace ChatbotTest
{
    public class TestChatbotApp : ChatbotApp
    {
        public TestChatbotApp(IServiceProvider serviceProvider, ChatbotAppConfiguration configuration, WebhookService webhookService, TemplateService templateService, FileSettingsService fileSettingsService)
            : base(serviceProvider, configuration, webhookService, templateService, fileSettingsService)
        {

        }

        protected override Task OnChangedSettings(ChangedSettingsData changedSettingsData)
        {
            return base.OnChangedSettings(changedSettingsData);
        }

        protected override Task OnException(ChatbotException ex)
        {
            return base.OnException(ex);
        }
    }
}
