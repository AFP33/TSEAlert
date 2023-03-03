using Microsoft.Toolkit.Uwp.Notifications;
using System.Windows.Forms;
using System.Globalization;
using TSEAlert.Handler;
using System.Threading;
using TSEAlert.Models;
using System.Linq;
using System;
using Tse;

namespace TSEAlert.Service
{
    internal class Core
    {
        private Label _lblStatus { get; set; }
        public Core(Label lblStatus)
        {
            _lblStatus = lblStatus;
        }

        public void Run()
        {
            try
            {
                while (true)
                {
                    if (!(bool)TSEAlert.Properties.Settings.Default["MainService"]) // if Main Serice is Disable
                    {
                        _lblStatus.Invoke(new Action(() =>
                        {
                            _lblStatus.Text = "Main Service is stopped.";
                        }));
                        Thread.Sleep(TimeSpan.FromSeconds(Convert.ToInt32(TSEAlert.Properties.Settings.Default["ServiceDuration"])));
                        continue;
                    }
                    // Main Service is Active
                    _lblStatus.Invoke(new Action(() =>
                    {
                        _lblStatus.Text = "";
                    }));
                    var dbHandler = new AlertHandler();
                    var alerts = dbHandler.Get().Where(e => e.Status == true).ToList();
                    foreach (var alert in alerts)
                    {
                        var tse = new TSE();
                        var stock = tse.GetMarketHandler().FindStock(alert.Symbol).Where(x => x.Name == alert.Name && x.Symbol == alert.Symbol && x.TseCode == alert.TseCode).FirstOrDefault();
                        if (stock == null)
                            continue;
                        var lastPrice = tse.GetStockHandler(stock).BriefInformations().LastTransaction;

                        switch (alert.AlertType)
                        {
                            case Models.AlertType.RISING_PRICE:
                                if (lastPrice >= Convert.ToInt32(alert.Price))
                                    ActiveAlert(alert, Models.AlertType.RISING_PRICE);
                                break;
                            case Models.AlertType.REDUCING_PRICE:
                                if (lastPrice <= Convert.ToInt32(alert.Price))
                                    ActiveAlert(alert, Models.AlertType.REDUCING_PRICE);
                                break;
                            default:
                                break;
                        }
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(Convert.ToInt32(TSEAlert.Properties.Settings.Default["ServiceDuration"])));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ActiveAlert(Models.Alert alert, Models.AlertType alertType)
        {
            try
            {
                var dbHandler = new AlertHandler();
                alert.Status = false;
                dbHandler.Update(alert);
                ShowToastNotification(alert.Symbol);
                GenerateAlertMessage(alert, alertType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerateAlertMessage(Alert alert, Models.AlertType alertType)
        {
            try
            {
                string message = "- هشدار ";
                switch (alertType)
                {
                    case Models.AlertType.RISING_PRICE:
                        message += "بیشتر شدن سهم ";
                        break;
                    case Models.AlertType.REDUCING_PRICE:
                        message += "کمتر شدن سهم ";
                        break;
                    default:
                        break;
                }
                message += alert.Symbol + " از قیمت " + alert.Price + " فعال شده است" + "(" + GetCurrentDate() + ").";
                new MessageHandler().Add(new Models.Message
                {
                    Content = message,
                    Date = DateTime.Today
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ShowToastNotification(string stockName)
        {
            try
            {
                if (!(bool)TSEAlert.Properties.Settings.Default["Notification"])
                    return;

                new ToastContentBuilder()
                    .AddText("یک هشدار فعال شد")
                    .AddText("هشدار مربوط به سهم " + stockName + " فعال شده است.")
                    .Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GetCurrentDate()
        {
            try
            {
                var today = DateTime.Today;
                PersianCalendar persianCalendar = new PersianCalendar();
                return string.Format("{0}/{1}/{2}",
                    persianCalendar.GetYear(today),
                    persianCalendar.GetMonth(today),
                    persianCalendar.GetDayOfMonth(today));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
