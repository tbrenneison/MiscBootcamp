﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc; 

namespace MVCmusicstoretutorial2.Models
{
    [Bind(Exclude = "AlbumdID")]
    public class Album
    {
        [ScaffoldColumn(false)] //hides album id from scaffolding editors
        public int AlbumId { get; set; }
        [DisplayName("Genre")]
        public int GenreId { get; set; }
        [DisplayName("Artist")]
        public int ArtistId { get; set; }
        [Required(ErrorMessage = "An Album Title is required")]
        [StringLength(160)]
        public string Title { get; set; } 
        [Required(ErrorMessage ="Price is required")]
        [Range(0.01, 100.00)]
        public decimal Price { get; set; }
        [DisplayName("Album Art URL")]
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; } //virtual properties allow Entity to lazy-load as necessary
        public virtual  Artist Artist { get; set; }
    }
}