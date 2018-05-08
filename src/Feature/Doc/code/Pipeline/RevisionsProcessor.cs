﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;

namespace SF.Feature.Doc.Pipeline
{
    public class RevisionsProcessor : BaseDocProcessor
    {
        public override void ConfigureSection(Item item)
        {
            this.SectionName = string.Empty;
            this.IncludeInTOC = false;
            this.SectionContent = RenderPartialView("/Views/Docs/Revisions.cshtml", item);
        }
    }
}