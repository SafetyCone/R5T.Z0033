using System;

using R5T.R0008.Extensions;
using R5T.R0008.T000;
using R5T.T0131;


namespace R5T.Z0033
{
    [ValuesMarker]
    public partial interface ISteveJGordonLinks : IValuesMarker
    {
        /// <summary>
        /// <see href="https://www.stevejgordon.co.uk/aspnet-core-dependency-injection-what-is-the-iserviceprovider-and-how-is-it-built"/>
        /// </summary>
        public Link WhatIsIServiceProvider => "https://www.stevejgordon.co.uk/aspnet-core-dependency-injection-what-is-the-iserviceprovider-and-how-is-it-built".ToLink();
    }
}
