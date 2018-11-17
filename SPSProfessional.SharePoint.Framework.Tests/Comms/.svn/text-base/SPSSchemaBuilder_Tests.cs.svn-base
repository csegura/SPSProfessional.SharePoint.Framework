using NUnit.Framework;
using SPSProfessional.SharePoint.Framework.Comms;

namespace SPSProfessional.SharePoint.Framework.Tests.Comms
{
    public class SPSSchemaBuilderImplementation : SPSSchemaBuilder
    {
    }

    [TestFixture]
    public class SPSSchemaBuilder_Tests
    {
        [Test]
        public void Constructor()
        {
            SPSSchemaBuilderImplementation schemaBuilder;

            using (schemaBuilder = new SPSSchemaBuilderImplementation())
            {
                Assert.IsNotNull(schemaBuilder);
                Assert.IsNotNull(schemaBuilder.Schema);
                Assert.IsNotNull(schemaBuilder.Row);
                Assert.IsNotNull(schemaBuilder.BuilderTable);
                Assert.IsNotNull(schemaBuilder.GetDataView());
            }
        }       
    }
}