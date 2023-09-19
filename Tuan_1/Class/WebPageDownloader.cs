namespace Tuan_1.Class
{
    // class này chịu trách nhiệm tải trang web
    public class WebPageDownloader
    {
        private HttpClient _httpClient;

        public WebPageDownloader()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string?> DownloadPageAsync(string url)
        {
            try
            {
                // Gửi yêu cầu HTTP GET đến URL
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                // Nếu server trả về trạng thái 200(Ok)
                if (response.IsSuccessStatusCode)
                {
                    string htmlContent = await response.Content.ReadAsStringAsync();
                    return htmlContent;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải trang web: {ex.Message}");
                return null;
            }

            /*
             * Trong đoạn mã trên, "luồng chính" là luồng thực thi chương trình chính của ứng dụng của bạn. Khi bạn gọi phương thức DownloadPageAsync, nó được gọi trên luồng chính.Cụ thể:
                
                    + Khi bạn gọi DownloadPageAsync từ luồng chính, nó bắt đầu thực thi đoạn mã bên trong phương thức.

                    + Trong phương thức DownloadPageAsync, khi bạn gọi _httpClient.GetAsync(url), nó gửi yêu cầu HTTP GET đến URL đã cho, và tại điểm này, nó tạo ra một yêu cầu I/O bất đồng bộ.

                    + Thay vì chặn luồng chính và chờ cho đến khi yêu cầu I/O hoàn thành, await được sử dụng, cho phép luồng chính tiếp tục thực hiện các công việc khác.

                    + Sau khi yêu cầu I/O hoàn thành và phản hồi được trả về từ máy chủ (hoặc có lỗi), luồng chính tiếp tục thực hiện dòng mã sau lệnh await, thực hiện việc kiểm tra kết quả và trả về dữ liệu hoặc xử lý lỗi.

                    + Vì vậy, trong trường hợp này, luồng chính là luồng thực thi chương trình và async và await được sử dụng để không chặn luồng chính trong quá trình thực hiện hoạt động bất đồng bộ như tải trang web.
             */
        }
    }
}
