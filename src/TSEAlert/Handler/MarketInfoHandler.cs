using System.Globalization;
using System;
using Tse;

namespace TSEAlert.Handler
{
    internal class MarketInfoHandler
    {
        private string _MarketStatus { get; set; }
        private string _OverallIndex { get; set; }
        private string _OverallIndexChange { get; set; }
        private string _EqualWeightIndex { get; set; }
        private string _EqualWeightIndexChange { get; set; }
        private string _MarketValue { get; set; }
        private string _TransactionCount { get; set; }
        private string _TransactionValue { get; set; }
        private string _TransactionVolume { get; set; }

        public MarketInfoHandler()
        {
            try
            {
                FetchData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string MarketStatus { get { return _MarketStatus; } }
        public string OverallIndex { get { return _OverallIndex; } }
        public string OverallIndexChange { get { return _OverallIndexChange; } }
        public string EqualWeightIndex { get { return _EqualWeightIndex; } }
        public string EqualWeightIndexChange { get { return _EqualWeightIndexChange; } }
        public string MarketValue { get { return _MarketValue; } }
        public string TransactionCount { get { return _TransactionCount; } }
        public string TransactionValue { get { return _TransactionValue; } }
        public string TransactionVolume { get { return _TransactionVolume; } }

        private void FetchData()
        {
            try
            {
                var tse = new TSE();
                var bourseAtGlance = tse.GetBourseHandler().BourseAtGlance();
                _TransactionValue = bourseAtGlance.TransactionValue.ToString("N0", new NumberFormatInfo() { NumberGroupSizes = new[] { 3 }, NumberGroupSeparator = "," });
                _TransactionVolume = bourseAtGlance.TransactionVolume.ToString("N0", new NumberFormatInfo() { NumberGroupSizes = new[] { 3 }, NumberGroupSeparator = "," });
                _TransactionCount = bourseAtGlance.TransactionCount.ToString();
                _MarketValue = bourseAtGlance.MarketValue.ToString("N0", new NumberFormatInfo() { NumberGroupSizes = new[] { 3 }, NumberGroupSeparator = "," });
                _EqualWeightIndex = bourseAtGlance.WeightIndex.ToString("N0", new NumberFormatInfo() { NumberGroupSizes = new[] { 3 }, NumberGroupSeparator = "," });
                _OverallIndex = bourseAtGlance.OverallIndex.ToString("N0", new NumberFormatInfo() { NumberGroupSizes = new[] { 3 }, NumberGroupSeparator = "," });
                _MarketStatus = bourseAtGlance.MarketStatus.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
