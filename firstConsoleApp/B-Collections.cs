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
    }
}
