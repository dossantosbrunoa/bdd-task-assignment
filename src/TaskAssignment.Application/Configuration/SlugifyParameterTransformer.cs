using System.Text.RegularExpressions;

namespace TaskAssignment.Application.Configuration
{
    public class SlugifyParameterTransformer : IOutboundParameterTransformer
    {
        public string? TransformOutbound(object? value)
        {
            if(value == null)
            {
                return null;
            }

            var stringValue = value.ToString() ?? "";

            return Regex.Replace(stringValue, "([a-z])([A-Z])", "$1-$2").ToLower();
        }
    }
}
