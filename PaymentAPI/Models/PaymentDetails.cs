﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetails
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string SecurityCode { get; set; }
    }
}