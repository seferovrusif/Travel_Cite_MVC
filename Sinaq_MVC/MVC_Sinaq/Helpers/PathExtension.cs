namespace MVC_Sinaq.Helpers
{
    public class PathExtension
    {
        public static string FileUpload => Path.Combine("UploadIMG", "DestinationMainImg");

        public static string RootPath { get; set; }
    }
}
