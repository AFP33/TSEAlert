using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using TSEAlert.Handler;
using System;

namespace TSEAlert.Service
{
    internal class MarketInfo
    {
        private DataGridView _dgvMarketInfo { get; set; }
        private Label _lblStatus { get; set; }

        public MarketInfo(DataGridView dgvMarketInfo, Label lblStatus)
        {
            _dgvMarketInfo = dgvMarketInfo;
            _lblStatus = lblStatus;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    if (!(bool)TSEAlert.Properties.Settings.Default["MarketInfoService"]) // service is disable
                    {
                        _lblStatus.Invoke(new Action(() =>
                        {
                            _lblStatus.Text = "Market Information Service is stopped.";
                        }));
                        _dgvMarketInfo.Invoke(new Action(() =>
                        {
                            _dgvMarketInfo.DataSource = new List<MarketInfoBindingObject>();
                        }));
                        Thread.Sleep(TimeSpan.FromSeconds(Convert.ToInt32(TSEAlert.Properties.Settings.Default["ServiceDuration"])));
                        continue;
                    }
                    // service is active
                    _lblStatus.Invoke(new Action(() =>
                    {
                        _lblStatus.Text = "";
                    }));
                    var miHandler = new MarketInfoHandler();
                    List<MarketInfoBindingObject> marketInfos = new List<MarketInfoBindingObject>();
                    marketInfos.Add(new MarketInfoBindingObject() { FeatureName = "وضعیت بازار", FeatureValue = miHandler.MarketStatus });
                    marketInfos.Add(new MarketInfoBindingObject() { FeatureName = "شاخص کل", FeatureValue = miHandler.OverallIndex });
                    marketInfos.Add(new MarketInfoBindingObject() { FeatureName = "شاخص کل(هم وزن)", FeatureValue = miHandler.EqualWeightIndex });
                    marketInfos.Add(new MarketInfoBindingObject() { FeatureName = "ارزش بازار", FeatureValue = miHandler.MarketValue });
                    marketInfos.Add(new MarketInfoBindingObject() { FeatureName = "تعداد معاملات", FeatureValue = miHandler.TransactionCount });
                    marketInfos.Add(new MarketInfoBindingObject() { FeatureName = "ارزش معاملات", FeatureValue = miHandler.TransactionValue });
                    marketInfos.Add(new MarketInfoBindingObject() { FeatureName = "حجم معاملات", FeatureValue = miHandler.TransactionVolume });

                    _dgvMarketInfo.Invoke(new Action(() => _dgvMarketInfo.DataSource = marketInfos));

                    Thread.Sleep(TimeSpan.FromSeconds(Convert.ToInt32(TSEAlert.Properties.Settings.Default["ServiceDuration"])));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }

    public class MarketInfoBindingObject
    {
        public string FeatureName { get; set; }
        public string FeatureValue { get; set; }
    }
}
