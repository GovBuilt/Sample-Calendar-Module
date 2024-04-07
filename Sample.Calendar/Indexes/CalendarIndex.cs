using OrchardCore.ContentManagement;
using YesSql.Indexes;

namespace Sample.Calendar.Indexes;

public class CalendarIndex : MapIndex
{
    public string ContentItemId { get; set; }
}

public class CalendarIndexProvider : IndexProvider<ContentItem>
{
    public override void Describe(DescribeContext<ContentItem> context)
    {
        throw new System.NotImplementedException();
    }
}
