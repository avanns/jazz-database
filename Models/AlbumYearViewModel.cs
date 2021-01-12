using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcJazz.Models
{
    public class AlbumYearViewModel
        {
            public List<Album> Albums { get; set; }
            public SelectList Years { get; set; }
            public string RecordingYear { get; set; }
            public string SearchString { get; set; }
        }
    }