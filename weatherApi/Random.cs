namespace weatherApi
{
    public class Random
    {
        public long Random1(int n1,int n2)
        {
            DateTime dt = DateTime.Now;
            long l = dt.Millisecond;
            int min =Math.Min(n1,n2);
            int max =Math.Max(n1,n2);   
            return l%(max-min+1)+min;

        }
    }
}
