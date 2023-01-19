using System.Collections.Generic;
using HtmlAgilityPack;
using System.Linq;
using System;

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
                var network = new Network.Network();
                network.SendRequest(Network.Address.GetMarketInfoAddress());

                if (network.ResponseStatus != "OK")
                    throw new Exception("TseTmc Dosn't Correct Response.");

                DeserializeResponse(network.ResponseResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DeserializeResponse(string htmlResponse)
        {
            try
            {
                if (htmlResponse == null || string.IsNullOrWhiteSpace(htmlResponse))
                    return;
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(htmlResponse);
                var nodes = htmlDoc.DocumentNode.SelectNodes("//td").ToList();

                ReadMarketStatus(nodes);
                ReadOverallIndex(nodes);
                ReadEqualWeightIndex(nodes);
                ReadMarketValue(nodes);
                ReadTransactionCount(nodes);
                ReadTransactionVolume(nodes);
                ReadTransactionValue(nodes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ReadTransactionValue(List<HtmlNode> nodes)
        {
            try
            {
                _TransactionValue = nodes[13].InnerText;
            }
            catch (Exception)
            {
                _TransactionValue = "Error to read.";
            }
        }

        private void ReadTransactionVolume(List<HtmlNode> nodes)
        {
            try
            {
                _TransactionVolume = nodes[15].InnerText;
            }
            catch (Exception)
            {
                _TransactionCount = "Error to read.";
            }
        }

        private void ReadTransactionCount(List<HtmlNode> nodes)
        {
            try
            {
                _TransactionCount = nodes[11].InnerText;
            }
            catch (Exception)
            {
                _TransactionCount = "Error to read.";
            }
        }

        private void ReadMarketValue(List<HtmlNode> nodes)
        {
            try
            {
                _MarketValue = nodes[7].InnerText;
            }
            catch (Exception)
            {
                _MarketValue = "Error to read.";
            }
        }

        private void ReadEqualWeightIndex(List<HtmlNode> nodes)
        {
            try
            {
                var splited = nodes[5].InnerText.Split(' ');
                _EqualWeightIndex = splited[0];
                _EqualWeightIndexChange = splited[1];
            }
            catch (Exception)
            {
                _EqualWeightIndex = "Error to read.";
                _EqualWeightIndexChange = "Error to read.";
            }
        }

        private void ReadOverallIndex(List<HtmlNode> nodes)
        {
            try
            {
                var splited = nodes[3].InnerText.Split(' ');
                _OverallIndex = splited[0];
                _OverallIndexChange = splited[1];
            }
            catch (Exception)
            {
                _OverallIndex = "Error to read.";
                _OverallIndexChange = "Error to read.";
            }
        }

        private void ReadMarketStatus(List<HtmlNode> nodes)
        {
            try
            {
                _MarketStatus = nodes[1].InnerText.Substring(0, nodes[1].InnerText.Length - 6);
            }
            catch (Exception)
            {
                _MarketStatus = "Error to read.";
            }
        }
    }
}
