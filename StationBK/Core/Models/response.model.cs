using Microsoft.VisualBasic;

namespace StationBK.Core.Models
{
    public class response
    {
       string resMsg { get; set; }
        public response(string msg)
        {
            this.resMsg = msg;
        }
    }
    
}
