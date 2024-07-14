namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
  /*
* 8
* 7
* 6
* 5
* 4    #                            #
* 3   #  #                         #
* 2  #    #        #              #
* 1 #      #      # #            #
--0---------#----#---#----------#----------------------
* 1          #  #     #        #
* 2           #        #      #
* 3                     #    #
* 4                      #  #
* 5                       #
* 6
* 7
* 8
*/
    public static int Solution(int[] points)
    {
        var pointsCount = points.Length;
        var deepestPitDepth = -1;

        //Iterate through points
        for (int leftIndex = 0; leftIndex < pointsCount - 2; leftIndex++)  //In the problem statement leftIndex is referenced as P
        {
            if (points[leftIndex] <= 0) continue; // Skip non-positive points

            int rockBottomIndex = leftIndex + 1;
            //Assume a pit bottom and check if the next point has a decrease in slope, continue checking, 
            //with each successful check a new pit bottom should be tagged
            //In the problem statement rockBottomIndex is referenced as Q
            while (rockBottomIndex < pointsCount - 1 && points[rockBottomIndex] > points[rockBottomIndex + 1])
                rockBottomIndex++;

            if (rockBottomIndex == pointsCount - 1) continue; // No valid pit if at the end

            int rightIndex = rockBottomIndex + 1;
            //Assume the top of the pit as pit bottom, check the next point for an increase in slope,
            //With each successful check a new ridge should be tagged
            //In the problem statement rightIndex is referenced as R
            while (rightIndex + 1 < pointsCount && points[rightIndex] < points[rightIndex + 1])
                rightIndex++;

            //Check if a ridge was found
            //Calculate pit depth
            if (points[leftIndex] > 0 && points[rockBottomIndex] < points[leftIndex] && points[rockBottomIndex] < points[rightIndex])
            {
                int depth = Math.Min(points[leftIndex] - points[rockBottomIndex], points[rightIndex] - points[rockBottomIndex]);
                deepestPitDepth = Math.Max(deepestPitDepth, depth);
            }

            // Move leftIndex to the last rightIndex to avoid rechecking
            leftIndex = rightIndex - 1;
        }

        return deepestPitDepth;

    }
}
