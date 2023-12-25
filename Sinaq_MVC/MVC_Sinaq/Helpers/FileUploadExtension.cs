namespace MVC_Sinaq.Helpers
{
    public static class FileUploadExtension
    {
        public static async Task<string> FileUploadasync(this IFormFile file, string path)
        {
                string extension = Path.GetExtension(file.FileName);
                string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                if (fileName.Length > 32)
                {
                    fileName = fileName.Substring(0, 32);
                }
                fileName=Path.Combine(path,Path.GetRandomFileName()+ fileName+extension);
            using (FileStream fs = File.Create(Path.Combine(PathExtension.RootPath, fileName))) {
                await file.CopyToAsync(fs);
            } 

            return fileName;
        }
    }
}
