using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public static class ExtentionMethods
    {
        public static string KsbDescription(this KsbKeys e)
        {
            switch (e)
            {
                case KsbKeys.SE1:
                    return "Description SE1";
                case KsbKeys.SE2:
                    return "Description SE2";
                case KsbKeys.SE3:
                    return "Description SE3";
            }
            return "KSB error";
        }
    }
}
