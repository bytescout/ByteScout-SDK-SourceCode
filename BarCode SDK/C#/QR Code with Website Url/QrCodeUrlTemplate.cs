//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
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
