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
    class QrCodeVCardTemplate
    {
        #region Constructors

        public QrCodeVCardTemplate() { }
        public QrCodeVCardTemplate(string FirstName, string LastName, string Phone, string Fax, string Email, string Company, string Job, string Street, string City, string State, string ZipCode, string Country)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;

            this.Phone = Phone;
            this.Fax = Fax;
            this.Email = Email;

            this.Company = Company;
            this.Job = Job;

            this.State = State;
            this.City = City;
            this.Street = Street;
            this.Country = Country;
            this.ZipCode = ZipCode;
        }

        #endregion

        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public string Company { get; set; }
        public string Job { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        #endregion

        #region Overloaded Methods

        public override string ToString()
        {
            if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName))
                return base.ToString();

            return $@"BEGIN:VCARD
VERSION:2.1
N:{LastName};{FirstName};;
FN:{FirstName} {LastName}
ORG:{Company}
TITLE:{Job}
TEL;WORK;VOICE:{Phone}
TEL;FAX;VOICE:{Fax}
ADR;WORK;PREF:;;{Street};{City};{State};{ZipCode};{Country}
LABEL;WORK;PREF;ENCODING=QUOTED-PRINTABLE;CHARSET=UTF-8
EMAIL:{Email}
END:VCARD
";
        }

        #endregion
    }
}
