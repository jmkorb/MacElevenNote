﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ElevenNoteWebMVC.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
