using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.Search
{
    public class SearchIndexer
    {
        public SearchIndexer()
        {
            var cred = new Microsoft.Azure.Search.SearchCredentials(Configuration.ConfigurationManager.Instance.SearchSecretKey);
            var s = new Microsoft.Azure.Search.SearchServiceClient(Configuration.ConfigurationManager.Instance.SearchApiName, cred);

            var c = s.Indexes.GetClient("");
        } 
    }
}
