//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3031
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.Contracts.AddInSideAdapters
{
    
    [System.AddIn.Pipeline.AddInAdapterAttribute()]
    public class IInputPostHandlerViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Multitouch.Contracts.Contracts.IInputPostHandlerContract
    {
        private Multitouch.Contracts.IInputPostHandler _view;
        public IInputPostHandlerViewToContractAddInAdapter(Multitouch.Contracts.IInputPostHandler view)
        {
            _view = view;
        }
        public virtual void Handle(Multitouch.Contracts.Contracts.IContactContract contact)
        {
            _view.Handle(Multitouch.Contracts.AddInSideAdapters.IContactAddInAdapter.ContractToViewAdapter(contact));
        }
        internal Multitouch.Contracts.IInputPostHandler GetSourceView()
        {
            return _view;
        }
    }
}
