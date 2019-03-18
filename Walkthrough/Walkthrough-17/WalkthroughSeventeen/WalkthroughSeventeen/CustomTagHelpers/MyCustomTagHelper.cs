﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WalkthroughSeventeen.CustomTagHelpers
{
    [HtmlTargetElement("my-first-tag-helper")]
    public class MyCustomTagHelper : TagHelper
    {
        public string Name { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "CustomTagHelper";
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            sb.AppendFormat("<span>Hi! {0}</span>", this.Name);

            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}
