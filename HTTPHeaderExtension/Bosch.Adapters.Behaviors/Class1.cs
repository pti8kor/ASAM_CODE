using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.Xml;
using System.Net;
using System.IO;
using System.ServiceModel.Configuration;
using System.ServiceModel.Web;
using System.Configuration;
using System.Web.Script.Serialization;
using System;
using System.Text;

namespace HTTPHeaderExtension
{

    public class ExtendedHTTPHeaderBehavior : IClientMessageInspector, IEndpointBehavior
    {
        public ExtendedHTTPHeaderBehavior()
        {
            // added because new his ws supports tls1.2
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

        }


        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            // do nothing
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            // do nothing
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(this);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            // do nothing
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            // do nothing
        }



        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            HttpRequestMessageProperty hRProp = new HttpRequestMessageProperty();

            // FFM3FE pw is coded here

            hRProp.Headers["Authorization"] = "Basic RkZNM0ZFOkRvTm90VXNlNEFueVRlc3Rpbmdz";
                
            request.Properties.Add(HttpRequestMessageProperty.Name, hRProp);

            return null;
        }



    }

    public class ExtendedHTTPHeaderBehaviorElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(ExtendedHTTPHeaderBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new ExtendedHTTPHeaderBehavior();
        }

    }

}
