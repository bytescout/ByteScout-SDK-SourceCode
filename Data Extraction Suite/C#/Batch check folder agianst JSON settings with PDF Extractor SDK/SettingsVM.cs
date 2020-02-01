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
using System.Text;

namespace BatchCheckFolderAgainstJsonSettings
{
    public class SettingsVM
    {
        public string MainFolderName { get; set; }
        public List<Settings> Settings { get; set; }
    }

    public class Settings
    {
        public string category { get; set; }
        public string regex { get; set; }
    }
}
