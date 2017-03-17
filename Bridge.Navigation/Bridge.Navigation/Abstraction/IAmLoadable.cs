using System.Collections.Generic;

namespace Bridge.Navigation.Abstraction
{
    public interface IAmLoadable
    {
        /// <summary>
        /// Called when navigate to this controller
        /// </summary>
        /// <param name="parameters"></param>
        void OnLoad(Dictionary<string, object> parameters);
    }
}