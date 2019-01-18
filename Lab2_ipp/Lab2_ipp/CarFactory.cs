using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_ipp
{
    class CarFactory
    {
        private static Dictionary<string, Car> storedObjects = new Dictionary<string, Car>();

        public static Car getNiva()
        {
            if(!storedObjects.ContainsKey("niva"))
            {
                storedObjects["niva"] = new Niva();
            }
            return storedObjects["niva"];
        }
        public static Car getLuxuryNiva()
        {
            if (!storedObjects.ContainsKey("luxuryniva"))
            {
                storedObjects["luxuryniva"] = new LuxuryCarDecorator(new Niva());
            }
            return storedObjects["luxuryniva"];
        }
        public static Car getSportNiva()
        {
            if (!storedObjects.ContainsKey("sportniva"))
            {
                storedObjects["sportniva"] = new SportCarDecorator(new Niva());
            }
            return storedObjects["sportniva"];
        }
        public static Car getMercedes()
        {
            if (!storedObjects.ContainsKey("mercedes"))
            {
                storedObjects["mercedes"] = new Mercedes();
            }
            return storedObjects["mercedes"];
        }
        public static Car getLuxuryMercedes()
        {
            if (!storedObjects.ContainsKey("luxurymercedes"))
            {
                storedObjects["luxurymercedes"] = new LuxuryCarDecorator(new Mercedes());
            }
            return storedObjects["luxurymercedes"];
        }
        public static Car getSportMerecedes()
        {
            if (!storedObjects.ContainsKey("sportmercedes"))
            {
                storedObjects["sportmercedes"] = new SportCarDecorator(new Mercedes());
            }
            return storedObjects["sportmercedes"];
        }
    }
}
