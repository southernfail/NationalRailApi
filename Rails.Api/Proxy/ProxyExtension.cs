using System;
using System.ServiceModel;

namespace Rails.Api.Proxy
{
    #region Client

    internal partial interface LDBServiceSoap : IDisposable
    {

    }

    internal partial class LDBServiceSoapClient
    {
        #region IDisposable implementation

        /// <summary>
        /// IDisposable.Dispose implementation, calls Dispose(true).
        /// </summary>
        void IDisposable.Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Dispose worker method. Handles graceful shutdown of the
        /// client even if it is an faulted state.
        /// </summary>
        /// <param name="disposing">Are we disposing (alternative
        /// is to be finalizing)</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                try
                {
                    if (State != CommunicationState.Faulted)
                    {
                        Close();
                    }
                }
                finally
                {
                    if (State != CommunicationState.Closed)
                    {
                        Abort();
                    }
                }
            }
        }

        /// <summary>
        /// Finalizer.
        /// </summary>
        ~LDBServiceSoapClient()
        {
            Dispose(false);
        }

        #endregion
    }


    #endregion

    #region Rquests
    /// <summary>
    /// Interface allowing generic handling of the access token, forms part of every request to the api. 
    /// </summary>
    internal interface IApiRequest
    {
        AccessToken Token { set; }
    }

    public interface IProxyRequest
    {
        string Crs { get; set; }
        int TimeOffset { get; set; }
        int TimeWindow { get; set; }
    }

    public interface IBoardRequest : IProxyRequest
    {
        ushort NumRows { get; set; }
        string FilterCrs { get; set; }
        FilterType FilterType { get; set; }
    }

    public interface IJourneyRequest
    {
        string ServiceID { get; set; }
    }

    public interface IDepartureRequest : IProxyRequest
    {
        string[] FilterList { get; set; }
    }

    internal partial class GetArrBoardWithDetailsRequest : IApiRequest, IBoardRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public ushort NumRows
        {
            get { return numRows; }
            set { numRows = value; }
        }
        public string Crs
        {
            get { return crs; }
            set { crs = value; }
        }
        public string FilterCrs
        {
            get { return filterCrs; }
            set { filterCrs = value; }
        }
        public FilterType FilterType
        {
            get { return filterType; }
            set { filterType = value; }
        }
        public int TimeOffset
        {
            get { return timeOffset; }
            set { timeOffset = value; }
        }
        public int TimeWindow
        {
            get { return timeWindow; }
            set { timeWindow = value; }
        }
    }

    internal partial class GetArrDepBoardWithDetailsRequest : IApiRequest, IBoardRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public ushort NumRows
        {
            get { return numRows; }
            set { numRows = value; }
        }
        public string Crs
        {
            get { return crs; }
            set { crs = value; }
        }
        public string FilterCrs
        {
            get { return filterCrs; }
            set { filterCrs = value; }
        }
        public FilterType FilterType
        {
            get { return filterType; }
            set { filterType = value; }
        }
        public int TimeOffset
        {
            get { return timeOffset; }
            set { timeOffset = value; }
        }
        public int TimeWindow
        {
            get { return timeWindow; }
            set { timeWindow = value; }
        }
    }

    internal partial class GetArrivalBoardRequest : IApiRequest, IBoardRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public ushort NumRows
        {
            get { return numRows; }
            set { numRows = value; }
        }
        public string Crs
        {
            get { return crs; }
            set { crs = value; }
        }
        public string FilterCrs
        {
            get { return filterCrs; }
            set { filterCrs = value; }
        }
        public FilterType FilterType
        {
            get { return filterType; }
            set { filterType = value; }
        }
        public int TimeOffset
        {
            get { return timeOffset; }
            set { timeOffset = value; }
        }
        public int TimeWindow
        {
            get { return timeWindow; }
            set { timeWindow = value; }
        }
    }

    internal partial class GetArrivalDepartureBoardRequest : IApiRequest, IBoardRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public ushort NumRows
        {
            get { return numRows; }
            set { numRows = value; }
        }
        public string Crs
        {
            get { return crs; }
            set { crs = value; }
        }
        public string FilterCrs
        {
            get { return filterCrs; }
            set { filterCrs = value; }
        }
        public FilterType FilterType
        {
            get { return filterType; }
            set { filterType = value; }
        }
        public int TimeOffset
        {
            get { return timeOffset; }
            set { timeOffset = value; }
        }
        public int TimeWindow
        {
            get { return timeWindow; }
            set { timeWindow = value; }
        }
    }

    internal partial class GetDepBoardWithDetailsRequest : IApiRequest, IBoardRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public ushort NumRows
        {
            get { return numRows; }
            set { numRows = value; }
        }
        public string Crs
        {
            get { return crs; }
            set { crs = value; }
        }
        public string FilterCrs
        {
            get { return filterCrs; }
            set { filterCrs = value; }
        }
        public FilterType FilterType
        {
            get { return filterType; }
            set { filterType = value; }
        }
        public int TimeOffset
        {
            get { return timeOffset; }
            set { timeOffset = value; }
        }
        public int TimeWindow
        {
            get { return timeWindow; }
            set { timeWindow = value; }
        }
    }

    internal partial class GetDepartureBoardRequest : IApiRequest, IBoardRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public ushort NumRows
        {
            get { return numRows; }
            set { numRows = value; }
        }
        public string Crs
        {
            get { return crs; }
            set { crs = value; }
        }
        public string FilterCrs
        {
            get { return filterCrs; }
            set { filterCrs = value; }
        }
        public FilterType FilterType
        {
            get { return filterType; }
            set { filterType = value; }
        }
        public int TimeOffset
        {
            get { return timeOffset; }
            set { timeOffset = value; }
        }
        public int TimeWindow
        {
            get { return timeWindow; }
            set { timeWindow = value; }
        }
    }

    internal partial class GetFastestDeparturesRequest : IApiRequest, IDepartureRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public string Crs
        {
            get { return crs; }
            set { crs = value; }
        }

        public string[] FilterList
        {
            get { return filterList; }
            set { filterList = value; }
        }

        public int TimeOffset
        {
            get { return timeOffset; }
            set { timeOffset = value; }
        }

        public int TimeWindow
        {
            get { return timeWindow; }
            set { timeWindow = value; }
        }
    }

    internal partial class GetFastestDeparturesWithDetailsRequest : IApiRequest, IProxyRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public string Crs
        {
            get { return crs; }
            set { crs = value; }
        }

        public string[] FilterList
        {
            get { return filterList; }
            set { filterList = value; }
        }

        public int TimeOffset
        {
            get { return timeOffset; }
            set { timeOffset = value; }
        }

        public int TimeWindow
        {
            get { return timeWindow; }
            set { timeWindow = value; }
        }
    }

    internal partial class GetNextDeparturesRequest : IApiRequest, IDepartureRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public string Crs
        {
            get { return crs; }
            set { crs = value; }
        }

        public string[] FilterList
        {
            get { return filterList; }
            set { filterList = value; }
        }

        public int TimeOffset
        {
            get { return timeOffset; }
            set { timeOffset = value; }
        }

        public int TimeWindow
        {
            get { return timeWindow; }
            set { timeWindow = value; }
        }
    }

    internal partial class GetNextDeparturesWithDetailsRequest : IApiRequest, IProxyRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public string Crs
        {
            get { return crs; }
            set { crs = value; }
        }

        public string[] FilterList
        {
            get { return filterList; }
            set { filterList = value; }
        }

        public int TimeOffset
        {
            get { return timeOffset; }
            set { timeOffset = value; }
        }

        public int TimeWindow
        {
            get { return timeWindow; }
            set { timeWindow = value; }
        }
    }

    internal partial class GetServiceDetailsRequest : IApiRequest, IJourneyRequest
    {

        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }

        public string ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }
    }
    #endregion



}
