using Tuan_1.Class;

namespace Tuan_1.Test
{
    public static class Function_Tester
    {
        public static async void Download_And_Save_Web_CheckIp()
        {
            WebPageDownloader downloader = new WebPageDownloader();
            var htmlContentTask = downloader.DownloadPageAsync(Urls.url_web_check_ip);

            // Đợi cho đến khi htmlCodeTask hoàn thành và lấy giá trị thực tế
            string? htmlContent = await htmlContentTask;

            HtmlFileSaver.SaveHtmlToFile("C:\\Users\\tmt01\\OneDrive\\Máy tính\\crawler.txt", htmlContent);
        }
    }
}
