using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    public abstract class FakturoidEntity {

        protected FakturoidEntity(FakturoidContext context) {
            if (context == null) throw new ArgumentNullException("context");
            this.Context = context;
        }
        
        protected FakturoidContext Context { get; private set; }
        
    }
}
