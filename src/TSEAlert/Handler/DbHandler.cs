using System.Collections.Generic;
using TSEAlert.Models;
using TSEAlert.DAL;
using System.Linq;

namespace TSEAlert.Handler
{
    public class DbHandler
    {
        private DbContextFactory _dbContext { get; set; }

        public DbHandler()
        {
            _dbContext = new DbContextFactory();
        }

        public DbHandler(DbContextFactory dbContext)
        {
            _dbContext = dbContext;
        }

        #region Alert Handlers

        public List<Alert> GetAlerts()
        {
            try
            {
                return _dbContext.Alerts.ToList();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public Alert GetAlert(int id)
        {
            try
            {
                var alert = _dbContext.Alerts.SingleOrDefault(e => e.Id == id);
                return alert;

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void AddAlert(Alert alert)
        {
            try
            {
                _dbContext.Alerts.Add(alert);
                _dbContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAlert(int alertId, Alert newAlert)
        {
            try
            {
                var alert = _dbContext.Alerts.SingleOrDefault(e => e.Id == alertId);
                if (alert != null)
                {
                    alert.Status = newAlert.Status;
                    alert.Price = newAlert.Price;
                    _dbContext.SaveChanges();
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveAlert(Alert alert)
        {
            try
            {
                _dbContext.Alerts.Remove(alert);
                _dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveAlert(int id)
        {
            try
            {
                var alert = _dbContext.Alerts.SingleOrDefault(x => x.Id == id);
                if (alert != null)
                {
                    _dbContext.Alerts.Remove(alert);
                    _dbContext.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveAlert(List<Alert> alerts)
        {
            try
            {
                _dbContext.Alerts.RemoveRange(alerts);
                _dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Stock Handlers

        public List<Stock> GetStocks()
        {
            try
            {
                return _dbContext.Stocks.ToList();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public Stock GetStock(int stockId)
        {
            try
            {
                return _dbContext.Stocks.SingleOrDefault(e => e.Id == stockId);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void AddStock(Stock stock)
        {
            try
            {
                _dbContext.Stocks.Add(stock);
                _dbContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveStock(Stock stock)
        {
            try
            {
                _dbContext.Stocks.Remove(stock);
                _dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveStock(int id)
        {
            try
            {
                var stock = _dbContext.Stocks.SingleOrDefault(x => x.Id == id);
                if (stock != null)
                {
                    _dbContext.Stocks.Remove(stock);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveStock(List<Stock> stocks)
        {
            try
            {
                _dbContext.Stocks.RemoveRange(stocks);
                _dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateStock(Stock stock)
        {
            try
            {
                var oldStock = _dbContext.Stocks.SingleOrDefault(x => x.Id == stock.Id);
                if (oldStock != null)
                {
                    oldStock.Symbol = stock.Symbol;
                    oldStock.TseCode = stock.TseCode;
                    oldStock.Name = stock.Name;
                    oldStock.OtherData = stock.OtherData;
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Alert Message Handlers
        public List<AlertMessage> GetAlertMessages()
        {
            try
            {
                return _dbContext.AlertMessages.ToList();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public AlertMessage GetAlertMessage(int id)
        {
            try
            {
                return _dbContext.AlertMessages.SingleOrDefault(x => x.Id == id);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void AddAlertMessage(AlertMessage alertMessage)
        {
            try
            {
                _dbContext.AlertMessages.Add(alertMessage);
                _dbContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateAlertMessage(AlertMessage alertMessage)
        {
            try
            {
                var oldAlertMessage = _dbContext.AlertMessages.SingleOrDefault(x => x.Id == alertMessage.Id);
                if (oldAlertMessage != null)
                {
                    oldAlertMessage.Message = alertMessage.Message;
                    oldAlertMessage.Date = alertMessage.Date;
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveAlertMessages(List<AlertMessage> alertMessages)
        {
            try
            {
                _dbContext.AlertMessages.RemoveRange(alertMessages);
                _dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveAlertMessages()
        {
            try
            {
                _dbContext.AlertMessages.RemoveRange(_dbContext.AlertMessages.ToList());
                _dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveAlertMessages(int id)
        {
            try
            {
                var alertMessage = _dbContext.AlertMessages.SingleOrDefault(x => x.Id == id);
                if (alertMessage != null)
                {
                    _dbContext.AlertMessages.Remove(alertMessage);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        #endregion



    }
}
