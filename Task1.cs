using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public string courseName;
    public int numModules;
    public int numReadings;
    public int numQuizzes;
    public int numAssignments;
    public bool taughtBefore;
    private double challengeScore;

    void Start()
    {
        /*****************************
         * CALCULATE CHALLENGE SCORE *
         *****************************/

        // Add 1 if instructor hasn't taught this course before
        if (!taughtBefore)
            challengeScore += 1;

        // (15%) Number of modules in the course, (30%) Number of Reading Materials, (15%) Number of Quizzes, (30%) Number of Assignments
        challengeScore += numModules * 0.15 + numReadings * 0.3 + numQuizzes * 0.15 + numAssignments * 0.3;

        // Make sure challenge score is min 1, max 10
        if(challengeScore < 1)
        {
            challengeScore = 1;
        } else if (challengeScore > 10)   
        {
            challengeScore = 10;
        }

        Debug.Log("Task 1\n" +
            $"Course Name: {courseName} || Challenge Score: {challengeScore}");
    }
}
