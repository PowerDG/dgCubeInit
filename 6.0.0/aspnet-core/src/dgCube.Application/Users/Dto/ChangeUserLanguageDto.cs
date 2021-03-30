using System.ComponentModel.DataAnnotations;

namespace dgCube.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}