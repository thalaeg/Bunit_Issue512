using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunit_Issue512
{
    public class ButtonComponent : ComponentBase
    {
        [CascadingParameter] public DivExample CascadedDiv { get; set; } = default!;
        [CascadingParameter] public TemplateExample CascadedTemplate { get; set; } = default!;

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(1, "button");
            builder.CloseElement();
        }
    }
}
