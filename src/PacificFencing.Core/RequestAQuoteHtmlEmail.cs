﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace PacificFencing.Core
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\CloudStorage\GoogleDrive\Code\Microsoft\MVC\DotNetLatestGithub\PacificFencing\src\PacificFencing.Core\RequestAQuoteHtmlEmail.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class RequestAQuoteHtmlEmail : RequestAQuoteHtmlEmailBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n\r\n<html>\r\n    <head>\r\n      <style type=\"text/css\">\r\n        /* RESET */\r\n     " +
                    "   body, h1, h2, h3, h4, h5, h6, a, em, strong, img, p ol, ul, li, table, thead," +
                    " tbody, tr, th, td {\r\n        margin: 0;\r\n        padding: 0;\r\n        border: 0" +
                    ";\r\n        outline: 0;\r\n        }\r\n        /* END RESET */\r\n        body {\r\n    " +
                    "    color: #333;\r\n        font-family: Verdana, sans-serif;\r\n        font-size: " +
                    "13px; /*13px*/\r\n        }\r\n        h1 {\r\n        font-size: 32px;\r\n        font-" +
                    "weight: normal;\r\n        line-height: 1.0;\r\n        margin: 40px 0 24px 0;\r\n    " +
                    "          width: 492px;\r\n          }\r\n        a, a:visited {\r\n        color: #6f" +
                    "6f6f;\r\n        text-decoration: underline;\r\n        }\r\n        a:hover, a:focus " +
                    "{\r\n        text-decoration: none;\r\n        }\r\n        p {\r\n        font-size: 13" +
                    "px;\r\n        line-height: 16px;\r\n        margin-bottom: 18px;\r\n              wid" +
                    "th: 576px;\r\n          }\r\n        table {\r\n          border-style: none;\r\n       " +
                    "       border-color: inherit;\r\n              border-width: 0;\r\n              fon" +
                    "t-size: 13px;\r\n              line-height: 18px;\r\n              border-collapse: " +
                    "collapse;\r\n              width: 788px;\r\n          }\r\n\r\n\r\n        table td {\r\n   " +
                    "     vertical-align: top;\r\n        }\r\n        table td.label {\r\n        color: #" +
                    "999;\r\n        text-align: right;\r\n        }\r\n        table td.data {\r\n        co" +
                    "lor: #333;\r\n        text-align: left;\r\n        }\r\n\r\n        span.tel {\r\n        " +
                    "white-space: nowrap;\r\n        }\r\n\r\n          .auto-style1 {\r\n              width" +
                    ": 607px;\r\n          }\r\n\r\n      </style>\r\n    </head>\r\n\r\n    <body>\r\n      <table" +
                    " width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n        <tr>\r\n       " +
                    "   <td align=\"center\" width=\"567\">\r\n            <!-- HTML -->\r\n            <tabl" +
                    "e border=\"0\" cellspacing=\"0\" cellpadding=\"0\" align=\"center\">\r\n              <tr>" +
                    "\r\n                <td align=\"center\" class=\"auto-style1\">\r\n                  <ta" +
                    "ble width=\"550\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n                   " +
                    " <tr>\r\n                      <td width=\"184\">\r\n                          <img sr" +
                    "c=\"https://placeimg.com/128/208/arch/grayscale\">\r\n                      </td>\r\n " +
                    "                     <td width=\"383\">\r\n                        <h1>Your Pacific " +
                    "Fencing Quote</h1>\r\n                        \r\n                      </td>\r\n     " +
                    "               </tr>\r\n                  </table>\r\n                </td>\r\n       " +
                    "       </tr>\r\n              <tr>\r\n                <td class=\"auto-style1\">\r\n    " +
                    "              <table width=\"567\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n  " +
                    "                  <tr>\r\n                      <td width=\"200\">&nbsp;</td>\r\n     " +
                    "                 <td width=\"5\">&nbsp;</td>\r\n                      <td width=\"362" +
                    "\">&nbsp;</td>\r\n                    </tr>\r\n                    <tr>\r\n            " +
                    "          <td width=\"200\" bgcolor=\"#D6D6D6\" height=\"1\"></td>\r\n                  " +
                    "    <td width=\"5\" bgcolor=\"#D6D6D6\" height=\"1\"></td>\r\n                      <td " +
                    "width=\"362\" bgcolor=\"#D6D6D6\"></td>\r\n                    </tr>\r\n                " +
                    "    <tr>\r\n                      <td width=\"567\" align=\"left\"><p>Dear : <strong>");
            
            #line 113 "E:\CloudStorage\GoogleDrive\Code\Microsoft\MVC\DotNetLatestGithub\PacificFencing\src\PacificFencing.Core\RequestAQuoteHtmlEmail.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(RequestAQuote.ContactName));
            
            #line default
            #line hidden
            this.Write(@"</strong> </p> </td>
                     </tr>
                      <tr>
                        
                        <td width=""567"" align=""left"">
                          <p>Your request for a quote from pacific Fencing has been recevied. A customer representative will be contact with you withing 24hours.</p>

                            <h3>Request Details</h3>
                            <p>
                                ");
            
            #line 122 "E:\CloudStorage\GoogleDrive\Code\Microsoft\MVC\DotNetLatestGithub\PacificFencing\src\PacificFencing.Core\RequestAQuoteHtmlEmail.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(RequestAQuote.Description));
            
            #line default
            #line hidden
            this.Write("\r\n                            </p>\r\n\r\n                        </td>\r\n            " +
                    "          </tr>\r\n                    \r\n                          <tr>\r\n         " +
                    "                   <td width=\"200\">&nbsp;</td>\r\n                            <td " +
                    "width=\"5\">&nbsp;</td>\r\n                            <td width=\"362\">&nbsp;</td>\r\n" +
                    "                          </tr>\r\n                        </table>\r\n             " +
                    "   </td>\r\n              </tr>\r\n              <tr>\r\n                <td align=\"ce" +
                    "nter\" class=\"auto-style1\">\r\n                  <table width=\"550\" border=\"0\" cell" +
                    "spacing=\"0\" cellpadding=\"0\">\r\n                    <tr>\r\n                      <t" +
                    "d align=\"left\">\r\n                        <p>\r\n                          For more" +
                    " information please telephone the  Office on <span class=\"tel\">+44 (0)20 7304 40" +
                    "00</span> or <a href=\"#\">go online</a>. <br />\r\n                          Find o" +
                    "ut what&#8217;s on: <a href=\"#\">www.pacificfencing.com</a>\r\n                    " +
                    "    </p>\r\n                      </td>\r\n                    </tr>\r\n              " +
                    "      <tr>\r\n                      <td>&nbsp;</td>\r\n                    </tr>\r\n  " +
                    "                  <tr>\r\n                      <td align=\"left\">\r\n               " +
                    "         <p>\r\n                          If you prefer, you can choose to redeem " +
                    "your quote against a membership. If you wish to do so, please telephone the Offi" +
                    "ce on <span class=\"tel\">+44 (0)20 7212 9268</span> or <a href=\"http://www.roh.or" +
                    "g.uk/visit/tickets\">go online</a>. <br />\r\n                          Find out ab" +
                    "out the levels of membership available: <a href=\"#\">www.pacificfencing.com</a>\r\n" +
                    "                        </p>\r\n                      </td>\r\n                    <" +
                    "/tr>\r\n                  </table>\r\n                </td>\r\n              </tr>\r\n  " +
                    "          </table>\r\n            <!-- HTML -->\r\n          </td>\r\n        </tr>\r\n " +
                    "     </table>\r\n\r\n    </body>\r\n  </html>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class RequestAQuoteHtmlEmailBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}