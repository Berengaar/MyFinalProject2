﻿using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)      //İstediğim kadar IResult parametresis geçebilirim
        {
            foreach (var logic in logics)
            {
                return logic;
            }

            return null;
        }
        
            
    }

}
