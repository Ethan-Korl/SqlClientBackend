namespace SqlClientBackend.Utils
{
    public static class GeneralUtils
    {
        public static int GenerateCode(int minValue, int maxValue){
            var rd = new Random();
            var rd_number = rd.Next(minValue, maxValue);
            return rd_number;
        }
    }
}