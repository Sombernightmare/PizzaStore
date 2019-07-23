﻿using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.ViewModels
{
    public class OrderAddViewModel
    {
        public int OrderID { get; set; }

        [Required]
        [DisplayName("Customer")]
        public int CustomerID { get; set; }
        public OrderType OrderType { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
        public IEnumerable<SelectListItem> CustomerList { get; set; }
    }
}
