
    public class FloatValue
    {

        public float RnadomFloat(float minValue, float maxValue)
        {
            


            if (minValue < maxValue)
            {
                
                Console.WriteLine("your item has a value of: " + minValue + " and it is in good condition");
                return minValue;
            }
            else
            {
                Console.WriteLine("Your item has a value of: " + maxValue + " and it is in bad condition");
                return maxValue;
            }

            

        }





    }
}
