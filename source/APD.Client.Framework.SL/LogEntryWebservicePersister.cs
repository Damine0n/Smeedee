﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using APD.Client.Framework.SL;
using APD.Client.Framework.SL.LogEntryWebserviceRepository;
using APD.DomainModel.Framework;

using LogEntry=APD.DomainModel.Framework.Logging.LogEntry;


namespace APD.Framework.SL.Logging
{
    public class LogEntryWebservicePersister : IPersistDomainModels<LogEntry>
    {
        LogEntryRepositoryServiceClient client = new LogEntryRepositoryServiceClient();
        
        public LogEntryWebservicePersister()
        {
            client.Endpoint.Address = 
                WebServiceEndpointResolver.ResolveDynamicEndpointAddress(client.Endpoint.Address);
        }
        
        #region IPersistDomainModels<LogEntryPersister> Members

        public void Save(LogEntry domainModel)
        {
            client.LogAsync(domainModel);
        }

        public void Save(System.Collections.Generic.IEnumerable<LogEntry> domainModels)
        {
            foreach (var model in domainModels)
            {
                client.LogAsync(model);
            }
        }

        #endregion
    }
}