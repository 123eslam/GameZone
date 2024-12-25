namespace GameZone.ViewModels
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
        [AllowedExtensions(FileSettings.AllowedExtensions),MaxFileSize(FileSettings.MaxFileeSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
