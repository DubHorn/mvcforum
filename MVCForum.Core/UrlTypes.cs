﻿namespace MvcForum.Core
{
    using System.Web;
    using Constants;
    using Models.Enums;

    public static class UrlTypes
    {
        public static string UrlTypeName(UrlType e)
        {
            switch (e)
            {
                case UrlType.Topic:
                    return SiteConstants.Instance.TopicUrlIdentifier;
                case UrlType.Member:
                    return SiteConstants.Instance.MemberUrlIdentifier;
                case UrlType.Tag:
                    return SiteConstants.Instance.TagsUrlIdentifier;
                default:
                    return SiteConstants.Instance.CategoryUrlIdentifier;
            }
        }

        public static string GenerateUrl(UrlType e, string slug)
        {
            return VirtualPathUtility.ToAbsolute(
                $"~/{UrlTypeName(e)}/{HttpUtility.UrlEncode(HttpUtility.HtmlDecode(slug))}/");
        }

        public static string GenerateFileUrl(string filePath)
        {
            return VirtualPathUtility.ToAbsolute(filePath);
        }
    }
}