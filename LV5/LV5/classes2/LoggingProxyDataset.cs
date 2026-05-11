using LV5.interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5.classes2
{
    internal class LoggingProxyDataset:IDataset
    {
        private IDataset dataset;

        public LoggingProxyDataset(IDataset dataset)
        {
            this.dataset = dataset;
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            // Logiranje prije samog dohvaćanja podataka
            ConsoleLogger.Instance.Log("Započeto dohvaćanje podataka iz objekta Dataset.");

            var data = dataset.GetData();

            // Logiranje nakon uspješnog dohvaćanja
            ConsoleLogger.Instance.Log($"Podaci uspješno dohvaćeni. Broj redaka: {data.Count}");

            return data;
        }
    }
}
