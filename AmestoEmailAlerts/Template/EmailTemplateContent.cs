﻿namespace AmestoEmailAlerts.Template
{
    public static class EmailTemplateContent
    {

        public static readonly string Template = @"<html>

<head>
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">

    <!-- Facebook sharing information tags -->
    <meta property=""og:title"" content=""*|EmailSubject|*"">

    <title>*|EmailSubject|*</title>
    <style type=""text/css"">
        /* Client-specific Styles */
        #outlook a {
            padding: 0;
        }

        /* Force Outlook to provide a ""view in browser"" button. */
        body {
            width: 100% !important;
        }

        .ReadMsgBody {
            width: 100%;
        }

        .ExternalClass {
            width: 100%;
        }

        /* Force Hotmail to display emails at full width */
        body {
            -webkit-text-size-adjust: none;
        }

        /* Prevent Webkit platforms from changing default text sizes. */

        /* Reset Styles */
        body {
            margin: 0;
            padding: 0;
        }

        img {
            border: 0;
            height: auto;
            line-height: 100%;
            outline: none;
            text-decoration: none;
        }

        table tr td {
            border-collapse: collapse;
            padding: 8px;
        }

        #backgroundTable {
            height: 100% !important;
            margin: 0;
            padding: 0;
            width: 100% !important;
        }

        /* Template Styles */

        /* /\/\/\/\/\/\/\/\/\/\ STANDARD STYLING: COMMON PAGE ELEMENTS /\/\/\/\/\/\/\/\/\/\ */

        /**
            * @tab Page
            * @section background color
            * @tip Set the background color for your email. You may want to choose one that matches your company's branding.
            * @theme page
            */
        body,
        #backgroundTable {
            /*@editable*/
            background-color: #FAFAFA;
        }

        /**
            * @tab Page
            * @section email border
            * @tip Set the border for your email.
            */
        #templateContainer {
            /*@editable*/
            border: 0px solid #000000;
        }

        /**
            * @tab Page
            * @section heading 1
            * @tip Set the styling for all first-level headings in your emails. These should be the largest of your headings.
            * @style heading 1
            */
        h1,
        .h1 {
            /*@editable*/
            color: #202020;
            display: block;
            /*@editable*/
            font-family: Arial;
            /*@editable*/
            font-size: 34px;
            /*@editable*/
            font-weight: bold;
            /*@editable*/
            line-height: 100%;
            margin-top: 0;
            margin-right: 0;
            margin-bottom: 10px;
            margin-left: 0;
            /*@editable*/
            text-align: left;
        }

        /**
            * @tab Page
            * @section heading 2
            * @tip Set the styling for all second-level headings in your emails.
            * @style heading 2
            */
        h2,
        .h2 {
            /*@editable*/
            color: #202020;
            display: block;
            /*@editable*/
            font-family: Arial;
            /*@editable*/
            font-size: 30px;
            /*@editable*/
            font-weight: bold;
            /*@editable*/
            line-height: 100%;
            margin-top: 0;
            margin-right: 0;
            margin-bottom: 10px;
            margin-left: 0;
            /*@editable*/
            text-align: left;
        }

        /**
            * @tab Page
            * @section heading 3
            * @tip Set the styling for all third-level headings in your emails.
            * @style heading 3
            */
        h3,
        .h3 {
            /*@editable*/
            color: #202020;
            display: block;
            /*@editable*/
            font-family: Arial;
            /*@editable*/
            font-size: 26px;
            /*@editable*/
            font-weight: bold;
            /*@editable*/
            line-height: 100%;
            margin-top: 0;
            margin-right: 0;
            margin-bottom: 10px;
            margin-left: 0;
            /*@editable*/
            text-align: left;
        }

        /**
            * @tab Page
            * @section heading 4
            * @tip Set the styling for all fourth-level headings in your emails. These should be the smallest of your headings.
            * @style heading 4
            */
        h4,
        .h4 {
            /*@editable*/
            color: #202020;
            display: block;
            /*@editable*/
            font-family: ""Times New Roman"", serif;
            /*@editable*/
            font-size: 34px;
            /*@editable*/
            font-weight: bold;
            /*@editable*/
            line-height: 100%;
            margin-top: 0;
            margin-right: 0;
            margin-bottom: 10px;
            margin-left: 0;
            /*@editable*/
            text-align: center;
        }

        /* /\/\/\/\/\/\/\/\/\/\ STANDARD STYLING: HEADER /\/\/\/\/\/\/\/\/\/\ */

        /**
            * @tab Header
            * @section header style
            * @tip Set the background color and border for your email's header area.
            * @theme header
            */
        #templateHeader {
            /*@editable*/
            background-color: #FFFFFF;
            /*@editable*/
            border-bottom: 0;
        }

        /**
            * @tab Header
            * @section header text
            * @tip Set the styling for your email's header text. Choose a size and color that is easy to read.
            */
        .headerContent {
            /*@editable*/
            color: #000000;
            /*@editable*/
            font-family: Arial;
            /*@editable*/
            font-size: 34px;
            /*@editable*/
            font-weight: bold;
            /*@editable*/
            line-height: 100%;
            /*@editable*/
            padding: 0;
            /*@editable*/
            text-align: center;
            /*@editable*/
            vertical-align: middle;
        }

        /**
        * @tab Header
        * @section header link
        * @tip Set the styling for your email's header links. Choose a color that helps them stand out from your text.
        */
        .headerContent a:link,
        .headerContent a:visited,
            /* Yahoo! Mail Override */
        .headerContent a .yshortcuts
            /* Yahoo! Mail Override */ {
            /*@editable*/
            color: #336699;
            /*@editable*/
            font-weight: normal;
            /*@editable*/
            text-decoration: underline;
        }

        #headerImage {
            height: auto;
            max-width: 600px !important;
        }

        /* /\/\/\/\/\/\/\/\/\/\ STANDARD STYLING: MAIN BODY /\/\/\/\/\/\/\/\/\/\ */

        /**
            * @tab Body
            * @section body style
            * @tip Set the background color for your email's body area.
            */
        #templateContainer,
        .bodyContent {
            /*@editable*/
            background-color: #E3E0CD;
        }

        /**
        * @tab Body
        * @section body text
        * @tip Set the styling for your email's main content text. Choose a size and color that is easy to read.
        * @theme main
        */
        .bodyContent div {
            /*@editable*/
            color: #000000;
            /*@editable*/
            font-family: Arial;
            /*@editable*/
            font-size: 14px;
            /*@editable*/
            /* line-height: 150%; */
            /*@editable*/
            text-align: left;
        }

        /**
    * @tab Body
    * @section body link
    * @tip Set the styling for your email's main content links. Choose a color that helps them stand out from your text.
    */
        .bodyContent div a:link,
        .bodyContent div a:visited,
            /* Yahoo! Mail Override */
        .bodyContent div a .yshortcuts
            /* Yahoo! Mail Override */ {
            /*@editable*/
            color: #336699;
            /*@editable*/
            font-weight: normal;
            /*@editable*/
            text-decoration: underline;
        }

        /**
            * @tab Body
            * @section data table style
            * @tip Set the background color and border for your email's data table.
            */
        .templateDataTable {
            /*@editable*/
            background-color: #FFFFFF;
            /*@editable*/
            border: 1px solid #DDDDDD;
        }

        /**
            * @tab Body
            * @section data table heading text
            * @tip Set the styling for your email's data table text. Choose a size and color that is easy to read.
            */
        .dataTableHeading {
            /*@editable*/
            background-color: #D8E2EA;
            /*@editable*/
            color: #336699;
            /*@editable*/
            font-family: Helvetica;
            /*@editable*/
            font-size: 14px;
            /*@editable*/
            font-weight: bold;
            /*@editable*/
            /* line-height: 150%; */
            /*@editable*/
            text-align: left;
        }

        /**
        * @tab Body
        * @section data table heading link
        * @tip Set the styling for your email's data table links. Choose a color that helps them stand out from your text.
        */
        .dataTableHeading a:link,
        .dataTableHeading a:visited,
            /* Yahoo! Mail Override */
        .dataTableHeading a .yshortcuts
            /* Yahoo! Mail Override */ {
            /*@editable*/
            color: #FFFFFF;
            /*@editable*/
            font-weight: bold;
            /*@editable*/
            text-decoration: underline;
        }

        /**
            * @tab Body
            * @section data table text
            * @tip Set the styling for your email's data table text. Choose a size and color that is easy to read.
            */
        .dataTableContent {
            /*@editable*/
            border-top: 1px solid #DDDDDD;
            /*@editable*/
            border-bottom: 0;
            /*@editable*/
            color: #202020;
            /*@editable*/
            font-family: Helvetica;
            /*@editable*/
            font-size: 12px;
            /*@editable*/
            font-weight: bold;
            /*@editable*/
            /* line-height: 150%; */
            /*@editable*/
            text-align: left;
        }

        /**
        * @tab Body
        * @section data table link
        * @tip Set the styling for your email's data table links. Choose a color that helps them stand out from your text.
        */
        .dataTableContent a:link,
        .dataTableContent a:visited,
            /* Yahoo! Mail Override */
        .dataTableContent a .yshortcuts
            /* Yahoo! Mail Override */ {
            /*@editable*/
            color: #202020;
            /*@editable*/
            font-weight: bold;
            /*@editable*/
            text-decoration: underline;
        }

        /**
            * @tab Body
            * @section button style
            * @tip Set the styling for your email's button. Choose a style that draws attention.
            */
        .templateButton {
            -moz-border-radius: 3px;
            -webkit-border-radius: 3px;
            /*@editable*/
            background-color: #336699;
            /*@editable*/
            border: 0;
            border-collapse: separate !important;
            border-radius: 3px;
        }

        /**
        * @tab Body
        * @section button style
        * @tip Set the styling for your email's button. Choose a style that draws attention.
        */
        .templateButton,
        .templateButton a:link,
        .templateButton a:visited,
            /* Yahoo! Mail Override */
        .templateButton a .yshortcuts
            /* Yahoo! Mail Override */ {
            /*@editable*/
            color: #FFFFFF;
            /*@editable*/
            font-family: Arial;
            /*@editable*/
            font-size: 15px;
            /*@editable*/
            font-weight: bold;
            /*@editable*/
            letter-spacing: -.5px;
            /*@editable*/
            line-height: 100%;
            text-align: center;
            text-decoration: none;
        }

        .bodyContent img {
            display: inline;
            height: auto;
        }

        /* /\/\/\/\/\/\/\/\/\/\ STANDARD STYLING: FOOTER /\/\/\/\/\/\/\/\/\/\ */

        /**
            * @tab Footer
            * @section footer style
            * @tip Set the background color and top border for your email's footer area.
            * @theme footer
            */
        #templateFooter {
            /*@editable*/
            background-color: #E3E0CD;
            /*@editable*/
            border-top: 0;
        }

        /**
            * @tab Footer
            * @section footer text
            * @tip Set the styling for your email's footer text. Choose a size and color that is easy to read.
            * @theme footer
            */
        .footerContent div {
            /*@editable*/
            color: #707070;
            /*@editable*/
            font-family: Arial;
            /*@editable*/
            font-size: 12px;
            /*@editable*/
            line-height: 125%;
            /*@editable*/
            text-align: center;
        }

        /**
        * @tab Footer
        * @section footer link
        * @tip Set the styling for your email's footer links. Choose a color that helps them stand out from your text.
        */
        .footerContent div a:link,
        .footerContent div a:visited,
            /* Yahoo! Mail Override */
        .footerContent div a .yshortcuts
            /* Yahoo! Mail Override */ {
            /*@editable*/
            color: #336699;
            /*@editable*/
            font-weight: normal;
            /*@editable*/
            text-decoration: underline;
        }

        .footerContent img {
            display: inline;
        }

        /**
            * @tab Footer
            * @section utility bar style
            * @tip Set the background color and border for your email's footer utility bar.
            * @theme footer
            */
        #utility {
            /*@editable*/
            background-color: #E3E0CD;
            /*@editable*/
            border: 0;
        }

        /**
        * @tab Footer
        * @section utility bar style
        * @tip Set the background color and border for your email's footer utility bar.
        */
        #utility div {
            /*@editable*/
            text-align: center;
        }

        #monkeyRewards img {
            max-width: 190px;
        }

        .barcode {
            font-family: 'Libre Barcode 128';
            font-size: 80px;
        }

        .footermsg {
            line-height: 20px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            font-weight: normal;
            font-style: normal;
            text-decoration: none;
            color: rgb(0, 0, 0) !important;
            margin: 0px;
            padding: 0px;
        }

        .headermsg {
            font-weight: bold;
            color: inherit;
            margin: 0px 0px 13px;
            line-height: 18px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 18px;
            font-weight: bold;
            text-decoration: none;
            color: #202020;
            display: block;
            text-align: center;
            margin-bottom: 10px;
        }

        #tbalstyle {
            border-collapse: collapse;
            padding: 8px;
            font-family: Arial,Helvetica,sans-serif;
            width: 100%;
            border: 1px solid black;
            text-align: left;
            border-style: solid
        }
    </style>

    <!--<link href='https://fonts.googleapis.com/css?family=Libre Barcode 128' rel='stylesheet'>-->
