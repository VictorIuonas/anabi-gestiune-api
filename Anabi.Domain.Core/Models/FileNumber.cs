﻿using System;

namespace Anabi.Domain.Models
{
    public class FileNumber
    {
        public int Id { get; set; }

        public int FileId { get; set; }
        
        public string FileNo { get; set; }

        /// <summary>
        /// Instanta care a dat numarul
        /// </summary>

        /// <summary>
        /// Data la care a primit numarul de la instanta
        /// </summary>
        public DateTime NumberDate { get; set; }

        public Journal Journal { get; set; }
    }
}
