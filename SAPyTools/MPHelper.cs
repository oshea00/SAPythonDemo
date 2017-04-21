using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows;

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
            _sdk.SetStep("Delete Objects");
            var listObj = GetListWrapper(input);
            _sdk.SetCollectionObjectNameRefListArg("Object Names", listObj);
            _sdk.ExecuteStep();
        }

        public VariantWrapper GetListWrapper(List<string> input)
        {
            var list = new object[input.Count()];
            for (int i = 0; i < input.Count(); i++)
            {
                list[i] = (object)input[i];
            }
            return new System.Runtime.InteropServices.VariantWrapper(list);
        }
    }
}
