﻿using System;
using System.IO;

namespace HtmlConvertor.Helpers
{
    public static class PathHelper
    {
        public static bool IsPathExist(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            return Directory.Exists(path);
        }
    }
}