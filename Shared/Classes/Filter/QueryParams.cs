using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LCPCollection.Shared.Classes.Filter;

public class QueryParams
{
    [DisplayName("page")]
    [DefaultValue(1)]
    public int Page { get; set; }

    [DisplayName("pagesize")]
    [DefaultValue(10)]
    public int PageSize { get; set; }

    [DisplayName("sortorder")]
    [EnumDataType(typeof(SortEnum))]
    [DefaultValue(SortEnum.ASC)]
    public SortEnum? SortOrder { get; set; }

    [DisplayName("sortby")]
    [DefaultValue("Id")]
    public string? SortBy { get; set; }

    [DisplayName("search")]
    [DefaultValue("")]
    public string? Search { get; set; }

    [DisplayName("operator")]
    [EnumDataType(typeof(FilterOperatorEnum))]
    [DefaultValue(FilterOperatorEnum.Contains)]
    public FilterOperatorEnum? Operator { get; set; }
}

public class QueryParamsRes<T> where T : class
{
    public List<T>? Data { get; set; } = new List<T>();
    public QueryParams? QueryParams { get; set; }
    public int Count { get; set; }
    public int TotalCount { get; set; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SortEnum
{
    [Description("asc")] ASC,
    [Description("desc")] DESC
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FilterOperatorEnum
{
    [Description("Equals")] Equals,
    [Description("DoesntEqual")] DoesntEqual,
    [Description("GreaterThan")] GreaterThan,
    [Description("GreaterThanOrEqual")] GreaterThanOrEqual,
    [Description("LessThan")] LessThan,
    [Description("LessThanOrEqual")] LessThanOrEqual,
    [Description("Contains")] Contains,
    [Description("NotContains")] NotContains,
    [Description("StartsWith")] StartsWith,
    [Description("EndsWith")] EndsWith,
    [Description("IsEmpty")] IsEmpty,
    [Description("IsNotEmpty")] IsNotEmpty
}