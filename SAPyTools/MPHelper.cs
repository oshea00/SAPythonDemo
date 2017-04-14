using System.Collections.Generic;
using System.Linq;

namespace SAPyTools
{ 
    public class MPHelper
    {
        SpatialAnalyzerSDK.ISpatialAnalyzerSDK _sdk;
        public MPHelper(SpatialAnalyzerSDK.ISpatialAnalyzerSDK sdk)
        {
            _sdk = sdk;
        }

        public void DeleteObjects(List<string> input)
        {
            var list = new object[input.Count()];
            for(int i=0; i<input.Count(); i++)
            {
                list[i] = (object) input[i];
            }
            _sdk.SetStep("Delete Objects");
            var listObj = new System.Runtime.InteropServices.VariantWrapper(list);
            _sdk.SetCollectionObjectNameRefListArg("Object Names", listObj);
            _sdk.ExecuteStep();
        }
    }
}
