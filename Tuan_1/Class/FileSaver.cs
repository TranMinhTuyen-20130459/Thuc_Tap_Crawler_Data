namespace Tuan_1.Class
{
    // Class này chịu trách nhiệm lưu data vào file
    public static class FileSaver
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
