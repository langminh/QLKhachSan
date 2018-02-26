﻿using ProductMvc.Models.AjaxModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductMvc.ViewModel
{
    public class BillModel:CheckOut
    {
        public string RoomName { get; set; }
        public decimal RoomServiceAmout { get; set; }
        public string CheckOutTimeStr { get; set; }
        public string InvoiceNumber { get; set; }
    }
}