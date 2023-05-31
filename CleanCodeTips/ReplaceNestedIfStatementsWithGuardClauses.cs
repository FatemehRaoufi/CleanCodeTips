using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public enum ClientType
    {
        Business,
        ExistingClient,
        NewClient
    }
    public class ReplaceNestedIfStatementsWithGuardClauses
    {
        //The code before refactoring:
        public double GetInterestRate(ClientType clientType)
        {
            double result;
            if (clientType == ClientType.Business)
            {
                result = 0.05;
            }
            else
            {
                if (clientType == ClientType.ExistingClient)
                {
                    result = 0.02;
                }
                else
                {
                    result = 0.03;
                }
            }
            return result;
        }

        //After refactoring
        public double NewGetInterestRate(ClientType clientType)
        {
            //double result;
            if (clientType == ClientType.Business)
            {
                return 0.05;
            }

            if (clientType == ClientType.ExistingClient)
            {
                return 0.02;
            }
            //else
            //{
            //    result = 0.03;
            //}

            return 0.03;
        }
    }
}
