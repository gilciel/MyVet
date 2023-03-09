﻿using MyVet.WEB.Data.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
   public class Agenda
   {
      public int Id { get; set; }

      [Display(Name = "Date")]
      [Required(ErrorMessage = "The field {0} is mandatory.")]
      [DataType(DataType.DateTime)]
      [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}", ApplyFormatInEditMode = true)]
      public DateTime Date { get; set; }

      public Owner Owner { get; set; }

      public Pet Pet { get; set; }

      public string Remarks { get; set; }

      [Display(Name = "Is Available?")]
      public bool IsAvailable { get; set; }
   }
}
