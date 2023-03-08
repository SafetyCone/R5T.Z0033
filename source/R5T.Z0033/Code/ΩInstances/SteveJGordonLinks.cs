using System;


namespace R5T.Z0033
{
    public class SteveJGordonLinks : ISteveJGordonLinks
    {
        #region Infrastructure

        public static ISteveJGordonLinks Instance { get; } = new SteveJGordonLinks();


        private SteveJGordonLinks()
        {
        }

        #endregion
    }
}
