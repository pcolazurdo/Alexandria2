using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexandriaCLI.Domain;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlexandriaCLITest
{
    [TestClass]
    class HashStoreFactory_Test
    {
        private ISessionFactory _sessionFactory;
        private Configuration _configuration;

        [TestInitialize]
        public void TestFixtureSetUp()
        {
            _configuration = new Configuration();
            _configuration.Configure();
            _configuration.AddAssembly(typeof(HashStore).Assembly);
            _sessionFactory = _configuration.BuildSessionFactory();
        }
}