﻿using Price_Configurator.Models;
using System.Collections.Generic;

namespace Price_Configurator.ViewModels
{
    public class ProductEquipmentViewModel
    {
        public IEnumerable<ProductEquipment> CurrentProductEquipments { get; set; }
    }
}