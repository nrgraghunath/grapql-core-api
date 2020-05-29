using GraphQL.Types;
using graphl_core_api.Entities;
namespace graphl_core_api.Queries.Types
{
   public class SNTypeType : EnumerationGraphType<SNType>
    {
        public SNTypeType()
        {
            Name = "SNTypeType";
        }
    }
}