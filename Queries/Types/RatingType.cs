using GraphQL.Types;
using graphl_core_api.Entities;
namespace graphl_core_api.Queries.Types
{
    public class RatingType : ObjectGraphType<Rating>
    {
        public RatingType()
        {
            Field(x => x.Count);
            Field(x => x.Percent); 
        }
    } 
}