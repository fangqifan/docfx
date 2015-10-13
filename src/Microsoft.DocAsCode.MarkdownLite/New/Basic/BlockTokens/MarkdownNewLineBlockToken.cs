﻿namespace Microsoft.DocAsCode.MarkdownLite
{
    public class MarkdownNewLineBlockToken : IMarkdownToken
    {
        public MarkdownNewLineBlockToken(IMarkdownRule rule, string content)
        {
            Rule = rule;
            Content = content;
        }

        public IMarkdownRule Rule { get; }

        public string Content { get; }
    }
}