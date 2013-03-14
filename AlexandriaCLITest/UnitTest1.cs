using System;
using AlexandriaCLI.Domain;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlexandriaCLITest
{
    [TestClass]
    public class GenerateSchema_Fixture
    {
        [TestMethod]    
        public void Can_generate_schema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(HashStore).Assembly);

            SchemaExport schema = new SchemaExport(cfg);
            schema.Execute(false, true, false);
        }
    }
}
