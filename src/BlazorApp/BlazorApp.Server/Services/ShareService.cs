﻿using VijayAnand.MauiToolkit.Core.Services;

namespace BlazorApp.Server.Services
{
    public class ShareService : IShareService
    {
        public Task ShareText(string title, string text)
        {
            throw new NotImplementedException();
        }

        public Task ShareUri(string title, string text, string url)
        {
            throw new NotImplementedException();
        }
    }
}