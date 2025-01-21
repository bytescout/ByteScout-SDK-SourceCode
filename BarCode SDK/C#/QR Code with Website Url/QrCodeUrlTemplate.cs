//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateBarCode
{
    class QrCodeUrlTemplate
    {
        #region Constructors

        public QrCodeUrlTemplate() { }
        public QrCodeUrlTemplate(string Url) { this.Url = Url; }

        #endregion

        #region Properties

        public string Url { get; set; }

        #endregion

        #region Overloaded Methods

        public override string ToString()
        {
            if(string.IsNullOrEmpty(Url))
            return base.ToString();

            return Url;
        }

        #endregion
    }
}
