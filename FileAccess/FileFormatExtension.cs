﻿

namespace CookieCookbook.FileAccess;

public static class FileFormatExtension
{
    public static string AsFileExtension(this FileFormat fileFormat) =>
        fileFormat == FileFormat.Json ? "json" : "txt";


}
