﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ProtectedFiles.Web.Models
{
    public class UploadFileViewModel
    {
        [Required]
        public int ItemId { get; set; }

        public IFormFile File { get; set; }
    }
}
