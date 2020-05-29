using GraphQL;

namespace graphl_core_api.Controllers
{
   public class GraphQlQuery{
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public Inputs Variables { get; set; }
    }
}