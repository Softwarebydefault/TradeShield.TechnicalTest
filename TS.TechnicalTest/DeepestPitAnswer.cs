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

        int leftIndex = 0;
        //Iterate through points
        //In the problem statement leftIndex is referenced as P
        while (leftIndex < pointsCount - 2)
        {
            //Skip negative points
            // Find the start of the pit (P)
            while (leftIndex < pointsCount - 1 && points[leftIndex] <= 0)
                leftIndex++;
        }

        

        //Assume a pit bottom and check if the next point has a decrease in slope, continue checking, 
        //with each successful check a new pit bottom should be tagged

        //Check if a bit bottom was found

        //Assume the top of the pit as pit bottom, check the next point for an increase in slope,
        //With each successful check a new ridge should be tagged

        //Check if a ridge was found

        //Calculate pit depth

        return deepestPitDepth;

    }
}
