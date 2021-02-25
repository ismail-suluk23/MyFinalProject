using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
                
            }
            return null;
        }

        public static IResult Run(IResult result, object v1, object v2)
        {
            throw new NotImplementedException();
        }
    }
}
