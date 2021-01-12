using System;
using System.ComponentModel.DataAnnotations;

namespace MvcJazz.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Artist { get; set; }

        public string Title { get; set; }

        [Display(Name = "Rec. Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        
        public DateTime RecordingDate { get; set; }
        
        public string Personnel { get; set; }
        
        [Display(Name = "Album Image")]
        public string AlbumImage { get; set; }
    }
}