</head>

<body leftmargin=""0"" marginwidth=""0"" topmargin=""EmailSubject0"" marginheight=""0"" offset=""0"">
<center>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" height=""100%"" width=""100%"" id=""backgroundTable"">
        <tbody>
        <tr>
            <td align=""center"" valign=""top"" style=""padding-top:20px;"">
                <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"" id=""templateContainer""
                       style=""width: 1000px;"">
                    <tbody>
                    <tr>
                        <td align=""center"" valign=""top"">
                            <!-- // Begin Template Header \\ -->
                            <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600""
                                   id=""templateHeader"" style=""width: 1000px;"">
                                <tbody>
                                <tr>
                                    <td class=""headerContent"" style=""width: 114px;"">
                                        <span></span>
                                    </td>
                                </tr>
                                </tbody>
                            </table>
                            <!-- // End Template Header \\ -->
                        </td>
                    </tr>
                    <tr>
                        <td align=""center"" valign=""top"">
                            <!-- // Begin Template Body \\ -->
                            <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"" id=""templateBody""
                                   style=""width: 1000px;"">
                                <tbody>
                                <tr>
                                    <td valign=""top"">

                                        <!-- // Begin Module: Standard Content \\ -->
                                        <table border=""0"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
                                            <tbody>
                                            <tr>
                                                <td valign=""top"" class=""bodyContent"">
                                                    <div mc:edit=""std_content00"">
                                                        <h4 class=""h4""> *|EmailSubject|*</h4>
                                                        <br>
                                                        <center>
                                                                                <span class=""headermsg"">
                                                                                   *|Amesto logging|*</strong>
                                                                                    <br />
                                                        </center>
                                                        <br />

                                                        <!-- <hr style=""width: 70%; align-self: center; height:1px;border-width:0;color:black;background-color:black""> -->
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td valign=""top""
                                                    style=""padding-top:0; padding-bottom:0;"">
                                                    *|BODY|*
                                                </td>
                                            </tr>
                                            </tbody>
                                        </table>
                                        <!-- // End Module: Standard Content \\ -->

                                    </td>
                                </tr>
                                </tbody>
                            </table>
                            <!-- // End Template Body \\ -->
                        </td>
                    </tr>
                    <tr>
                        <td align=""center"" valign=""top"">
                            <!-- // Begin Template Footer \\ -->
                            <table border=""0"" cellpadding=""10"" cellspacing=""0"" width=""600""
                                   id=""templateFooter"">
                                <tbody>
                                <tr>
                                    <td valign=""top"" class=""footerContent"">

                                        <!-- // Begin Module: Transactional Footer \\ -->
                                        <table border=""0"" cellpadding=""10"" cellspacing=""0"" width=""100%"">
                                            <tbody>
                                            <tr>
                                                <td valign=""top"" class=""footerContent"" style=""line-height: 150%;"">
                                                    <div>

                                                       <!-- <hr style=""width:70%; align-self:center;height:1px;border-width:0;color:black;background-color:black"" /> -->

                                                        <center>
                                                            <span style="" line-height: 20px; font-family: Arial, Helvetica, sans-serif; font-weight: normal; font-style: normal; text-decoration: none; color: rgb(0, 0, 0) !important; margin: 0px; padding: 0px; margin-right: 20px; ""> This email was sent to *|ToEmail|* from the Amesto Log alert frameWork. Contact <i> support@amesto.no </i><br /> if you are not the correct recipient of this email.  </span><br />

                                                            <a href=""https://www.facebook.com/amestogroup"" target=""_blank"" rel=""noopener noreferrer"" data-auth=""NotApplicable"" style=""font-family: Arial,Helvetica,sans-serif; font-size: 12px; font-weight: normal; font-style: normal; text-decoration: none; vertical-align: text-top; color: black !important;"" data-linkindex=""7"">

                                                                <img data-imagetype=""External"" src=""https://infoamesto.via-em.com/resources/11702/My_Images/Ikoner/SoMe_NY/Facebook26x26.png"" alt="""" border=""0"" style=""outline:none;text-decoration:none;border:none"">

                                                            </a>
                                                            <a href=""https://twitter.com/Amesto"" target=""_blank"" rel=""noopener noreferrer"" data-auth=""NotApplicable"" style=""font-family: Arial,Helvetica,sans-serif; font-size: 12px; font-weight: normal; font-style: normal; text-decoration: none; vertical-align: text-top; color: black !important;"" data-linkindex=""8"">

                                                                <img data-imagetype=""External"" src=""https://infoamesto.via-em.com/resources/11702/My_Images/Ikoner/SoMe_NY/Twitter26x26.png"" alt="""" border=""0"" style=""outline:none;text-decoration:none;border:none"">

                                                            </a>
                                                            <a href=""https://www.linkedin.com/company/amesto-group/?trk=biz-brand-tree-co-name"" target=""_blank"" rel=""noopener noreferrer"" data-auth=""NotApplicable"" style=""font-family: Arial,Helvetica,sans-serif; font-size: 12px; font-weight: normal; text-decoration: none; font-style: normal; vertical-align: text-top; color: black !important;"" data-linkindex=""9"">

                                                                <img data-imagetype=""External"" src=""https://infoamesto.via-em.com/resources/11702/My_Images/Ikoner/SoMe_NY/LinkedIn26x26.png"" alt="""" border=""0"" style=""outline:none;text-decoration:none;border:none"">

                                                            </a>
                                                            <a href=""https://www.amestosolutions.no/blogg"" target=""_blank"" rel=""noopener noreferrer"" data-auth=""NotApplicable"" style=""font-family: Arial,Helvetica,sans-serif; font-size: 12px; font-weight: normal; font-style: normal; text-decoration: none; vertical-align: text-top; color: black !important; "" data-linkindex=""10"">

                                                                <img data-imagetype=""External"" src=""https://infoamesto.via-em.com/resources/11702/My_Images/Ikoner/SoMe_NY/Blogg26x26.png"" alt="""" border=""0"" style=""outline:none;text-decoration:none;border:none"">

                                                            </a>
                                                        </center>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td valign=""top"">
                                                    <div mc:edit=""std_footer"">
                                                        <em>Copyright © *|CURRENT_YEAR|* Amesto Order Application, All rights reserved.</em>
                                                        <br>
                                                        Postboks 6395 Etterstad, 0604
                                                        <br>
                                                        Oslo
                                                        <br>
                                                        + 47 922 03 214
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td valign=""middle"" id=""utility"">
                                                    <div mc:edit=""std_utility"">
                                                        &nbsp;<a href=""https://app-amesto-cairo-logs-dev.azurewebsites.net/""
                                                                 target=""_blank"">
                                                        view this in your
                                                        browser
                                                    </a>
                                                        | <a href=""#"">unsubscribe from this list</a>
                                                        &nbsp;
                                                    </div>
                                                </td>
                                            </tr>
                                            </tbody>
                                        </table>
                                        <!-- // End Module: Transactional Footer \\ -->

                                    </td>
                                </tr>
                                </tbody>
                            </table>
                            <!-- // End Template Footer \\ -->
                        </td>
                    </tr>
                    </tbody>
                </table>
                <br>
            </td>
        </tr>
        </tbody>
    </table>
</center>
</body>
</html>";
    }
}