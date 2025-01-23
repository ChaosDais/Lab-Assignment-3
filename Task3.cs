using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public int paycheck;
    private int hundreds = 0, fifties = 0, twenties = 0, tens = 0, fives = 0, ones = 0;

    void Start()
    {
        CalculateBills();

        Debug.Log("Task 3\n" +
            $"$100 Bills: {hundreds} || $50 Bills: {fifties} || $20 Bills: {twenties} || $10 Bills: {tens} || $5 Bills: {fives} || $1 Bills: {ones}");
    }

    public void CalculateBills()
    {
        // Separate the whole paycheck into bills.

        int temp = paycheck; // Store the amount paid

        while(temp > 0)
        {
            // Partition the paycheck into bills until there's no money left
            if(temp - 100 >= 0)
            {
                temp -= 100;
                hundreds++;
            }
            else if(temp - 50 >= 0)
            {
                temp -= 50;
                fifties++;
            }
            else if(temp - 20 >= 0)
            {
                temp -= 20;
                twenties++;
            }
            else if(temp - 10 >= 0)
            {
                temp -= 10;
                tens++;
            }
            else if (temp - 5 >= 0)
            {
                temp -= 5;
                fives++;
            }
            else
            {
                // Only $1 bills remaining
                temp -= 1;
                ones++;
            }
        }
    }
}
