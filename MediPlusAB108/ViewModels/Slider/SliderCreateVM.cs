using MediPlusAB108.Models;
using System.ComponentModel.DataAnnotations;

namespace MediPlusAB108.ViewModels.Slider
{
    public class SliderCreateVM : BaseEntity
    {
        [MaxLength(32)]
        public string Title { get; set; } = null!;
        [MaxLength(64)]
        public string Subtitle { get; set; } = null!;
        public string? Link { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}
