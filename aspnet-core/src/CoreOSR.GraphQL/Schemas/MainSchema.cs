using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using CoreOSR.Queries.Container;

namespace CoreOSR.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}