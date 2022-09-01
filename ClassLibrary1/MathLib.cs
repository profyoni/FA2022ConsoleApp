namespace ClassLibrary1 // ~ package
{
    public class MathLib // internal accessible in this project= assembly
    {
        public static int SquareFromString(String s)
        {
            int x = Convert.ToInt32(s);
            int squaredX = (int)Math.Pow(x, 2);
            return squaredX;
        }

        public static String Add(int a, int b)
        {
            int val =  a + b;
            return val.
        }
    }
}