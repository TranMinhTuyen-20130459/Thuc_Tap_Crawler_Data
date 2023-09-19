namespace Tuan_1.Class
{
    // class này chịu trách nhiệm lưu đoạn mã html vào file
    public static class HtmlFileSaver
    {
        public static void SaveHtmlToFile(string fileName, string? htmlCode)
        {
            try
            {
                File.WriteAllText(fileName, htmlCode);
                Console.WriteLine($"Đã lưu đoạn mã HTML vào tệp tin: {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lưu file: {ex.Message}");
            }
        }
    }
}
