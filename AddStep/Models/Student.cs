﻿
 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        public string SureName { get; set; }
        public DateTime Birthday { get; set; }
        [Required]
        [MaxLength(30)]
        public string Passport { get; set; }
        public Genders? Gender { get; set; }
        [Required]
        [MaxLength(30)]
        public string MobileNamber { get; set; }
        public string TelegramNamber { get; set; }
        public Nations? Nation { get; set; }
        public int InteristId { get; set; }
        public string Mahalla { get; set; }
        public string UnverstyCode { get; set; }
        public int Cours { get; set; }
        public string LiveReadyCode { get; set; }
        public Contracts? Contract { get; set; }
        public string NogironCode { get; set; }
  



    }
}