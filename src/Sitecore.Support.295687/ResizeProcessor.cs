using Sitecore.Diagnostics;
using Sitecore.Resources.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Resources.Media
{
  public class ResizeProcessor: Sitecore.Resources.Media.ResizeProcessor
  {
    public void Process(GetMediaStreamPipelineArgs args)
    {
      Assert.ArgumentNotNull(args, "args");
      if (!string.Equals(args.MediaData.MimeType, "image/gif", StringComparison.OrdinalIgnoreCase))
      {
        base.Process(args);
      }
    }
  }
}