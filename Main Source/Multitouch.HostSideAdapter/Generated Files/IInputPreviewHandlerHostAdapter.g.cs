//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.Contracts.HostSideAdapters
{
    
    public class IInputPreviewHandlerHostAdapter
    {
        internal static Multitouch.Contracts.IInputPreviewHandler ContractToViewAdapter(Multitouch.Contracts.Contracts.IInputPreviewHandlerContract contract)
        {
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IInputPreviewHandlerViewToContractHostAdapter))))
            {
                return ((IInputPreviewHandlerViewToContractHostAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IInputPreviewHandlerContractToViewHostAdapter(contract);
            }
        }
        internal static Multitouch.Contracts.Contracts.IInputPreviewHandlerContract ViewToContractAdapter(Multitouch.Contracts.IInputPreviewHandler view)
        {
            if (view.GetType().Equals(typeof(IInputPreviewHandlerContractToViewHostAdapter)))
            {
                return ((IInputPreviewHandlerContractToViewHostAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IInputPreviewHandlerViewToContractHostAdapter(view);
            }
        }
    }
}
