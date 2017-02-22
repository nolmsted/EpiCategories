﻿using System.Collections.Generic;
using System.Globalization;
using EPiServer.Core;

namespace Geta.EpiCategories
{
    public interface IContentInCategoryLocator
    {
        IEnumerable<T> GetDescendents<T>(ContentReference contentLink, ContentCategoryList categories) where T : ICategoryContent;

        IEnumerable<T> GetDescendents<T>(ContentReference contentLink, ContentCategoryList categories, CultureInfo culture) where T : ICategoryContent;

        IEnumerable<T> GetDescendents<T>(ContentReference contentLink, ContentCategoryList categories, LoaderOptions loaderOptions) where T : ICategoryContent;

        IEnumerable<T> GetChildren<T>(ContentReference contentLink, ContentCategoryList categories) where T : ICategoryContent;

        IEnumerable<T> GetChildren<T>(ContentReference contentLink, ContentCategoryList categories, CultureInfo culture) where T : ICategoryContent;

        IEnumerable<T> GetChildren<T>(ContentReference contentLink, ContentCategoryList categories, LoaderOptions loaderOptions) where T : ICategoryContent;
    }
}