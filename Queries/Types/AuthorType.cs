using GraphQL.Types;
using graphl_core_api.Entities;
namespace graphl_core_api.Queries.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(x => x.Id).Description("Id of an author");
            Field(x => x.Name).Description("Name of an author");
            Field(x => x.Bio).Description("Bio description of an author");
            Field(x => x.ImgUrl).Description("Url of an author's profile picture");
            Field(x => x.ProfileUrl).Description("Link of an author's profile");
        }
    }
}