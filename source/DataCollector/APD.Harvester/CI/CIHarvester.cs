﻿#region File header

// <copyright>
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
// </copyright> 
// 
// <contactinfo>
// The project webpage is located at http://agileprojectdashboard.org/
// which contains all the neccessary information.
// </contactinfo>
// 
// <author>Your Name</author>
// <email>your@email.com</email>
// <date>2009-MM-DD</date>

#endregion

using System;
using System.Collections.Generic;
using System.Linq;

using APD.DomainModel.CI;
using APD.DomainModel.Framework;
using APD.Harvester.Framework;
using APD.Harvester.SourceControl.Factories;
using APD.DomainModel.Config;


namespace APD.Harvester.CI
{
    public class CIHarvester : AbstractHarvester
    {
        private const string CI_CONFIG_NAME = "ci";

        private IAssembleRepository<CIServer> repositoryFactory;
        private IPersistDomainModels<CIServer> databasePersister;
        private IRepository<Configuration> configurationRepository;

        public override string Name
        {
            get { return "Continuous Integration Harvester"; }
        }

        public CIHarvester(IAssembleRepository<CIServer> repositoryFactory,
                           IPersistDomainModels<CIServer> databasePersister,
                           IRepository<Configuration> configurationRepository)
        {
            if (repositoryFactory == null)
                throw new ArgumentNullException("ciServerSourceRepository");

            if (databasePersister == null)
                throw new ArgumentNullException("databasePersister");

            if (configurationRepository == null)
                throw new ArgumentNullException("configurationRepository");

            this.repositoryFactory = repositoryFactory;
            this.databasePersister = databasePersister;
            this.configurationRepository = configurationRepository;
        }

        public override void DispatchDataHarvesting()
        {
            var ciConfiguration =
                configurationRepository.Get(new ConfigurationByName(CI_CONFIG_NAME)).SingleOrDefault();

            if (ciConfiguration != null)
            {
                var sourceRepository = repositoryFactory.Assemble(ciConfiguration);
                var data = sourceRepository.Get(new AllSpecification<CIServer>());
                databasePersister.Save(data);
            }
            else
                Console.WriteLine("Continuous Integration not configured");

            //IEnumerable<CIServer> fetchedServers = projectInfoRepository.Get(new AllSpecification<CIServer>());

            //foreach (var server in fetchedServers)
            //{
            //    databasePersister.Save(server);
            //}

        }

    }
}