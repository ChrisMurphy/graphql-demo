using GraphQL.Types;

namespace GraphQL.Api.Models
{
    public class DemoQuery : ObjectGraphType
    {
        public DemoQuery()
        {
            Field<BookType>(
              "book",
              resolve: context => new Book { Id = 1, Name = "The Jungle Book" }
            );
        }
    }
}
