using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _121_BestTimeToSellandBuy
        {
        // Say you have an array for which the ith element is the price of a given stock on day i.
        //If you were only permitted to complete at most one transaction(ie, buy one and sell one share of the stock),
        //design an algorithm to find the maximum profit.
        public int MaxProfit(int[] prices)
            {
          
            if (prices.Length == 0)
                return 0;
            int max = 0;
            int min = prices[0];
            for (int i = 1; i < prices.Length; i++)
                {
                if (min < prices[i])
                    max = Math.Max(max, prices[i] - min);
                else
                    min = prices[i];
                }
            return max;
            }
        }
    }
