//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
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
