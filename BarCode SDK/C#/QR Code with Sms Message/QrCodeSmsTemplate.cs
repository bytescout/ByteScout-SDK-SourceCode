//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
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
    class QrCodeSmsTemplate
    {
        #region Constructors

        public QrCodeSmsTemplate() { }
        public QrCodeSmsTemplate(string Number, string Message)
        {
            this.Number = Number;
            this.Message = Message;
        }

        #endregion

        #region Properties

        public string Number { get; set; }
        public string Message { get; set; }

        #endregion

        #region Overloaded Methods

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Number) && string.IsNullOrEmpty(Message))
                return base.ToString();

            return $"smsto:{Number}:{Message}";
        }

        #endregion
    }
}
