﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingInfringement.API.Models
{
    [Table("cartype")]
    public class CarType
    {
        [Key]
        public int Id { set; get; }
        public string Make { set; get; }
    }
}
