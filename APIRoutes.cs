namespace BlazorServerApp
{
    public static class APIRoutes
    {
#if DEVELOPMENT
        public static readonly string APIHost = "https://devapi.bdalldorf.tech";
#elif RELEASE
        public static readonly string APIHost = "https://api.bdalldorf.tech";
#else
        // TODO: Add Logic to hit up the local API Build instead the devapi deploy
        public static readonly string APIHost = "https://devapi.bdalldorf.tech";
#endif

        public static class TikTokDownloadRoute
        {
            public static readonly string FileDownload = $"{APIHost}/tiktok/filedownload/";
            public static readonly string FileDownloadImage = $"{APIHost}/tiktok/filedownloadimage/";
            public static readonly string UpdateHtmlPage = $"{APIHost}/tiktok/updatehtmlpage/";
        }

        public static class PHDownloadRoute
        {
            public static readonly string FileDownload = $"{APIHost}/ph/filedownload/";
            public static readonly string FileDownloadImage = $"{APIHost}/ph/filedownloadimage/";
            public static readonly string UpdateHtmlPage = $"{APIHost}/ph/updatehtmlpage/";
            public static readonly string VideoList = $"{APIHost}/ph/videolist/";
        }

        public static class FacebookDownloadRoute
        {
            public static readonly string FileDownload = $"{APIHost}/facebook/filedownload/";
            public static readonly string FileDownloadImage = $"{APIHost}/facebook/filedownloadimage/";
            public static readonly string UpdateHtmlPage = $"{APIHost}/facebook/updatehtmlpage/";
        }

        public static class InstagramDownloadRoute
        {
            public static readonly string FileDownload = $"{APIHost}/instagram/filedownload/";
            public static readonly string FileDownloadImage = $"{APIHost}/instagram/filedownloadimage/";
            public static readonly string UpdateHtmlPage = $"{APIHost}/instagram/updatehtmlpage/";
        }
    }
}
