namespace ConsoleApp8
{
    internal class Program
    {
        #region 1
        // Value type by value is take aclone and changes in local function
        //Value type by ref is a pointer to a value and change in parameter function
        public static void swapv(int x, int y) {

            int t = x;
            x= y;
            y= t;
        
        
        }
        public static void swapref( ref int x,ref int y)
        {

            int t = x;
            x = y;
            y = t;


        }
        #endregion
        #region 2
        //ref by value the ref to heap not stack  
        //ref by ref the ref to ref and change  in stack
        public static void print(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)     
                sum +=i;
            arr = new int[5];
      Console.WriteLine(sum);

        }
        public static void printref(ref int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum +=i;
            arr = new int[5];
            Console.WriteLine(sum);

        }

        #endregion
        #region 3
        public static int Sum(int x, int y, int z, int n) {


            return (x + y) + (z - n);
        
        }

        #endregion
        #region 4
        public static int sumd(int x)
        {
            int sum = 0;
            while (x != 0) {
                sum += x % 10;
                x/=10;
            }
            return sum;
        }

        #endregion
        #region 5
        public static bool prime(int x) {
            if(x == 1||x==0) return false;

            for (int i = 2; i <=int.MaxValue ; i++) { 
            
            if(x%i==0&&i!=x) return false;
            
            
            }
        return true;
        }

        #endregion
        #region 6
        public static void minmax(ref int[] arr) { 
         int min = int.MaxValue;
         int max = int.MinValue;




            for (int i = 0; i < arr.Length; i++) { 
            if(arr[i] <=min)
                    min = arr[i];
            if(arr[i] >=max) max = arr[i];
            
            
            }

            Console.WriteLine("max= " + max);
            Console.WriteLine("min= " + min);
        }


        #endregion
        #region 7
        public static int fac(int x)
        {
            int sum = 1;
            for (int i = 1; i <= x; i++) {
                sum *= i;
            
            }

            return sum;
        }
        #endregion
        #region 8
        public static void rep(string s,char c,int x)
        {
            char[] chars = s.ToCharArray();
            chars[x] = c;
            foreach (char p in chars)
                Console.Write(p);

            




        }

        #endregion

        static void Main(string[] args)
        {

            Console.WriteLine();
           
        }
    }
}
