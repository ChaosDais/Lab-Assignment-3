using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    public double coverPrice;
    public int copiesSold;
    private double cost;
    private double profit;

    void Start()
    {
        cost = coverPrice * (0.60) * copiesSold; // Bookstores get 40% discount off of the cover price. Multiply by number of copies
        cost += CalculateShipping(copiesSold); // Add shipping to wholescale cost
        profit = coverPrice * copiesSold - cost; // Subtract cost from the product of Cover Price and Copies Sold to get profit

        Debug.Log("Task 2\n" +
            $"Wholescale Cost: ${cost} || Profit: ${profit}");
    }

    public double CalculateShipping(int copies)
    {
        // Calculate shipping costs
        double shipping = 0;

        for (int i = 0; i < copies; i++)
        {
            if(i == 0)
            {
                // First copy costs $3
                shipping += 3;
            } else
            {
                // Each additional copy costs 75 cents
                shipping += 0.75;
            }
        }

        return shipping;
    }
   
}
