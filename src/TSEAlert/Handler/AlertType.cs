using System.Collections.Generic;
using System;

namespace TSEAlert.Handler
{
    internal static class AlertType
    {
        public static List<Tuple<TSEAlert.Models.AlertType, string>> GetAlertType()
        {
            try
            {
                List<Tuple<TSEAlert.Models.AlertType, string>> result = new List<Tuple<TSEAlert.Models.AlertType, string>>();

                result.Add(new Tuple<Models.AlertType, string>(TSEAlert.Models.AlertType.RISING_PRICE, "بیشتر شدن قیمت"));

                result.Add(new Tuple<Models.AlertType, string>(TSEAlert.Models.AlertType.REDUCING_PRICE, "کمتر شدن قیمت"));


                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetString(Models.AlertType? alertType)
        {
            try
            {
                var alertTypes = GetAlertType();
                foreach (var item in alertTypes)
                    if (item.Item1 == alertType)
                        return item.Item2;

                throw new Exception("Unable to Find AlertType.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Models.AlertType GetEnum(string alertType)
        {
            try
            {
                var alertTypes = GetAlertType();
                foreach (var item in alertTypes)
                    if (item.Item2 == alertType)
                        return item.Item1;

                throw new Exception("Unable to Find AlertType.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}
