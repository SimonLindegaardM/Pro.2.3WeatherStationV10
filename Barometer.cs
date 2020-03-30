namespace WeatherStationV10
{
    /// <summary>
    ///  Simple barometer, measuring pressure in hPa (hectopascal)
    /// </summary>
    public class Barometer
    {
        #region Instance fields
        private double _pressureInHPa;
        #endregion

        #region Constructor
        public Barometer()
        {
            _pressureInHPa = 1000.0;
        }
        #endregion

        #region Properties
        public double Pressure
        {
            get { return _pressureInHPa; }
            set { _pressureInHPa = value; }
        }

        public string WeatherDescription
        {
            get
            {
                if(Pressure <980)
                {
                    return "Stormy";
                }
                else if(Pressure <1000)
                {
                    return "Rainy";
                }
                else if(Pressure <1020)
                {
                    return "Changing";
                }
                else if(Pressure <1040)
                {
                    return "Fair";
                }
                else
                {
                    return "Very Dry";
                }
            }
        }
        #endregion
        // public static int Infinite(int Barometer)
        // while (Barometer<2000)
        // {
        //     System.Console.WriteLine();
        // }


    }
}