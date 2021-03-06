﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Smeedee.Client.Web.Serialization;
using Smeedee.DomainModel.Framework;
using Smeedee.DomainModel.Framework.Logging;
using Smeedee.DomainModel.SourceControl;
using Smeedee.Integration.Database.DomainModel.Repositories;

namespace Smeedee.Client.Web.Services
{
    [ServiceContract(Namespace = "http://smeedee.org")]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    //[UseReferenceTrackingSerializer]
    public class ChangesetRepositoryService
    {
        private readonly ChangesetDatabaseRepository repository; 

        public ChangesetRepositoryService()
        {
            repository = new ChangesetDatabaseRepository(DefaultSessionFactory.Instance);
        }

        [OperationContract]
        [ServiceKnownType(typeof(Specification<Changeset>))]
        [ServiceKnownType(typeof(AllChangesetsSpecification))]
        [ServiceKnownType(typeof(ChangesetsForUserSpecification))]
        [ServiceKnownType(typeof(ChangesetsAfterRevisionSpecification))]
        [ServiceKnownType(typeof(AllSpecification<Changeset>))]
        public IEnumerable<Changeset> Get(Specification<Changeset> specification)
        {
            IEnumerable<Changeset> result = new List<Changeset>();
            try
            {
                result = repository.Get(specification).ToList();
            }
            catch (Exception exception)
            {
                ILog logger = new Logger(new LogEntryDatabaseRepository(DefaultSessionFactory.Instance));
                logger.WriteEntry(new ErrorLogEntry(this.GetType().ToString(), exception.ToString()));
            }

            return result;
        }

    }
}
