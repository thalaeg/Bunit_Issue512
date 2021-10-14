using Bunit;
using Bunit_Issue512;
using Xunit;

namespace Bunit_Issue512.Tests;
public class ExampleTests : TestContext
{
    [Fact]
    public void DivWorkingTest1()
    {
        var div = RenderComponent<DivExample>();
        var cut = RenderComponent<ButtonComponent>(parameters => parameters
            .AddCascadingValue(div.Instance)
        );

        var button = cut.Find("button");
        // do stuff with button
    }

    [Fact]
    public void DivWorkingTest2()
    {
        var div = RenderComponent<DivExample>(parameters => parameters
            .AddChildContent<ButtonComponent>()
        );

        var button = div.Find("button");
        // do stuff with button
    }

    [Fact]
    public void TemplateWorkingTest1()
    {
        var div = RenderComponent<TemplateExample>();
        var cut = RenderComponent<ButtonComponent>(parameters => parameters
            .AddCascadingValue(div.Instance)
        );

        var button = cut.Find("button");
        // do stuff with button
    }

    [Fact]
    public void TemplateBrokenTest()
    {
        var div = RenderComponent<TemplateExample>(parameters => parameters
            .AddChildContent<ButtonComponent>()
        );

        var button = div.Find("button"); // Bunit.ElementNotFoundException : No elements were found that matches the selector 'button'
        // do stuff with button
    }
}
