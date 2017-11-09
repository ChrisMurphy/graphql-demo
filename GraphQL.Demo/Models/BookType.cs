using GraphQL.Types;

namespace GraphQL.Api.Models
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Field(x => x.Id).Description("The Id of the Book.");
            Field(x => x.Name, nullable: true).Description("The name of the Book.");
        }
    }
}
