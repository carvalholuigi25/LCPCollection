using LCPCollection.Shared.Classes;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace LCPCollection.Server.Filters
{
    public class ParameterFilter : IParameterFilter
    {
        public ParameterFilter()
        {
        }

        public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
        {
            var strcomp = StringComparison.InvariantCultureIgnoreCase;

            if (parameter.Name.Equals("SortBy", strcomp))
            {
                parameter.Schema.Enum = typeof(SharedDataCls).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).Select(x => new OpenApiString(x.Name)).ToList<IOpenApiAny>();
            }
        }
    }
}
