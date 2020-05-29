using GraphQL.Types;
using graphl_core_api.Entities;
namespace graphl_core_api.Queries.Types
{
    public class CommentType  : ObjectGraphType<Comment>
    {
        public CommentType ()
        {
            Field(x => x.Count);
            Field(x => x.Description);
            Field(x => x.Url);
        }
    }
}