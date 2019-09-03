using System;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Abstractions;
using Sitecore.DependencyInjection;
using Sitecore.Diagnostics;
using Sitecore.Resources.Media;

namespace Sitecore.Support.Resources.Media
{
  public class ResizeProcessor: Sitecore.Resources.Media.ResizeProcessor
  {
    public ResizeProcessor() : base(ServiceLocator.ServiceProvider.GetRequiredService<BaseMediaManager>(),
      ServiceLocator.ServiceProvider.GetRequiredService<BaseLog>())
    {
    }

    public new void Process(GetMediaStreamPipelineArgs args)
    {
      Assert.ArgumentNotNull(args, "args");
      if (!string.Equals(args.MediaData.MimeType, "image/gif", StringComparison.OrdinalIgnoreCase))
      {
        base.Process(args);
      }
    }
  }
}