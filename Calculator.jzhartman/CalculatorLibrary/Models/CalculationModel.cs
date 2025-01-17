﻿using System;
using System.Linq;
using CalculatorLibrary.Enums;

namespace CalculatorLibrary.Models
{
    public class CalculationModel
    {
        public double Operand1 { get; set; } = double.NaN;
        public double Operand2 { get; set; } = double.NaN;
        public Operation Operation { get; set; } = Operation.Error;
        public string OperationSymbol { get; set; }
        public double Result { get; set; } = double.NaN;
        public bool HasError { get; set; }
    }
}
