//Alice and Bob each created one problem for HackerRank.A reviewer rates the two challenges, awarding points on a scale from to  for three categories: problem clarity, originality, and difficulty.
//We define the rating for Alice's challenge to be the triplet , and the rating for Bob's challenge to be the triplet.
//Your task is to find their comparison points by comparing with, with , and with .
//If , then Alice is awarded point.
//If , then Bob is awarded point.
//If , then neither person receives a point.
//Comparison points is the total points a person earned.
//Given and, can you compare the two challenges and print their respective comparison points?
//Input Format
//The first line contains  space-separated integers, , , and , describing the respective values in triplet.
//The second line contains  space-separated integers, , , and , describing the respective values in triplet.
//Constraints
//Output Format
//Print two space-separated integers denoting the respective comparison points earned by Alice and Bob.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup
{
    class CompareTheTriplets
    {
        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int alice_score = 0;
            int bob_score = 0;
            if (a0 > b0)
                alice_score++;
            else if (a0 < b0)
                bob_score++;

            if (a1 > b1)
                alice_score++;
            else if (a1 < b1)
                bob_score++;

            if (a2 > b2)
                alice_score++;
            else if (a2 < b2)
                bob_score++;

            Console.Write("{0} {1}", alice_score, bob_score);

        }
    }
}
