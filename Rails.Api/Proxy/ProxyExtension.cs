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

    internal partial class GetArrBoardWithDetailsRequest : IApiRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }

    internal partial class GetArrDepBoardWithDetailsRequest : IApiRequest
    {

        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }

    internal partial class GetArrivalBoardRequest : IApiRequest
    {

        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }

    internal partial class GetArrivalDepartureBoardRequest : IApiRequest
    {

        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }

    internal partial class GetDepBoardWithDetailsRequest : IApiRequest
    {

        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }

    internal partial class GetDepartureBoardRequest : IApiRequest
    {

        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }

    internal partial class GetFastestDeparturesRequest : IApiRequest
    {

        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }

    internal partial class GetFastestDeparturesWithDetailsRequest : IApiRequest
    {

        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }

    internal partial class GetNextDeparturesRequest : IApiRequest
    {

        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }

    internal partial class GetNextDeparturesWithDetailsRequest : IApiRequest
    {
        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }

    internal partial class GetServiceDetailsRequest : IApiRequest
    {

        public AccessToken Token
        {
            private get { return AccessToken; }
            set { this.AccessToken = value; }
        }
    }
    #endregion



}
