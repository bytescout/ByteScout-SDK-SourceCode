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
    class QrCodeEmailTemplate
    {
        #region Constructors

        public QrCodeEmailTemplate() { }
        public QrCodeEmailTemplate(string Email, string Subject, string Message)
        {
            this.Email = Email;
            this.Subject = Subject;
            this.Message = Message;
        }

        #endregion

        #region Properties

        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        #endregion

        #region Overloaded Methods

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Email) && string.IsNullOrEmpty(Subject) && string.IsNullOrEmpty(Message))
                return base.ToString();

            return $@"MATMSG:TO:

{Email};

SUB:

{Subject}

BODY:

{Message}
;;";
        }

        #endregion
    }
}
