using System.Collections.Generic;

class Coll
{
    void Learn()
    {
        // one-dimensional
        byte[] ages = {78, 23, 45, 43, 65, 78};
        string[] names = { "rekha" , "rajani" , "smriti"};
        
        // null
        int[,] studentsInClassRoom = new int[7,6];
        studentsInClassRoom[0,0] = 54;
        studentsInClassRoom[0,1] = 43;
        studentsInClassRoom[0,2] = 473;
        studentsInClassRoom[0,3] = 439;
        studentsInClassRoom[0,4] = 430;

        // Jagged array
        int[][] studentsInClassRoom2 = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {3, 4},
            new int[] {2, 3, 1, 4}
        };

        // collections
        List <int> agesList = [3,3,4,2];//int as a generic parameter
        List<string> namesList = ["rekha","rama", "roshan"];//O(n),n=3

        Dictionary<string , long> countryPopulation = new();
        countryPopulation.Add("Nepal", 214343546);
        countryPopulation.Add("India", 342534646);
        countryPopulation.Add("America",1324234356);
        countryPopulation.Add("London", 88977876754);

        var p = countryPopulation["Nepal"];

    }
}
