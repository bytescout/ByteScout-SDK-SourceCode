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
