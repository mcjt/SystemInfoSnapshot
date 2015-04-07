﻿namespace SystemInfoSnapshot.Reports
{
    public sealed class Version : Report
    {
        public const string TemplateVar = "<!--[VERSION]-->";

        public override string GetTemplateVar()
        {
            return TemplateVar;
        }

        protected override void Build()
        {
            Html = ApplicationInfo.Version.ToString();
        }
    }
}
