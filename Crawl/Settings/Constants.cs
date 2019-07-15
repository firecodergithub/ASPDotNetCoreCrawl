﻿namespace LinkCrawler.Utils.Settings
{
    public static class Constants
    {
        public static class AppSettings
        {
            public const string BaseUrl = "BaseUrl";
            public const string ValidUrlRegex = "ValidUrlRegex";
            public const string OnlyReportBrokenLinksToOutput = "OnlyReportBrokenLinksToOutput";
            public const string CheckImages = "CheckImages";
            public const string SlackWebHookUrl = "Slack.WebHook.Url";
            public const string SlackWebHookBotName = "Slack.WebHook.Bot.Name";
            public const string SlackWebHookBotIconEmoji = "Slack.WebHook.Bot.IconEmoji";
            public const string SlackWebHookBotMessageFormat = "Slack.WebHook.Bot.MessageFormat";
            public const string CsvFilePath = "Csv.FilePath";
            public const string CsvOverwrite = "Csv.Overwrite";
            public const string CsvDelimiter = "Csv.Delimiter";
            public const string SuccessHttpStatusCodes = "SuccessHttpStatusCodes";
            public const string OutputProviders = "outputProviders";
            public const string PrintSummary = "PrintSummary";
            public const string TimeMsBetweenRequests = "TimeMsBetweenRequests";

            public const string TopWordsCount="TopWordsCount";
            public const string RemoveStopWords="RemoveStopWords";
            public const string LanguageStopWordsBySiteExtension="LanguageStopWords";
        }

        public static class Response
        {
            public const string ContentTypeTextHtml = "text/html";
            public const string ContentTypeTextText = "text/plain";
        }

        public static class Html
        {
            public const string Href = "href";
            public const string Src = "src";
            public const string LinkSearchPattern = "//a[@href]";
            public const string ImgSearchPattern = "//img[@src]";
        }
    }
}
