﻿using System;
using System.Linq;
using NzbDrone.Common.Extensions;
using NzbDrone.Core.MediaFiles.MediaInfo;
using NzbDrone.Core.Parser.Model;
using NzbDrone.Core.Qualities;

namespace NzbDrone.Core.Parser.Augmenters
{
    public class AugmentWithFileSize : IAugmentParsedMovieInfo

    {
        public Type HelperType
        {
            get
            {
                return typeof(LocalMovie);
            }
        }

        public ParsedMovieInfo AugmentMovieInfo(ParsedMovieInfo movieInfo, object helper)
        {
            if (helper is LocalMovie localMovie && localMovie.Size != 0)
            {
                movieInfo.ExtraInfo["Size"] = localMovie.Size;
            }

            return movieInfo;
        }
    }
}
