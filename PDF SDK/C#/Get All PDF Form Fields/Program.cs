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


using Bytescout.PDF;
using System;
using System.Collections.Generic;

namespace GetFormFields
{
    /// <summary>
    /// This example demonstrates how to all PDF form fields programmatically.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Load PDF form
            Document document = new Document(@"sample.pdf");
            document.RegistrationName = "demo";
            document.RegistrationKey = "demo";

            var formFields = new List<FormFieldInfo>();

            // Loop through all pages
            for (int i = 0; i < document.Pages.Count; i++)
            {
                var page = document.Pages[i];

                // Loop through all annotations
                foreach (var annotation in page.Annotations)
                {
                    if(annotation is EditBox || annotation is ComboBox || annotation is CheckBox || annotation is RadioButton)
                    {
                        // Get form field info
                        var fieldInfo = new FormFieldInfo
                        {
                            Type = annotation.Type.ToString(),
                            FieldName = ((Field)annotation).Name,
                            PageIndex = i,
                            Left = ((Field)annotation).Left,
                            Top = ((Field)annotation).Top,
                            Width = ((Field)annotation).Width,
                            Height = ((Field)annotation).Height
                        };

                        // Get value
                        switch (annotation.Type)
                        {
                            case AnnotationType.EditBox:
                                fieldInfo.Value = ((EditBox)annotation).Text;
                                break;
                            case AnnotationType.ComboBox:
                                fieldInfo.Value = ((ComboBox)annotation).Text;
                                break;
                            case AnnotationType.CheckBox:
                                fieldInfo.Value = ((CheckBox)annotation).Checked.ToString();
                                break;
                            case AnnotationType.RadioButton:
                                fieldInfo.Value = ((RadioButton)annotation).Checked.ToString();
                                break;
                        }

                        formFields.Add(fieldInfo);
                    }
                }
            }

            // Cleanup 
            document.Dispose();

            // Display Form data
            DisplayData(formFields);

            Console.ReadLine();
        }

        /// <summary>
        /// Displays data to console
        /// </summary>
        static void DisplayData(List<FormFieldInfo> formFieldInfos)
        {
            if(formFieldInfos != null && formFieldInfos.Count > 0)
            {
                foreach (var item in formFieldInfos)
                {
                    Console.WriteLine($"Type: {item.Type}\nFieldName: {item.FieldName}\nValue: {item.Value}\nPage Index: {item.PageIndex}\nLeft: {item.Left}, Top: {item.Top}, Width: {item.Width}, Height: {item.Height}");

                    Console.WriteLine();

                }
            }
        }

    }

    class FormFieldInfo
    {
        public string Type { get; set; }
        public string FieldName { get; set; }
        public string Value { get; set; }

        public int PageIndex { get; set; }

        public float Left { get; set; }
        public float Top { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
    }


}
